using Autofac;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeGeneric.BussinessLogic;
using TreeGeneric.Data;

namespace Tree.UI
{
    public partial class FrmRegions : Form
    {
        private readonly IRegionService regionService;
        private readonly ILifetimeScope scope;
        public FrmRegions(ILifetimeScope scope)
        {
            InitializeComponent();
            this.scope = scope;
            this.regionService = scope.Resolve<IRegionService>();
        }

        private void FrmRegions_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        public void RefreshGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = regionService.GetAll();
        }

        private void btnAddRegion_Click(object sender, EventArgs e)
        {
            FrmRegion frmRegion = new FrmRegion(regionService, this, null);
            frmRegion.ShowDialog();
        }

        private void btnEditRegion_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                FrmRegion frmRegion = new FrmRegion(regionService,this, id);
                frmRegion.ShowDialog();
            }
            else
            {
                MessageBox.Show("Düzenlemek için bir kayıt ekleyin");
            }
        }
        private void btnDeleteRegion_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                regionService.Delete(id);
                MessageBox.Show("Kayıt Başarıyla Silindi");
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kaydı seçiniz!");
            }
        }
    }
}
