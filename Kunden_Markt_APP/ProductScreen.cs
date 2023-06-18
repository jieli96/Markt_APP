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

        private int selectedProductid; 
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
            // abfragen ob eine Feld leer ist bevor man es speichert
            if (txtProductName.Text == null || txtBrand.Text == null || cbxCategorie.SelectedItem == null || txtPrice.Text == null)
            {
               MessageBox.Show("Bitte alle Felder ausfüllen");
                return; 
            }
            string productName = txtProductName.Text;
            string brand = txtBrand.Text;
            string categorie = cbxCategorie.Text;
            double price = double.Parse(txtPrice.Text);
             //string query = "insert into Products values ('" + productName + "', '" + brand + "', '" + categorie + "', " + price + ");";

            // andere Variante
            string query = string.Format("insert into Products values ('{0}','{1}','{2}', {3})", productName, brand,categorie,price);
            
            


            ExecuteQuery(query);
            //dataBaseConnection.Open();

            ////SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(querys, dataBaseConnection);
            ////DataSet dataSet = new DataSet();
            ////sqlDataAdapter.Fill(dataSet);
            //SqlCommand sqlCommand = new SqlCommand(query,dataBaseConnection);
            //sqlCommand.ExecuteNonQuery();

            //dataBaseConnection.Close();
            //Clearfields();
            //ShowProduct();
        }


        private void BttEdit_Click(object sender, EventArgs e)
        {
            if (selectedProductid == 0)
            {
                MessageBox.Show("Bitte wähle zuerst eine Produkte aus.");
                return;
            }

            string productName = txtProductName.Text;
            string brand = txtBrand.Text;
            string categorie = cbxCategorie.Text;
           double price = double.Parse(txtPrice.Text);
            string query = string.Format("update Products set Name='{0}',Marke='{1}',Kategorie='{2}',Preis ={3} where id={4}",productName,brand,categorie,price, selectedProductid);
            ExecuteQuery(query);
            
        }

        private void BttClear_Click(object sender, EventArgs e)
        {
            txtProductName.Text = string.Empty;
            txtBrand.Text = string.Empty;
            cbxCategorie.SelectedItem = null;
            cbxCategorie.Text = string.Empty;
            txtPrice.Text = string.Empty; 
            
        }

        // Leert alle Felder
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
            if(selectedProductid == 0)
            {
                MessageBox.Show("Bitte wähle zuerst eine Produkte aus.");
                return;
            }
            string query = string.Format("delete from Products where id ="+selectedProductid+";");
           ExecuteQuery(query);
        }

        private void ProductDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductName.Text = productDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtBrand.Text = productDGV.SelectedRows[0].Cells[2].Value.ToString();
            cbxCategorie.Text = productDGV.SelectedRows[0].Cells[3].Value.ToString();
            txtPrice.Text = productDGV.SelectedRows[0].Cells[4].Value.ToString();

           this.selectedProductid = (int)productDGV.SelectedRows[0].Cells[0].Value;
        }

        // führt SQl Befehle aus
        private void ExecuteQuery(string query)
        {
            dataBaseConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(query, dataBaseConnection);
            sqlCommand.ExecuteNonQuery();
            dataBaseConnection.Close();
            Clearfields();
            ShowProduct();
        }

        private void BttReturn_Click(object sender, EventArgs e)
        {
            MainView mainView = new MainView();
            mainView.Show();
            this.Hide();
        }
    }
}
