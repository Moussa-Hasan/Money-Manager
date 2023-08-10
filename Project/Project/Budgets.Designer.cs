namespace Project
{
    partial class Budgets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.btnTip = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSourceEx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAvgMonthlyIncome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAvgDailyExpense = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lstPerc = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAvgDailyIncome = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtExpense = new System.Windows.Forms.TextBox();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(180)))), ((int)(((byte)(236)))));
            this.label2.Font = new System.Drawing.Font("Ink Free", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 65);
            this.label2.TabIndex = 4;
            this.label2.Text = "budget";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstCategories
            // 
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.ItemHeight = 20;
            this.lstCategories.Location = new System.Drawing.Point(249, 125);
            this.lstCategories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(358, 164);
            this.lstCategories.TabIndex = 5;
            // 
            // txtTip
            // 
            this.txtTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(76)))));
            this.txtTip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTip.ForeColor = System.Drawing.Color.Black;
            this.txtTip.Location = new System.Drawing.Point(58, 35);
            this.txtTip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTip.Name = "txtTip";
            this.txtTip.ReadOnly = true;
            this.txtTip.Size = new System.Drawing.Size(333, 19);
            this.txtTip.TabIndex = 6;
            // 
            // btnTip
            // 
            this.btnTip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTip.Location = new System.Drawing.Point(441, 28);
            this.btnTip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTip.Name = "btnTip";
            this.btnTip.Size = new System.Drawing.Size(136, 35);
            this.btnTip.TabIndex = 7;
            this.btnTip.Text = "Tips generator";
            this.btnTip.UseVisualStyleBackColor = true;
            this.btnTip.Click += new System.EventHandler(this.btnTip_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.BackColor = System.Drawing.Color.White;
            this.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblAverage.Location = new System.Drawing.Point(236, 303);
            this.lblAverage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.ReadOnly = true;
            this.lblAverage.Size = new System.Drawing.Size(155, 19);
            this.lblAverage.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Select a source for expense:";
            // 
            // cboSourceEx
            // 
            this.cboSourceEx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSourceEx.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cboSourceEx.FormattingEnabled = true;
            this.cboSourceEx.Location = new System.Drawing.Point(249, 87);
            this.cboSourceEx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSourceEx.Name = "cboSourceEx";
            this.cboSourceEx.Size = new System.Drawing.Size(205, 28);
            this.cboSourceEx.TabIndex = 21;
            this.cboSourceEx.Tag = "";
            this.cboSourceEx.SelectedIndexChanged += new System.EventHandler(this.cboSourceEx_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tip:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(33, 303);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Average Monthly Expense: ";
            this.toolTip1.SetToolTip(this.label3, "This is the average amount of money you spend per month from the first of the yea" +
        "r till now.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(33, 331);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Average Monthly Income:";
            this.toolTip1.SetToolTip(this.label4, "This is the average amount of income you earn per month from the first of the yea" +
        "r till now.");
            // 
            // lblAvgMonthlyIncome
            // 
            this.lblAvgMonthlyIncome.BackColor = System.Drawing.Color.White;
            this.lblAvgMonthlyIncome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblAvgMonthlyIncome.Location = new System.Drawing.Point(236, 331);
            this.lblAvgMonthlyIncome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblAvgMonthlyIncome.Name = "lblAvgMonthlyIncome";
            this.lblAvgMonthlyIncome.ReadOnly = true;
            this.lblAvgMonthlyIncome.Size = new System.Drawing.Size(155, 19);
            this.lblAvgMonthlyIncome.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(33, 357);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Average Daily Expense: ";
            this.toolTip1.SetToolTip(this.label6, "This is the average amount of money you spend per day.");
            // 
            // lblAvgDailyExpense
            // 
            this.lblAvgDailyExpense.BackColor = System.Drawing.Color.White;
            this.lblAvgDailyExpense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblAvgDailyExpense.Location = new System.Drawing.Point(236, 357);
            this.lblAvgDailyExpense.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblAvgDailyExpense.Name = "lblAvgDailyExpense";
            this.lblAvgDailyExpense.ReadOnly = true;
            this.lblAvgDailyExpense.Size = new System.Drawing.Size(155, 19);
            this.lblAvgDailyExpense.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.txtTip);
            this.panel1.Controls.Add(this.btnTip);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 424);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 88);
            this.panel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(76)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(639, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(51, 424);
            this.panel2.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 424);
            this.panel3.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(4, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(635, 5);
            this.panel4.TabIndex = 32;
            // 
            // lstPerc
            // 
            this.lstPerc.FormattingEnabled = true;
            this.lstPerc.ItemHeight = 20;
            this.lstPerc.Location = new System.Drawing.Point(30, 125);
            this.lstPerc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstPerc.Name = "lstPerc";
            this.lstPerc.Size = new System.Drawing.Size(204, 164);
            this.lstPerc.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "% Expenses by category:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(33, 383);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Average Daily Income: ";
            this.toolTip1.SetToolTip(this.label8, "This is the average amount of income you earn per day.");
            // 
            // lblAvgDailyIncome
            // 
            this.lblAvgDailyIncome.BackColor = System.Drawing.Color.White;
            this.lblAvgDailyIncome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblAvgDailyIncome.Location = new System.Drawing.Point(236, 383);
            this.lblAvgDailyIncome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblAvgDailyIncome.Name = "lblAvgDailyIncome";
            this.lblAvgDailyIncome.ReadOnly = true;
            this.lblAvgDailyIncome.Size = new System.Drawing.Size(155, 19);
            this.lblAvgDailyIncome.TabIndex = 35;
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(180)))), ((int)(((byte)(236)))));
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmount.Location = new System.Drawing.Point(525, 382);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(68, 19);
            this.txtAmount.TabIndex = 42;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(410, 383);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Total Cash";
            // 
            // txtExpense
            // 
            this.txtExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(180)))), ((int)(((byte)(236)))));
            this.txtExpense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExpense.Location = new System.Drawing.Point(525, 331);
            this.txtExpense.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtExpense.Name = "txtExpense";
            this.txtExpense.ReadOnly = true;
            this.txtExpense.Size = new System.Drawing.Size(68, 19);
            this.txtExpense.TabIndex = 40;
            this.txtExpense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIncome
            // 
            this.txtIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(180)))), ((int)(((byte)(236)))));
            this.txtIncome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIncome.ForeColor = System.Drawing.Color.Black;
            this.txtIncome.Location = new System.Drawing.Point(525, 303);
            this.txtIncome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.ReadOnly = true;
            this.txtIncome.Size = new System.Drawing.Size(68, 19);
            this.txtIncome.TabIndex = 39;
            this.txtIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(410, 331);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 20);
            this.label10.TabIndex = 38;
            this.label10.Text = "Total Expenses";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(410, 303);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 20);
            this.label11.TabIndex = 37;
            this.label11.Text = "Total Incomes";
            // 
            // Budgets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(690, 512);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtExpense);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblAvgDailyIncome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstPerc);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAvgDailyExpense);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAvgMonthlyIncome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboSourceEx);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lstCategories);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Budgets";
            this.Text = "Budgets";
            this.Load += new System.EventHandler(this.Budgets_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Button btnTip;
        private System.Windows.Forms.TextBox lblAverage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSourceEx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lblAvgMonthlyIncome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lblAvgDailyExpense;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox lstPerc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lblAvgDailyIncome;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtExpense;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}