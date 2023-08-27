using System.Data;
using System.Data.SqlClient;

namespace Pastane_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=krsDbPastane;Integrated Security=True");

        private void MalzemeListesi()
        {
            string command = "select material_id as 'ID', name as 'Ad', stock as 'Stok', price as 'Fiyat', note as 'Not' from tbl_materials";
            SqlDataAdapter da = new SqlDataAdapter(command, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MalzemeListesi();
        }
    }
}