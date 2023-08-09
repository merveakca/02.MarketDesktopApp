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
        List<ReceiptDetail> receiptDetails = new();
        List<ReceiptPayment> receiptPayments = new();

        public MainForm()
        {
            InitializeComponent();
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)  //13 sayısı Enter tuşunun kodudur.(eğer enter tuşuna basılırsa demek istiyor)
            {
                connection.Open();

                int id = 0;
                if (!int.TryParse(txtBarcode.Text, out id))
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
                    AddShoppingCart(id, name, price);
                }
                else
                {
                    MessageBox.Show("Ürün bulunamadı", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBarcode.Text = "";
                }
            }
        }

        private void AddShoppingCart(int id, string name, decimal price)
        {
            dgList.Rows.Add();
            int count = dgList.Rows.Count - 1;

            dgList.Rows[count].Cells[0].Value = count + 1;    //#
            dgList.Rows[count].Cells[1].Value = name;         //Name
            dgList.Rows[count].Cells[2].Value = 1;            //Quantity
            dgList.Rows[count].Cells[3].Value = price;        //Price
            dgList.Rows[count].Cells[4].Value = (price * 1).ToString("#,##0.00") + "₺";   //Total Price

            txtBarcode.Text = "";

            total = 0;

            for (int i = 0; i < dgList.Rows.Count; i++)
            {
                total += (Convert.ToDecimal(dgList.Rows[i].Cells["Quantity"].Value) * Convert.ToDecimal(dgList.Rows[i].Cells["Price"].Value));
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

            ReceiptDetail receiptDetail = new()
            {
                Price = price,
                Total = price * 1,
                ProductId = id,
                ReceiptId = 1,
                Quantity = 1
            };
            receiptDetails.Add(receiptDetail);

        }

        private void btnKK_Click(object sender, EventArgs e)
        {
            string payment = txtPayment.Text;
            dgPayment.Rows.Add("Credit Card", payment);
            txtPayment.Text = "0";

            remaing -= Convert.ToDecimal(payment);
            if (remaing <= 0) gbPayment.Enabled = false;
            lbRemaing.Text = remaing.ToString("#,##0.00") + " ₺";

            ReceiptPayment receiptPayment = new()
            {
                ReceiptId = 1,
                Amount = Convert.ToDecimal(payment),
                Type = "Credit Card"
            };
            receiptPayments.Add(receiptPayment);
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            string payment = txtPayment.Text;
            dgPayment.Rows.Add("Cash", payment);
            txtPayment.Text = "0";


            remaing -= Convert.ToDecimal(payment);

            if (remaing <= 0) gbPayment.Enabled = false;
            lbRemaing.Text = remaing.ToString("#,##0.00") + " ₺";

            ReceiptPayment receiptPayment = new()
            {
                ReceiptId = 1,
                Amount = Convert.ToDecimal(payment),
                Type = "Cash"
            };
            receiptPayments.Add(receiptPayment);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            dgList.Rows.Clear();
            dgPayment.Rows.Clear();
            lbRemaing.Text = "0,00 ₺";
            lbTotal.Text = "0,00 ₺";
            txtPayment.Text = "0";
            total = 0;
            remaing = 0;
            gbPayment.Enabled = true;
            txtBarcode.Focus();
            receiptDetails = new();
            receiptPayments = new();
            receiptId = 0;
        }

        int receiptId = 0;
        SqlConnection connection = new("Data Source=DESKTOP-3BJ5GK9\\SQLEXPRESS;Initial Catalog=MarketDb;Integrated Security=True;");

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (remaing > 0)
            {
                MessageBox.Show("Tüm ödeme yapılmadı!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            connection.Open();
            Guid receiptNumber = Guid.NewGuid();
            string query = $"Insert into Receipts(Id,Date,Total,Payment,Remaining,ReceiptNumber) Values(0,'{DateTime.Now}', {total}, {total - remaing}, {remaing}, '{receiptNumber}')";

            //Burada hata var.

            SqlCommand command = new(query, connection);
            command.ExecuteNonQuery();

            SqlCommand getIdCommand = new($"Select TOP 1 Id From Receipts Where ReceiptNumber={receiptNumber}", connection);
            SqlDataReader reader = getIdCommand.ExecuteReader();
            receiptId = (int)reader["Id"];

            foreach (var detail in receiptDetails)
            {
                string detailQuery = $"insert into ReceiptDetails Values({receiptId},{detail.ProductId},{detail.Quantity},{detail.Price},{detail.Total})";
                SqlCommand detailCommand = new(detailQuery, connection);
                detailCommand.ExecuteNonQuery();
            }

            foreach (var payment in receiptPayments)
            {
                string paymentQuery = $"insert into ReceiptPayments Values({receiptId},{payment.Type},{payment.Amount})";
                SqlCommand pametnCommand = new(paymentQuery, connection);
                pametnCommand.ExecuteNonQuery();
            }

            connection.Close();

            Clear();

            MessageBox.Show("Alış-veriş başarıyla tamamlandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    public class ReceiptDetail
    {
        public int ReceiptId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
    }

    public class ReceiptPayment
    {
        public int ReceiptId { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
    }




