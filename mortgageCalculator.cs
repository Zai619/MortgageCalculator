using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s1131426房貸計算器
{
    public partial class mortgageCalculator : Form
    {
        public mortgageCalculator()
        {
            InitializeComponent();
            this.txtGracePeriod.Text = "0";
            this.txtMonthPay.Visible = false;
            this.label21.Visible = false;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtTotalLoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void mortgageCalculator_Click(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {

            if (this.txtGracePeriod.Text == "" || double.Parse(this.txtGracePeriod.Text) < 0 )
            {
                MessageBox.Show("寬限期須大於等於零", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (this.txtLoanLimit.Text == "" || double.Parse(this.txtLoanLimit.Text) <= 0 || double.Parse(this.txtLoanLimit.Text) < double.Parse(this.txtGracePeriod.Text))
            {
                MessageBox.Show("貸款年限須大於零", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.txtTotalPrice.Text == "" || double.Parse(this.txtTotalPrice.Text) <= 0 )
            {
                MessageBox.Show("價格必須大於零", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.txtSelfFund.Text == "" || double.Parse(this.txtSelfFund.Text) < 0 || double.Parse(this.txtSelfFund.Text) > 100)
            {
                MessageBox.Show("自備款比例需介於0-100", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.txtLoanRate.Text == "" || double.Parse(this.txtLoanRate.Text) < 0 || double.Parse(this.txtLoanRate.Text) > 100)
            {
                MessageBox.Show("貸款利率需介於0-100", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var grace = double.Parse(this.txtGracePeriod.Text)*12.0;
            var totalPrice = double.Parse(this.txtTotalPrice.Text);
            var selfFund = double.Parse(this.txtSelfFund.Text) / 100.0;
            var totalLoan = totalPrice * (1.0 - selfFund);
            this.txtTotalLoan.Text = (Math.Round(totalLoan, 2)).ToString("N");


            var month = double.Parse(this.txtLoanLimit.Text) * 12;
            var rate = double.Parse(this.txtLoanRate.Text) / 100.0 / 12.0;
 
            if (grace > 0)
            {


                this.txtInGrace.Text = (Math.Round(totalLoan * rate, 2)).ToString("N");
                month -= grace;
                var MonthPay = totalLoan * rate * Math.Pow(1 + rate, month) / (Math.Pow(1 + rate, month) - 1);
                this.txtOutGrace.Text = (Math.Round(MonthPay, 2)).ToString("N");
                var firstInterest = totalLoan * rate;
                this.txtFirstInterest.Text = (Math.Round(firstInterest, 2)).ToString("N");

                this.txtFirstPrincipal.Text = "0";
                this.txtTotalPay.Text = (Math.Round(MonthPay * month + totalLoan * rate * grace, 2)).ToString("N");
                this.txtTotalInterest.Text = (Math.Round(MonthPay * month + totalLoan * rate * grace - totalLoan, 2)).ToString("N");
            }
            else
            {
                this.txtMonthPay.Visible = true;
                this.label21.Visible = true;
                this.txtInGrace.Visible = false;
                this.txtOutGrace.Visible = false;
                this.label12.Visible = false;
                this.label13.Visible = false;
                this.label19.Visible = false;
                this.label20.Visible = false;

                var MonthPay = totalLoan * rate * Math.Pow(1 + rate, month) / (Math.Pow(1 + rate, month) - 1);
                this.txtMonthPay.Text = (Math.Round(MonthPay, 2)).ToString("N");
                var firstInterest = totalLoan * rate;
                this.txtFirstInterest.Text = (Math.Round(firstInterest,2)).ToString("N");

                this.txtFirstPrincipal.Text = (Math.Round(MonthPay - firstInterest,2)).ToString("N");
                this.txtTotalPay.Text = (Math.Round(MonthPay * month,2)).ToString("N");
                this.txtTotalInterest.Text = (Math.Round(MonthPay * month - totalLoan,2)).ToString("N");
            }







        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGracePeriod_TextChanged(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstPrincipal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtTotalPay_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void mortgageCalculator_Load(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}
