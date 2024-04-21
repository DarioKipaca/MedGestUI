using MedGestUI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedGestUI.Views
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            ControlFrmMain control = new ControlFrmMain(this,PanelConteiner);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
