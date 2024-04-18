
namespace FGIS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            Select_JSON = new System.Windows.Forms.Button();
            textBox4 = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            tabPage2 = new System.Windows.Forms.TabPage();
            dataGridView3 = new System.Windows.Forms.DataGridView();
            tabPage3 = new System.Windows.Forms.TabPage();
            dataGridView5 = new System.Windows.Forms.DataGridView();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            textBox5 = new System.Windows.Forms.TextBox();
            textBox6 = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            textBox7 = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            textBox8 = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            Select_SQL = new System.Windows.Forms.Button();
            tabPage4 = new System.Windows.Forms.TabPage();
            dataGridView6 = new System.Windows.Forms.DataGridView();
            tabPage5 = new System.Windows.Forms.TabPage();
            verification_date_end = new System.Windows.Forms.TextBox();
            verification_date_start = new System.Windows.Forms.TextBox();
            mi_modification = new System.Windows.Forms.TextBox();
            org_title = new System.Windows.Forms.TextBox();
            mit_number = new System.Windows.Forms.TextBox();
            button_HTTP = new System.Windows.Forms.Button();
            dataGridView4 = new System.Windows.Forms.DataGridView();
            HTTP_LOAD = new System.Windows.Forms.Button();
            richTextBox3 = new System.Windows.Forms.RichTextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new System.Drawing.Point(14, 16);
            tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1035, 453);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView2);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.Controls.Add(Select_JSON);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new System.Drawing.Point(4, 29);
            tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage1.Size = new System.Drawing.Size(1027, 420);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Поиск(JSON)";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new System.Drawing.Point(7, 268);
            dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new System.Drawing.Size(1016, 144);
            dataGridView2.TabIndex = 27;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(370, 8);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(649, 252);
            dataGridView1.TabIndex = 26;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new System.Drawing.Point(192, 8);
            richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(171, 251);
            richTextBox1.TabIndex = 25;
            richTextBox1.Text = "";
            // 
            // Select_JSON
            // 
            Select_JSON.Location = new System.Drawing.Point(7, 184);
            Select_JSON.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Select_JSON.Name = "Select_JSON";
            Select_JSON.Size = new System.Drawing.Size(178, 31);
            Select_JSON.TabIndex = 23;
            Select_JSON.Text = "Найти";
            Select_JSON.UseVisualStyleBackColor = true;
            Select_JSON.Click += Select_JSON_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(131, 145);
            textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "2024";
            textBox4.Size = new System.Drawing.Size(53, 27);
            textBox4.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(99, 149);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(28, 20);
            label9.TabIndex = 21;
            label9.Text = "До";
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(38, 145);
            textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "2023";
            textBox3.Size = new System.Drawing.Size(54, 27);
            textBox3.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(7, 149);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(26, 20);
            label7.TabIndex = 18;
            label7.Text = "От";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(7, 121);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(61, 20);
            label3.TabIndex = 6;
            label3.Text = "Периуд";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(7, 87);
            textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "350С04";
            textBox2.Size = new System.Drawing.Size(178, 27);
            textBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(7, 63);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(159, 20);
            label2.TabIndex = 4;
            label2.Text = "Номер модификации";
            // 
            // textBox1
            // 
            textBox1.AccessibleDescription = "";
            textBox1.Location = new System.Drawing.Point(7, 28);
            textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "64173-16";
            textBox1.Size = new System.Drawing.Size(178, 27);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 4);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(185, 20);
            label1.TabIndex = 2;
            label1.Text = "Регистрационный номер";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView3);
            tabPage2.Location = new System.Drawing.Point(4, 29);
            tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage2.Size = new System.Drawing.Size(1027, 420);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "JSON_Result";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new System.Drawing.Point(3, 4);
            dataGridView3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new System.Drawing.Size(1019, 408);
            dataGridView3.TabIndex = 15;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView5);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(textBox5);
            tabPage3.Controls.Add(textBox6);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(textBox7);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(textBox8);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(Select_SQL);
            tabPage3.Location = new System.Drawing.Point(4, 29);
            tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage3.Size = new System.Drawing.Size(1027, 420);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Поиск(SQL)";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new System.Drawing.Point(192, 4);
            dataGridView5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowHeadersWidth = 51;
            dataGridView5.RowTemplate.Height = 25;
            dataGridView5.Size = new System.Drawing.Size(831, 408);
            dataGridView5.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(99, 151);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(28, 20);
            label4.TabIndex = 44;
            label4.Text = "До";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(7, 151);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(26, 20);
            label5.TabIndex = 43;
            label5.Text = "От";
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(131, 147);
            textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "2024";
            textBox5.Size = new System.Drawing.Size(53, 27);
            textBox5.TabIndex = 42;
            // 
            // textBox6
            // 
            textBox6.Location = new System.Drawing.Point(38, 147);
            textBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "2023";
            textBox6.Size = new System.Drawing.Size(54, 27);
            textBox6.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(7, 123);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(61, 20);
            label6.TabIndex = 40;
            label6.Text = "Периуд";
            // 
            // textBox7
            // 
            textBox7.Location = new System.Drawing.Point(7, 88);
            textBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "350С04";
            textBox7.Size = new System.Drawing.Size(178, 27);
            textBox7.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(7, 64);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(159, 20);
            label8.TabIndex = 38;
            label8.Text = "Номер модификации";
            // 
            // textBox8
            // 
            textBox8.AccessibleDescription = "";
            textBox8.Location = new System.Drawing.Point(7, 28);
            textBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "64173-16";
            textBox8.Size = new System.Drawing.Size(178, 27);
            textBox8.TabIndex = 37;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(7, 4);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(185, 20);
            label10.TabIndex = 36;
            label10.Text = "Регистрационный номер";
            // 
            // Select_SQL
            // 
            Select_SQL.Location = new System.Drawing.Point(7, 185);
            Select_SQL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Select_SQL.Name = "Select_SQL";
            Select_SQL.Size = new System.Drawing.Size(178, 31);
            Select_SQL.TabIndex = 35;
            Select_SQL.Text = "Найти";
            Select_SQL.UseVisualStyleBackColor = true;
            Select_SQL.Click += Select_SQL_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridView6);
            tabPage4.Location = new System.Drawing.Point(4, 29);
            tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage4.Size = new System.Drawing.Size(1027, 420);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "SQL_Result";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Location = new System.Drawing.Point(3, 4);
            dataGridView6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.RowHeadersWidth = 51;
            dataGridView6.RowTemplate.Height = 25;
            dataGridView6.Size = new System.Drawing.Size(1019, 408);
            dataGridView6.TabIndex = 16;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(richTextBox3);
            tabPage5.Controls.Add(verification_date_end);
            tabPage5.Controls.Add(verification_date_start);
            tabPage5.Controls.Add(mi_modification);
            tabPage5.Controls.Add(org_title);
            tabPage5.Controls.Add(mit_number);
            tabPage5.Controls.Add(button_HTTP);
            tabPage5.Controls.Add(dataGridView4);
            tabPage5.Controls.Add(HTTP_LOAD);
            tabPage5.Location = new System.Drawing.Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new System.Windows.Forms.Padding(3);
            tabPage5.Size = new System.Drawing.Size(1027, 420);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "HTTP";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // verification_date_end
            // 
            verification_date_end.AccessibleDescription = "";
            verification_date_end.Location = new System.Drawing.Point(794, 351);
            verification_date_end.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            verification_date_end.Name = "verification_date_end";
            verification_date_end.PlaceholderText = "15.01.2024";
            verification_date_end.Size = new System.Drawing.Size(191, 27);
            verification_date_end.TabIndex = 42;
            // 
            // verification_date_start
            // 
            verification_date_start.AccessibleDescription = "";
            verification_date_start.Location = new System.Drawing.Point(597, 351);
            verification_date_start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            verification_date_start.Name = "verification_date_start";
            verification_date_start.PlaceholderText = "13.01.2024";
            verification_date_start.Size = new System.Drawing.Size(191, 27);
            verification_date_start.TabIndex = 41;
            // 
            // mi_modification
            // 
            mi_modification.AccessibleDescription = "";
            mi_modification.Location = new System.Drawing.Point(400, 351);
            mi_modification.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            mi_modification.Name = "mi_modification";
            mi_modification.PlaceholderText = "350C04";
            mi_modification.Size = new System.Drawing.Size(191, 27);
            mi_modification.TabIndex = 40;
            // 
            // org_title
            // 
            org_title.AccessibleDescription = "";
            org_title.Location = new System.Drawing.Point(203, 351);
            org_title.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            org_title.Name = "org_title";
            org_title.PlaceholderText = "ФГУП \\\"РФЯЦ - ВНИИЭФ\\\"";
            org_title.Size = new System.Drawing.Size(191, 27);
            org_title.TabIndex = 39;
            // 
            // mit_number
            // 
            mit_number.AccessibleDescription = "";
            mit_number.Location = new System.Drawing.Point(6, 351);
            mit_number.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            mit_number.Name = "mit_number";
            mit_number.PlaceholderText = "64173-16";
            mit_number.Size = new System.Drawing.Size(191, 27);
            mit_number.TabIndex = 38;
            // 
            // button_HTTP
            // 
            button_HTTP.Location = new System.Drawing.Point(106, 385);
            button_HTTP.Name = "button_HTTP";
            button_HTTP.Size = new System.Drawing.Size(94, 29);
            button_HTTP.TabIndex = 29;
            button_HTTP.Text = "Вывод";
            button_HTTP.UseVisualStyleBackColor = true;
            button_HTTP.Click += button_HTTP_Click;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new System.Drawing.Point(6, 4);
            dataGridView4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.RowTemplate.Height = 25;
            dataGridView4.Size = new System.Drawing.Size(1015, 339);
            dataGridView4.TabIndex = 28;
            // 
            // HTTP_LOAD
            // 
            HTTP_LOAD.Location = new System.Drawing.Point(6, 385);
            HTTP_LOAD.Name = "HTTP_LOAD";
            HTTP_LOAD.Size = new System.Drawing.Size(94, 29);
            HTTP_LOAD.TabIndex = 27;
            HTTP_LOAD.Text = "Найти";
            HTTP_LOAD.UseVisualStyleBackColor = true;
            HTTP_LOAD.Click += HTTP_LOAD_Click;
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new System.Drawing.Point(206, 385);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new System.Drawing.Size(247, 29);
            richTextBox3.TabIndex = 43;
            richTextBox3.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1063, 472);
            Controls.Add(tabControl1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Select_JSON;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Select_SQL;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button HTTP_LOAD;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button button_HTTP;
        private System.Windows.Forms.TextBox mi_modification;
        private System.Windows.Forms.TextBox org_title;
        private System.Windows.Forms.TextBox mit_number;
        private System.Windows.Forms.TextBox verification_date_end;
        private System.Windows.Forms.TextBox verification_date_start;
        private System.Windows.Forms.RichTextBox richTextBox3;
    }
}

