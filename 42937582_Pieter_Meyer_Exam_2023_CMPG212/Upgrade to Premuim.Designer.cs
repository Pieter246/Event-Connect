
namespace _42937582_Pieter_Meyer_Exam_2023_CMPG212
{
    partial class Upgrade_to_Premuim
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpgrade = new System.Windows.Forms.Button();
            this.gbUpgradePremuim = new System.Windows.Forms.GroupBox();
            this.radYes = new System.Windows.Forms.RadioButton();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gbUpgradePremuim.SuspendLayout();
            this.SuspendLayout();
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
            // btnUpgrade
            // 
            this.btnUpgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpgrade.Location = new System.Drawing.Point(60, 212);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(111, 40);
            this.btnUpgrade.TabIndex = 6;
            this.btnUpgrade.Text = "Upgrade";
            this.btnUpgrade.UseVisualStyleBackColor = true;
            this.btnUpgrade.Click += new System.EventHandler(this.btnUpgrade_Click);
            // 
            // gbUpgradePremuim
            // 
            this.gbUpgradePremuim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbUpgradePremuim.Controls.Add(this.label1);
            this.gbUpgradePremuim.Controls.Add(this.radNo);
            this.gbUpgradePremuim.Controls.Add(this.radYes);
            this.gbUpgradePremuim.Controls.Add(this.btnCancel);
            this.gbUpgradePremuim.Controls.Add(this.btnUpgrade);
            this.gbUpgradePremuim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUpgradePremuim.Location = new System.Drawing.Point(204, 224);
            this.gbUpgradePremuim.Name = "gbUpgradePremuim";
            this.gbUpgradePremuim.Size = new System.Drawing.Size(385, 271);
            this.gbUpgradePremuim.TabIndex = 1;
            this.gbUpgradePremuim.TabStop = false;
            this.gbUpgradePremuim.Text = "Upgrade to premuim:";
            // 
            // radYes
            // 
            this.radYes.AutoSize = true;
            this.radYes.Location = new System.Drawing.Point(85, 129);
            this.radYes.Name = "radYes";
            this.radYes.Size = new System.Drawing.Size(55, 24);
            this.radYes.TabIndex = 8;
            this.radYes.TabStop = true;
            this.radYes.Text = "Yes";
            this.radYes.UseVisualStyleBackColor = true;
            // 
            // radNo
            // 
            this.radNo.AutoSize = true;
            this.radNo.Location = new System.Drawing.Point(241, 129);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(47, 24);
            this.radNo.TabIndex = 9;
            this.radNo.TabStop = true;
            this.radNo.Text = "No";
            this.radNo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Do you want to be a premium member ?";
            // 
            // Upgrade_to_Premuim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_42937582_Pieter_Meyer_Exam_2023_CMPG212.Properties.Resources.EventConnect;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(851, 555);
            this.Controls.Add(this.gbUpgradePremuim);
            this.DoubleBuffered = true;
            this.Name = "Upgrade_to_Premuim";
            this.Text = "Upgrade_to_Premuim";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbUpgradePremuim.ResumeLayout(false);
            this.gbUpgradePremuim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpgrade;
        private System.Windows.Forms.GroupBox gbUpgradePremuim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radNo;
        private System.Windows.Forms.RadioButton radYes;
    }
}