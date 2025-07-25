
namespace _42937582_Pieter_Meyer_Exam_2023_CMPG212
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPremuimMember = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbCreatePasword = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbCellphoneNr = new System.Windows.Forms.TextBox();
            this.txbSurname = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblPremuimMember = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProviderRegister = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnUpdatClientInfo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRegister)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.cbPremuimMember);
            this.groupBox1.Controls.Add(this.cbGender);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txbCreatePasword);
            this.groupBox1.Controls.Add(this.txbEmail);
            this.groupBox1.Controls.Add(this.txbCellphoneNr);
            this.groupBox1.Controls.Add(this.txbSurname);
            this.groupBox1.Controls.Add(this.txbName);
            this.groupBox1.Controls.Add(this.lblPremuimMember);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(170, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 393);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Details";
            // 
            // cbPremuimMember
            // 
            this.cbPremuimMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPremuimMember.FormattingEnabled = true;
            this.cbPremuimMember.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbPremuimMember.Location = new System.Drawing.Point(356, 333);
            this.cbPremuimMember.Name = "cbPremuimMember";
            this.cbPremuimMember.Size = new System.Drawing.Size(121, 28);
            this.cbPremuimMember.TabIndex = 14;
            this.cbPremuimMember.SelectedIndexChanged += new System.EventHandler(this.cbPremuimMember_SelectedIndexChanged);
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(202, 237);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(139, 28);
            this.cbGender.TabIndex = 13;
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.cbGender_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Gender:";
            // 
            // txbCreatePasword
            // 
            this.txbCreatePasword.Location = new System.Drawing.Point(202, 284);
            this.txbCreatePasword.Name = "txbCreatePasword";
            this.txbCreatePasword.Size = new System.Drawing.Size(235, 26);
            this.txbCreatePasword.TabIndex = 10;
            this.txbCreatePasword.TextChanged += new System.EventHandler(this.txbCreatePasword_TextChanged);
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(202, 188);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(235, 26);
            this.txbEmail.TabIndex = 9;
            this.txbEmail.TextChanged += new System.EventHandler(this.txbEmail_TextChanged);
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
            // lblPremuimMember
            // 
            this.lblPremuimMember.AutoSize = true;
            this.lblPremuimMember.Location = new System.Drawing.Point(60, 336);
            this.lblPremuimMember.Name = "lblPremuimMember";
            this.lblPremuimMember.Size = new System.Drawing.Size(281, 20);
            this.lblPremuimMember.TabIndex = 5;
            this.lblPremuimMember.Text = "Do you want to be a premuim member:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(60, 287);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(133, 20);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Create password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
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
            // btnNewRegister
            // 
            this.btnNewRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRegister.Location = new System.Drawing.Point(170, 643);
            this.btnNewRegister.Name = "btnNewRegister";
            this.btnNewRegister.Size = new System.Drawing.Size(131, 44);
            this.btnNewRegister.TabIndex = 2;
            this.btnNewRegister.Text = "Register";
            this.btnNewRegister.UseVisualStyleBackColor = true;
            this.btnNewRegister.Click += new System.EventHandler(this.btnNewRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(560, 643);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 44);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProviderRegister
            // 
            this.errorProviderRegister.ContainerControl = this;
            // 
            // btnUpdatClientInfo
            // 
            this.btnUpdatClientInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdatClientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatClientInfo.Location = new System.Drawing.Point(361, 643);
            this.btnUpdatClientInfo.Name = "btnUpdatClientInfo";
            this.btnUpdatClientInfo.Size = new System.Drawing.Size(131, 44);
            this.btnUpdatClientInfo.TabIndex = 4;
            this.btnUpdatClientInfo.Text = "Update Info";
            this.btnUpdatClientInfo.UseVisualStyleBackColor = true;
            this.btnUpdatClientInfo.Click += new System.EventHandler(this.btnUpdatClientInfo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(706, 500);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 117);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Password rules when create:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(266, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "At least one special character eg !@#$%, NOT spaces";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "At least two numerical numbers";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "At least one lowercase letter";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "At least one uppercase letter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "At least 6 characters";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_42937582_Pieter_Meyer_Exam_2023_CMPG212.Properties.Resources.EventConnect;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 699);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnUpdatClientInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNewRegister);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "Register";
            this.Text = "Register";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRegister)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbCreatePasword;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbCellphoneNr;
        private System.Windows.Forms.TextBox txbSurname;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblPremuimMember;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPremuimMember;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNewRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProviderRegister;
        private System.Windows.Forms.Button btnUpdatClientInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}