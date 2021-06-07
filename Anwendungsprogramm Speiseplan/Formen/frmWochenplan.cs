using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anwendungsprogramm_Speiseplan
{
    public partial class Wochenplan : Form
    {
        public Wochenplan()
        {
            InitializeComponent();
        }

        #region Variablen        
        #endregion

        #region Methoden
        #endregion

        #region Code
        private void Wochenplan_Load(object sender, EventArgs e)
        {
            MessageBox.Show(new System.DateTime(1996, 1, 3).ToString());
        }

        #endregion

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
