using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Warehouse.Models;

namespace Warehouse
{
    public partial class Form1 : Form
    {
        string conn_str;
        SqlConnection conn;
        List<Supplier> supps;
        List<Category> categories;
        List<Product> products;
        public Form1()
        {
            InitializeComponent();
            conn_str = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            conn = new SqlConnection(conn_str);
            supps = new List<Supplier>();
            categories = new List<Category>();
            products = new List<Product>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Connection established", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            else
            {
                MessageBox.Show("Connection failed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }
        private void LoadData()
        {
            string query = "SELECT Name,Quantity,CostPrice,DeliveryDate,SupplierId,CategoryId FROM Goods";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
        private void maxQuantity_Click(object sender, EventArgs e)
        {
            string query = "SELECT Name,Quantity,CostPrice,DeliveryDate FROM Goods WHERE Quantity IN (SELECT MAX(Quantity) FROM Goods)";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void minQuantity_Click(object sender, EventArgs e)
        {
            string query = "SELECT Name,Quantity,CostPrice,DeliveryDate FROM Goods WHERE Quantity IN (SELECT MIN(Quantity) FROM Goods)";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void minCostPrice_Click(object sender, EventArgs e)
        {
            string query = "SELECT Name,Quantity,CostPrice,DeliveryDate FROM Goods WHERE CostPrice IN (SELECT MIN(CostPrice) FROM Goods)";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void maxCostPrice_Click(object sender, EventArgs e)
        {
            string query = "SELECT Name,Quantity,CostPrice,DeliveryDate FROM Goods WHERE CostPrice IN (SELECT MAX(CostPrice) FROM Goods)";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void oldestProd_Click(object sender, EventArgs e)
        {
            string query = "SELECT TOP (1) Name,Quantity,CostPrice,DeliveryDate FROM Goods ORDER BY DeliveryDate";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void showAllSupp_Click(object sender, EventArgs e)
        { 
            string query = "SELECT * FROM Suppliers";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                supps.Add(new Supplier()
                {
                    Id = (int)reader["Id"],
                    Name = reader["Name"].ToString()
                });
            }
            conn.Close();
            suppList.DataSource = supps;
            suppList.DisplayMember = "Name";
            suppList.SelectedIndex = 0;
        }

        private void showAllCateg_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Categories";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                categories.Add(new Category()
                {
                    Id = (int)reader["Id"],
                    Name = reader["Name"].ToString()
                });
            }
            conn.Close();
            categList.DataSource = categories;
            categList.DisplayMember = "Name";
            categList.SelectedIndex = 0;
        }
       
        private void categList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
            int k = categList.SelectedIndex + 1;
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"CategoryId = {k}";
        }

        private void avgQuantity_Click(object sender, EventArgs e)
        {
            string query = "Select c.Name as [Product Category], AVG(g.Quantity) as [Average quantity of goods]" +
                "from Categories c join Goods g on c.Id = g.CategoryId group by c.Name";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void suppList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
            int k = suppList.SelectedIndex + 1;
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"SupplierId = {k}";
        }

        private void showAllGoods_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Goods";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                products.Add(new Product()
                {
                    Id = (int)reader["Id"],
                    Name = reader["Name"].ToString(),
                    Quantity = (int)reader["Quantity"],
                    CostPrice = (decimal)reader["CostPrice"],
                    DeliveryDate = (DateTime)reader["DeliveryDate"],
                    CategoryId = (int)reader["CategoryId"],
                    SupplierId = (int)reader["SupplierId"]
                });
            }
            conn.Close();
            dataGridView1.DataSource = products;
        }
    }
}
