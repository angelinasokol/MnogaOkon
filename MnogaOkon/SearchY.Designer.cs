﻿namespace MnogaOkon
{
    partial class SearchY
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.всеЗадачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиГипотенузуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиСкоростьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вычислитьYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вычислитьXYZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вЫЙТИToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Данные для расчёта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(328, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Результат расчёта:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 61);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(268, 178);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(331, 61);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(254, 178);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "A = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(23, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "B = ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(68, 88);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(68, 134);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Y = A + B",
            "Y = A / B",
            "Y = A * B"});
            this.comboBox1.Location = new System.Drawing.Point(136, 201);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(91, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Выберите способ расчёта:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(12, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(317, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(268, 46);
            this.button2.TabIndex = 11;
            this.button2.Text = "Главное меню";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.всеЗадачиToolStripMenuItem,
            this.вЫЙТИToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(597, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // всеЗадачиToolStripMenuItem
            // 
            this.всеЗадачиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.найтиГипотенузуToolStripMenuItem,
            this.найтиСкоростьToolStripMenuItem,
            this.вычислитьYToolStripMenuItem,
            this.вычислитьXYZToolStripMenuItem});
            this.всеЗадачиToolStripMenuItem.Name = "всеЗадачиToolStripMenuItem";
            this.всеЗадачиToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.всеЗадачиToolStripMenuItem.Text = "Все задачи";
            // 
            // найтиГипотенузуToolStripMenuItem
            // 
            this.найтиГипотенузуToolStripMenuItem.Name = "найтиГипотенузуToolStripMenuItem";
            this.найтиГипотенузуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.найтиГипотенузуToolStripMenuItem.Text = "Найти гипотенузу";
            this.найтиГипотенузуToolStripMenuItem.Click += new System.EventHandler(this.найтиГипотенузуToolStripMenuItem_Click);
            // 
            // найтиСкоростьToolStripMenuItem
            // 
            this.найтиСкоростьToolStripMenuItem.Name = "найтиСкоростьToolStripMenuItem";
            this.найтиСкоростьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.найтиСкоростьToolStripMenuItem.Text = "Найти скорость";
            this.найтиСкоростьToolStripMenuItem.Click += new System.EventHandler(this.найтиСкоростьToolStripMenuItem_Click);
            // 
            // вычислитьYToolStripMenuItem
            // 
            this.вычислитьYToolStripMenuItem.Name = "вычислитьYToolStripMenuItem";
            this.вычислитьYToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вычислитьYToolStripMenuItem.Text = "Вычислить Y";
            this.вычислитьYToolStripMenuItem.Click += new System.EventHandler(this.вычислитьYToolStripMenuItem_Click);
            // 
            // вычислитьXYZToolStripMenuItem
            // 
            this.вычислитьXYZToolStripMenuItem.Name = "вычислитьXYZToolStripMenuItem";
            this.вычислитьXYZToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вычислитьXYZToolStripMenuItem.Text = "Вычислить X, Y, Z";
            this.вычислитьXYZToolStripMenuItem.Click += new System.EventHandler(this.вычислитьXYZToolStripMenuItem_Click);
            // 
            // вЫЙТИToolStripMenuItem
            // 
            this.вЫЙТИToolStripMenuItem.Name = "вЫЙТИToolStripMenuItem";
            this.вЫЙТИToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.вЫЙТИToolStripMenuItem.Text = "ВЫЙТИ";
            this.вЫЙТИToolStripMenuItem.Click += new System.EventHandler(this.вЫЙТИToolStripMenuItem_Click);
            // 
            // SearchY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(597, 327);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchY";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem всеЗадачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиГипотенузуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиСкоростьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вычислитьYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вычислитьXYZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вЫЙТИToolStripMenuItem;
    }
}