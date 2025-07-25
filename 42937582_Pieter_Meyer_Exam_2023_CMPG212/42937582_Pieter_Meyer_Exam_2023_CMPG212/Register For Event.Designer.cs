
namespace _42937582_Pieter_Meyer_Exam_2023_CMPG212
{
    partial class Register_For_Event
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegisterForEvent = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbCellphoneNr = new System.Windows.Forms.TextBox();
            this.txbSurname = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderRegisterForEvent = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRegisterForEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(605, 539);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 44);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegisterForEvent
            // 
            this.btnRegisterForEvent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegisterForEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterForEvent.Location = new System.Drawing.Point(171, 539);
            this.btnRegisterForEvent.Name = "btnRegisterForEvent";
            this.btnRegisterForEvent.Size = new System.Drawing.Size(181, 44);
            this.btnRegisterForEvent.TabIndex = 5;
            this.btnRegisterForEvent.Text = "Register for Event";
            this.btnRegisterForEvent.UseVisualStyleBackColor = true;
            this.btnRegisterForEvent.Click += new System.EventHandler(this.btnRegisterForEvent_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.cbGender);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txbCellphoneNr);
            this.groupBox1.Controls.Add(this.txbSurname);
            this.groupBox1.Controls.Add(this.txbName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(157, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 277);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Details";
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(202, 194);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(139, 28);
            this.cbGender.TabIndex = 13;
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.cbGender_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Gender:";
            // 
            // txbCellphoneNr
            // 
            this.txbCellphoneNr.Location = new System.Drawing.Point(202, 141);
            this.txbCellphoneNr.Name = "txbCellphoneNr";
            this.txbCellphoneNr.Size = new System.Drawing.Size(235, 26);
            this.txbCellphoneNr.TabIndex = 8;
            this.txbCellphoneNr.TextChanged += new System.EventHandler(this.txbCellphoneNr_TextChanged);
            // 
            // txbSurname
            // 
            this.txbSurname.Location = new System.Drawing.Point(202, 91);
            this.txbSurname.Name = "txbSurname";
            this.txbSurname.Size = new System.Drawing.Size(235, 26);
            this.txbSurname.TabIndex = 7;
            this.txbSurname.TextChanged += new System.EventHandler(this.txbSurname_TextChanged);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(202, 43);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(235, 26);
            this.txbName.TabIndex = 6;
            this.txbName.TextChanged += new System.EventHandler(this.txbName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cellphone Nr:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // errorProviderRegisterForEvent
            // 
            this.errorProviderRegisterForEvent.ContainerControl = this;
            // 
            // Register_For_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_42937582_Pieter_Meyer_Exam_2023_CMPG212.Properties.Resources.EventConnect;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 671);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegisterForEvent);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "Register_For_Event";
            this.Text = "Register_For_Event";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Register_For_Event_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRegisterForEvent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegisterForEvent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbCellphoneNr;
        private System.Windows.Forms.TextBox txbSurname;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProviderRegisterForEvent;
    }
}