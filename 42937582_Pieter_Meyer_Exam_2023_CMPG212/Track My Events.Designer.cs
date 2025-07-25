
namespace _42937582_Pieter_Meyer_Exam_2023_CMPG212
{
    partial class Track_My_Events
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
            this.cbIdTrackEvents = new System.Windows.Forms.ComboBox();
            this.lblIdHostingEvents = new System.Windows.Forms.Label();
            this.btnUpdateEvent = new System.Windows.Forms.Button();
            this.lblTrackEvents = new System.Windows.Forms.Label();
            this.dgvDisplayHostingEvents = new System.Windows.Forms.DataGridView();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnViewParticipants = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayHostingEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // cbIdTrackEvents
            // 
            this.cbIdTrackEvents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbIdTrackEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdTrackEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIdTrackEvents.FormattingEnabled = true;
            this.cbIdTrackEvents.Location = new System.Drawing.Point(370, 588);
            this.cbIdTrackEvents.Name = "cbIdTrackEvents";
            this.cbIdTrackEvents.Size = new System.Drawing.Size(96, 24);
            this.cbIdTrackEvents.TabIndex = 14;
            // 
            // lblIdHostingEvents
            // 
            this.lblIdHostingEvents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdHostingEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdHostingEvents.Location = new System.Drawing.Point(85, 581);
            this.lblIdHostingEvents.Name = "lblIdHostingEvents";
            this.lblIdHostingEvents.Size = new System.Drawing.Size(279, 40);
            this.lblIdHostingEvents.TabIndex = 13;
            this.lblIdHostingEvents.Text = "Select id number of row you want Update / Delete or View Participants:";
            // 
            // btnUpdateEvent
            // 
            this.btnUpdateEvent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEvent.Location = new System.Drawing.Point(472, 577);
            this.btnUpdateEvent.Name = "btnUpdateEvent";
            this.btnUpdateEvent.Size = new System.Drawing.Size(126, 44);
            this.btnUpdateEvent.TabIndex = 12;
            this.btnUpdateEvent.Text = "Update Event";
            this.btnUpdateEvent.UseVisualStyleBackColor = true;
            this.btnUpdateEvent.Click += new System.EventHandler(this.btnUpdateEvent_Click);
            // 
            // lblTrackEvents
            // 
            this.lblTrackEvents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTrackEvents.AutoSize = true;
            this.lblTrackEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackEvents.Location = new System.Drawing.Point(397, 225);
            this.lblTrackEvents.Name = "lblTrackEvents";
            this.lblTrackEvents.Size = new System.Drawing.Size(281, 25);
            this.lblTrackEvents.TabIndex = 11;
            this.lblTrackEvents.Text = "Viewing your hosting events";
            // 
            // dgvDisplayHostingEvents
            // 
            this.dgvDisplayHostingEvents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDisplayHostingEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayHostingEvents.Location = new System.Drawing.Point(74, 278);
            this.dgvDisplayHostingEvents.Name = "dgvDisplayHostingEvents";
            this.dgvDisplayHostingEvents.Size = new System.Drawing.Size(947, 276);
            this.dgvDisplayHostingEvents.TabIndex = 10;
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEvent.Location = new System.Drawing.Point(620, 577);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(126, 44);
            this.btnDeleteEvent.TabIndex = 15;
            this.btnDeleteEvent.Text = "Delete Event";
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(913, 577);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 44);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnViewParticipants
            // 
            this.btnViewParticipants.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewParticipants.Location = new System.Drawing.Point(766, 577);
            this.btnViewParticipants.Name = "btnViewParticipants";
            this.btnViewParticipants.Size = new System.Drawing.Size(126, 44);
            this.btnViewParticipants.TabIndex = 17;
            this.btnViewParticipants.Text = "View Participants";
            this.btnViewParticipants.UseVisualStyleBackColor = true;
            this.btnViewParticipants.Click += new System.EventHandler(this.btnViewParticipants_Click);
            // 
            // Track_My_Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_42937582_Pieter_Meyer_Exam_2023_CMPG212.Properties.Resources.EventConnect;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1102, 648);
            this.Controls.Add(this.btnViewParticipants);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteEvent);
            this.Controls.Add(this.cbIdTrackEvents);
            this.Controls.Add(this.lblIdHostingEvents);
            this.Controls.Add(this.btnUpdateEvent);
            this.Controls.Add(this.lblTrackEvents);
            this.Controls.Add(this.dgvDisplayHostingEvents);
            this.DoubleBuffered = true;
            this.Name = "Track_My_Events";
            this.Text = "Track_My_Events";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Track_My_Events_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayHostingEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbIdTrackEvents;
        private System.Windows.Forms.Label lblIdHostingEvents;
        private System.Windows.Forms.Button btnUpdateEvent;
        private System.Windows.Forms.Label lblTrackEvents;
        private System.Windows.Forms.DataGridView dgvDisplayHostingEvents;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnViewParticipants;
    }
}