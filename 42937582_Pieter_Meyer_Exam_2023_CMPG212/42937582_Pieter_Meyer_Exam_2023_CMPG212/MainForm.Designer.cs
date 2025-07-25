
namespace _42937582_Pieter_Meyer_Exam_2023_CMPG212
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yourUpcomingEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upcomingEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hostEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEventsCreatedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membershipInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.lblSumery = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbDescSearch = new System.Windows.Forms.ComboBox();
            this.cbVenueSearch = new System.Windows.Forms.ComboBox();
            this.cbDateSearch = new System.Windows.Forms.ComboBox();
            this.cbNameSearch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegForEvent = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.cbId = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventsToolStripMenuItem,
            this.personalDetailsToolStripMenuItem,
            this.membershipInformationToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yourUpcomingEventsToolStripMenuItem,
            this.upcomingEventsToolStripMenuItem,
            this.eventHistoryToolStripMenuItem,
            this.hostEventsToolStripMenuItem});
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.eventsToolStripMenuItem.Text = "Events";
            // 
            // yourUpcomingEventsToolStripMenuItem
            // 
            this.yourUpcomingEventsToolStripMenuItem.Name = "yourUpcomingEventsToolStripMenuItem";
            this.yourUpcomingEventsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.yourUpcomingEventsToolStripMenuItem.Text = "Your Upcoming Events";
            this.yourUpcomingEventsToolStripMenuItem.Click += new System.EventHandler(this.yourUpcomingEventsToolStripMenuItem_Click);
            // 
            // upcomingEventsToolStripMenuItem
            // 
            this.upcomingEventsToolStripMenuItem.Name = "upcomingEventsToolStripMenuItem";
            this.upcomingEventsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.upcomingEventsToolStripMenuItem.Text = "Upcoming Events";
            this.upcomingEventsToolStripMenuItem.Click += new System.EventHandler(this.upcomingEventsToolStripMenuItem_Click);
            // 
            // eventHistoryToolStripMenuItem
            // 
            this.eventHistoryToolStripMenuItem.Name = "eventHistoryToolStripMenuItem";
            this.eventHistoryToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.eventHistoryToolStripMenuItem.Text = "Event History";
            this.eventHistoryToolStripMenuItem.Click += new System.EventHandler(this.eventHistoryToolStripMenuItem_Click);
            // 
            // hostEventsToolStripMenuItem
            // 
            this.hostEventsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createEventToolStripMenuItem,
            this.viewEventsCreatedToolStripMenuItem});
            this.hostEventsToolStripMenuItem.Enabled = false;
            this.hostEventsToolStripMenuItem.Name = "hostEventsToolStripMenuItem";
            this.hostEventsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.hostEventsToolStripMenuItem.Text = "Host Events";
            // 
            // createEventToolStripMenuItem
            // 
            this.createEventToolStripMenuItem.Name = "createEventToolStripMenuItem";
            this.createEventToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.createEventToolStripMenuItem.Text = "Create Event";
            this.createEventToolStripMenuItem.Click += new System.EventHandler(this.createEventToolStripMenuItem_Click);
            // 
            // viewEventsCreatedToolStripMenuItem
            // 
            this.viewEventsCreatedToolStripMenuItem.Name = "viewEventsCreatedToolStripMenuItem";
            this.viewEventsCreatedToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.viewEventsCreatedToolStripMenuItem.Text = "View Your Events Created";
            this.viewEventsCreatedToolStripMenuItem.Click += new System.EventHandler(this.viewEventsCreatedToolStripMenuItem_Click);
            // 
            // personalDetailsToolStripMenuItem
            // 
            this.personalDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewUpdateToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.personalDetailsToolStripMenuItem.Name = "personalDetailsToolStripMenuItem";
            this.personalDetailsToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.personalDetailsToolStripMenuItem.Text = "Personal Details";
            // 
            // viewUpdateToolStripMenuItem
            // 
            this.viewUpdateToolStripMenuItem.Name = "viewUpdateToolStripMenuItem";
            this.viewUpdateToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.viewUpdateToolStripMenuItem.Text = "View / Update";
            this.viewUpdateToolStripMenuItem.Click += new System.EventHandler(this.viewUpdateToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // membershipInformationToolStripMenuItem
            // 
            this.membershipInformationToolStripMenuItem.Name = "membershipInformationToolStripMenuItem";
            this.membershipInformationToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.membershipInformationToolStripMenuItem.Text = "Upgade to premuim";
            this.membershipInformationToolStripMenuItem.Click += new System.EventHandler(this.membershipInformationToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(326, 268);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.Size = new System.Drawing.Size(577, 276);
            this.dgvDisplay.TabIndex = 1;
            // 
            // lblSumery
            // 
            this.lblSumery.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSumery.AutoSize = true;
            this.lblSumery.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumery.Location = new System.Drawing.Point(450, 218);
            this.lblSumery.Name = "lblSumery";
            this.lblSumery.Size = new System.Drawing.Size(180, 25);
            this.lblSumery.TabIndex = 2;
            this.lblSumery.Text = "Upcoming Events";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Event Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date (dd/mm/yyyy):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Venue:";
            // 
            // gbSearch
            // 
            this.gbSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.cbDescSearch);
            this.gbSearch.Controls.Add(this.cbVenueSearch);
            this.gbSearch.Controls.Add(this.cbDateSearch);
            this.gbSearch.Controls.Add(this.cbNameSearch);
            this.gbSearch.Controls.Add(this.label4);
            this.gbSearch.Controls.Add(this.label1);
            this.gbSearch.Controls.Add(this.label3);
            this.gbSearch.Controls.Add(this.label2);
            this.gbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearch.Location = new System.Drawing.Point(12, 268);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(301, 276);
            this.gbSearch.TabIndex = 6;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search for event:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(81, 232);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(124, 38);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbDescSearch
            // 
            this.cbDescSearch.FormattingEnabled = true;
            this.cbDescSearch.Items.AddRange(new object[] {
            "Formal",
            "Informal",
            "Semi-formal"});
            this.cbDescSearch.Location = new System.Drawing.Point(97, 188);
            this.cbDescSearch.Name = "cbDescSearch";
            this.cbDescSearch.Size = new System.Drawing.Size(189, 28);
            this.cbDescSearch.TabIndex = 10;
            // 
            // cbVenueSearch
            // 
            this.cbVenueSearch.FormattingEnabled = true;
            this.cbVenueSearch.Items.AddRange(new object[] {
            "Crystal Gardens Convention Center - Capacity: 1000",
            "Starlight Ballroom - Capacity: 500",
            "Serenity Plaza - Capacity: 300",
            "Golden Pavilion - Capacity: 250",
            "Emerald Hall - Capacity: 200",
            "Moonbean Theater - Capacity: 150",
            "Harmony Lounge - Capacity: 100"});
            this.cbVenueSearch.Location = new System.Drawing.Point(97, 136);
            this.cbVenueSearch.Name = "cbVenueSearch";
            this.cbVenueSearch.Size = new System.Drawing.Size(189, 28);
            this.cbVenueSearch.TabIndex = 9;
            // 
            // cbDateSearch
            // 
            this.cbDateSearch.FormattingEnabled = true;
            this.cbDateSearch.Location = new System.Drawing.Point(137, 84);
            this.cbDateSearch.Name = "cbDateSearch";
            this.cbDateSearch.Size = new System.Drawing.Size(149, 28);
            this.cbDateSearch.TabIndex = 8;
            // 
            // cbNameSearch
            // 
            this.cbNameSearch.FormattingEnabled = true;
            this.cbNameSearch.Location = new System.Drawing.Point(97, 30);
            this.cbNameSearch.Name = "cbNameSearch";
            this.cbNameSearch.Size = new System.Drawing.Size(189, 28);
            this.cbNameSearch.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description:";
            // 
            // btnRegForEvent
            // 
            this.btnRegForEvent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegForEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegForEvent.Location = new System.Drawing.Point(688, 573);
            this.btnRegForEvent.Name = "btnRegForEvent";
            this.btnRegForEvent.Size = new System.Drawing.Size(152, 44);
            this.btnRegForEvent.TabIndex = 7;
            this.btnRegForEvent.Text = "Register for Event";
            this.btnRegForEvent.UseVisualStyleBackColor = true;
            this.btnRegForEvent.Click += new System.EventHandler(this.btnRegForEvent_Click);
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(158, 584);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(344, 20);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "Select id number of row you want to register for:";
            // 
            // cbId
            // 
            this.cbId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbId.FormattingEnabled = true;
            this.cbId.Location = new System.Drawing.Point(508, 582);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(112, 24);
            this.cbId.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_42937582_Pieter_Meyer_Exam_2023_CMPG212.Properties.Resources.EventConnect;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 650);
            this.Controls.Add(this.cbId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnRegForEvent);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.lblSumery);
            this.Controls.Add(this.dgvDisplay);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yourUpcomingEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upcomingEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hostEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membershipInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Label lblSumery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.ComboBox cbDescSearch;
        private System.Windows.Forms.ComboBox cbVenueSearch;
        private System.Windows.Forms.ComboBox cbDateSearch;
        private System.Windows.Forms.ComboBox cbNameSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegForEvent;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cbId;
        private System.Windows.Forms.ToolStripMenuItem createEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEventsCreatedToolStripMenuItem;
    }
}