using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moradi_Remote_Desktop
{
    public partial class updater : MetroFramework.Forms.MetroForm
    {
        public updater()
        {
            InitializeComponent();
        }

        private void updater_Load(object sender, EventArgs e)
        {

        }

        private void CurVer_Tick(object sender, EventArgs e)
        {
            label2.Text = "Current Version: " + ProductVersion.ToString();
        }

        private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
