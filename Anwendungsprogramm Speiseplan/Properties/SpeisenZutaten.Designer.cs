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
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.speiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zutatenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hinzufügenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(62, 105);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(322, 255);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(436, 105);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(322, 255);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speiseToolStripMenuItem,
            this.zutatenToolStripMenuItem});
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
            this.speiseToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.speiseToolStripMenuItem.Text = "Speise";
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
            // hinzufügenToolStripMenuItem
            // 
            this.hinzufügenToolStripMenuItem.Name = "hinzufügenToolStripMenuItem";
            this.hinzufügenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hinzufügenToolStripMenuItem.Text = "Hinzufügen";
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.löschenToolStripMenuItem.Text = "Löschen";
            // 
            // hinzufügenToolStripMenuItem1
            // 
            this.hinzufügenToolStripMenuItem1.Name = "hinzufügenToolStripMenuItem1";
            this.hinzufügenToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.hinzufügenToolStripMenuItem1.Text = "Hinzufügen";
            // 
            // bearbeitenToolStripMenuItem1
            // 
            this.bearbeitenToolStripMenuItem1.Name = "bearbeitenToolStripMenuItem1";
            this.bearbeitenToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.bearbeitenToolStripMenuItem1.Text = "Bearbeiten";
            // 
            // löschenToolStripMenuItem1
            // 
            this.löschenToolStripMenuItem1.Name = "löschenToolStripMenuItem1";
            this.löschenToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.löschenToolStripMenuItem1.Text = "Löschen";
            // 
            // SpeisenZutaten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 459);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SpeisenZutaten";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem speiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zutatenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hinzufügenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem1;
    }
}