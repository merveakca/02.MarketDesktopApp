using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                dgList.Rows.Add();
                int count = dgList.Rows.Count - 1;

                string code = txtBarcode.Text;
                dgList.Rows[count].Cells[0].Value = count + 1;    //#
                dgList.Rows[count].Cells[1].Value = code;         //Name
                dgList.Rows[count].Cells[2].Value = 10;           //Quantity
                dgList.Rows[count].Cells[3].Value = 5000.22;      //Price
                dgList.Rows[count].Cells[4].Value = (10 * 5000.22).ToString("#,##0.00") + "₺";   //Total Price

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
    }
}
