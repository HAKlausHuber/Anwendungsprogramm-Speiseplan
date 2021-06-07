namespace Anwendungsprogramm_Speiseplan.Properties
{
    partial class SpeisenZutaten
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
            this.components = new System.ComponentModel.Container();
            this.lvSpeise = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvAllergen = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.speiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zutatenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hinzufügenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lvZutat = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsSpeise = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsZutat = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsAllergen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAlles = new System.Windows.Forms.Button();
            this.btnBewerten = new System.Windows.Forms.Button();
            this.allergeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hinzufügenToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.hinzufügenToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.hinzufügenToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.hinzufügenToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.zutatZuSpeiseHinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allergeneVonSpeiseAnpassenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.cmsSpeise.SuspendLayout();
            this.cmsZutat.SuspendLayout();
            this.cmsAllergen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvSpeise
            // 
            this.lvSpeise.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvSpeise.ContextMenuStrip = this.cmsSpeise;
            this.lvSpeise.HideSelection = false;
            this.lvSpeise.Location = new System.Drawing.Point(62, 105);
            this.lvSpeise.Name = "lvSpeise";
            this.lvSpeise.Size = new System.Drawing.Size(327, 313);
            this.lvSpeise.TabIndex = 0;
            this.lvSpeise.UseCompatibleStateImageBehavior = false;
            this.lvSpeise.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Bild";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Bezeichnung";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Gang";
            // 
            // lvAllergen
            // 
            this.lvAllergen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvAllergen.ContextMenuStrip = this.cmsAllergen;
            this.lvAllergen.HideSelection = false;
            this.lvAllergen.Location = new System.Drawing.Point(436, 286);
            this.lvAllergen.Name = "lvAllergen";
            this.lvAllergen.Size = new System.Drawing.Size(322, 132);
            this.lvAllergen.TabIndex = 1;
            this.lvAllergen.UseCompatibleStateImageBehavior = false;
            this.lvAllergen.View = System.Windows.Forms.View.Details;
            this.lvAllergen.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Bezeichnung";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speiseToolStripMenuItem,
            this.zutatenToolStripMenuItem,
            this.allergeneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // speiseToolStripMenuItem
            // 
            this.speiseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hinzufügenToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.löschenToolStripMenuItem});
            this.speiseToolStripMenuItem.Name = "speiseToolStripMenuItem";
            this.speiseToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.speiseToolStripMenuItem.Text = "Speisen";
            // 
            // hinzufügenToolStripMenuItem
            // 
            this.hinzufügenToolStripMenuItem.Name = "hinzufügenToolStripMenuItem";
            this.hinzufügenToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.hinzufügenToolStripMenuItem.Text = "Hinzufügen";
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.löschenToolStripMenuItem.Text = "Löschen";
            // 
            // zutatenToolStripMenuItem
            // 
            this.zutatenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hinzufügenToolStripMenuItem1,
            this.bearbeitenToolStripMenuItem1,
            this.löschenToolStripMenuItem1});
            this.zutatenToolStripMenuItem.Name = "zutatenToolStripMenuItem";
            this.zutatenToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.zutatenToolStripMenuItem.Text = "Zutaten";
            // 
            // hinzufügenToolStripMenuItem1
            // 
            this.hinzufügenToolStripMenuItem1.Name = "hinzufügenToolStripMenuItem1";
            this.hinzufügenToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.hinzufügenToolStripMenuItem1.Text = "Hinzufügen";
            // 
            // bearbeitenToolStripMenuItem1
            // 
            this.bearbeitenToolStripMenuItem1.Name = "bearbeitenToolStripMenuItem1";
            this.bearbeitenToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.bearbeitenToolStripMenuItem1.Text = "Bearbeiten";
            // 
            // löschenToolStripMenuItem1
            // 
            this.löschenToolStripMenuItem1.Name = "löschenToolStripMenuItem1";
            this.löschenToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.löschenToolStripMenuItem1.Text = "Löschen";
            // 
            // lvZutat
            // 
            this.lvZutat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvZutat.ContextMenuStrip = this.cmsZutat;
            this.lvZutat.HideSelection = false;
            this.lvZutat.Location = new System.Drawing.Point(436, 62);
            this.lvZutat.Name = "lvZutat";
            this.lvZutat.Size = new System.Drawing.Size(322, 195);
            this.lvZutat.TabIndex = 3;
            this.lvZutat.UseCompatibleStateImageBehavior = false;
            this.lvZutat.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Bezeichnung";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Beschreibung";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Einheit";
            // 
            // cmsSpeise
            // 
            this.cmsSpeise.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hinzufügenToolStripMenuItem3,
            this.bearbeitenToolStripMenuItem3,
            this.löschenToolStripMenuItem3});
            this.cmsSpeise.Name = "contextMenuStrip1";
            this.cmsSpeise.Size = new System.Drawing.Size(137, 70);
            // 
            // cmsZutat
            // 
            this.cmsZutat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hinzufügenToolStripMenuItem4,
            this.bearbeitenToolStripMenuItem4,
            this.löschenToolStripMenuItem4,
            this.zutatZuSpeiseHinzufügenToolStripMenuItem});
            this.cmsZutat.Name = "contextMenuStrip2";
            this.cmsZutat.Size = new System.Drawing.Size(227, 92);
            // 
            // cmsAllergen
            // 
            this.cmsAllergen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hinzufügenToolStripMenuItem5,
            this.bearbeitenToolStripMenuItem5,
            this.löschenToolStripMenuItem5,
            this.allergeneVonSpeiseAnpassenToolStripMenuItem});
            this.cmsAllergen.Name = "contextMenuStrip3";
            this.cmsAllergen.Size = new System.Drawing.Size(236, 92);
            // 
            // btnAlles
            // 
            this.btnAlles.Location = new System.Drawing.Point(294, 62);
            this.btnAlles.Name = "btnAlles";
            this.btnAlles.Size = new System.Drawing.Size(95, 23);
            this.btnAlles.TabIndex = 4;
            this.btnAlles.Text = "Alles anzeigen";
            this.btnAlles.UseVisualStyleBackColor = true;
            // 
            // btnBewerten
            // 
            this.btnBewerten.Location = new System.Drawing.Point(62, 62);
            this.btnBewerten.Name = "btnBewerten";
            this.btnBewerten.Size = new System.Drawing.Size(75, 23);
            this.btnBewerten.TabIndex = 4;
            this.btnBewerten.Text = "Bewerten";
            this.btnBewerten.UseVisualStyleBackColor = true;
            // 
            // allergeneToolStripMenuItem
            // 
            this.allergeneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hinzufügenToolStripMenuItem2,
            this.bearbeitenToolStripMenuItem2,
            this.löschenToolStripMenuItem2});
            this.allergeneToolStripMenuItem.Name = "allergeneToolStripMenuItem";
            this.allergeneToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.allergeneToolStripMenuItem.Text = "Allergene";
            // 
            // hinzufügenToolStripMenuItem2
            // 
            this.hinzufügenToolStripMenuItem2.Name = "hinzufügenToolStripMenuItem2";
            this.hinzufügenToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.hinzufügenToolStripMenuItem2.Text = "Hinzufügen";
            // 
            // bearbeitenToolStripMenuItem2
            // 
            this.bearbeitenToolStripMenuItem2.Name = "bearbeitenToolStripMenuItem2";
            this.bearbeitenToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.bearbeitenToolStripMenuItem2.Text = "Bearbeiten";
            // 
            // löschenToolStripMenuItem2
            // 
            this.löschenToolStripMenuItem2.Name = "löschenToolStripMenuItem2";
            this.löschenToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.löschenToolStripMenuItem2.Text = "Löschen";
            // 
            // hinzufügenToolStripMenuItem3
            // 
            this.hinzufügenToolStripMenuItem3.Name = "hinzufügenToolStripMenuItem3";
            this.hinzufügenToolStripMenuItem3.Size = new System.Drawing.Size(136, 22);
            this.hinzufügenToolStripMenuItem3.Text = "Hinzufügen";
            // 
            // bearbeitenToolStripMenuItem3
            // 
            this.bearbeitenToolStripMenuItem3.Name = "bearbeitenToolStripMenuItem3";
            this.bearbeitenToolStripMenuItem3.Size = new System.Drawing.Size(136, 22);
            this.bearbeitenToolStripMenuItem3.Text = "Bearbeiten";
            // 
            // löschenToolStripMenuItem3
            // 
            this.löschenToolStripMenuItem3.Name = "löschenToolStripMenuItem3";
            this.löschenToolStripMenuItem3.Size = new System.Drawing.Size(136, 22);
            this.löschenToolStripMenuItem3.Text = "Löschen";
            // 
            // hinzufügenToolStripMenuItem4
            // 
            this.hinzufügenToolStripMenuItem4.Name = "hinzufügenToolStripMenuItem4";
            this.hinzufügenToolStripMenuItem4.Size = new System.Drawing.Size(136, 22);
            this.hinzufügenToolStripMenuItem4.Text = "Hinzufügen";
            // 
            // bearbeitenToolStripMenuItem4
            // 
            this.bearbeitenToolStripMenuItem4.Name = "bearbeitenToolStripMenuItem4";
            this.bearbeitenToolStripMenuItem4.Size = new System.Drawing.Size(136, 22);
            this.bearbeitenToolStripMenuItem4.Text = "Bearbeiten";
            // 
            // löschenToolStripMenuItem4
            // 
            this.löschenToolStripMenuItem4.Name = "löschenToolStripMenuItem4";
            this.löschenToolStripMenuItem4.Size = new System.Drawing.Size(136, 22);
            this.löschenToolStripMenuItem4.Text = "Löschen";
            // 
            // hinzufügenToolStripMenuItem5
            // 
            this.hinzufügenToolStripMenuItem5.Name = "hinzufügenToolStripMenuItem5";
            this.hinzufügenToolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.hinzufügenToolStripMenuItem5.Text = "Hinzufügen";
            // 
            // bearbeitenToolStripMenuItem5
            // 
            this.bearbeitenToolStripMenuItem5.Name = "bearbeitenToolStripMenuItem5";
            this.bearbeitenToolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.bearbeitenToolStripMenuItem5.Text = "Bearbeiten";
            // 
            // löschenToolStripMenuItem5
            // 
            this.löschenToolStripMenuItem5.Name = "löschenToolStripMenuItem5";
            this.löschenToolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.löschenToolStripMenuItem5.Text = "Löschen";
            // 
            // zutatZuSpeiseHinzufügenToolStripMenuItem
            // 
            this.zutatZuSpeiseHinzufügenToolStripMenuItem.Name = "zutatZuSpeiseHinzufügenToolStripMenuItem";
            this.zutatZuSpeiseHinzufügenToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.zutatZuSpeiseHinzufügenToolStripMenuItem.Text = "Zutaten von Speise anpassen";
            // 
            // allergeneVonSpeiseAnpassenToolStripMenuItem
            // 
            this.allergeneVonSpeiseAnpassenToolStripMenuItem.Name = "allergeneVonSpeiseAnpassenToolStripMenuItem";
            this.allergeneVonSpeiseAnpassenToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.allergeneVonSpeiseAnpassenToolStripMenuItem.Text = "Allergene von Speise anpassen";
            // 
            // SpeisenZutaten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 459);
            this.Controls.Add(this.btnBewerten);
            this.Controls.Add(this.btnAlles);
            this.Controls.Add(this.lvZutat);
            this.Controls.Add(this.lvAllergen);
            this.Controls.Add(this.lvSpeise);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SpeisenZutaten";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmsSpeise.ResumeLayout(false);
            this.cmsZutat.ResumeLayout(false);
            this.cmsAllergen.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvSpeise;
        private System.Windows.Forms.ListView lvAllergen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem speiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zutatenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hinzufügenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lvZutat;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ContextMenuStrip cmsSpeise;
        private System.Windows.Forms.ContextMenuStrip cmsZutat;
        private System.Windows.Forms.ContextMenuStrip cmsAllergen;
        private System.Windows.Forms.Button btnAlles;
        private System.Windows.Forms.Button btnBewerten;
        private System.Windows.Forms.ToolStripMenuItem hinzufügenToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem hinzufügenToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem allergeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hinzufügenToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem hinzufügenToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem allergeneVonSpeiseAnpassenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zutatZuSpeiseHinzufügenToolStripMenuItem;
    }
}