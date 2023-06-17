namespace Kunde_Biomark
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.bttProduktVerwalten = new System.Windows.Forms.Button();
            this.bttRechnnung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttProduktVerwalten
            // 
            this.bttProduktVerwalten.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttProduktVerwalten.BackgroundImage")));
            this.bttProduktVerwalten.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttProduktVerwalten.ForeColor = System.Drawing.Color.White;
            this.bttProduktVerwalten.Location = new System.Drawing.Point(12, 82);
            this.bttProduktVerwalten.Name = "bttProduktVerwalten";
            this.bttProduktVerwalten.Size = new System.Drawing.Size(275, 125);
            this.bttProduktVerwalten.TabIndex = 0;
            this.bttProduktVerwalten.Text = "Produkt verwalten";
            this.bttProduktVerwalten.UseVisualStyleBackColor = true;
            this.bttProduktVerwalten.Click += new System.EventHandler(this.BttProduktVerwalten_Click);
            // 
            // bttRechnnung
            // 
            this.bttRechnnung.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttRechnnung.BackgroundImage")));
            this.bttRechnnung.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttRechnnung.ForeColor = System.Drawing.Color.White;
            this.bttRechnnung.Location = new System.Drawing.Point(326, 82);
            this.bttRechnnung.Name = "bttRechnnung";
            this.bttRechnnung.Size = new System.Drawing.Size(275, 125);
            this.bttRechnnung.TabIndex = 1;
            this.bttRechnnung.Text = "Rechnung erstellen";
            this.bttRechnnung.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(627, 272);
            this.Controls.Add(this.bttRechnnung);
            this.Controls.Add(this.bttProduktVerwalten);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hauptmenü";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttProduktVerwalten;
        private System.Windows.Forms.Button bttRechnnung;
    }
}