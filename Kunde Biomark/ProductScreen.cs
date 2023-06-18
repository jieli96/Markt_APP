using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kunde_Biomark
{
    public partial class ProductScreen : Form
    {

        // Verbinden mit der Datenbank
        private SqlConnection dataBaseConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Schule\Documents\Markt_DB.mdf;Integrated Security = True; Connect Timeout = 30");
        public ProductScreen()
        {
            InitializeComponent();

            ShowProduct();
        }

        private void ShowProduct()
        {
            // Hier Ladet man die Daten
            dataBaseConnection.Open();

            string query = "select * from Products;";
            // führt query aus
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, dataBaseConnection);

            //Ein Ojekt erstellt mit der klasse DataSet
            DataSet dataSet = new DataSet();

            // DataSet wird mit Daten gefüllt
            sqlDataAdapter.Fill(dataSet);

            productDGV.DataSource = dataSet.Tables[0];
            productDGV.Columns[0].Visible = false;
            dataBaseConnection.Close();
        }

        private void BttSave_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == null || txtBrand.Text == null || cbxCategorie.SelectedItem == null || txtPrice.Text == null)
            {
               MessageBox.Show("Bitte alle Felder ausfüllen");
                return; 
            }
            string productName = txtProductName.Text;
            string brand = txtBrand.Text;
            string categorie = (string)cbxCategorie.SelectedItem;
            double price = double.Parse(txtPrice.Text);
           // string query = "insert into Products values ('" + productName + "', '" + brand + "', '" + categorie + "', " + price + ");";

            // andere Methode
            string query = string.Format("insert into Products values ('{0}','{1}','{2}', {3})", productName, brand,categorie,price);
            
            
            dataBaseConnection.Open();

            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(querys, dataBaseConnection);
            //DataSet dataSet = new DataSet();
            //sqlDataAdapter.Fill(dataSet);
            SqlCommand sqlCommand = new SqlCommand(query,dataBaseConnection);
            sqlCommand.ExecuteNonQuery();

            dataBaseConnection.Close();
            Clearfields();
            ShowProduct();
        }

        private void BttEdit_Click(object sender, EventArgs e)
        {
            //DataGridView dataGridView = new DataGridView();
            //var selectData = dataGridView.SelectedRows.
        }

        private void BttClear_Click(object sender, EventArgs e)
        {
            txtProductName.Text = string.Empty;
            txtBrand.Text = string.Empty;
            cbxCategorie.SelectedItem = null;
            cbxCategorie.Text = string.Empty;
            txtPrice.Text = string.Empty; 
            
        }
       private void Clearfields()
        {
            txtProductName.Text = string.Empty;
            txtBrand.Text = string.Empty;
            cbxCategorie.SelectedItem = null;
            cbxCategorie.Text = string.Empty;
            txtPrice.Text = string.Empty;
        }

        private void BttDelete_Click(object sender, EventArgs e)
        {
            string query = string.Format("delete from Products where ");
        }

       
    }
}
