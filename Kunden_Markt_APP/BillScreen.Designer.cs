using System.Windows.Forms;

namespace Kunde_Biomark
{
    partial class BillScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnSaveInvoice = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.Black;
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.ForeColor = System.Drawing.Color.White;
            this.txtCustomerName.Location = new System.Drawing.Point(138, 28);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(200, 20);
            this.txtCustomerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Black;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.ForeColor = System.Drawing.Color.White;
            this.txtAddress.Location = new System.Drawing.Point(138, 58);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Invoice Number:";
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.BackColor = System.Drawing.Color.Black;
            this.txtInvoiceNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceNumber.ForeColor = System.Drawing.Color.White;
            this.txtInvoiceNumber.Location = new System.Drawing.Point(138, 88);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(200, 20);
            this.txtInvoiceNumber.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Invoice Date:";
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtpInvoiceDate.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dtpInvoiceDate.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpInvoiceDate.CustomFormat = "yyyy-MM-dd";
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(138, 118);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(200, 20);
            this.dtpInvoiceDate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(32, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Amount:";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.Black;
            this.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalAmount.ForeColor = System.Drawing.Color.White;
            this.txtTotalAmount.Location = new System.Drawing.Point(138, 148);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(200, 20);
            this.txtTotalAmount.TabIndex = 9;
            // 
            // dgvProducts
            // 
            this.dgvProducts.Location = new System.Drawing.Point(0, 0);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(240, 150);
            this.dgvProducts.TabIndex = 0;
            // 
            // productName
            // 
            this.productName.Name = "productName";
            // 
            // quantity
            // 
            this.quantity.Name = "quantity";
            // 
            // price
            // 
            this.price.Name = "price";
            // 
            // total
            // 
            this.total.Name = "total";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(0, 0);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 0;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(0, 0);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProduct.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(0, 0);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 0;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(0, 0);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(100, 20);
            this.txtTax.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 0;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(0, 0);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 0;
            // 
            // btnSaveInvoice
            // 
            this.btnSaveInvoice.Location = new System.Drawing.Point(0, 0);
            this.btnSaveInvoice.Name = "btnSaveInvoice";
            this.btnSaveInvoice.Size = new System.Drawing.Size(75, 23);
            this.btnSaveInvoice.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(138, 188);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(263, 188);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // BillScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1139, 717);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpInvoiceDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInvoiceNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "BillScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Form";
          
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInvoiceNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnSaveInvoice;
    }
}