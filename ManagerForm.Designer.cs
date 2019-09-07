namespace Metro_Rail_Management_System
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.labelMetroNo = new System.Windows.Forms.Label();
            this.labelCurrentStopage = new System.Windows.Forms.Label();
            this.labelNextStoppage = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.linkLabeldetails = new System.Windows.Forms.LinkLabel();
            this.buttonMe = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelE = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.labelAdd = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelI = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxSource = new System.Windows.Forms.ComboBox();
            this.comboBoxNext = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMetroNo
            // 
            this.labelMetroNo.AutoSize = true;
            this.labelMetroNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetroNo.Location = new System.Drawing.Point(54, 135);
            this.labelMetroNo.Name = "labelMetroNo";
            this.labelMetroNo.Size = new System.Drawing.Size(63, 16);
            this.labelMetroNo.TabIndex = 0;
            this.labelMetroNo.Text = "Metro No";
            // 
            // labelCurrentStopage
            // 
            this.labelCurrentStopage.AutoSize = true;
            this.labelCurrentStopage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentStopage.Location = new System.Drawing.Point(54, 166);
            this.labelCurrentStopage.Name = "labelCurrentStopage";
            this.labelCurrentStopage.Size = new System.Drawing.Size(111, 16);
            this.labelCurrentStopage.TabIndex = 1;
            this.labelCurrentStopage.Text = "Current stoppage";
            // 
            // labelNextStoppage
            // 
            this.labelNextStoppage.AutoSize = true;
            this.labelNextStoppage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNextStoppage.Location = new System.Drawing.Point(54, 202);
            this.labelNextStoppage.Name = "labelNextStoppage";
            this.labelNextStoppage.Size = new System.Drawing.Size(101, 16);
            this.labelNextStoppage.TabIndex = 2;
            this.labelNextStoppage.Text = "Next Stoppage ";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSubmit.ImageIndex = 5;
            this.buttonSubmit.ImageList = this.imageList1;
            this.buttonSubmit.Location = new System.Drawing.Point(115, 269);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(64, 44);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // linkLabeldetails
            // 
            this.linkLabeldetails.AutoSize = true;
            this.linkLabeldetails.Location = new System.Drawing.Point(155, 332);
            this.linkLabeldetails.Name = "linkLabeldetails";
            this.linkLabeldetails.Size = new System.Drawing.Size(135, 13);
            this.linkLabeldetails.TabIndex = 11;
            this.linkLabeldetails.TabStop = true;
            this.linkLabeldetails.Text = "Click here to see rail details";
            this.linkLabeldetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabeldetails_LinkClicked);
            // 
            // buttonMe
            // 
            this.buttonMe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMe.ImageIndex = 0;
            this.buttonMe.ImageList = this.imageList1;
            this.buttonMe.Location = new System.Drawing.Point(18, 269);
            this.buttonMe.Name = "buttonMe";
            this.buttonMe.Size = new System.Drawing.Size(81, 44);
            this.buttonMe.TabIndex = 12;
            this.buttonMe.Text = "About Me";
            this.buttonMe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMe.UseVisualStyleBackColor = false;
            this.buttonMe.Click += new System.EventHandler(this.ButtonMe_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "images.png");
            this.imageList1.Images.SetKeyName(1, "blue-play-button-icon-17903.png");
            this.imageList1.Images.SetKeyName(2, "depositphotos_56512111-stock-photo-logout-power-off-icon-glossy.jpg");
            this.imageList1.Images.SetKeyName(3, "12172954-logout-icon.jpg");
            this.imageList1.Images.SetKeyName(4, "Apps-Dialog-Shutdown-Icon-334173.png");
            this.imageList1.Images.SetKeyName(5, "submit-button-clipart-icon-783382-997630.jpg");
            this.imageList1.Images.SetKeyName(6, "images (1).png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBoxN);
            this.panel1.Controls.Add(this.textBoxAge);
            this.panel1.Controls.Add(this.textBoxAdd);
            this.panel1.Controls.Add(this.textBoxP);
            this.panel1.Controls.Add(this.textBoxE);
            this.panel1.Controls.Add(this.textBoxPass);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelE);
            this.panel1.Controls.Add(this.labelP);
            this.panel1.Controls.Add(this.labelAdd);
            this.panel1.Controls.Add(this.labelN);
            this.panel1.Controls.Add(this.labelAge);
            this.panel1.Controls.Add(this.labelI);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(374, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 332);
            this.panel1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.ImageIndex = 6;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(214, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Edit";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBoxN
            // 
            this.textBoxN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxN.Location = new System.Drawing.Point(179, 84);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(133, 22);
            this.textBoxN.TabIndex = 15;
            this.textBoxN.TextChanged += new System.EventHandler(this.TextBoxN_TextChanged);
            this.textBoxN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxN_KeyPress);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAge.Location = new System.Drawing.Point(179, 112);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(133, 22);
            this.textBoxAge.TabIndex = 14;
            this.textBoxAge.TextChanged += new System.EventHandler(this.TextBoxAge_TextChanged);
            this.textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAge_KeyPress);
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdd.Location = new System.Drawing.Point(179, 140);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(133, 22);
            this.textBoxAdd.TabIndex = 13;
            // 
            // textBoxP
            // 
            this.textBoxP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxP.Location = new System.Drawing.Point(179, 168);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(133, 22);
            this.textBoxP.TabIndex = 12;
            this.textBoxP.TextChanged += new System.EventHandler(this.TextBoxP_TextChanged);
            // 
            // textBoxE
            // 
            this.textBoxE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxE.Location = new System.Drawing.Point(179, 196);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(133, 22);
            this.textBoxE.TabIndex = 11;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.Location = new System.Drawing.Point(179, 224);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(133, 22);
            this.textBoxPass.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(148, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Manager Info";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Assigned Rail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Password";
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelE.Location = new System.Drawing.Point(42, 202);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(47, 16);
            this.labelE.TabIndex = 5;
            this.labelE.Text = "Email";
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP.Location = new System.Drawing.Point(42, 174);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(76, 16);
            this.labelP.TabIndex = 4;
            this.labelP.Text = "Phone No";
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdd.Location = new System.Drawing.Point(42, 146);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(66, 16);
            this.labelAdd.TabIndex = 3;
            this.labelAdd.Text = "Address";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelN.Location = new System.Drawing.Point(42, 90);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(49, 16);
            this.labelN.TabIndex = 2;
            this.labelN.Text = "Name";
            this.labelN.Click += new System.EventHandler(this.LabelN_Click);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(42, 115);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(36, 16);
            this.labelAge.TabIndex = 1;
            this.labelAge.Text = "Age";
            // 
            // labelI
            // 
            this.labelI.AutoSize = true;
            this.labelI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelI.Location = new System.Drawing.Point(42, 59);
            this.labelI.Name = "labelI";
            this.labelI.Size = new System.Drawing.Size(23, 16);
            this.labelI.TabIndex = 0;
            this.labelI.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(179, 64);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(133, 21);
            this.textBoxID.TabIndex = 20;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(179, 97);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(133, 21);
            this.textBoxName.TabIndex = 21;
            this.textBoxName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(179, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 21);
            this.textBox1.TabIndex = 23;
            // 
            // comboBoxSource
            // 
            this.comboBoxSource.FormattingEnabled = true;
            this.comboBoxSource.Items.AddRange(new object[] {
            "Uttara-North",
            "Uttara-Center",
            "Uttara-South",
            "Pallabi",
            "Mirpur11",
            "Mirpur10",
            "Kazipara",
            "Shewrapara",
            "Agargaon",
            "Bijoy-Sarani",
            "Farmgate",
            "Karwan-Bazar",
            "Shahbagh",
            "Dhaka-University",
            "Bangladesh Secretariat",
            "Motijheel"});
            this.comboBoxSource.Location = new System.Drawing.Point(179, 165);
            this.comboBoxSource.Name = "comboBoxSource";
            this.comboBoxSource.Size = new System.Drawing.Size(133, 21);
            this.comboBoxSource.TabIndex = 24;
            // 
            // comboBoxNext
            // 
            this.comboBoxNext.FormattingEnabled = true;
            this.comboBoxNext.Items.AddRange(new object[] {
            "Uttara-North",
            "Uttara-Center",
            "Uttara-South",
            "Pallabi",
            "Mirpur11",
            "Mirpur10",
            "Kazipara",
            "Shewrapara",
            "Agargaon",
            "Bijoy-Sarani",
            "Farmgate",
            "Karwan-Bazar",
            "Shahbagh",
            "Dhaka-University",
            "Bangladesh Secretariat",
            "Motijheel"});
            this.comboBoxNext.Location = new System.Drawing.Point(179, 202);
            this.comboBoxNext.Name = "comboBoxNext";
            this.comboBoxNext.Size = new System.Drawing.Size(133, 21);
            this.comboBoxNext.TabIndex = 25;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.ImageIndex = 4;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(268, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 44);
            this.button2.TabIndex = 26;
            this.button2.Text = "Logout";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.ImageIndex = 1;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(198, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 44);
            this.button3.TabIndex = 27;
            this.button3.Text = "Refresh";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "label4";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(791, 357);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxNext);
            this.Controls.Add(this.comboBoxSource);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonMe);
            this.Controls.Add(this.linkLabeldetails);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelNextStoppage);
            this.Controls.Add(this.labelCurrentStopage);
            this.Controls.Add(this.labelMetroNo);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMetroNo;
        private System.Windows.Forms.Label labelCurrentStopage;
        private System.Windows.Forms.Label labelNextStoppage;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.LinkLabel linkLabeldetails;
        private System.Windows.Forms.Button buttonMe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelI;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxSource;
        private System.Windows.Forms.ComboBox comboBoxNext;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}