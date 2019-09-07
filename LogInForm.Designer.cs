namespace Metro_Rail_Management_System
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.buttonlogin = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelUserType = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.linkLabeRegister = new System.Windows.Forms.LinkLabel();
            this.linkLabeldetails = new System.Windows.Forms.LinkLabel();
            this.comboBoxUserType = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonlogin
            // 
            this.buttonlogin.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogin.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.buttonlogin.ImageIndex = 0;
            this.buttonlogin.Location = new System.Drawing.Point(256, 427);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(88, 36);
            this.buttonlogin.TabIndex = 0;
            this.buttonlogin.Text = "Login";
            this.buttonlogin.UseVisualStyleBackColor = false;
            this.buttonlogin.Click += new System.EventHandler(this.Buttonlogin_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(210, 356);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(121, 20);
            this.textBoxId.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(210, 390);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(121, 20);
            this.textBoxPassword.TabIndex = 2;
            // 
            // labelUserType
            // 
            this.labelUserType.AutoSize = true;
            this.labelUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserType.Location = new System.Drawing.Point(121, 318);
            this.labelUserType.Name = "labelUserType";
            this.labelUserType.Size = new System.Drawing.Size(77, 16);
            this.labelUserType.TabIndex = 3;
            this.labelUserType.Text = "UserType";
            this.labelUserType.Click += new System.EventHandler(this.Label1_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(121, 363);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(23, 16);
            this.labelId.TabIndex = 4;
            this.labelId.Text = "ID";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(121, 397);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(76, 16);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Password";
            // 
            // linkLabeRegister
            // 
            this.linkLabeRegister.AutoSize = true;
            this.linkLabeRegister.Location = new System.Drawing.Point(110, 479);
            this.linkLabeRegister.Name = "linkLabeRegister";
            this.linkLabeRegister.Size = new System.Drawing.Size(221, 13);
            this.linkLabeRegister.TabIndex = 9;
            this.linkLabeRegister.TabStop = true;
            this.linkLabeRegister.Text = "Don\'t have an account?Click here to register ";
            this.linkLabeRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabeRegister_LinkClicked);
            // 
            // linkLabeldetails
            // 
            this.linkLabeldetails.AutoSize = true;
            this.linkLabeldetails.Location = new System.Drawing.Point(534, 479);
            this.linkLabeldetails.Name = "linkLabeldetails";
            this.linkLabeldetails.Size = new System.Drawing.Size(119, 13);
            this.linkLabeldetails.TabIndex = 10;
            this.linkLabeldetails.TabStop = true;
            this.linkLabeldetails.Text = "Click here to see details";
            this.linkLabeldetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabeldetails_LinkClicked);
            // 
            // comboBoxUserType
            // 
            this.comboBoxUserType.FormattingEnabled = true;
            this.comboBoxUserType.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Passenger"});
            this.comboBoxUserType.Location = new System.Drawing.Point(210, 315);
            this.comboBoxUserType.Name = "comboBoxUserType";
            this.comboBoxUserType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUserType.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(685, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(684, 526);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxUserType);
            this.Controls.Add(this.linkLabeldetails);
            this.Controls.Add(this.linkLabeRegister);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelUserType);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonlogin);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelUserType;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.LinkLabel linkLabeRegister;
        private System.Windows.Forms.LinkLabel linkLabeldetails;
        private System.Windows.Forms.ComboBox comboBoxUserType;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

