namespace TreeGeneric.UI
{
    partial class FrmTreeType
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
            this.cbTreeRegion = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCommission = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbPassive = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPlantingPrice = new System.Windows.Forms.TextBox();
            this.txtTreePrice = new System.Windows.Forms.TextBox();
            this.txtAvailabilityCount = new System.Windows.Forms.TextBox();
            this.txtPicture = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTreeRegion
            // 
            this.cbTreeRegion.FormattingEnabled = true;
            this.cbTreeRegion.Location = new System.Drawing.Point(380, 135);
            this.cbTreeRegion.Name = "cbTreeRegion";
            this.cbTreeRegion.Size = new System.Drawing.Size(187, 22);
            this.cbTreeRegion.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(296, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 14);
            this.label9.TabIndex = 50;
            this.label9.Text = "Ağaç Bölgesi :";
            // 
            // txtCommission
            // 
            this.txtCommission.Location = new System.Drawing.Point(380, 93);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.Size = new System.Drawing.Size(187, 22);
            this.txtCommission.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 14);
            this.label8.TabIndex = 48;
            this.label8.Text = "Komisyon Tutarı :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbPassive);
            this.groupBox2.Controls.Add(this.rbActive);
            this.groupBox2.Location = new System.Drawing.Point(380, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 56);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            // 
            // rbPassive
            // 
            this.rbPassive.AutoSize = true;
            this.rbPassive.Location = new System.Drawing.Point(124, 19);
            this.rbPassive.Name = "rbPassive";
            this.rbPassive.Size = new System.Drawing.Size(50, 18);
            this.rbPassive.TabIndex = 1;
            this.rbPassive.TabStop = true;
            this.rbPassive.Text = "Pasif";
            this.rbPassive.UseVisualStyleBackColor = true;
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(7, 20);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(50, 18);
            this.rbActive.TabIndex = 0;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Aktif";
            this.rbActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(201, 255);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(178, 35);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "KAYDET";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPlantingPrice
            // 
            this.txtPlantingPrice.Location = new System.Drawing.Point(380, 51);
            this.txtPlantingPrice.Name = "txtPlantingPrice";
            this.txtPlantingPrice.Size = new System.Drawing.Size(187, 22);
            this.txtPlantingPrice.TabIndex = 45;
            // 
            // txtTreePrice
            // 
            this.txtTreePrice.Location = new System.Drawing.Point(380, 12);
            this.txtTreePrice.Name = "txtTreePrice";
            this.txtTreePrice.Size = new System.Drawing.Size(187, 22);
            this.txtTreePrice.TabIndex = 44;
            // 
            // txtAvailabilityCount
            // 
            this.txtAvailabilityCount.Location = new System.Drawing.Point(78, 208);
            this.txtAvailabilityCount.Name = "txtAvailabilityCount";
            this.txtAvailabilityCount.Size = new System.Drawing.Size(187, 22);
            this.txtAvailabilityCount.TabIndex = 43;
            // 
            // txtPicture
            // 
            this.txtPicture.Location = new System.Drawing.Point(78, 172);
            this.txtPicture.Name = "txtPicture";
            this.txtPicture.Size = new System.Drawing.Size(187, 22);
            this.txtPicture.TabIndex = 42;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(78, 56);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(187, 102);
            this.txtDescription.TabIndex = 41;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(78, 11);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 22);
            this.txtName.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(316, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 14);
            this.label10.TabIndex = 39;
            this.label10.Text = "Aktif mi ? ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(296, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 14);
            this.label11.TabIndex = 38;
            this.label11.Text = "Dikim Ücreti :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(307, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 14);
            this.label12.TabIndex = 37;
            this.label12.Text = "Ağaç Fiyatı :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 175);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 14);
            this.label14.TabIndex = 35;
            this.label14.Text = "Fotoğraf :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(44, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 14);
            this.label16.TabIndex = 33;
            this.label16.Text = "Ad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 14);
            this.label1.TabIndex = 52;
            this.label1.Text = "Açıklama :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 53;
            this.label2.Text = "Ağaç Adeti :";
            // 
            // FrmTreeType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 306);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTreeRegion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCommission);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPlantingPrice);
            this.Controls.Add(this.txtTreePrice);
            this.Controls.Add(this.txtAvailabilityCount);
            this.Controls.Add(this.txtPicture);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.Name = "FrmTreeType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ağaç Ekle/Düzenle";
            this.Load += new System.EventHandler(this.FrmTreeType_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbTreeRegion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCommission;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbPassive;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPlantingPrice;
        private System.Windows.Forms.TextBox txtTreePrice;
        private System.Windows.Forms.TextBox txtAvailabilityCount;
        private System.Windows.Forms.TextBox txtPicture;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}