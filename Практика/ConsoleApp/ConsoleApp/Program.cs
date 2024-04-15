﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    static HttpClient httpClient = new HttpClient();
    
    static async Task Main()
    {
        Saves person = new Saves();
        for (int i = 0; i < 22227980; i = i + 100)
        {
            var response = await httpClient.GetAsync($"https://fgis.gost.ru/fundmetrology/eapi/vri?verification_date=2021-09-01&start={i}&rows={100}");
            person = await response.Content.ReadFromJsonAsync<Saves>();
            string content = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"{content}");
            using (FileStream fs = new("save_1.json", FileMode.OpenOrCreate))
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };
                await JsonSerializer.SerializeAsync<Saves>(fs, person, options);
            }
            response = null;
        }
    }
}
class Item
{
    public string vri_id { get; set; }
    public string org_title { get; set; }
    public string mit_number { get; set; }
    public string mit_title { get; set; }
    public string mit_notation { get; set; }
    public string mi_modification { get; set; }
    public string mi_number { get; set; }
    public string verification_date { get; set; }
    public string valid_date { get; set; }
    public string result_docnum { get; set; }
    public bool applicability { get; set; }
}
class Results
{
    public int count { get; set; }
    public int start { get; set; }
    public int rows { get; set; }
    public List<Item> items { get; set; }
}
class Saves
{
    public Results result { get; set; }
}
class List_save
{
    public List<Saves> list { get; set; }
}
