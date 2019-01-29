namespace TreeGeneric.UI
{
    partial class FrmTreeTypes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteTree = new System.Windows.Forms.Button();
            this.btnEditTree = new System.Windows.Forms.Button();
            this.btnAddTree = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteTree);
            this.panel1.Controls.Add(this.btnEditTree);
            this.panel1.Controls.Add(this.btnAddTree);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 86);
            this.panel1.TabIndex = 0;
            // 
            // btnDeleteTree
            // 
            this.btnDeleteTree.Location = new System.Drawing.Point(597, 25);
            this.btnDeleteTree.Name = "btnDeleteTree";
            this.btnDeleteTree.Size = new System.Drawing.Size(118, 33);
            this.btnDeleteTree.TabIndex = 2;
            this.btnDeleteTree.Text = "Ağaç Tipi Sil";
            this.btnDeleteTree.UseVisualStyleBackColor = true;
            this.btnDeleteTree.Click += new System.EventHandler(this.btnDeleteTree_Click);
            // 
            // btnEditTree
            // 
            this.btnEditTree.Location = new System.Drawing.Point(323, 25);
            this.btnEditTree.Name = "btnEditTree";
            this.btnEditTree.Size = new System.Drawing.Size(118, 33);
            this.btnEditTree.TabIndex = 1;
            this.btnEditTree.Text = "Ağaç Tipi Düzenle";
            this.btnEditTree.UseVisualStyleBackColor = true;
            this.btnEditTree.Click += new System.EventHandler(this.btnEditTree_Click);
            // 
            // btnAddTree
            // 
            this.btnAddTree.Location = new System.Drawing.Point(28, 25);
            this.btnAddTree.Name = "btnAddTree";
            this.btnAddTree.Size = new System.Drawing.Size(118, 33);
            this.btnAddTree.TabIndex = 0;
            this.btnAddTree.Text = "Ağaç Tipi Ekle";
            this.btnAddTree.UseVisualStyleBackColor = true;
            this.btnAddTree.Click += new System.EventHandler(this.btnAddTree_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column3,
            this.Column7,
            this.Column8,
            this.Column6});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(845, 315);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Ağaç Adı";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TreePrice";
            this.Column4.HeaderText = "Ağaç Fiyatı";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "PlantingPrice";
            this.Column5.HeaderText = "Dikim Fiyatı";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "AvailabilityCount";
            this.Column3.HeaderText = "Stok Adeti";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "RegionName";
            this.Column7.HeaderText = "Ağaç Bölgesi";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "UnitPrice";
            this.Column8.HeaderText = "Birim Fiyat";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "IsActive";
            this.Column6.HeaderText = "Aktif Mi ?";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // FrmTreeTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 401);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FrmTreeTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ağaçlar";
            this.Load += new System.EventHandler(this.FrmTreeTypes_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteTree;
        private System.Windows.Forms.Button btnEditTree;
        private System.Windows.Forms.Button btnAddTree;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}