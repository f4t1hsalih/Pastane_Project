using System.Data;
using System.Data.SqlClient;

//FS
namespace Pastane_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=krsDbPastane;Integrated Security=True");

        private void MaterialList()
        {
            string command = "select material_id as 'ID', name as 'Ad', stock as 'Stok', price as 'Fiyat', note as 'Not' from tbl_materials";
            SqlDataAdapter da = new SqlDataAdapter(command, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void ProductList()
        {
            string command = "select product_id as 'ID', name as 'Ad', b_price as 'Alýþ Fiyatý', s_price as 'Satýþ Fiyatý', stock as 'Stok' from tbl_products";
            SqlDataAdapter da = new SqlDataAdapter(command, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Till()
        {
            string command = "select entry as 'Giriþ', out as 'Çýkýþ' from tbl_till";
            SqlDataAdapter da = new SqlDataAdapter(command, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void MaterialClear()
        {
            txtMaterialName.Clear();
            txtMaterialStock.Clear();
            txtMaterialPrice.Clear();
            txtMaterialNotes.Clear();
        }

        private void ProductClear()
        {
            txtProductName.Clear();
            txtProductBPrice.Clear();
        }

        private void MaterialAddClear()
        {
            cmbProduct.SelectedIndex = 0;
            cmbMaterial.SelectedIndex = 0;
            txtAmount.Clear();
            txtCost.Clear();
        }

        private void Products()
        {
            con.Open();
            string command = "select product_id, name from tbl_products";
            SqlDataAdapter da = new SqlDataAdapter(command, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbProduct.ValueMember = "product_id";
            cmbProduct.DisplayMember = "name";
            cmbProduct.DataSource = dt;
            con.Close();
        }

        private void Materials()
        {
            con.Open();
            string command = "select material_id, name from tbl_materials";
            SqlDataAdapter da = new SqlDataAdapter(command, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbMaterial.ValueMember = "material_id";
            cmbMaterial.DisplayMember = "name";
            cmbMaterial.DataSource = dt;
            con.Close();
        }

        private double CostCalculation()
        {
            con.Open();
            string command = "select price from tbl_materials where material_id = @p1";
            SqlCommand cmd = new SqlCommand(command, con);
            cmd.Parameters.AddWithValue("@p1", cmbMaterial.SelectedValue);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                double price = Convert.ToDouble(dr[0].ToString());
                con.Close();
                return price;
            }
            else
            {
                con.Close();
                return 0;
            }
        }

        private double TotalCostCalculation(string id)
        {
            con.Open();
            string command = "select sum(cost) from tbl_oven where product_id = @p1";
            SqlCommand cmd = new SqlCommand(command, con);
            cmd.Parameters.AddWithValue("@p1", id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return Convert.ToDouble(dr[0]);
            }
            else
            {
                con.Close();
                return 0;
            }
        }

        //---

        private void Form1_Load(object sender, EventArgs e)
        {
            MaterialList();
            Products();
            Materials();
        }

        private void btnÜrünListesi_Click(object sender, EventArgs e)
        {
            ProductList();
        }

        private void btnMalzemeListesi_Click(object sender, EventArgs e)
        {
            MaterialList();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            Till();
        }

        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {
            con.Open();
            string command = "insert into tbl_materials(name, stock, price, note) values (@p1, @p2, @p3, @p4)";
            SqlCommand cmd = new SqlCommand(command, con);
            cmd.Parameters.AddWithValue("@p1", txtMaterialName.Text);
            cmd.Parameters.AddWithValue("@p2", decimal.Parse(txtMaterialStock.Text));
            cmd.Parameters.AddWithValue("@p3", decimal.Parse(txtMaterialPrice.Text));
            cmd.Parameters.AddWithValue("@p4", txtMaterialNotes.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Malzeme Sisteme Eklendi");

            MaterialClear();
            MaterialList();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            con.Open();
            string command = "insert into tbl_products(name) values (@p1)";
            SqlCommand cmd = new SqlCommand(command, con);
            cmd.Parameters.AddWithValue("@p1", txtProductName.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Ürün Sisteme Kaydedildi");

            ProductClear();
            ProductList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            con.Open();
            string command = "insert into tbl_oven(product_id, material_id, amount, cost) values (@p1, @p2, @p3, @p4)";
            SqlCommand cmd = new SqlCommand(command, con);
            cmd.Parameters.AddWithValue("@p1", cmbProduct.SelectedValue);
            cmd.Parameters.AddWithValue("@p2", cmbMaterial.SelectedValue);
            cmd.Parameters.AddWithValue("@p3", decimal.Parse(txtAmount.Text));
            cmd.Parameters.AddWithValue("@p4", decimal.Parse(txtCost.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Malzeme Eklendi");
            MaterialAddClear();

            ProductList();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            double price = 0, cost = 0;

            if (txtAmount.Text == "")
            {
                txtAmount.Text = "0";
            }
            if (txtAmount.Text == "0")
            {
                txtAmount.SelectAll();
            }

            price = CostCalculation();

            cost = price / 1000 * Convert.ToDouble(txtAmount.Text);
            txtCost.Text = cost.ToString();
        }

        private void txtAmount_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == "0")
            {
                txtAmount.SelectAll();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;

            string prouctid = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            txtProductName.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            txtProductBPrice.Text = TotalCostCalculation(prouctid).ToString();

        }
    }
}