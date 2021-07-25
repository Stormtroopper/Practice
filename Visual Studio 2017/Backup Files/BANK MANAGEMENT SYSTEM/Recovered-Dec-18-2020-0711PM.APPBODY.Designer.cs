namespace BANK_MANAGEMENT_SYSTEM
{
    partial class APPBODY
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APPBODY));
            this.LoginTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Slidingp = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LOANSTAB = new System.Windows.Forms.Button();
            this.ABOUTTAB = new System.Windows.Forms.Button();
            this.TRANSACTIONTAB = new System.Windows.Forms.Button();
            this.SETTINGSTAB = new System.Windows.Forms.Button();
            this.ACCOUNTSTAB = new System.Windows.Forms.Button();
            this.BRANCHTAB = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Toggle1 = new System.Windows.Forms.Button();
            this.slidingpanelTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.Slidingp.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginTimer
            // 
            this.LoginTimer.Interval = 50;
            this.LoginTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 35);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.Location = new System.Drawing.Point(754, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 35);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Location = new System.Drawing.Point(833, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 35);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(789, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 35);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Slidingp
            // 
            this.Slidingp.Controls.Add(this.panel2);
            this.Slidingp.Controls.Add(this.Toggle1);
            this.Slidingp.Dock = System.Windows.Forms.DockStyle.Left;
            this.Slidingp.Location = new System.Drawing.Point(0, 35);
            this.Slidingp.Name = "Slidingp";
            this.Slidingp.Size = new System.Drawing.Size(160, 439);
            this.Slidingp.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.ABOUTTAB);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.BRANCHTAB);
            this.panel2.Controls.Add(this.ACCOUNTSTAB);
            this.panel2.Controls.Add(this.TRANSACTIONTAB);
            this.panel2.Controls.Add(this.LOANSTAB);
            this.panel2.Controls.Add(this.SETTINGSTAB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 439);
            this.panel2.TabIndex = 3;
            // 
            // LOANSTAB
            // 
            this.LOANSTAB.BackColor = System.Drawing.Color.Transparent;
            this.LOANSTAB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LOANSTAB.Font = new System.Drawing.Font("Minion Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOANSTAB.Location = new System.Drawing.Point(0, 160);
            this.LOANSTAB.Name = "LOANSTAB";
            this.LOANSTAB.Size = new System.Drawing.Size(160, 60);
            this.LOANSTAB.TabIndex = 8;
            this.LOANSTAB.Text = "LOANS";
            this.LOANSTAB.UseVisualStyleBackColor = false;
            // 
            // ABOUTTAB
            // 
            this.ABOUTTAB.BackColor = System.Drawing.Color.Transparent;
            this.ABOUTTAB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ABOUTTAB.Font = new System.Drawing.Font("Minion Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ABOUTTAB.Location = new System.Drawing.Point(0, 325);
            this.ABOUTTAB.Name = "ABOUTTAB";
            this.ABOUTTAB.Size = new System.Drawing.Size(160, 60);
            this.ABOUTTAB.TabIndex = 7;
            this.ABOUTTAB.Text = "ABOUT";
            this.ABOUTTAB.UseVisualStyleBackColor = false;
            // 
            // TRANSACTIONTAB
            // 
            this.TRANSACTIONTAB.BackColor = System.Drawing.Color.Transparent;
            this.TRANSACTIONTAB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TRANSACTIONTAB.Font = new System.Drawing.Font("Minion Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRANSACTIONTAB.Location = new System.Drawing.Point(0, 216);
            this.TRANSACTIONTAB.Name = "TRANSACTIONTAB";
            this.TRANSACTIONTAB.Size = new System.Drawing.Size(160, 60);
            this.TRANSACTIONTAB.TabIndex = 5;
            this.TRANSACTIONTAB.Text = "TRANSACTIONS";
            this.TRANSACTIONTAB.UseVisualStyleBackColor = false;
            // 
            // SETTINGSTAB
            // 
            this.SETTINGSTAB.BackColor = System.Drawing.Color.Transparent;
            this.SETTINGSTAB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SETTINGSTAB.Font = new System.Drawing.Font("Minion Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SETTINGSTAB.Location = new System.Drawing.Point(0, 270);
            this.SETTINGSTAB.Name = "SETTINGSTAB";
            this.SETTINGSTAB.Size = new System.Drawing.Size(160, 60);
            this.SETTINGSTAB.TabIndex = 6;
            this.SETTINGSTAB.Text = "SETTINGS";
            this.SETTINGSTAB.UseVisualStyleBackColor = false;
            // 
            // ACCOUNTSTAB
            // 
            this.ACCOUNTSTAB.BackColor = System.Drawing.Color.Transparent;
            this.ACCOUNTSTAB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ACCOUNTSTAB.Font = new System.Drawing.Font("Minion Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACCOUNTSTAB.Location = new System.Drawing.Point(0, 103);
            this.ACCOUNTSTAB.Name = "ACCOUNTSTAB";
            this.ACCOUNTSTAB.Size = new System.Drawing.Size(160, 60);
            this.ACCOUNTSTAB.TabIndex = 4;
            this.ACCOUNTSTAB.Text = "ACCOUNTS";
            this.ACCOUNTSTAB.UseVisualStyleBackColor = false;
            // 
            // BRANCHTAB
            // 
            this.BRANCHTAB.BackColor = System.Drawing.Color.Transparent;
            this.BRANCHTAB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRANCHTAB.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRANCHTAB.Location = new System.Drawing.Point(0, 50);
            this.BRANCHTAB.Name = "BRANCHTAB";
            this.BRANCHTAB.Size = new System.Drawing.Size(160, 60);
            this.BRANCHTAB.TabIndex = 3;
            this.BRANCHTAB.Text = "BRANCH";
            this.BRANCHTAB.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 60);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Toggle1
            // 
            this.Toggle1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Toggle1.Location = new System.Drawing.Point(0, 0);
            this.Toggle1.Name = "Toggle1";
            this.Toggle1.Size = new System.Drawing.Size(160, 61);
            this.Toggle1.TabIndex = 2;
            this.Toggle1.UseVisualStyleBackColor = true;
            this.Toggle1.Click += new System.EventHandler(this.Toggle1_Click);
            // 
            // slidingpanelTimer
            // 
            this.slidingpanelTimer.Tick += new System.EventHandler(this.slidingpanelTimer_Tick);
            // 
            // APPBODY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(871, 474);
            this.Controls.Add(this.Slidingp);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "APPBODY";
            this.Text = "APPBODY";
            this.Load += new System.EventHandler(this.APPBODY_Load);
            this.panel1.ResumeLayout(false);
            this.Slidingp.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer LoginTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel Slidingp;
        private System.Windows.Forms.Button Toggle1;
        private System.Windows.Forms.Timer slidingpanelTimer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ABOUTTAB;
        private System.Windows.Forms.Button SETTINGSTAB;
        private System.Windows.Forms.Button TRANSACTIONTAB;
        private System.Windows.Forms.Button ACCOUNTSTAB;
        private System.Windows.Forms.Button BRANCHTAB;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button LOANSTAB;
    }
}