namespace FightClub_Dyachenko
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MainLabel = new System.Windows.Forms.Label();
            this.entername = new System.Windows.Forms.Label();
            this.butstart = new System.Windows.Forms.Button();
            this.move = new System.Windows.Forms.Label();
            this.player1name = new System.Windows.Forms.Label();
            this.player2name = new System.Windows.Forms.Label();
            this.hpBar1 = new System.Windows.Forms.ProgressBar();
            this.hpBar2 = new System.Windows.Forms.ProgressBar();
            this.butblock1 = new System.Windows.Forms.Button();
            this.butblock2 = new System.Windows.Forms.Button();
            this.butblock3 = new System.Windows.Forms.Button();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.hp1 = new System.Windows.Forms.Label();
            this.hp2 = new System.Windows.Forms.Label();
            this.move2 = new System.Windows.Forms.Label();
            this.restbut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(333, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(420, 40);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLabel.Location = new System.Drawing.Point(12, 9);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(511, 67);
            this.MainLabel.TabIndex = 1;
            this.MainLabel.Text = "Бойцовский Клуб";
            this.MainLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // entername
            // 
            this.entername.AutoSize = true;
            this.entername.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.entername.Location = new System.Drawing.Point(18, 106);
            this.entername.Name = "entername";
            this.entername.Size = new System.Drawing.Size(266, 33);
            this.entername.TabIndex = 2;
            this.entername.Text = "Введите своё имя:";
            // 
            // butstart
            // 
            this.butstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butstart.Location = new System.Drawing.Point(567, 12);
            this.butstart.Name = "butstart";
            this.butstart.Size = new System.Drawing.Size(186, 70);
            this.butstart.TabIndex = 3;
            this.butstart.Text = "СТАРТ";
            this.butstart.UseVisualStyleBackColor = true;
            this.butstart.Click += new System.EventHandler(this.button1_Click);
            // 
            // move
            // 
            this.move.AutoSize = true;
            this.move.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F);
            this.move.Location = new System.Drawing.Point(18, 302);
            this.move.Name = "move";
            this.move.Size = new System.Drawing.Size(129, 30);
            this.move.TabIndex = 4;
            this.move.Text = "Действуй";
            this.move.Visible = false;
            // 
            // player1name
            // 
            this.player1name.AutoSize = true;
            this.player1name.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player1name.Location = new System.Drawing.Point(18, 184);
            this.player1name.MaximumSize = new System.Drawing.Size(500, 33);
            this.player1name.MinimumSize = new System.Drawing.Size(266, 33);
            this.player1name.Name = "player1name";
            this.player1name.Size = new System.Drawing.Size(266, 33);
            this.player1name.TabIndex = 5;
            this.player1name.Text = "Имя:";
            this.player1name.Visible = false;
            this.player1name.Click += new System.EventHandler(this.label4_Click);
            // 
            // player2name
            // 
            this.player2name.AutoSize = true;
            this.player2name.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player2name.Location = new System.Drawing.Point(693, 184);
            this.player2name.MaximumSize = new System.Drawing.Size(266, 33);
            this.player2name.MinimumSize = new System.Drawing.Size(266, 33);
            this.player2name.Name = "player2name";
            this.player2name.Size = new System.Drawing.Size(266, 33);
            this.player2name.TabIndex = 6;
            this.player2name.Text = "Имя:";
            this.player2name.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.player2name.Visible = false;
            // 
            // hpBar1
            // 
            this.hpBar1.Location = new System.Drawing.Point(24, 237);
            this.hpBar1.Name = "hpBar1";
            this.hpBar1.Size = new System.Drawing.Size(366, 40);
            this.hpBar1.TabIndex = 7;
            this.hpBar1.Value = 100;
            this.hpBar1.Visible = false;
            // 
            // hpBar2
            // 
            this.hpBar2.Location = new System.Drawing.Point(593, 237);
            this.hpBar2.Name = "hpBar2";
            this.hpBar2.Size = new System.Drawing.Size(366, 40);
            this.hpBar2.TabIndex = 8;
            this.hpBar2.Value = 100;
            this.hpBar2.Visible = false;
            // 
            // butblock1
            // 
            this.butblock1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butblock1.Location = new System.Drawing.Point(24, 365);
            this.butblock1.Name = "butblock1";
            this.butblock1.Size = new System.Drawing.Size(246, 61);
            this.butblock1.TabIndex = 9;
            this.butblock1.Text = "ЦЕЛЬ";
            this.butblock1.UseVisualStyleBackColor = true;
            this.butblock1.Visible = false;
            this.butblock1.Click += new System.EventHandler(this.butblock1_Click);
            // 
            // butblock2
            // 
            this.butblock2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butblock2.Location = new System.Drawing.Point(24, 444);
            this.butblock2.Name = "butblock2";
            this.butblock2.Size = new System.Drawing.Size(246, 61);
            this.butblock2.TabIndex = 10;
            this.butblock2.Text = "ЦЕЛЬ";
            this.butblock2.UseVisualStyleBackColor = true;
            this.butblock2.Visible = false;
            this.butblock2.Click += new System.EventHandler(this.butblock2_Click);
            // 
            // butblock3
            // 
            this.butblock3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butblock3.Location = new System.Drawing.Point(24, 523);
            this.butblock3.Name = "butblock3";
            this.butblock3.Size = new System.Drawing.Size(246, 61);
            this.butblock3.TabIndex = 11;
            this.butblock3.Text = "ЦЕЛЬ";
            this.butblock3.UseVisualStyleBackColor = true;
            this.butblock3.Visible = false;
            this.butblock3.Click += new System.EventHandler(this.butblock3_Click);
            // 
            // LogTextBox
            // 
            this.LogTextBox.AcceptsReturn = true;
            this.LogTextBox.AcceptsTab = true;
            this.LogTextBox.BackColor = System.Drawing.Color.Black;
            this.LogTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.LogTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LogTextBox.ForeColor = System.Drawing.Color.Red;
            this.LogTextBox.Location = new System.Drawing.Point(543, 312);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(440, 352);
            this.LogTextBox.TabIndex = 12;
            this.LogTextBox.TabStop = false;
            this.LogTextBox.Visible = false;
            // 
            // hp1
            // 
            this.hp1.AutoSize = true;
            this.hp1.BackColor = System.Drawing.Color.Green;
            this.hp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.hp1.ForeColor = System.Drawing.Color.DarkRed;
            this.hp1.Location = new System.Drawing.Point(396, 237);
            this.hp1.MaximumSize = new System.Drawing.Size(71, 40);
            this.hp1.MinimumSize = new System.Drawing.Size(71, 40);
            this.hp1.Name = "hp1";
            this.hp1.Size = new System.Drawing.Size(71, 40);
            this.hp1.TabIndex = 13;
            this.hp1.Text = "100";
            this.hp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hp1.Visible = false;
            // 
            // hp2
            // 
            this.hp2.AutoSize = true;
            this.hp2.BackColor = System.Drawing.Color.Green;
            this.hp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.hp2.ForeColor = System.Drawing.Color.DarkRed;
            this.hp2.Location = new System.Drawing.Point(516, 237);
            this.hp2.MaximumSize = new System.Drawing.Size(71, 40);
            this.hp2.MinimumSize = new System.Drawing.Size(71, 40);
            this.hp2.Name = "hp2";
            this.hp2.Size = new System.Drawing.Size(71, 40);
            this.hp2.TabIndex = 14;
            this.hp2.Text = "100";
            this.hp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hp2.Visible = false;
            // 
            // move2
            // 
            this.move2.AutoSize = true;
            this.move2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.move2.ForeColor = System.Drawing.Color.Red;
            this.move2.Location = new System.Drawing.Point(276, 365);
            this.move2.MaximumSize = new System.Drawing.Size(240, 250);
            this.move2.MinimumSize = new System.Drawing.Size(240, 250);
            this.move2.Name = "move2";
            this.move2.Size = new System.Drawing.Size(240, 250);
            this.move2.TabIndex = 15;
            this.move2.Text = "Действуй";
            this.move2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // restbut
            // 
            this.restbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.restbut.Location = new System.Drawing.Point(24, 87);
            this.restbut.Name = "restbut";
            this.restbut.Size = new System.Drawing.Size(186, 70);
            this.restbut.TabIndex = 16;
            this.restbut.Text = "РЕСТАРТ";
            this.restbut.UseVisualStyleBackColor = true;
            this.restbut.Visible = false;
            this.restbut.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 663);
            this.Controls.Add(this.restbut);
            this.Controls.Add(this.move2);
            this.Controls.Add(this.hp2);
            this.Controls.Add(this.hp1);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.butblock3);
            this.Controls.Add(this.butblock2);
            this.Controls.Add(this.butblock1);
            this.Controls.Add(this.hpBar2);
            this.Controls.Add(this.hpBar1);
            this.Controls.Add(this.player2name);
            this.Controls.Add(this.player1name);
            this.Controls.Add(this.move);
            this.Controls.Add(this.butstart);
            this.Controls.Add(this.entername);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Form1";
            this.Text = "FightClub";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Label entername;
        private System.Windows.Forms.Button butstart;
        private System.Windows.Forms.Label move;
        private System.Windows.Forms.Label player1name;
        private System.Windows.Forms.Label player2name;
        private System.Windows.Forms.ProgressBar hpBar1;
        private System.Windows.Forms.ProgressBar hpBar2;
        private System.Windows.Forms.Button butblock1;
        private System.Windows.Forms.Button butblock2;
        private System.Windows.Forms.Button butblock3;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Label hp1;
        private System.Windows.Forms.Label hp2;
        private System.Windows.Forms.Label move2;
        private System.Windows.Forms.Button restbut;
    }
}

