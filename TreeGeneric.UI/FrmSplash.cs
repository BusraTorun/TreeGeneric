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

namespace Tree.UI
{
    public partial class FrmSplash : Form
    {
        private readonly ILifetimeScope scope;
        public FrmSplash(ILifetimeScope scope) 
        {
            InitializeComponent();
            this.scope = scope;            
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain(scope);
            frm.Show();
            this.Hide();
            timer1.Stop();
        }
    }
}
