using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Text.Json;
using System.IO;

namespace FGIS
{
    public partial class Form1 : Form
    {
        Result Save = new Result();
        Result tmp = new Result();
        Date date = new Date();
        Result_poisk Save_poisk = new Result_poisk();
        bool True = true;
        int[] ID_MASS = new int[1] { 0 };
        string[] poisk = new string[4] { "", "", "", "" };
        int size;
        int id = 1;
        int ID_DB;
        int save_id = 0;
        int time = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                DataGridViewTextBoxColumn Column;
                Column = new System.Windows.Forms.DataGridViewTextBoxColumn
                {
                    ReadOnly = true
                };
                switch (i)
                {
                    case 0:
                        Column.HeaderText = "№";
                        break;
                    case 1:
                        Column.HeaderText = "Регистрационный номер";
                        break;
                    case 2:
                        Column.HeaderText = "Номер модификации";
                        break;
                    case 3:
                        Column.HeaderText = "Дата начала";
                        break;
                    case 4:
                        Column.HeaderText = "Дата окончания";
                        break;
                }
                dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column });
            }
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    DataGridViewTextBoxColumn Column;
                    Column = new System.Windows.Forms.DataGridViewTextBoxColumn
                    {
                        ReadOnly = true
                    };
                    switch (i)
                    {
                        case 0:
                            Column.HeaderText = "№";
                            break;
                        case 1:
                            Column.HeaderText = "vri_id";
                            break;
                        case 2:
                            Column.HeaderText = "org_title";
                            break;
                        case 3:
                            Column.HeaderText = "mit_number";
                            break;
                        case 4:
                            Column.HeaderText = "mit_title";
                            break;
                        case 5:
                            Column.HeaderText = "mit_notation";
                            break;
                        case 6:
                            Column.HeaderText = "mi_modification";
                            break;
                        case 7:
                            Column.HeaderText = "mi_number";
                            break;
                        case 8:
                            Column.HeaderText = "verification_date";
                            break;
                        case 9:
                            Column.HeaderText = "valid_date";
                            break;
                        case 10:
                            Column.HeaderText = "result_docnum";
                            break;
                        case 11:
                            Column.HeaderText = "applicability";
                            break;
                    }
                    if (j == 0)
                    {
                        dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column }); 
                    }
                    else if (j == 1)
                    {
                        dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column });
                    }
                }
            }
            using (FileStream fs = new("result.json", FileMode.OpenOrCreate))
            {
                Save = await JsonSerializer.DeserializeAsync<Result>(fs);
                tmp = Save;
                Dgv3();
            }
            Load_file_save();
            Load_BD_Result();
        }
        private void Dgv3()
        {
            foreach (var item in Save.items)
            {
                if (item.valid_date == null)
                {
                    item.valid_date = "-";
                }
                dataGridView3.Rows.Add(id++,
                        item.vri_id,
                        item.org_title,
                        item.mit_number,
                        item.mit_title,
                        item.mit_notation,
                        item.mi_modification,
                        item.mi_number,
                        item.verification_date,
                        item.valid_date,
                        item.result_docnum,
                        item.applicability);
            }
        }
        private async void Load_file_save()
        {
            using (FileStream fs = new FileStream("save_1.json", FileMode.OpenOrCreate))
            {

                try
                {
                    Date Save_date = await JsonSerializer.DeserializeAsync<Date>(fs);
                    foreach (var his in Save_date.histori)
                    {
                        save_id = his.Id;
                        textBox1.Text = his.Number;
                        textBox2.Text = his.Modification;
                        textBox3.Text = his.Data_ver;
                        textBox4.Text = his.Data_val;
                        dataGridView1.Rows.Clear();
                        id = 1;
                        foreach (var item in his.items)
                        {
                            dataGridView1.Rows.Add(id,
                            item.mit_number,
                            item.mi_modification,
                            item.verification_date,
                            item.valid_date);
                            id++;
                        }
                    }
                }
                catch
                {

                }
            }
        }
        private void Load_BD_Result()
        {
            string sqlQuery = "SELECT * FROM Result";
            BD(sqlQuery, 1);
            sqlQuery = "SELECT * FROM ARG";
            BD(sqlQuery, 5);
            sqlQuery = $"SELECT ID_Result FROM ID_Results WHERE ID_ARG = '{ID_DB}'";
            BD(sqlQuery, 4);
            sqlQuery = $"SELECT * FROM Result WHERE ID = '{ID_MASS[0]}'";
            for (int i = 1; i < size; i++)
            {
                sqlQuery += $"OR ID = '{ID_MASS[i]}'";
            }
            BD(sqlQuery, 2);
        }
        private void Sdgv(int index, int sdgv)
        {
            time = 1;
            id = 0;
            foreach (var item in Save.items)
            {

                try
                {
                    if (textBox3.Text != "")
                    {
                        Convert.ToInt32(textBox3.Text);
                    }
                    if (textBox4.Text != "")
                    {
                        Convert.ToInt32(textBox4.Text);
                    }
                    string ver = "0";
                    for (int i = 6; i < 10; i++)
                    {
                        switch (i)
                        {
                            case 6:
                                ver += item.verification_date[i];
                                break;
                            case 7:
                                ver += item.verification_date[i];
                                break;
                            case 8:
                                ver += item.verification_date[i];
                                break;
                            case 9:
                                ver += item.verification_date[i];
                                break;
                        }
                    }
                    int date = Convert.ToInt32(ver);
                    if (Convert.ToInt32(textBox3.Text) > Convert.ToInt32(textBox4.Text))
                    {
                        MessageBox.Show("Неправельный ввод года");
                        break;
                    }
                    else
                    {
                        if (textBox3.Text != "" && textBox4.Text != "" &&
                            date >= Convert.ToInt32(textBox3.Text) && date <= Convert.ToInt32(textBox4.Text) &&
                            (item.mit_number == textBox1.Text && textBox1.Text != "") &&
                            (textBox2.Text == "" || textBox2.Text == item.mi_modification) ||
                            textBox3.Text != "" && textBox4.Text == "" && date >= Convert.ToInt32(textBox3.Text) &&
                            (item.mit_number == textBox1.Text && textBox1.Text != "") &&
                            (textBox2.Text == "" || textBox2.Text == item.mi_modification) ||
                            textBox4.Text != "" && textBox3.Text == "" && date <= Convert.ToInt32(textBox4.Text) &&
                            (item.mit_number == textBox1.Text && textBox1.Text != "") &&
                            (textBox2.Text == "" || textBox2.Text == item.mi_modification) ||
                            textBox3.Text == "" && textBox4.Text == "" && textBox2.Text == "" && textBox1.Text == item.mit_number)
                        {
                            switch (sdgv)
                            {
                                case 1:
                                    dataGridView1.Rows.Add(time, item.mit_number, item.mi_modification, item.verification_date, item.valid_date);
                                    time++;
                                    tmp.items.Add(item);
                                    break;
                                case 2:
                                    if (id == index)
                                    {
                                        dataGridView2.Rows.Add(id + 1,
                                            item.vri_id,
                                            item.org_title,
                                            item.mit_number,
                                            item.mit_title,
                                            item.mit_notation,
                                            item.mi_modification,
                                            item.mi_number,
                                            item.verification_date,
                                            item.valid_date,
                                            item.result_docnum,
                                            item.applicability);
                                    }
                                    id++;
                                    break;
                            }

                        }
                        if (textBox3.Text == "" && textBox4.Text == "" && textBox1.Text == "" && textBox2.Text == item.mi_modification ||
                            textBox3.Text == "" && textBox4.Text == "" && textBox1.Text == item.mit_number && textBox2.Text == item.mi_modification)
                        {
                            switch (sdgv)
                            {
                                case 1:
                                    dataGridView1.Rows.Add(time, item.mit_number, item.mi_modification, item.verification_date, item.valid_date);
                                    time++;
                                    tmp.items.Add(item);
                                    break;
                                case 2:
                                    if (id == index)
                                    {
                                        dataGridView2.Rows.Add(id + 1,
                                            item.vri_id,
                                            item.org_title,
                                            item.mit_number,
                                            item.mit_title,
                                            item.mit_notation,
                                            item.mi_modification,
                                            item.mi_number,
                                            item.verification_date,
                                            item.valid_date,
                                            item.result_docnum,
                                            item.applicability);
                                    }
                                    id++;
                                    break;
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Вводился не год");
                    break;
                }
            }
        }
        private async void Save_result()
        {
            save_id++;
            Save_poisk.Id = save_id;
            Save_poisk.Number = poisk[0];
            Save_poisk.Modification = poisk[1];
            Save_poisk.Data_ver = poisk[2];
            Save_poisk.Data_val = poisk[3];
            Save_poisk.items = tmp.items;
            using (FileStream fs = new("save_1.json", FileMode.OpenOrCreate))
            {
                try
                {
                    Date Save_date = await JsonSerializer.DeserializeAsync<Date>(fs);
                    date = Save_date;
                }
                catch
                {
                }
            }
            using (FileStream fs = new("save_1.json", FileMode.OpenOrCreate))
            {
                bool False = false;
                foreach (var his in date.histori)
                {
                    if (Save_poisk.Number == his.Number &&
                        Save_poisk.Modification == his.Modification &&
                        Save_poisk.Data_ver == his.Data_ver &&
                        Save_poisk.Data_val == his.Data_val)
                    {
                        False = true;
                        save_id--;
                    }
                }
                if (False == false)
                {
                    date.histori.Add(Save_poisk);
                }
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };
                await JsonSerializer.SerializeAsync<Date>(fs, date, options);
            }
        }
        private async void Select_JSON_Click(object sender, EventArgs e)
        {
            int sdgv = 1;
            tmp.items.Clear();
            using (FileStream fs = new("result.json", FileMode.OpenOrCreate))
            {
                Save = await JsonSerializer.DeserializeAsync<Result>(fs);
            }
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            poisk[0] = textBox1.Text;
            poisk[1] = textBox2.Text;
            poisk[2] = textBox3.Text;
            poisk[3] = textBox4.Text;
            Sdgv(0, sdgv);
            richTextBox1.Text += ($"_________________________\n" +
                $"Найдено {time - 1}: элементов по параметрам:\n " +
                $"Номер:{textBox1.Text}\n" +
                $"Модификация:{textBox2.Text}\n" +
                $"Периуд по году\nот:{textBox3.Text}\n" +
                $"до:{textBox4.Text}\n");
            Save_result();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sdgv = 2;
            dataGridView2.Rows.Clear();
            Sdgv(e.RowIndex, sdgv);
        }
        private void BD(string sqlQuery, int i)
        {
            try
            {
                string connectionString = "Data Source=Test.db;";
                using (SQLiteConnection sqlConnection = new SQLiteConnection(connectionString))
                {
                    sqlConnection.Open();
                    string cmd = sqlQuery;
                    SQLiteCommand command = new SQLiteCommand(cmd, sqlConnection);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    // Вывод на грид
                    switch (i)
                    {
                        case 1:
                            dataGridView6.DataSource = dt;
                            break;
                        case 2:
                            dataGridView5.DataSource = dt;
                            ID_MASS = new int[dt.Rows.Count];
                            size = dt.Rows.Count;
                            for (int j = 0; j < dt.Rows.Count; j++)
                            {
                                ID_MASS[j] = Convert.ToInt32(dt.Rows[j].ItemArray[0]);
                            }
                            if (dt.Rows.Count == 0)
                            {
                                ID_MASS = new int[1];
                                ID_MASS[0] = 0;
                                size = 1;
                            }
                            break;
                        case 3:
                            dataGridView5.DataSource = dt;
                            if (dt.Rows.Count > 0)
                            {
                                True = false;
                                ID_DB = Convert.ToInt32(dt.Rows[0].ItemArray[0]);
                            }
                            else if (dt.Rows.Count == 0)
                            {
                                True = true;
                                ID_MASS = new int[1];
                                ID_MASS[0] = 0;
                                size = 1;
                            }
                            break;
                        case 4:
                            if (dt.Rows.Count > 0)
                            {
                                ID_MASS = new int[dt.Rows.Count];
                                size = dt.Rows.Count;
                                for (int j = 0; j < dt.Rows.Count; j++)
                                {
                                    ID_MASS[j] = Convert.ToInt32(dt.Rows[j].ItemArray[0]);
                                }
                            }
                            if (dt.Rows.Count == 0)
                            {
                                ID_MASS = new int[1];
                                ID_MASS[0] = 0;
                                size = 1;
                            }
                            break;
                        case 5:
                            if (dt.Rows.Count > 0)
                            {
                                for (i = 0; i < dt.Rows.Count; i++)
                                {
                                    ID_DB = Convert.ToInt32(dt.Rows[i].ItemArray[0]);
                                    textBox8.Text = dt.Rows[i].ItemArray[1].ToString();
                                    textBox7.Text = dt.Rows[i].ItemArray[2].ToString();
                                    textBox6.Text = dt.Rows[i].ItemArray[3].ToString();
                                    textBox5.Text = dt.Rows[i].ItemArray[4].ToString();
                                }
                            }
                            break;
                    }
                    sqlConnection.Close();
                }
            }
            catch
            {
            }
        }
        private void BD_vvod()
        {
            string connectionString = "Data Source=Test.db;";
            using (SQLiteConnection sqlConnection = new SQLiteConnection(connectionString))
            {
                foreach (var item in Save.items)
                {
                    string sqlQuery;
                    sqlConnection.Open();
                    sqlQuery = $"INSERT INTO Result(vri_id,org_title,mit_number,mit_title, mit_notation,mi_modification,mi_number," +
                                $"verification_date,valid_date,result_docnum,applicability)" +
                                $" VALUES ('{item.vri_id}','{item.org_title}','{item.mit_number}','{item.mit_title}','{item.mit_notation}','{item.mi_modification}'," +
                                $"'{item.mi_number}','{item.verification_date}','{item.valid_date}','{item.result_docnum}','{item.applicability}')";
                    string cmd = sqlQuery;
                    SQLiteCommand command = new SQLiteCommand(cmd, sqlConnection);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    sqlConnection.Close();
                }
            }
        }

        private void Select_SQL_Click(object sender, EventArgs e)
        {
            int DATE = 0;
            string sqlQuery = "";
            sqlQuery = $"SELECT ID FROM ARG WHERE date_start = '{textBox6.Text}' AND date_end = '{textBox5.Text}' AND " +
                    $" mit_number = '{textBox8.Text}' AND mi_modification = '{textBox7.Text}' ";
            BD(sqlQuery, 3);
            if (True == true)
            {
                try
                {
                    DATE = Convert.ToInt32(textBox6.Text);
                }
                catch
                {
                }
                if (textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
                {
                    sqlQuery = $"SELECT * FROM Result WHERE verification_date LIKE '%{DATE}' AND  " +
                        $" mit_number = '{textBox8.Text}' AND mi_modification = '{textBox7.Text}' ";
                    for (int i = DATE + 1; i <= Convert.ToInt32(textBox5.Text); i++)
                    {
                        sqlQuery += $"OR verification_date LIKE '%{i}' AND  " +
                        $" mit_number = '{textBox8.Text}' AND mi_modification = '{textBox7.Text}' ";

                    }
                }
                else if (textBox7.Text == "" && textBox8.Text != "")
                {
                    if (textBox5.Text != "" && textBox6.Text != "")
                    {
                        sqlQuery = $"SELECT * FROM Result WHERE verification_date LIKE '%{DATE}' AND  " +
                        $" mit_number = '{textBox8.Text}' ";
                        for (int i = DATE + 1; i <= Convert.ToInt32(textBox5.Text); i++)
                        {
                            sqlQuery += $"OR verification_date LIKE '%{i}' AND  " +
                            $" mit_number = '{textBox8.Text}' ";
                        }
                    }
                    else if (textBox5.Text == "" && textBox6.Text != "")
                    {
                        sqlQuery = $"SELECT * FROM Result WHERE verification_date LIKE '%{DATE}' AND  " +
                        $" mit_number = '{textBox8.Text}' ";
                        for (int i = DATE + 1; i <= DATE + 10; i++)
                        {
                            sqlQuery += $"OR verification_date LIKE '%{i}' AND  " +
                            $" mit_number = '{textBox8.Text}' ";
                        }
                        DATE += 10;
                        textBox5.Text = DATE.ToString();
                    }
                    else if (textBox5.Text != "" && textBox6.Text == "")
                    {
                        sqlQuery = $"SELECT * FROM Result WHERE verification_date LIKE '%{DATE}' AND  " +
                        $" mit_number = '{textBox8.Text}' ";
                        for (int i = 0; i <= Convert.ToInt32(textBox5.Text); i++)
                        {
                            sqlQuery += $"OR verification_date LIKE '%{i}' AND  " +
                            $" mit_number = '{textBox8.Text}' ";
                        }
                    }
                }
                else if (textBox5.Text == "" && textBox6.Text == "" && textBox7.Text != "" && textBox8.Text == "")
                {
                    sqlQuery = $"SELECT * FROM Result WHERE mi_modification = '{textBox7.Text}' ";
                }
                BD(sqlQuery, 2);
                sqlQuery = $"INSERT INTO ARG (mit_number, mi_modification, date_start, date_end)" +
                    $" VALUES ('{textBox8.Text}','{textBox7.Text}','{textBox6.Text}','{textBox5.Text}')";
                BD(sqlQuery, 0);
                sqlQuery = $"SELECT ID FROM ARG WHERE date_start = '{textBox6.Text}' AND date_end = '{textBox5.Text}' AND " +
                     $" mit_number = '{textBox8.Text}' AND mi_modification = '{textBox7.Text}' ";
                BD(sqlQuery, 3);
                for (int i = 0; i < size; i++)
                {
                    sqlQuery = $"INSERT INTO ID_Results (ID_ARG, ID_Result) VALUES ('{ID_DB}','{ID_MASS[i]}')";
                    BD(sqlQuery, 0);
                }
            }
            if (True == false)
            {
                sqlQuery = $"SELECT ID_Result FROM ID_Results WHERE ID_ARG = '{ID_DB}'";
                BD(sqlQuery, 4);
                sqlQuery = $"SELECT * FROM Result WHERE ID = '{ID_MASS[0]}'";
                for (int i = 1; i < size; i++)
                {
                    sqlQuery += $"OR ID = '{ID_MASS[i]}'";
                }
                BD(sqlQuery, 2);
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
    class Result
    {
        public List<Item> items { get; set; }
    }
    class Result_poisk
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Modification { get; set; }
        public string Data_ver { get; set; }
        public string Data_val { get; set; }
        public List<Item> items { get; set; }
    }
    class Date
    {
        public List<Result_poisk> histori { get; set; }
    }
}
