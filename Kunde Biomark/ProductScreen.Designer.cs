namespace Kunde_Biomark
{
    partial class ProductScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCategorie = new System.Windows.Forms.ComboBox();
            this.bttSave = new System.Windows.Forms.Button();
            this.bttClear = new System.Windows.Forms.Button();
            this.bttEdit = new System.Windows.Forms.Button();
            this.bttDelete = new System.Windows.Forms.Button();
            this.productDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.productDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.Black;
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.ForeColor = System.Drawing.Color.White;
            this.txtProductName.Location = new System.Drawing.Point(100, 28);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(268, 20);
            this.txtProductName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marke";
            // 
            // txtBrand
            // 
            this.txtBrand.BackColor = System.Drawing.Color.Black;
            this.txtBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrand.ForeColor = System.Drawing.Color.White;
            this.txtBrand.Location = new System.Drawing.Point(101, 65);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(165, 20);
            this.txtBrand.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preis";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Black;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.ForeColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(101, 135);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(85, 20);
            this.txtPrice.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kategorie";
            // 
            // cbxCategorie
            // 
            this.cbxCategorie.BackColor = System.Drawing.Color.Black;
            this.cbxCategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCategorie.ForeColor = System.Drawing.Color.White;
            this.cbxCategorie.FormattingEnabled = true;
            this.cbxCategorie.Items.AddRange(new object[] {
            "Obst",
            "Gemüse",
            "Fleisch",
            "Fisch",
            "Drogerie",
            "Getränke"});
            this.cbxCategorie.Location = new System.Drawing.Point(101, 102);
            this.cbxCategorie.Name = "cbxCategorie";
            this.cbxCategorie.Size = new System.Drawing.Size(165, 21);
            this.cbxCategorie.TabIndex = 7;
            // 
            // bttSave
            // 
            this.bttSave.BackColor = System.Drawing.Color.Black;
            this.bttSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSave.ForeColor = System.Drawing.Color.White;
            this.bttSave.Location = new System.Drawing.Point(101, 161);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(85, 25);
            this.bttSave.TabIndex = 10;
            this.bttSave.Text = "Speichern";
            this.bttSave.UseVisualStyleBackColor = false;
            this.bttSave.Click += new System.EventHandler(this.BttSave_Click);
            // 
            // bttClear
            // 
            this.bttClear.BackColor = System.Drawing.Color.Black;
            this.bttClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttClear.ForeColor = System.Drawing.Color.White;
            this.bttClear.Location = new System.Drawing.Point(283, 161);
            this.bttClear.Name = "bttClear";
            this.bttClear.Size = new System.Drawing.Size(85, 25);
            this.bttClear.TabIndex = 11;
            this.bttClear.Text = "Leeren";
            this.bttClear.UseVisualStyleBackColor = false;
            this.bttClear.Click += new System.EventHandler(this.BttClear_Click);
            // 
            // bttEdit
            // 
            this.bttEdit.BackColor = System.Drawing.Color.Black;
            this.bttEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttEdit.ForeColor = System.Drawing.Color.White;
            this.bttEdit.Location = new System.Drawing.Point(192, 161);
            this.bttEdit.Name = "bttEdit";
            this.bttEdit.Size = new System.Drawing.Size(85, 25);
            this.bttEdit.TabIndex = 12;
            this.bttEdit.Text = "Bearbeiten";
            this.bttEdit.UseVisualStyleBackColor = false;
            this.bttEdit.Click += new System.EventHandler(this.BttEdit_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.BackColor = System.Drawing.Color.Black;
            this.bttDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttDelete.ForeColor = System.Drawing.Color.White;
            this.bttDelete.Location = new System.Drawing.Point(374, 161);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(85, 25);
            this.bttDelete.TabIndex = 13;
            this.bttDelete.Text = "Löschen";
            this.bttDelete.UseVisualStyleBackColor = false;
            this.bttDelete.Click += new System.EventHandler(this.BttDelete_Click);
            // 
            // productDGV
            // 
            this.productDGV.AllowUserToAddRows = false;
            this.productDGV.AllowUserToDeleteRows = false;
            this.productDGV.AllowUserToResizeColumns = false;
            this.productDGV.AllowUserToResizeRows = false;
            this.productDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDGV.BackgroundColor = System.Drawing.Color.Black;
            this.productDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.productDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDGV.Location = new System.Drawing.Point(35, 192);
            this.productDGV.MultiSelect = false;
            this.productDGV.Name = "productDGV";
            this.productDGV.ReadOnly = true;
            this.productDGV.RowHeadersVisible = false;
            this.productDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.productDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.productDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.productDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDGV.Size = new System.Drawing.Size(733, 257);
            this.productDGV.TabIndex = 14;
            this.productDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDGV_CellContentClick);
            // 
            // ProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(799, 461);
            this.Controls.Add(this.productDGV);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.bttEdit);
            this.Controls.Add(this.bttClear);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.cbxCategorie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProductScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produkte";
            ((System.ComponentModel.ISupportInitialize)(this.productDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxCategorie;
        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.Button bttClear;
        private System.Windows.Forms.Button bttEdit;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.DataGridView productDGV;
    }
}