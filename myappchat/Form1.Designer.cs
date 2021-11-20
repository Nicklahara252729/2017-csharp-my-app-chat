namespace myappchat
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblnamauser = new System.Windows.Forms.Label();
            this.btnreload = new System.Windows.Forms.Button();
            this.btnsend = new System.Windows.Forms.Button();
            this.btnadduser = new System.Windows.Forms.Button();
            this.txtmessage = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.txtidsiswa = new System.Windows.Forms.TextBox();
            this.btnload = new System.Windows.Forms.Button();
            this.txtinputid = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.listchat = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblnamauser);
            this.panel1.Controls.Add(this.btnreload);
            this.panel1.Controls.Add(this.btnsend);
            this.panel1.Controls.Add(this.btnadduser);
            this.panel1.Controls.Add(this.txtmessage);
            this.panel1.Controls.Add(this.txtnama);
            this.panel1.Controls.Add(this.btnok);
            this.panel1.Controls.Add(this.txtidsiswa);
            this.panel1.Controls.Add(this.btnload);
            this.panel1.Controls.Add(this.txtinputid);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 532);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "PESAN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "NAMA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "YOUR ID";
            // 
            // lblnamauser
            // 
            this.lblnamauser.AutoSize = true;
            this.lblnamauser.Location = new System.Drawing.Point(13, 136);
            this.lblnamauser.Name = "lblnamauser";
            this.lblnamauser.Size = new System.Drawing.Size(60, 13);
            this.lblnamauser.TabIndex = 10;
            this.lblnamauser.Text = "Nama User";
            // 
            // btnreload
            // 
            this.btnreload.Location = new System.Drawing.Point(13, 499);
            this.btnreload.Name = "btnreload";
            this.btnreload.Size = new System.Drawing.Size(250, 28);
            this.btnreload.TabIndex = 9;
            this.btnreload.Text = "Reload";
            this.btnreload.UseVisualStyleBackColor = true;
            this.btnreload.Click += new System.EventHandler(this.btnreload_Click);
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(13, 465);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(250, 28);
            this.btnsend.TabIndex = 8;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // btnadduser
            // 
            this.btnadduser.Location = new System.Drawing.Point(185, 431);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.Size = new System.Drawing.Size(78, 28);
            this.btnadduser.TabIndex = 7;
            this.btnadduser.Text = "Add User";
            this.btnadduser.UseVisualStyleBackColor = true;
            this.btnadduser.Click += new System.EventHandler(this.btnadduser_Click);
            // 
            // txtmessage
            // 
            this.txtmessage.Location = new System.Drawing.Point(84, 285);
            this.txtmessage.Multiline = true;
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.Size = new System.Drawing.Size(179, 121);
            this.txtmessage.TabIndex = 6;
            // 
            // txtnama
            // 
            this.txtnama.Enabled = false;
            this.txtnama.Location = new System.Drawing.Point(84, 251);
            this.txtnama.Multiline = true;
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(179, 28);
            this.txtnama.TabIndex = 5;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(233, 217);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(30, 28);
            this.btnok.TabIndex = 4;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Visible = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // txtidsiswa
            // 
            this.txtidsiswa.Enabled = false;
            this.txtidsiswa.Location = new System.Drawing.Point(84, 217);
            this.txtidsiswa.Multiline = true;
            this.txtidsiswa.Name = "txtidsiswa";
            this.txtidsiswa.Size = new System.Drawing.Size(143, 28);
            this.txtidsiswa.TabIndex = 3;
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(233, 152);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(30, 28);
            this.btnload.TabIndex = 1;
            this.btnload.Text = "O";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // txtinputid
            // 
            this.txtinputid.Location = new System.Drawing.Point(13, 152);
            this.txtinputid.Multiline = true;
            this.txtinputid.Name = "txtinputid";
            this.txtinputid.Size = new System.Drawing.Size(214, 28);
            this.txtinputid.TabIndex = 1;
            this.txtinputid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtinputid_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(276, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 35);
            this.panel2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(140, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "IT SOLUTION BOARDING 4 CHAT";
            // 
            // listchat
            // 
            this.listchat.FormattingEnabled = true;
            this.listchat.Location = new System.Drawing.Point(275, 34);
            this.listchat.Name = "listchat";
            this.listchat.Size = new System.Drawing.Size(454, 498);
            this.listchat.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Clear Msg";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 531);
            this.Controls.Add(this.listchat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblnamauser;
        private System.Windows.Forms.Button btnreload;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Button btnadduser;
        private System.Windows.Forms.TextBox txtmessage;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.TextBox txtidsiswa;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.TextBox txtinputid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listchat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

