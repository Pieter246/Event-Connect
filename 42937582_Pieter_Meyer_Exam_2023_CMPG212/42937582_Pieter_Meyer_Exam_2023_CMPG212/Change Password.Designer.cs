
namespace _42937582_Pieter_Meyer_Exam_2023_CMPG212
{
    partial class Change_Password
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
            this.gbChangePassword = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.txbConfirmPassword = new System.Windows.Forms.TextBox();
            this.txbNewPassword = new System.Windows.Forms.TextBox();
            this.txbCurrentPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderChangePassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbChangePassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderChangePassword)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbChangePassword
            // 
            this.gbChangePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbChangePassword.Controls.Add(this.btnCancel);
            this.gbChangePassword.Controls.Add(this.btnChange);
            this.gbChangePassword.Controls.Add(this.txbConfirmPassword);
            this.gbChangePassword.Controls.Add(this.txbNewPassword);
            this.gbChangePassword.Controls.Add(this.txbCurrentPassword);
            this.gbChangePassword.Controls.Add(this.label3);
            this.gbChangePassword.Controls.Add(this.label2);
            this.gbChangePassword.Controls.Add(this.label1);
            this.gbChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChangePassword.Location = new System.Drawing.Point(227, 224);
            this.gbChangePassword.Name = "gbChangePassword";
            this.gbChangePassword.Size = new System.Drawing.Size(385, 271);
            this.gbChangePassword.TabIndex = 0;
            this.gbChangePassword.TabStop = false;
            this.gbChangePassword.Text = "Change Password:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(214, 212);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(60, 212);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(111, 40);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txbConfirmPassword
            // 
            this.txbConfirmPassword.Location = new System.Drawing.Point(171, 152);
            this.txbConfirmPassword.Name = "txbConfirmPassword";
            this.txbConfirmPassword.Size = new System.Drawing.Size(187, 26);
            this.txbConfirmPassword.TabIndex = 5;
            this.txbConfirmPassword.TextChanged += new System.EventHandler(this.txbConfirmPassword_TextChanged);
            // 
            // txbNewPassword
            // 
            this.txbNewPassword.Location = new System.Drawing.Point(171, 105);
            this.txbNewPassword.Name = "txbNewPassword";
            this.txbNewPassword.Size = new System.Drawing.Size(187, 26);
            this.txbNewPassword.TabIndex = 4;
            this.txbNewPassword.TextChanged += new System.EventHandler(this.txbNewPassword_TextChanged);
            // 
            // txbCurrentPassword
            // 
            this.txbCurrentPassword.Location = new System.Drawing.Point(171, 56);
            this.txbCurrentPassword.Name = "txbCurrentPassword";
            this.txbCurrentPassword.Size = new System.Drawing.Size(187, 26);
            this.txbCurrentPassword.TabIndex = 3;
            this.txbCurrentPassword.TextChanged += new System.EventHandler(this.txbCurrentPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Password:";
            // 
            // errorProviderChangePassword
            // 
            this.errorProviderChangePassword.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(634, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 117);
            this.groupBox2.TabIndex = 6;
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
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_42937582_Pieter_Meyer_Exam_2023_CMPG212.Properties.Resources.EventConnect;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1011, 569);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbChangePassword);
            this.DoubleBuffered = true;
            this.Name = "Change_Password";
            this.Text = "Change_Password";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbChangePassword.ResumeLayout(false);
            this.gbChangePassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderChangePassword)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbChangePassword;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txbConfirmPassword;
        private System.Windows.Forms.TextBox txbNewPassword;
        private System.Windows.Forms.TextBox txbCurrentPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProviderChangePassword;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}