
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblVon = new System.Windows.Forms.Label();
            this.lblBis = new System.Windows.Forms.Label();
            this.btnBestaetigen = new System.Windows.Forms.Button();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(57, 71);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(316, 71);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 0;
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
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Location = new System.Drawing.Point(347, 135);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(108, 45);
            this.btnAbbrechen.TabIndex = 3;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "frmNeuPlan";
            this.Text = "frmNeuPlan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblVon;
        private System.Windows.Forms.Label lblBis;
        private System.Windows.Forms.Button btnBestaetigen;
        private System.Windows.Forms.Button btnAbbrechen;
    }
}