namespace s1131426房貸計算器
{
    partial class mortgageCalculator
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtLoanRate = new System.Windows.Forms.TextBox();
            this.txtLoanLimit = new System.Windows.Forms.TextBox();
            this.txtGracePeriod = new System.Windows.Forms.TextBox();
            this.txtSelfFund = new System.Windows.Forms.TextBox();
            this.txtTotalLoan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInGrace = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFirstInterest = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFirstPrincipal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalInterest = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalPay = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtOutGrace = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "房屋總價";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(36, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "自備款比例";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(36, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "貸款年限";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(36, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "寬限期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(36, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "貸款利率";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(260, 38);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(242, 25);
            this.txtTotalPrice.TabIndex = 5;
            this.txtTotalPrice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtLoanRate
            // 
            this.txtLoanRate.Location = new System.Drawing.Point(260, 193);
            this.txtLoanRate.Name = "txtLoanRate";
            this.txtLoanRate.Size = new System.Drawing.Size(242, 25);
            this.txtLoanRate.TabIndex = 6;
            // 
            // txtLoanLimit
            // 
            this.txtLoanLimit.Location = new System.Drawing.Point(260, 280);
            this.txtLoanLimit.Name = "txtLoanLimit";
            this.txtLoanLimit.Size = new System.Drawing.Size(242, 25);
            this.txtLoanLimit.TabIndex = 7;
            this.txtLoanLimit.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtGracePeriod
            // 
            this.txtGracePeriod.Location = new System.Drawing.Point(260, 337);
            this.txtGracePeriod.Name = "txtGracePeriod";
            this.txtGracePeriod.Size = new System.Drawing.Size(242, 25);
            this.txtGracePeriod.TabIndex = 8;
            this.txtGracePeriod.TextChanged += new System.EventHandler(this.txtGracePeriod_TextChanged);
            // 
            // txtSelfFund
            // 
            this.txtSelfFund.Location = new System.Drawing.Point(260, 122);
            this.txtSelfFund.Name = "txtSelfFund";
            this.txtSelfFund.Size = new System.Drawing.Size(242, 25);
            this.txtSelfFund.TabIndex = 9;
            // 
            // txtTotalLoan
            // 
            this.txtTotalLoan.Location = new System.Drawing.Point(980, 42);
            this.txtTotalLoan.Name = "txtTotalLoan";
            this.txtTotalLoan.Size = new System.Drawing.Size(242, 25);
            this.txtTotalLoan.TabIndex = 13;
            this.txtTotalLoan.TextChanged += new System.EventHandler(this.txtTotalLoan_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(756, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 33);
            this.label6.TabIndex = 12;
            this.label6.Text = "貸款總金額";
            // 
            // txtInGrace
            // 
            this.txtInGrace.Location = new System.Drawing.Point(990, 193);
            this.txtInGrace.Name = "txtInGrace";
            this.txtInGrace.Size = new System.Drawing.Size(242, 25);
            this.txtInGrace.TabIndex = 15;
            this.txtInGrace.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(766, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(389, 33);
            this.label7.TabIndex = 14;
            this.label7.Text = "每月應繳金額 (本 + 息)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtFirstInterest
            // 
            this.txtFirstInterest.Location = new System.Drawing.Point(980, 373);
            this.txtFirstInterest.Name = "txtFirstInterest";
            this.txtFirstInterest.Size = new System.Drawing.Size(242, 25);
            this.txtFirstInterest.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(756, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 33);
            this.label8.TabIndex = 16;
            this.label8.Text = "首期利息";
            // 
            // txtFirstPrincipal
            // 
            this.txtFirstPrincipal.Location = new System.Drawing.Point(990, 449);
            this.txtFirstPrincipal.Name = "txtFirstPrincipal";
            this.txtFirstPrincipal.Size = new System.Drawing.Size(242, 25);
            this.txtFirstPrincipal.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(766, 445);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 33);
            this.label9.TabIndex = 18;
            this.label9.Text = "首期本金";
            // 
            // txtTotalInterest
            // 
            this.txtTotalInterest.Location = new System.Drawing.Point(980, 529);
            this.txtTotalInterest.Name = "txtTotalInterest";
            this.txtTotalInterest.Size = new System.Drawing.Size(242, 25);
            this.txtTotalInterest.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(756, 525);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 33);
            this.label10.TabIndex = 20;
            this.label10.Text = "總利息支出";
            // 
            // txtTotalPay
            // 
            this.txtTotalPay.Location = new System.Drawing.Point(980, 588);
            this.txtTotalPay.Name = "txtTotalPay";
            this.txtTotalPay.Size = new System.Drawing.Size(242, 25);
            this.txtTotalPay.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(756, 584);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 33);
            this.label11.TabIndex = 22;
            this.label11.Text = "總還款金額";
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRun.Location = new System.Drawing.Point(578, 158);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(140, 115);
            this.btnRun.TabIndex = 24;
            this.btnRun.Text = "計算";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtOutGrace
            // 
            this.txtOutGrace.Location = new System.Drawing.Point(990, 280);
            this.txtOutGrace.Name = "txtOutGrace";
            this.txtOutGrace.Size = new System.Drawing.Size(242, 25);
            this.txtOutGrace.TabIndex = 25;
            this.txtOutGrace.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(766, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 33);
            this.label12.TabIndex = 26;
            this.label12.Text = "寬限期內";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(779, 280);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 33);
            this.label13.TabIndex = 27;
            this.label13.Text = "寬限期後";
            // 
            // mortgageCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 675);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtOutGrace);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtTotalPay);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTotalInterest);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtFirstPrincipal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFirstInterest);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtInGrace);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotalLoan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSelfFund);
            this.Controls.Add(this.txtGracePeriod);
            this.Controls.Add(this.txtLoanLimit);
            this.Controls.Add(this.txtLoanRate);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mortgageCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "房貸計算器";
            this.Click += new System.EventHandler(this.mortgageCalculator_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtLoanRate;
        private System.Windows.Forms.TextBox txtLoanLimit;
        private System.Windows.Forms.TextBox txtGracePeriod;
        private System.Windows.Forms.TextBox txtSelfFund;
        private System.Windows.Forms.TextBox txtTotalLoan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInGrace;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFirstInterest;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFirstPrincipal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalInterest;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalPay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtOutGrace;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

