using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02.MarketDesktopApp
{
    public partial class MainForm : Form
    {
        decimal total = 0;
        decimal remaing = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)  //13 sayısı Enter tuşunun kodudur.(eğer enter tuşuna basılırsa demek istiyor)
            {
                string connectionString = "Data Source=DESKTOP-D84DF12\\SQLEXPRESS02;Initial Catalog=MarketDb;Integrated Security=True;";

                SqlConnection connection = new(connectionString);
                connection.Open();

                int id = 0;
                int.TryParse(txtBarcode.Text, out id);
                if (id == 0)
                {
                    MessageBox.Show("Sadece numaretik değerler girebilirsiniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBarcode.Text = "";
                    return;
                }

                string query = "Select Top 1 * FROM Products where Id=" + id;
                SqlCommand command = new(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var name = reader["Name"].ToString();
                    var price = (decimal)reader["Price"];
                    AddShoppingCart(name, price);
                }
                else
                {
                    MessageBox.Show("Ürün bulunamadı", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBarcode.Text = "";
                }
            }
        }

        private void AddShoppingCart(string name, decimal price)
        {
            dgList.Rows.Add();
            int count = dgList.Rows.Count - 1;

            string code = txtBarcode.Text;
            dgList.Rows[count].Cells[0].Value = count + 1;    //#
            dgList.Rows[count].Cells[1].Value = name;         //Name
            dgList.Rows[count].Cells[2].Value = 1;            //Quantity
            dgList.Rows[count].Cells[3].Value = price;      //Price
            dgList.Rows[count].Cells[4].Value = (price * 1).ToString("#,##0.00") + "₺";   //Total Price

            txtBarcode.Text = "";

            total = 0;

            for (int i = 0; i < dgList.Rows.Count; i++)
            {
                total += (Convert.ToDecimal(dgList.Rows[i].Cells[2].Value) * Convert.ToDecimal(dgList.Rows[i].Cells[3].Value));
            }

            lbTotal.Text = total.ToString("#,##0.00") + "₺";

            decimal totalPayment = 0;
            for (int i = 0; i < dgPayment.Rows.Count; i++)
            {
                totalPayment += Convert.ToDecimal(dgPayment.Rows[i].Cells[1].Value);
            }

            remaing = total - totalPayment;

            lbRemaing.Text = remaing.ToString("#,##0.00") + " ₺";
            txtPayment.Text = remaing.ToString();
        }

        private void btnKK_Click(object sender, EventArgs e)
        {
            string payment = txtPayment.Text;
            dgPayment.Rows.Add("Credit Card", payment);
            txtPayment.Text = "0";

            remaing -= Convert.ToDecimal(payment);
            if (remaing <= 0) gbPayment.Enabled = false;
            lbRemaing.Text = remaing.ToString("#,##0.00") + " ₺";
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            string payment = txtPayment.Text;
            dgPayment.Rows.Add("Cash", payment);
            txtPayment.Text = "0";


            remaing -= Convert.ToDecimal(payment);

            if (remaing <= 0) gbPayment.Enabled = false;
            lbRemaing.Text = remaing.ToString("#,##0.00") + " ₺";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBarcode.Text = "0";
            dgList.Rows.Clear();
            lbTotal.Text = "0";
            txtPayment.Text= "0";
            dgPayment.Rows.Clear();
            lbRemaing.Text = "0";
        }
    }
}
