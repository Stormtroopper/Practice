using System;

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
            this.panel3 = new System.Windows.Forms.Panel();
            this.login = new System.Windows.Forms.Button();
            this.minmise = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SLIDING = new System.Windows.Forms.FlowLayoutPanel();
            this.TOGGLEB = new System.Windows.Forms.Button();
            this.BRANCHT = new System.Windows.Forms.Button();
            this.ACCOUNTST = new System.Windows.Forms.Button();
            this.LOANST = new System.Windows.Forms.Button();
            this.TRANSACTIONT = new System.Windows.Forms.Button();
            this.SETTINGST = new System.Windows.Forms.Button();
            this.ABOUTT = new System.Windows.Forms.Button();
            this.LOG_IN = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            this.SLIDING.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.login);
            this.panel3.Controls.Add(this.minmise);
            this.panel3.Controls.Add(this.close);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(864, 29);
            this.panel3.TabIndex = 0;
            // 
            // login
            // 
            this.login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login.BackgroundImage")));
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.ForeColor = System.Drawing.Color.LightGray;
            this.login.Location = new System.Drawing.Point(751, 0);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(33, 29);
            this.login.TabIndex = 1;
            this.login.UseVisualStyleBackColor = true;
            // 
            // minmise
            // 
            this.minmise.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minmise.BackgroundImage")));
            this.minmise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minmise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minmise.ForeColor = System.Drawing.Color.LightGray;
            this.minmise.Location = new System.Drawing.Point(790, 0);
            this.minmise.Name = "minmise";
            this.minmise.Size = new System.Drawing.Size(34, 29);
            this.minmise.TabIndex = 2;
            this.minmise.UseVisualStyleBackColor = true;
            // 
            // close
            // 
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.LightGray;
            this.close.Location = new System.Drawing.Point(830, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(34, 29);
            this.close.TabIndex = 0;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // SLIDING
            // 
            this.SLIDING.BackColor = System.Drawing.Color.LightGray;
            this.SLIDING.Controls.Add(this.TOGGLEB);
            this.SLIDING.Controls.Add(this.BRANCHT);
            this.SLIDING.Controls.Add(this.ACCOUNTST);
            this.SLIDING.Controls.Add(this.LOANST);
            this.SLIDING.Controls.Add(this.TRANSACTIONT);
            this.SLIDING.Controls.Add(this.SETTINGST);
            this.SLIDING.Controls.Add(this.ABOUTT);
            this.SLIDING.Dock = System.Windows.Forms.DockStyle.Left;
            this.SLIDING.Location = new System.Drawing.Point(0, 29);
            this.SLIDING.Name = "SLIDING";
            this.SLIDING.Size = new System.Drawing.Size(200, 449);
            this.SLIDING.TabIndex = 1;
            // 
            // TOGGLEB
            // 
            this.TOGGLEB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TOGGLEB.Location = new System.Drawing.Point(3, 3);
            this.TOGGLEB.Name = "TOGGLEB";
            this.TOGGLEB.Size = new System.Drawing.Size(197, 48);
            this.TOGGLEB.TabIndex = 2;
            this.TOGGLEB.UseVisualStyleBackColor = true;
            this.TOGGLEB.Click += new System.EventHandler(this.button8_Click);
            // 
            // BRANCHT
            // 
            this.BRANCHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRANCHT.Image = ((System.Drawing.Image)(resources.GetObject("BRANCHT.Image")));
            this.BRANCHT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BRANCHT.Location = new System.Drawing.Point(3, 57);
            this.BRANCHT.Name = "BRANCHT";
            this.BRANCHT.Size = new System.Drawing.Size(197, 43);
            this.BRANCHT.TabIndex = 1;
            this.BRANCHT.Text = "BRANCH";
            this.BRANCHT.UseVisualStyleBackColor = true;
            // 
            // ACCOUNTST
            // 
            this.ACCOUNTST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ACCOUNTST.Location = new System.Drawing.Point(3, 106);
            this.ACCOUNTST.Name = "ACCOUNTST";
            this.ACCOUNTST.Size = new System.Drawing.Size(197, 45);
            this.ACCOUNTST.TabIndex = 0;
            this.ACCOUNTST.Text = "ACCOUNTS";
            this.ACCOUNTST.UseVisualStyleBackColor = true;
            // 
            // LOANST
            // 
            this.LOANST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LOANST.Location = new System.Drawing.Point(3, 157);
            this.LOANST.Name = "LOANST";
            this.LOANST.Size = new System.Drawing.Size(197, 45);
            this.LOANST.TabIndex = 3;
            this.LOANST.Text = "LOANS";
            this.LOANST.UseVisualStyleBackColor = true;
            // 
            // TRANSACTIONT
            // 
            this.TRANSACTIONT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TRANSACTIONT.Location = new System.Drawing.Point(3, 208);
            this.TRANSACTIONT.Name = "TRANSACTIONT";
            this.TRANSACTIONT.Size = new System.Drawing.Size(197, 45);
            this.TRANSACTIONT.TabIndex = 4;
            this.TRANSACTIONT.Text = "TRANSACTIONS";
            this.TRANSACTIONT.UseVisualStyleBackColor = true;
            // 
            // SETTINGST
            // 
            this.SETTINGST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SETTINGST.Location = new System.Drawing.Point(3, 259);
            this.SETTINGST.Name = "SETTINGST";
            this.SETTINGST.Size = new System.Drawing.Size(197, 45);
            this.SETTINGST.TabIndex = 5;
            this.SETTINGST.Text = "SETTINGS";
            this.SETTINGST.UseVisualStyleBackColor = true;
            // 
            // ABOUTT
            // 
            this.ABOUTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ABOUTT.Location = new System.Drawing.Point(3, 310);
            this.ABOUTT.Name = "ABOUTT";
            this.ABOUTT.Size = new System.Drawing.Size(197, 45);
            this.ABOUTT.TabIndex = 6;
            this.ABOUTT.Text = "ABOUT";
            this.ABOUTT.UseVisualStyleBackColor = true;
            // 
            // LOG_IN
            // 
            this.LOG_IN.Tick += new System.EventHandler(this.LOG_IN_Click);
            // 
            // APPBODY
            // 
            this.ClientSize = new System.Drawing.Size(864, 478);
            this.Controls.Add(this.SLIDING);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "APPBODY";
            this.panel3.ResumeLayout(false);
            this.SLIDING.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button minmise;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.FlowLayoutPanel SLIDING;
        private System.Windows.Forms.Button BRANCHT;
        private System.Windows.Forms.Button TOGGLEB;
        private System.Windows.Forms.Button ACCOUNTST;
        private System.Windows.Forms.Button LOANST;
        private System.Windows.Forms.Button TRANSACTIONT;
        private System.Windows.Forms.Button SETTINGST;
        private System.Windows.Forms.Button ABOUTT;
        private System.Windows.Forms.Timer LOG_IN;
    }
}