﻿namespace MnogaOkon
{
    partial class Gipotenuza
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходные данные:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 51);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(274, 167);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "1-й катет:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "2-й катет:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 66);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(111, 101);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(113, 22);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(292, 50);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(311, 167);
            this.textBox4.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(289, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Результаты расчётов:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(24, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(591, 50);
            this.button2.TabIndex = 9;
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
            this.menuStrip1.Size = new System.Drawing.Size(615, 24);
            this.menuStrip1.TabIndex = 10;
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
            // Gipotenuza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(615, 287);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Gipotenuza";
            this.Text = "Найти гипотенузу";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
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

