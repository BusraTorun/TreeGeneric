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
using TreeGeneric.UI;

namespace Tree.UI
{
    public partial class FrmMain : Form
    {
        private readonly ILifetimeScope scope;
        public FrmMain(ILifetimeScope scope)
        {
            InitializeComponent();
            this.scope = scope;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            pnlHome.Visible = true;
            pnlDonate.Visible = false;
            pnlAccount.Visible = false;
            pnlPlant.Visible = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            pnlHome.Visible = false;
            pnlDonate.Visible = true;
            pnlAccount.Visible = false;
            pnlPlant.Visible = false;

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            pnlHome.Visible = false;
            pnlDonate.Visible = false;
            pnlAccount.Visible = false;
            pnlPlant.Visible = true;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            pnlHome.Visible = false;
            pnlDonate.Visible = false;
            pnlAccount.Visible = true;
            pnlPlant.Visible = false;

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            pnlHome.Visible = true;
            pnlDonate.Visible = false;
            pnlAccount.Visible = false;
            pnlPlant.Visible = false;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bölgelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmRegions(scope);
            frm.ShowDialog();
        }

        private void ağaçTipleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmTreeTypes = new FrmTreeTypes(scope);
            frmTreeTypes.ShowDialog();
        }
    }
}
