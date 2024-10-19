namespace Tic_Tac_Toe_Game_Assignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { optionsToolStripMenuItem, aboutToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(520, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.BackColor = SystemColors.ControlLight;
            optionsToolStripMenuItem.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            optionsToolStripMenuItem.ForeColor = SystemColors.GrayText;
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(122, 24);
            optionsToolStripMenuItem.Text = "New Game F1";
            optionsToolStripMenuItem.Click += optionsToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.BackColor = SystemColors.ControlLight;
            aboutToolStripMenuItem.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            aboutToolStripMenuItem.ForeColor = SystemColors.GrayText;
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(95, 24);
            aboutToolStripMenuItem.Text = "About F2";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = SystemColors.ControlLight;
            exitToolStripMenuItem.Font = new Font("Consolas", 10.2F, FontStyle.Bold);
            exitToolStripMenuItem.ForeColor = SystemColors.GrayText;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(86, 24);
            exitToolStripMenuItem.Text = "Exit F3";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btn9, 2, 2);
            tableLayoutPanel1.Controls.Add(btn8, 1, 2);
            tableLayoutPanel1.Controls.Add(btn7, 0, 2);
            tableLayoutPanel1.Controls.Add(btn6, 2, 1);
            tableLayoutPanel1.Controls.Add(btn5, 1, 1);
            tableLayoutPanel1.Controls.Add(btn4, 0, 1);
            tableLayoutPanel1.Controls.Add(btn3, 2, 0);
            tableLayoutPanel1.Controls.Add(btn2, 1, 0);
            tableLayoutPanel1.Controls.Add(btn1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 28);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(520, 425);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btn9
            // 
            btn9.BackColor = Color.PapayaWhip;
            btn9.Dock = DockStyle.Fill;
            btn9.FlatAppearance.BorderSize = 5;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            btn9.Location = new Point(349, 285);
            btn9.Name = "btn9";
            btn9.Size = new Size(168, 137);
            btn9.TabIndex = 8;
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += button_click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.PapayaWhip;
            btn8.Dock = DockStyle.Fill;
            btn8.FlatAppearance.BorderSize = 5;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            btn8.Location = new Point(176, 285);
            btn8.Name = "btn8";
            btn8.Size = new Size(167, 137);
            btn8.TabIndex = 7;
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += button_click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.PapayaWhip;
            btn7.Dock = DockStyle.Fill;
            btn7.FlatAppearance.BorderSize = 5;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            btn7.Location = new Point(3, 285);
            btn7.Name = "btn7";
            btn7.Size = new Size(167, 137);
            btn7.TabIndex = 6;
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += button_click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.PapayaWhip;
            btn6.Dock = DockStyle.Fill;
            btn6.FlatAppearance.BorderSize = 5;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            btn6.Location = new Point(349, 144);
            btn6.Name = "btn6";
            btn6.Size = new Size(168, 135);
            btn6.TabIndex = 5;
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += button_click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.PapayaWhip;
            btn5.Dock = DockStyle.Fill;
            btn5.FlatAppearance.BorderSize = 5;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            btn5.Location = new Point(176, 144);
            btn5.Name = "btn5";
            btn5.Size = new Size(167, 135);
            btn5.TabIndex = 4;
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += button_click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.PapayaWhip;
            btn4.Dock = DockStyle.Fill;
            btn4.FlatAppearance.BorderSize = 5;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            btn4.Location = new Point(3, 144);
            btn4.Name = "btn4";
            btn4.Size = new Size(167, 135);
            btn4.TabIndex = 3;
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += button_click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.PapayaWhip;
            btn3.Dock = DockStyle.Fill;
            btn3.FlatAppearance.BorderSize = 5;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            btn3.Location = new Point(349, 3);
            btn3.Name = "btn3";
            btn3.Size = new Size(168, 135);
            btn3.TabIndex = 2;
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += button_click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.PapayaWhip;
            btn2.Dock = DockStyle.Fill;
            btn2.FlatAppearance.BorderSize = 5;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            btn2.Location = new Point(176, 3);
            btn2.Name = "btn2";
            btn2.Size = new Size(167, 135);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += button_click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.PapayaWhip;
            btn1.Dock = DockStyle.Fill;
            btn1.FlatAppearance.BorderSize = 5;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            btn1.Location = new Point(3, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(167, 135);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += button_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 453);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(1000, 1000);
            MinimumSize = new Size(350, 500);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btn1;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
    }
}
