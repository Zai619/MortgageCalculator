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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtMonthPay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(36, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "房屋總價";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(36, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "自備款比例";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(36, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "貸款年限";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(36, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "寬限期";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(36, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "貸款利率";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotalPrice.Location = new System.Drawing.Point(260, 38);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(242, 51);
            this.txtTotalPrice.TabIndex = 5;
            this.txtTotalPrice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtLoanRate
            // 
            this.txtLoanRate.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLoanRate.Location = new System.Drawing.Point(260, 193);
            this.txtLoanRate.Name = "txtLoanRate";
            this.txtLoanRate.Size = new System.Drawing.Size(242, 51);
            this.txtLoanRate.TabIndex = 6;
            // 
            // txtLoanLimit
            // 
            this.txtLoanLimit.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLoanLimit.Location = new System.Drawing.Point(260, 269);
            this.txtLoanLimit.Name = "txtLoanLimit";
            this.txtLoanLimit.Size = new System.Drawing.Size(242, 51);
            this.txtLoanLimit.TabIndex = 7;
            this.txtLoanLimit.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtGracePeriod
            // 
            this.txtGracePeriod.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtGracePeriod.Location = new System.Drawing.Point(260, 337);
            this.txtGracePeriod.Name = "txtGracePeriod";
            this.txtGracePeriod.Size = new System.Drawing.Size(242, 51);
            this.txtGracePeriod.TabIndex = 8;
            this.txtGracePeriod.TextChanged += new System.EventHandler(this.txtGracePeriod_TextChanged);
            // 
            // txtSelfFund
            // 
            this.txtSelfFund.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSelfFund.Location = new System.Drawing.Point(260, 112);
            this.txtSelfFund.Name = "txtSelfFund";
            this.txtSelfFund.Size = new System.Drawing.Size(242, 51);
            this.txtSelfFund.TabIndex = 9;
            // 
            // txtTotalLoan
            // 
            this.txtTotalLoan.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotalLoan.Location = new System.Drawing.Point(980, 38);
            this.txtTotalLoan.Name = "txtTotalLoan";
            this.txtTotalLoan.Size = new System.Drawing.Size(242, 51);
            this.txtTotalLoan.TabIndex = 13;
            this.txtTotalLoan.TextChanged += new System.EventHandler(this.txtTotalLoan_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(756, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 33);
            this.label6.TabIndex = 12;
            this.label6.Text = "貸款總金額";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtInGrace
            // 
            this.txtInGrace.Location = new System.Drawing.Point(232, 58);
            this.txtInGrace.Name = "txtInGrace";
            this.txtInGrace.Size = new System.Drawing.Size(231, 47);
            this.txtInGrace.TabIndex = 15;
            this.txtInGrace.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtFirstInterest
            // 
            this.txtFirstInterest.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtFirstInterest.Location = new System.Drawing.Point(980, 112);
            this.txtFirstInterest.Name = "txtFirstInterest";
            this.txtFirstInterest.Size = new System.Drawing.Size(242, 51);
            this.txtFirstInterest.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(756, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 33);
            this.label8.TabIndex = 16;
            this.label8.Text = "首期利息";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtFirstPrincipal
            // 
            this.txtFirstPrincipal.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtFirstPrincipal.Location = new System.Drawing.Point(980, 193);
            this.txtFirstPrincipal.Name = "txtFirstPrincipal";
            this.txtFirstPrincipal.Size = new System.Drawing.Size(242, 51);
            this.txtFirstPrincipal.TabIndex = 19;
            this.txtFirstPrincipal.TextChanged += new System.EventHandler(this.txtFirstPrincipal_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(756, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 33);
            this.label9.TabIndex = 18;
            this.label9.Text = "首期本金";
            // 
            // txtTotalInterest
            // 
            this.txtTotalInterest.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotalInterest.Location = new System.Drawing.Point(980, 269);
            this.txtTotalInterest.Name = "txtTotalInterest";
            this.txtTotalInterest.Size = new System.Drawing.Size(242, 51);
            this.txtTotalInterest.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(756, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 33);
            this.label10.TabIndex = 20;
            this.label10.Text = "總利息支出";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtTotalPay
            // 
            this.txtTotalPay.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotalPay.Location = new System.Drawing.Point(980, 337);
            this.txtTotalPay.Name = "txtTotalPay";
            this.txtTotalPay.Size = new System.Drawing.Size(242, 51);
            this.txtTotalPay.TabIndex = 23;
            this.txtTotalPay.TextChanged += new System.EventHandler(this.txtTotalPay_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(756, 347);
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
            this.txtOutGrace.Location = new System.Drawing.Point(232, 122);
            this.txtOutGrace.Name = "txtOutGrace";
            this.txtOutGrace.Size = new System.Drawing.Size(231, 47);
            this.txtOutGrace.TabIndex = 25;
            this.txtOutGrace.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(28, 61);
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
            this.label13.Location = new System.Drawing.Point(28, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 33);
            this.label13.TabIndex = 27;
            this.label13.Text = "寬限期後";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtMonthPay);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtInGrace);
            this.groupBox1.Controls.Add(this.txtOutGrace);
            this.groupBox1.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(762, 440);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 211);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "每月應繳金額 (本 + 息)";
            // 
            // txtMonthPay
            // 
            this.txtMonthPay.Location = new System.Drawing.Point(133, 85);
            this.txtMonthPay.Name = "txtMonthPay";
            this.txtMonthPay.Size = new System.Drawing.Size(242, 47);
            this.txtMonthPay.TabIndex = 28;
            this.txtMonthPay.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(523, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 33);
            this.label7.TabIndex = 29;
            this.label7.Text = "TWD";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(1237, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 33);
            this.label14.TabIndex = 30;
            this.label14.Text = "TWD";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(1237, 122);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 33);
            this.label15.TabIndex = 31;
            this.label15.Text = "TWD";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(1237, 203);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 33);
            this.label16.TabIndex = 32;
            this.label16.Text = "TWD";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(1237, 279);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 33);
            this.label17.TabIndex = 33;
            this.label17.Text = "TWD";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(1237, 347);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 33);
            this.label18.TabIndex = 34;
            this.label18.Text = "TWD";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label19.Location = new System.Drawing.Point(467, 66);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 33);
            this.label19.TabIndex = 35;
            this.label19.Text = "TWD";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label20.Location = new System.Drawing.Point(467, 130);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 33);
            this.label20.TabIndex = 35;
            this.label20.Text = "TWD";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label21.Location = new System.Drawing.Point(381, 88);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 33);
            this.label21.TabIndex = 35;
            this.label21.Text = "TWD";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label22.Location = new System.Drawing.Point(523, 347);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 33);
            this.label22.TabIndex = 35;
            this.label22.Text = "年";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label23.Location = new System.Drawing.Point(523, 279);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 33);
            this.label23.TabIndex = 36;
            this.label23.Text = "年";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label24.Location = new System.Drawing.Point(523, 199);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(32, 33);
            this.label24.TabIndex = 37;
            this.label24.Text = "%";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label25.Location = new System.Drawing.Point(523, 122);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(32, 33);
            this.label25.TabIndex = 38;
            this.label25.Text = "%";
            // 
            // mortgageCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 675);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtTotalPay);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTotalInterest);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtFirstPrincipal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFirstInterest);
            this.Controls.Add(this.label8);
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
            this.Load += new System.EventHandler(this.mortgageCalculator_Load);
            this.Click += new System.EventHandler(this.mortgageCalculator_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtMonthPay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
    }
}

