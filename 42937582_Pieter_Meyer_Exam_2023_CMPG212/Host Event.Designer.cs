
namespace _42937582_Pieter_Meyer_Exam_2023_CMPG212
{
    partial class Host_Event
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCost = new System.Windows.Forms.ComboBox();
            this.cbVenue = new System.Windows.Forms.ComboBox();
            this.txbTime = new System.Windows.Forms.TextBox();
            this.txbDate = new System.Windows.Forms.TextBox();
            this.cbDescription = new System.Windows.Forms.ComboBox();
            this.txbEventName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreatEvent = new System.Windows.Forms.Button();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.errorProviderHostEvent = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnUpdateEvent2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHostEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.cbCost);
            this.groupBox1.Controls.Add(this.cbVenue);
            this.groupBox1.Controls.Add(this.txbTime);
            this.groupBox1.Controls.Add(this.txbDate);
            this.groupBox1.Controls.Add(this.cbDescription);
            this.groupBox1.Controls.Add(this.txbEventName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(159, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Host Event:";
            // 
            // cbCost
            // 
            this.cbCost.FormattingEnabled = true;
            this.cbCost.Items.AddRange(new object[] {
            "Free"});
            this.cbCost.Location = new System.Drawing.Point(388, 268);
            this.cbCost.Name = "cbCost";
            this.cbCost.Size = new System.Drawing.Size(145, 28);
            this.cbCost.TabIndex = 11;
            this.cbCost.SelectedIndexChanged += new System.EventHandler(this.cbCost_SelectedIndexChanged);
            // 
            // cbVenue
            // 
            this.cbVenue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVenue.FormattingEnabled = true;
            this.cbVenue.Items.AddRange(new object[] {
            "Crystal Gardens Convention Center - Capacity: 1000",
            "Starlight Ballroom - Capacity: 500",
            "Serenity Plaza - Capacity: 300",
            "Golden Pavilion - Capacity: 250",
            "Emerald Hall - Capacity: 200",
            "Moonbean Theater - Capacity: 150",
            "Harmony Lounge - Capacity: 100"});
            this.cbVenue.Location = new System.Drawing.Point(136, 218);
            this.cbVenue.Name = "cbVenue";
            this.cbVenue.Size = new System.Drawing.Size(387, 28);
            this.cbVenue.TabIndex = 10;
            this.cbVenue.SelectedIndexChanged += new System.EventHandler(this.cbVenue_SelectedIndexChanged);
            // 
            // txbTime
            // 
            this.txbTime.Location = new System.Drawing.Point(128, 172);
            this.txbTime.Name = "txbTime";
            this.txbTime.Size = new System.Drawing.Size(168, 26);
            this.txbTime.TabIndex = 9;
            this.txbTime.TextChanged += new System.EventHandler(this.txbTime_TextChanged);
            // 
            // txbDate
            // 
            this.txbDate.Location = new System.Drawing.Point(212, 123);
            this.txbDate.Name = "txbDate";
            this.txbDate.Size = new System.Drawing.Size(168, 26);
            this.txbDate.TabIndex = 8;
            this.txbDate.TextChanged += new System.EventHandler(this.txbDate_TextChanged);
            // 
            // cbDescription
            // 
            this.cbDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDescription.FormattingEnabled = true;
            this.cbDescription.Items.AddRange(new object[] {
            "Formal",
            "Informal",
            "Semi-formal"});
            this.cbDescription.Location = new System.Drawing.Point(135, 76);
            this.cbDescription.Name = "cbDescription";
            this.cbDescription.Size = new System.Drawing.Size(154, 28);
            this.cbDescription.TabIndex = 7;
            this.cbDescription.SelectedIndexChanged += new System.EventHandler(this.cbDescription_SelectedIndexChanged);
            // 
            // txbEventName
            // 
            this.txbEventName.Location = new System.Drawing.Point(135, 35);
            this.txbEventName.Name = "txbEventName";
            this.txbEventName.Size = new System.Drawing.Size(197, 26);
            this.txbEventName.TabIndex = 6;
            this.txbEventName.TextChanged += new System.EventHandler(this.txbEventName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(351, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cost (Type R and then amount (R 100.00) or choose Free):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Choose Venue:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time (hh:mm):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of Event (yyyy/mm/dd):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of Event:";
            // 
            // btnCreatEvent
            // 
            this.btnCreatEvent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreatEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatEvent.Location = new System.Drawing.Point(159, 543);
            this.btnCreatEvent.Name = "btnCreatEvent";
            this.btnCreatEvent.Size = new System.Drawing.Size(151, 47);
            this.btnCreatEvent.TabIndex = 1;
            this.btnCreatEvent.Text = "Creat Event";
            this.btnCreatEvent.UseVisualStyleBackColor = true;
            this.btnCreatEvent.Click += new System.EventHandler(this.btnCreatEvent_Click);
            // 
            // btnCancel2
            // 
            this.btnCancel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel2.Location = new System.Drawing.Point(554, 543);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(151, 47);
            this.btnCancel2.TabIndex = 2;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // errorProviderHostEvent
            // 
            this.errorProviderHostEvent.ContainerControl = this;
            // 
            // btnUpdateEvent2
            // 
            this.btnUpdateEvent2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateEvent2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEvent2.Location = new System.Drawing.Point(356, 543);
            this.btnUpdateEvent2.Name = "btnUpdateEvent2";
            this.btnUpdateEvent2.Size = new System.Drawing.Size(154, 47);
            this.btnUpdateEvent2.TabIndex = 3;
            this.btnUpdateEvent2.Text = "Update Event";
            this.btnUpdateEvent2.UseVisualStyleBackColor = true;
            this.btnUpdateEvent2.Click += new System.EventHandler(this.btnUpdateEvent2_Click);
            // 
            // Host_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_42937582_Pieter_Meyer_Exam_2023_CMPG212.Properties.Resources.EventConnect;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 602);
            this.Controls.Add(this.btnUpdateEvent2);
            this.Controls.Add(this.btnCancel2);
            this.Controls.Add(this.btnCreatEvent);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "Host_Event";
            this.Text = "Host_Event";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHostEvent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCost;
        private System.Windows.Forms.ComboBox cbVenue;
        private System.Windows.Forms.TextBox txbTime;
        private System.Windows.Forms.TextBox txbDate;
        private System.Windows.Forms.ComboBox cbDescription;
        private System.Windows.Forms.TextBox txbEventName;
        private System.Windows.Forms.Button btnCreatEvent;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.ErrorProvider errorProviderHostEvent;
        private System.Windows.Forms.Button btnUpdateEvent2;
    }
}