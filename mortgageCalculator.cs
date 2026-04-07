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
            var grace = double.Parse(this.txtGracePeriod.Text)*12.0;
            var totalPrice = double.Parse(this.txtTotalPrice.Text);
            var selfFund = double.Parse(this.txtSelfFund.Text) / 100.0;
            var totalLoan = totalPrice * (1.0 - selfFund);
            this.txtTotalLoan.Text = (totalLoan).ToString();


            var month = double.Parse(this.txtLoanLimit.Text) * 12;
            var rate = double.Parse(this.txtLoanRate.Text) / 100.0 / 12.0;

            if (grace > 0)
            {
                this.txtInGrace.Text = (totalLoan*rate).ToString();
                month -= grace;
                var MonthPay = totalLoan * rate * Math.Pow(1 + rate, month) / (Math.Pow(1 + rate, month) - 1);
                this.txtOutGrace.Text = (MonthPay).ToString();
                var firstInterest = totalLoan * rate;
                this.txtFirstInterest.Text = (firstInterest).ToString();

                this.txtFirstPrincipal.Text = "0";
                this.txtTotalPay.Text = (MonthPay * month + totalLoan * rate * grace).ToString();
                this.txtTotalInterest.Text = (MonthPay * month + totalLoan * rate * grace - totalLoan).ToString();
            }
            else
            {
                this.txtInGrace.Visible = false;
                var MonthPay = totalLoan * rate * Math.Pow(1 + rate, month) / (Math.Pow(1 + rate, month) - 1);
                this.txtOutGrace.Text = (MonthPay).ToString();
                this.txtInGrace.Text = "0";
                var firstInterest = totalLoan * rate;
                this.txtFirstInterest.Text = (firstInterest).ToString();

                this.txtFirstPrincipal.Text = (MonthPay - firstInterest).ToString();
                this.txtTotalPay.Text = (MonthPay * month).ToString();
                this.txtTotalInterest.Text = (MonthPay * month - totalLoan).ToString();
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
    }
}
