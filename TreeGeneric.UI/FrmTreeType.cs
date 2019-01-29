using System;
using System.Windows.Forms;
using Autofac;
using TreeGeneric.BussinessLogic;
using TreeGeneric.Model;

namespace TreeGeneric.UI
{
    public partial class FrmTreeType : Form
    {
        private ITreeTypeService treeTypeService;
        private FrmTreeTypes frmTreeTypes;
        private int? selectedId;
        private readonly IRegionService regionService;


        public FrmTreeType(ITreeTypeService treeTypeService, FrmTreeTypes frmTreeTypes,int? id,ILifetimeScope scope)
        {
            InitializeComponent();
            this.treeTypeService = treeTypeService;
            this.frmTreeTypes = frmTreeTypes;
            selectedId = id;
            regionService = scope.Resolve<IRegionService>();
        }

        private void FrmTreeType_Load(object sender, EventArgs e)
        {
            if (selectedId!=null)
            {
                var treeType = treeTypeService.Find(f => f.Id == selectedId);
                txtName.Text = treeType.Name;
                txtDescription.Text = treeType.Description;
                txtPicture.Text = treeType.Photo;
                txtAvailabilityCount.Text = treeType.AvailabilityCount.ToString();
                txtTreePrice.Text = treeType.TreePrice.ToString();
                txtPlantingPrice.Text = treeType.PlantingPrice.ToString();
                txtCommission.Text = treeType.Commision.ToString();


                int regionId = treeType.RegionId;
                var region = regionService.Find(regionId);


                cbTreeRegion.DataSource = regionService.GetAll();
                cbTreeRegion.ValueMember = "Id";
                cbTreeRegion.DisplayMember = "Name";
                cbTreeRegion.SelectedIndex = cbTreeRegion.FindString(region.Name);

                if (treeType.IsActive)
                {
                    rbActive.Checked = true;
                }
                else
                {
                    rbPassive.Checked = true;
                }
            }
            
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedId == null)
            {
                AddTreeType();
            }
            else
            {
                UpdateTreeType();
            }
        }

        private void AddTreeType()
        {
            var treeType = new TreeType();
            treeType.Name = txtName.Text;
            treeType.Description = txtDescription.Text;
            treeType.Photo = txtPicture.Text;
            treeType.AvailabilityCount = int.Parse(txtAvailabilityCount.Text);
            treeType.TreePrice = decimal.Parse(txtTreePrice.Text);
            treeType.PlantingPrice = decimal.Parse(txtPlantingPrice.Text);
            treeType.Commision = decimal.Parse(txtCommission.Text);


            treeType.RegionId = int.Parse(cbTreeRegion.SelectedValue.ToString());

            if (rbActive.Checked)
            {
                treeType.IsActive = true;
            }
            else if (rbPassive.Checked)
            {
                treeType.IsActive = false;
            }

            treeTypeService.Insert(treeType);
            this.Close();
            frmTreeTypes.RefreshGrid();


        }

        private void UpdateTreeType()
        {
                var treeType = treeTypeService.Find(t => t.Id == selectedId);
                treeType.Name = txtName.Text;
                treeType.Description = txtDescription.Text;
                treeType.Photo = txtPicture.Text;
                treeType.AvailabilityCount = int.Parse(txtAvailabilityCount.Text);
                treeType.TreePrice = decimal.Parse(txtTreePrice.Text);
                treeType.PlantingPrice = decimal.Parse(txtPlantingPrice.Text);
                treeType.Commision = decimal.Parse(txtCommission.Text);


                treeType.RegionId = int.Parse(cbTreeRegion.SelectedValue.ToString());



                if (rbActive.Checked)
                {
                    treeType.IsActive = true;
                }
                else if (rbPassive.Checked)
                {
                    treeType.IsActive = false;
                }

                treeTypeService.Update(treeType);
                this.Close();
                frmTreeTypes.RefreshGrid();
       
        }



    }
}
