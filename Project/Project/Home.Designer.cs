namespace Project
{
    partial class DeleteIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteIn));
            this.label1 = new System.Windows.Forms.Label();
            this.projectDbDataSet1 = new Project.projectDbDataSet();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblUsername = new System.Windows.Forms.Label();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.dgvIncomes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExpense = new System.Windows.Forms.TextBox();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.deleteInc = new System.Windows.Forms.PictureBox();
            this.deleteEx = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.projectDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteInc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteEx)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(180)))), ((int)(((byte)(236)))));
            this.label1.Font = new System.Drawing.Font("Ink Free", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "home";
            // 
            // projectDbDataSet1
            // 
            this.projectDbDataSet1.DataSetName = "projectDbDataSet";
            this.projectDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Vivaldi", 21F, System.Drawing.FontStyle.Italic);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(180)))), ((int)(((byte)(236)))));
            this.lblUsername.Location = new System.Drawing.Point(207, 28);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(171, 50);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Welcome ";
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvExpenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.Location = new System.Drawing.Point(26, 346);
            this.dgvExpenses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.RowHeadersWidth = 62;
            this.dgvExpenses.Size = new System.Drawing.Size(488, 125);
            this.dgvExpenses.TabIndex = 5;
            this.dgvExpenses.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvExpenses_CellBeginEdit);
            // 
            // dgvIncomes
            // 
            this.dgvIncomes.BackgroundColor = System.Drawing.Color.White;
            this.dgvIncomes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIncomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncomes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvIncomes.Location = new System.Drawing.Point(26, 135);
            this.dgvIncomes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvIncomes.Name = "dgvIncomes";
            this.dgvIncomes.RowHeadersWidth = 62;
            this.dgvIncomes.Size = new System.Drawing.Size(488, 142);
            this.dgvIncomes.TabIndex = 6;
            this.dgvIncomes.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvIncomes_CellBeginEdit);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 311);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Expenses:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Incomes";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(180)))), ((int)(((byte)(236)))));
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmount.Location = new System.Drawing.Point(561, 28);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(68, 19);
            this.txtAmount.TabIndex = 20;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Total Cash";
            // 
            // txtExpense
            // 
            this.txtExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(180)))), ((int)(((byte)(236)))));
            this.txtExpense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExpense.Location = new System.Drawing.Point(351, 311);
            this.txtExpense.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtExpense.Name = "txtExpense";
            this.txtExpense.ReadOnly = true;
            this.txtExpense.Size = new System.Drawing.Size(68, 19);
            this.txtExpense.TabIndex = 18;
            this.txtExpense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIncome
            // 
            this.txtIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(180)))), ((int)(((byte)(236)))));
            this.txtIncome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIncome.ForeColor = System.Drawing.Color.Black;
            this.txtIncome.Location = new System.Drawing.Point(351, 100);
            this.txtIncome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.ReadOnly = true;
            this.txtIncome.Size = new System.Drawing.Size(68, 19);
            this.txtIncome.TabIndex = 17;
            this.txtIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 311);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total Expenses";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total Incomes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(195, 94);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 32);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(195, 302);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 35);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(442, 28);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 38);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // deleteInc
            // 
            this.deleteInc.Image = ((System.Drawing.Image)(resources.GetObject("deleteInc.Image")));
            this.deleteInc.Location = new System.Drawing.Point(104, 94);
            this.deleteInc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteInc.Name = "deleteInc";
            this.deleteInc.Size = new System.Drawing.Size(27, 26);
            this.deleteInc.TabIndex = 25;
            this.deleteInc.TabStop = false;
            this.deleteInc.Click += new System.EventHandler(this.deleteInc_Click);
            // 
            // deleteEx
            // 
            this.deleteEx.Image = ((System.Drawing.Image)(resources.GetObject("deleteEx.Image")));
            this.deleteEx.Location = new System.Drawing.Point(106, 302);
            this.deleteEx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteEx.Name = "deleteEx";
            this.deleteEx.Size = new System.Drawing.Size(24, 28);
            this.deleteEx.TabIndex = 26;
            this.deleteEx.TabStop = false;
            this.deleteEx.Click += new System.EventHandler(this.deleteEx_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(76)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(639, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(51, 512);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(76)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 507);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 5);
            this.panel2.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(4, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(635, 5);
            this.panel4.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 507);
            this.panel3.TabIndex = 33;
            // 
            // DeleteIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(690, 512);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteEx);
            this.Controls.Add(this.deleteInc);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtExpense);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvIncomes);
            this.Controls.Add(this.dgvExpenses);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DeleteIn";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteInc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteEx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private projectDbDataSet projectDbDataSet1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.DataGridView dgvIncomes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExpense;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox deleteInc;
        private System.Windows.Forms.PictureBox deleteEx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}