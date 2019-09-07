namespace Metro_Rail_Management_System
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panelmanagerlist = new System.Windows.Forms.Panel();
            this.labelheading2 = new System.Windows.Forms.Label();
            this.buttonManager = new System.Windows.Forms.Button();
            this.dataGridViewManager = new System.Windows.Forms.DataGridView();
            this.panelManagerRequest = new System.Windows.Forms.Panel();
            this.labelheading1 = new System.Windows.Forms.Label();
            this.buttonAccepted = new System.Windows.Forms.Button();
            this.buttonRejected = new System.Windows.Forms.Button();
            this.dataGridViewManagerRequest = new System.Windows.Forms.DataGridView();
            this.panelpassengerlist = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewPassenger = new System.Windows.Forms.DataGridView();
            this.buttonPassenger = new System.Windows.Forms.Button();
            this.panelPassengerRequest = new System.Windows.Forms.Panel();
            this.labelheading3 = new System.Windows.Forms.Label();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonReject = new System.Windows.Forms.Button();
            this.dataGridViewPassengerRequest = new System.Windows.Forms.DataGridView();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passengerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.railDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManagerRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PassengerRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelRaillist = new System.Windows.Forms.Panel();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.labelid = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddtrain = new System.Windows.Forms.Button();
            this.dataGridViewRail = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabeldetails = new System.Windows.Forms.LinkLabel();
            this.panelmanagerlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManager)).BeginInit();
            this.panelManagerRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManagerRequest)).BeginInit();
            this.panelpassengerlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassenger)).BeginInit();
            this.panelPassengerRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassengerRequest)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelRaillist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRail)).BeginInit();
            this.SuspendLayout();
            // 
            // panelmanagerlist
            // 
            this.panelmanagerlist.Controls.Add(this.labelheading2);
            this.panelmanagerlist.Controls.Add(this.buttonManager);
            this.panelmanagerlist.Controls.Add(this.dataGridViewManager);
            this.panelmanagerlist.Location = new System.Drawing.Point(3, 26);
            this.panelmanagerlist.Name = "panelmanagerlist";
            this.panelmanagerlist.Size = new System.Drawing.Size(618, 316);
            this.panelmanagerlist.TabIndex = 0;
            // 
            // labelheading2
            // 
            this.labelheading2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelheading2.Location = new System.Drawing.Point(93, 0);
            this.labelheading2.Name = "labelheading2";
            this.labelheading2.Size = new System.Drawing.Size(428, 36);
            this.labelheading2.TabIndex = 6;
            this.labelheading2.Text = "List of Managers";
            // 
            // buttonManager
            // 
            this.buttonManager.Location = new System.Drawing.Point(269, 280);
            this.buttonManager.Name = "buttonManager";
            this.buttonManager.Size = new System.Drawing.Size(75, 23);
            this.buttonManager.TabIndex = 3;
            this.buttonManager.Text = "Remove";
            this.buttonManager.UseVisualStyleBackColor = true;
            this.buttonManager.Click += new System.EventHandler(this.ButtonManager_Click);
            // 
            // dataGridViewManager
            // 
            this.dataGridViewManager.AllowUserToAddRows = false;
            this.dataGridViewManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManager.Location = new System.Drawing.Point(0, 39);
            this.dataGridViewManager.Name = "dataGridViewManager";
            this.dataGridViewManager.Size = new System.Drawing.Size(618, 236);
            this.dataGridViewManager.TabIndex = 0;
            // 
            // panelManagerRequest
            // 
            this.panelManagerRequest.Controls.Add(this.labelheading1);
            this.panelManagerRequest.Controls.Add(this.buttonAccepted);
            this.panelManagerRequest.Controls.Add(this.buttonRejected);
            this.panelManagerRequest.Controls.Add(this.dataGridViewManagerRequest);
            this.panelManagerRequest.Location = new System.Drawing.Point(0, 0);
            this.panelManagerRequest.Name = "panelManagerRequest";
            this.panelManagerRequest.Size = new System.Drawing.Size(618, 315);
            this.panelManagerRequest.TabIndex = 4;
            // 
            // labelheading1
            // 
            this.labelheading1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelheading1.Location = new System.Drawing.Point(93, 0);
            this.labelheading1.Name = "labelheading1";
            this.labelheading1.Size = new System.Drawing.Size(428, 36);
            this.labelheading1.TabIndex = 5;
            this.labelheading1.Text = "List of Requested Managers";
            // 
            // buttonAccepted
            // 
            this.buttonAccepted.Location = new System.Drawing.Point(221, 281);
            this.buttonAccepted.Name = "buttonAccepted";
            this.buttonAccepted.Size = new System.Drawing.Size(75, 23);
            this.buttonAccepted.TabIndex = 4;
            this.buttonAccepted.Text = "Accept";
            this.buttonAccepted.UseVisualStyleBackColor = true;
            this.buttonAccepted.Click += new System.EventHandler(this.ButtonAccepted_Click);
            // 
            // buttonRejected
            // 
            this.buttonRejected.Location = new System.Drawing.Point(329, 281);
            this.buttonRejected.Name = "buttonRejected";
            this.buttonRejected.Size = new System.Drawing.Size(75, 23);
            this.buttonRejected.TabIndex = 3;
            this.buttonRejected.Text = "Reject";
            this.buttonRejected.UseVisualStyleBackColor = true;
            this.buttonRejected.Click += new System.EventHandler(this.ButtonRejected_Click);
            // 
            // dataGridViewManagerRequest
            // 
            this.dataGridViewManagerRequest.AllowUserToAddRows = false;
            this.dataGridViewManagerRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManagerRequest.Location = new System.Drawing.Point(0, 39);
            this.dataGridViewManagerRequest.Name = "dataGridViewManagerRequest";
            this.dataGridViewManagerRequest.Size = new System.Drawing.Size(618, 233);
            this.dataGridViewManagerRequest.TabIndex = 0;
            // 
            // panelpassengerlist
            // 
            this.panelpassengerlist.Controls.Add(this.label1);
            this.panelpassengerlist.Controls.Add(this.dataGridViewPassenger);
            this.panelpassengerlist.Controls.Add(this.buttonPassenger);
            this.panelpassengerlist.Location = new System.Drawing.Point(3, 26);
            this.panelpassengerlist.Name = "panelpassengerlist";
            this.panelpassengerlist.Size = new System.Drawing.Size(618, 316);
            this.panelpassengerlist.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "List of Passengers";
            // 
            // dataGridViewPassenger
            // 
            this.dataGridViewPassenger.AllowUserToAddRows = false;
            this.dataGridViewPassenger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPassenger.Location = new System.Drawing.Point(0, 39);
            this.dataGridViewPassenger.Name = "dataGridViewPassenger";
            this.dataGridViewPassenger.Size = new System.Drawing.Size(618, 233);
            this.dataGridViewPassenger.TabIndex = 1;
            // 
            // buttonPassenger
            // 
            this.buttonPassenger.Location = new System.Drawing.Point(269, 279);
            this.buttonPassenger.Name = "buttonPassenger";
            this.buttonPassenger.Size = new System.Drawing.Size(75, 23);
            this.buttonPassenger.TabIndex = 2;
            this.buttonPassenger.Text = "Remove";
            this.buttonPassenger.UseVisualStyleBackColor = true;
            this.buttonPassenger.Click += new System.EventHandler(this.ButtonPassenger_Click);
            // 
            // panelPassengerRequest
            // 
            this.panelPassengerRequest.Controls.Add(this.labelheading3);
            this.panelPassengerRequest.Controls.Add(this.panelManagerRequest);
            this.panelPassengerRequest.Controls.Add(this.buttonAccept);
            this.panelPassengerRequest.Controls.Add(this.buttonReject);
            this.panelPassengerRequest.Controls.Add(this.dataGridViewPassengerRequest);
            this.panelPassengerRequest.Location = new System.Drawing.Point(3, 27);
            this.panelPassengerRequest.Name = "panelPassengerRequest";
            this.panelPassengerRequest.Size = new System.Drawing.Size(618, 315);
            this.panelPassengerRequest.TabIndex = 5;
            // 
            // labelheading3
            // 
            this.labelheading3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelheading3.Location = new System.Drawing.Point(93, 0);
            this.labelheading3.Name = "labelheading3";
            this.labelheading3.Size = new System.Drawing.Size(428, 36);
            this.labelheading3.TabIndex = 6;
            this.labelheading3.Text = "List of Requested Passengers";
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(206, 281);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 4;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.ButtonAccept_Click);
            // 
            // buttonReject
            // 
            this.buttonReject.Location = new System.Drawing.Point(329, 281);
            this.buttonReject.Name = "buttonReject";
            this.buttonReject.Size = new System.Drawing.Size(75, 23);
            this.buttonReject.TabIndex = 3;
            this.buttonReject.Text = "Reject";
            this.buttonReject.UseVisualStyleBackColor = true;
            this.buttonReject.Click += new System.EventHandler(this.ButtonReject_Click);
            // 
            // dataGridViewPassengerRequest
            // 
            this.dataGridViewPassengerRequest.AllowUserToAddRows = false;
            this.dataGridViewPassengerRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPassengerRequest.Location = new System.Drawing.Point(0, 39);
            this.dataGridViewPassengerRequest.Name = "dataGridViewPassengerRequest";
            this.dataGridViewPassengerRequest.Size = new System.Drawing.Size(615, 233);
            this.dataGridViewPassengerRequest.TabIndex = 0;
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managerListToolStripMenuItem,
            this.passengerListToolStripMenuItem,
            this.railDetailsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // managerListToolStripMenuItem
            // 
            this.managerListToolStripMenuItem.Name = "managerListToolStripMenuItem";
            this.managerListToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.managerListToolStripMenuItem.Text = "Manager List";
            this.managerListToolStripMenuItem.Click += new System.EventHandler(this.ManagerListToolStripMenuItem_Click);
            // 
            // passengerListToolStripMenuItem
            // 
            this.passengerListToolStripMenuItem.Name = "passengerListToolStripMenuItem";
            this.passengerListToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.passengerListToolStripMenuItem.Text = "Passenger List";
            this.passengerListToolStripMenuItem.Click += new System.EventHandler(this.PassengerListToolStripMenuItem_Click);
            // 
            // railDetailsToolStripMenuItem
            // 
            this.railDetailsToolStripMenuItem.Name = "railDetailsToolStripMenuItem";
            this.railDetailsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.railDetailsToolStripMenuItem.Text = "Rail Details";
            this.railDetailsToolStripMenuItem.Click += new System.EventHandler(this.RailDetailsToolStripMenuItem_Click);
            // 
            // pendingToolStripMenuItem
            // 
            this.pendingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManagerRequestToolStripMenuItem,
            this.PassengerRequestToolStripMenuItem});
            this.pendingToolStripMenuItem.Name = "pendingToolStripMenuItem";
            this.pendingToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.pendingToolStripMenuItem.Text = "Pending";
            // 
            // ManagerRequestToolStripMenuItem
            // 
            this.ManagerRequestToolStripMenuItem.Name = "ManagerRequestToolStripMenuItem";
            this.ManagerRequestToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.ManagerRequestToolStripMenuItem.Text = "Manager request";
            this.ManagerRequestToolStripMenuItem.Click += new System.EventHandler(this.ManagerRequestToolStripMenuItem_Click);
            // 
            // PassengerRequestToolStripMenuItem
            // 
            this.PassengerRequestToolStripMenuItem.Name = "PassengerRequestToolStripMenuItem";
            this.PassengerRequestToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.PassengerRequestToolStripMenuItem.Text = "Passenger request";
            this.PassengerRequestToolStripMenuItem.Click += new System.EventHandler(this.PassengerRequestToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.pendingToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // panelRaillist
            // 
            this.panelRaillist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelRaillist.Controls.Add(this.textBoxid);
            this.panelRaillist.Controls.Add(this.labelid);
            this.panelRaillist.Controls.Add(this.buttonUpdate);
            this.panelRaillist.Controls.Add(this.buttonDelete);
            this.panelRaillist.Controls.Add(this.comboBox1);
            this.panelRaillist.Controls.Add(this.label3);
            this.panelRaillist.Controls.Add(this.buttonAddtrain);
            this.panelRaillist.Controls.Add(this.dataGridViewRail);
            this.panelRaillist.Controls.Add(this.label2);
            this.panelRaillist.Location = new System.Drawing.Point(0, 26);
            this.panelRaillist.Name = "panelRaillist";
            this.panelRaillist.Size = new System.Drawing.Size(621, 316);
            this.panelRaillist.TabIndex = 6;
            // 
            // textBoxid
            // 
            this.textBoxid.BackColor = System.Drawing.Color.White;
            this.textBoxid.Location = new System.Drawing.Point(79, 53);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(100, 20);
            this.textBoxid.TabIndex = 9;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(4, 56);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(46, 13);
            this.labelid.TabIndex = 8;
            this.labelid.Text = "Train Id ";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(79, 215);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(79, 169);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete Rail";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Assign Maager";
            // 
            // buttonAddtrain
            // 
            this.buttonAddtrain.Location = new System.Drawing.Point(79, 131);
            this.buttonAddtrain.Name = "buttonAddtrain";
            this.buttonAddtrain.Size = new System.Drawing.Size(75, 23);
            this.buttonAddtrain.TabIndex = 2;
            this.buttonAddtrain.Text = "Add train";
            this.buttonAddtrain.UseVisualStyleBackColor = true;
            this.buttonAddtrain.Click += new System.EventHandler(this.ButtonAddtrain_Click);
            // 
            // dataGridViewRail
            // 
            this.dataGridViewRail.AllowUserToAddRows = false;
            this.dataGridViewRail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewRail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRail.Location = new System.Drawing.Point(185, 39);
            this.dataGridViewRail.Name = "dataGridViewRail";
            this.dataGridViewRail.Size = new System.Drawing.Size(436, 274);
            this.dataGridViewRail.TabIndex = 1;
            this.dataGridViewRail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewRail_CellClick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label2.Location = new System.Drawing.Point(91, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "                                 List of Rail";
            // 
            // linkLabeldetails
            // 
            this.linkLabeldetails.AutoSize = true;
            this.linkLabeldetails.Location = new System.Drawing.Point(253, 364);
            this.linkLabeldetails.Name = "linkLabeldetails";
            this.linkLabeldetails.Size = new System.Drawing.Size(119, 13);
            this.linkLabeldetails.TabIndex = 11;
            this.linkLabeldetails.TabStop = true;
            this.linkLabeldetails.Text = "Click here to see details";
            this.linkLabeldetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabeldetails_LinkClicked);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 412);
            this.Controls.Add(this.linkLabeldetails);
            this.Controls.Add(this.panelRaillist);
            this.Controls.Add(this.panelPassengerRequest);
            this.Controls.Add(this.panelmanagerlist);
            this.Controls.Add(this.panelpassengerlist);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.panelmanagerlist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManager)).EndInit();
            this.panelManagerRequest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManagerRequest)).EndInit();
            this.panelpassengerlist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassenger)).EndInit();
            this.panelPassengerRequest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassengerRequest)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelRaillist.ResumeLayout(false);
            this.panelRaillist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelmanagerlist;
        private System.Windows.Forms.Panel panelpassengerlist;
        private System.Windows.Forms.DataGridView dataGridViewManager;
        private System.Windows.Forms.DataGridView dataGridViewPassenger;
        private System.Windows.Forms.Button buttonPassenger;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passengerListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem railDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManagerRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PassengerRequestToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button buttonManager;
        private System.Windows.Forms.Panel panelManagerRequest;
        private System.Windows.Forms.Button buttonAccepted;
        private System.Windows.Forms.Button buttonRejected;
        private System.Windows.Forms.DataGridView dataGridViewManagerRequest;
        private System.Windows.Forms.Panel panelPassengerRequest;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonReject;
        private System.Windows.Forms.DataGridView dataGridViewPassengerRequest;
        private System.Windows.Forms.Label labelheading1;
        private System.Windows.Forms.Label labelheading2;
        private System.Windows.Forms.Label labelheading3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRaillist;
        private System.Windows.Forms.DataGridView dataGridViewRail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabeldetails;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddtrain;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}