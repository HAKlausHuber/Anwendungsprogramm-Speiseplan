using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anwendungsprogramm_Speiseplan.Formen
{
    public partial class frmNeuPlan : Form
    {
        public frmNeuPlan()
        {
            InitializeComponent();
        }

        #region Variablen
        DateTime Montag;
        DateTime Freitag;
        #endregion

        #region Methoden
        #endregion

        #region Code
        private void frmNeuPlan_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                if (dtpFreitag.Value.DayOfWeek == DayOfWeek.Friday)
                {

                    Freitag = dtpFreitag.Value;
                    dtpMontag.Value = dtpFreitag.Value;
                    dtpMontag.Value = dtpMontag.Value.Day - 5;
                    Montag = new DateTime(dtpFreitag.Value.Year, dtpFreitag.Value.Month, dtpFreitag.Value.Day - 5);

                    break;
                }
                dtpFreitag.Value = dtpFreitag.Value.AddDays(1);
            }
        }

        private void dtpMontag_ValueChanged(object sender, EventArgs e)
        {
            if(dtpMontag.Value.DayOfWeek == DayOfWeek.Monday)
            {
                Montag = dtpMontag.Value;
                dtpFreitag.Value = dtpMontag.Value.AddDays(5);
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie einen Montag aus!");
                dtpMontag.Value = Montag;
            }
        }

        private void dtpFreitag_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFreitag.Value.DayOfWeek == DayOfWeek.Friday)
            {
                Freitag = dtpFreitag.Value;
                dtpMontag.Value = dtpFreitag.Value.AddDays(5);
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie einen Freitag aus!");
                dtpMontag.Value = Freitag;
            }
        }

        private void btnBestaetigen_Click(object sender, EventArgs e)
        {

        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
