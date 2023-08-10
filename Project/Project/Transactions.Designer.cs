namespace Project
{
    partial class Transactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transactions));
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmountIn = new System.Windows.Forms.TextBox();
            this.txtDescriptionIn = new System.Windows.Forms.TextBox();
            this.cboSourceIn = new System.Windows.Forms.ComboBox();
            this.btnAddIn = new System.Windows.Forms.Button();
            this.btnAddEx = new System.Windows.Forms.Button();
            this.cboSourceEx = new System.Windows.Forms.ComboBox();
            this.txtDescriptionEx = new System.Windows.Forms.TextBox();
            this.txtAmountEx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(180)))), ((int)(((byte)(236)))));
            this.label2.Font = new System.Drawing.Font("Ink Free", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 43);
            this.label2.TabIndex = 5;
            this.label2.Text = "transaction";
            // 
            // txtAmountIn
            // 
            this.txtAmountIn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAmountIn.Location = new System.Drawing.Point(20, 111);
            this.txtAmountIn.Name = "txtAmountIn";
            this.txtAmountIn.Size = new System.Drawing.Size(117, 20);
            this.txtAmountIn.TabIndex = 9;
            this.txtAmountIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // txtDescriptionIn
            // 
            this.txtDescriptionIn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDescriptionIn.Location = new System.Drawing.Point(20, 155);
            this.txtDescriptionIn.Multiline = true;
            this.txtDescriptionIn.Name = "txtDescriptionIn";
            this.txtDescriptionIn.Size = new System.Drawing.Size(138, 67);
            this.txtDescriptionIn.TabIndex = 10;
            // 
            // cboSourceIn
            // 
            this.cboSourceIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSourceIn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cboSourceIn.FormattingEnabled = true;
            this.cboSourceIn.Items.AddRange(new object[] {
            "Salary or wages",
            "Self-employment income",
            "Rental income",
            "Investment income",
            "Interest income",
            "Capital gains",
            "Royalties",
            "Pension or retirement income",
            "Social Security benefits",
            "Inheritance"});
            this.cboSourceIn.Location = new System.Drawing.Point(20, 247);
            this.cboSourceIn.Name = "cboSourceIn";
            this.cboSourceIn.Size = new System.Drawing.Size(138, 21);
            this.cboSourceIn.TabIndex = 11;
            // 
            // btnAddIn
            // 
            this.btnAddIn.Location = new System.Drawing.Point(20, 284);
            this.btnAddIn.Name = "btnAddIn";
            this.btnAddIn.Size = new System.Drawing.Size(138, 23);
            this.btnAddIn.TabIndex = 12;
            this.btnAddIn.Text = "Add Income";
            this.btnAddIn.UseVisualStyleBackColor = true;
            this.btnAddIn.Click += new System.EventHandler(this.btnAddIn_Click_1);
            // 
            // btnAddEx
            // 
            this.btnAddEx.Location = new System.Drawing.Point(224, 284);
            this.btnAddEx.Name = "btnAddEx";
            this.btnAddEx.Size = new System.Drawing.Size(138, 23);
            this.btnAddEx.TabIndex = 16;
            this.btnAddEx.Text = "Add Expenses";
            this.btnAddEx.UseVisualStyleBackColor = true;
            this.btnAddEx.Click += new System.EventHandler(this.btnAddEx_Click);
            // 
            // cboSourceEx
            // 
            this.cboSourceEx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSourceEx.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cboSourceEx.FormattingEnabled = true;
            this.cboSourceEx.Items.AddRange(new object[] {
            "Housing",
            "Utilities",
            "Transportation",
            "Food",
            "Entertainment",
            "Personal Care",
            "Education",
            "Medical/Healthcare",
            "Insurance",
            "Taxes",
            "Other"});
            this.cboSourceEx.Location = new System.Drawing.Point(224, 247);
            this.cboSourceEx.Name = "cboSourceEx";
            this.cboSourceEx.Size = new System.Drawing.Size(138, 21);
            this.cboSourceEx.TabIndex = 15;
            this.cboSourceEx.Tag = "";
            // 
            // txtDescriptionEx
            // 
            this.txtDescriptionEx.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDescriptionEx.Location = new System.Drawing.Point(224, 155);
            this.txtDescriptionEx.Multiline = true;
            this.txtDescriptionEx.Name = "txtDescriptionEx";
            this.txtDescriptionEx.Size = new System.Drawing.Size(138, 67);
            this.txtDescriptionEx.TabIndex = 14;
            // 
            // txtAmountEx
            // 
            this.txtAmountEx.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAmountEx.Location = new System.Drawing.Point(224, 111);
            this.txtAmountEx.Name = "txtAmountEx";
            this.txtAmountEx.Size = new System.Drawing.Size(117, 20);
            this.txtAmountEx.TabIndex = 13;
            this.txtAmountEx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Enter the amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Enter the amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Select a source:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Select a source:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Enter a description:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Enter a description:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 26);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(277, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 26);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(76)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 330);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 3);
            this.panel2.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(76)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(426, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(34, 333);
            this.panel1.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(423, 3);
            this.panel4.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 330);
            this.panel3.TabIndex = 33;
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 333);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddEx);
            this.Controls.Add(this.cboSourceEx);
            this.Controls.Add(this.txtDescriptionEx);
            this.Controls.Add(this.txtAmountEx);
            this.Controls.Add(this.btnAddIn);
            this.Controls.Add(this.cboSourceIn);
            this.Controls.Add(this.txtDescriptionIn);
            this.Controls.Add(this.txtAmountIn);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transactions";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.Transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmountIn;
        private System.Windows.Forms.TextBox txtDescriptionIn;
        private System.Windows.Forms.ComboBox cboSourceIn;
        private System.Windows.Forms.Button btnAddIn;
        private System.Windows.Forms.Button btnAddEx;
        private System.Windows.Forms.ComboBox cboSourceEx;
        private System.Windows.Forms.TextBox txtDescriptionEx;
        private System.Windows.Forms.TextBox txtAmountEx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}