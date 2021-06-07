
namespace Anwendungsprogramm_Speiseplan.Formen
{
    partial class frmNeuPlan
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
            this.dtpMontag = new System.Windows.Forms.DateTimePicker();
            this.dtpFreitag = new System.Windows.Forms.DateTimePicker();
            this.lblVon = new System.Windows.Forms.Label();
            this.lblBis = new System.Windows.Forms.Label();
            this.btnBestaetigen = new System.Windows.Forms.Button();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpMontag
            // 
            this.dtpMontag.Location = new System.Drawing.Point(57, 71);
            this.dtpMontag.Name = "dtpMontag";
            this.dtpMontag.Size = new System.Drawing.Size(200, 20);
            this.dtpMontag.TabIndex = 0;
            this.dtpMontag.ValueChanged += new System.EventHandler(this.dtpMontag_ValueChanged);
            // 
            // dtpFreitag
            // 
            this.dtpFreitag.Location = new System.Drawing.Point(316, 71);
            this.dtpFreitag.Name = "dtpFreitag";
            this.dtpFreitag.Size = new System.Drawing.Size(200, 20);
            this.dtpFreitag.TabIndex = 0;
            this.dtpFreitag.ValueChanged += new System.EventHandler(this.dtpFreitag_ValueChanged);
            // 
            // lblVon
            // 
            this.lblVon.AutoSize = true;
            this.lblVon.Location = new System.Drawing.Point(54, 25);
            this.lblVon.Name = "lblVon";
            this.lblVon.Size = new System.Drawing.Size(29, 13);
            this.lblVon.TabIndex = 1;
            this.lblVon.Text = "Von:";
            // 
            // lblBis
            // 
            this.lblBis.AutoSize = true;
            this.lblBis.Location = new System.Drawing.Point(313, 25);
            this.lblBis.Name = "lblBis";
            this.lblBis.Size = new System.Drawing.Size(24, 13);
            this.lblBis.TabIndex = 2;
            this.lblBis.Text = "Bis:";
            // 
            // btnBestaetigen
            // 
            this.btnBestaetigen.Location = new System.Drawing.Point(88, 135);
            this.btnBestaetigen.Name = "btnBestaetigen";
            this.btnBestaetigen.Size = new System.Drawing.Size(108, 45);
            this.btnBestaetigen.TabIndex = 3;
            this.btnBestaetigen.Text = "Bestätigen";
            this.btnBestaetigen.UseVisualStyleBackColor = true;
            this.btnBestaetigen.Click += new System.EventHandler(this.btnBestaetigen_Click);
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Location = new System.Drawing.Point(347, 135);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(108, 45);
            this.btnAbbrechen.TabIndex = 3;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // frmNeuPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 206);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.btnBestaetigen);
            this.Controls.Add(this.lblBis);
            this.Controls.Add(this.lblVon);
            this.Controls.Add(this.dtpFreitag);
            this.Controls.Add(this.dtpMontag);
            this.Name = "frmNeuPlan";
            this.Text = "frmNeuPlan";
            this.Load += new System.EventHandler(this.frmNeuPlan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpMontag;
        private System.Windows.Forms.DateTimePicker dtpFreitag;
        private System.Windows.Forms.Label lblVon;
        private System.Windows.Forms.Label lblBis;
        private System.Windows.Forms.Button btnBestaetigen;
        private System.Windows.Forms.Button btnAbbrechen;
    }
}