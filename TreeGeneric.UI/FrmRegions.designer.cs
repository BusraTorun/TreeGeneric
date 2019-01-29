namespace Tree.UI
{
    partial class FrmRegions
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteRegion = new System.Windows.Forms.Button();
            this.btnEditRegion = new System.Windows.Forms.Button();
            this.btnAddRegion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2,
            this.Column4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(660, 317);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Id";
            this.Column3.HeaderText = "Id";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "Bölge Adı";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Capacity";
            this.Column2.HeaderText = "Kapasite";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "IsActive";
            this.Column4.HeaderText = "Aktif Mi?";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteRegion);
            this.panel1.Controls.Add(this.btnEditRegion);
            this.panel1.Controls.Add(this.btnAddRegion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 85);
            this.panel1.TabIndex = 1;
            // 
            // btnDeleteRegion
            // 
            this.btnDeleteRegion.Location = new System.Drawing.Point(502, 31);
            this.btnDeleteRegion.Name = "btnDeleteRegion";
            this.btnDeleteRegion.Size = new System.Drawing.Size(102, 27);
            this.btnDeleteRegion.TabIndex = 2;
            this.btnDeleteRegion.Text = "Bölge Sil";
            this.btnDeleteRegion.UseVisualStyleBackColor = true;
            this.btnDeleteRegion.Click += new System.EventHandler(this.btnDeleteRegion_Click);
            // 
            // btnEditRegion
            // 
            this.btnEditRegion.Location = new System.Drawing.Point(276, 31);
            this.btnEditRegion.Name = "btnEditRegion";
            this.btnEditRegion.Size = new System.Drawing.Size(102, 27);
            this.btnEditRegion.TabIndex = 1;
            this.btnEditRegion.Text = "Bölge Düzenle";
            this.btnEditRegion.UseVisualStyleBackColor = true;
            this.btnEditRegion.Click += new System.EventHandler(this.btnEditRegion_Click);
            // 
            // btnAddRegion
            // 
            this.btnAddRegion.Location = new System.Drawing.Point(58, 31);
            this.btnAddRegion.Name = "btnAddRegion";
            this.btnAddRegion.Size = new System.Drawing.Size(87, 27);
            this.btnAddRegion.TabIndex = 0;
            this.btnAddRegion.Text = "Bölge Ekle";
            this.btnAddRegion.UseVisualStyleBackColor = true;
            this.btnAddRegion.Click += new System.EventHandler(this.btnAddRegion_Click);
            // 
            // FrmRegions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 402);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FrmRegions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bölgeler";
            this.Load += new System.EventHandler(this.FrmRegions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteRegion;
        private System.Windows.Forms.Button btnEditRegion;
        private System.Windows.Forms.Button btnAddRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}