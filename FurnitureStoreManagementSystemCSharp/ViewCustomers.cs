using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FurnitureStoreManagementSystemCSharp
{
    public partial class ViewCustomers : Form
    {
        public ViewCustomers()
        {
            InitializeComponent();
        }

        private void ViewCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'furnitureDataSet6.cust' table. You can move, or remove it, as needed.
            this.custTableAdapter.Fill(this.furnitureDataSet6.cust);
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Вадим Макаренко\OneDrive\Desktop\FurnitureStoreManagementSystemCSharp\FurnitureStoreManagementSystemCSharp\furniture.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM cust";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }
    }
}
