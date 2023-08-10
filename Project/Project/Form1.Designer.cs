namespace Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBudget = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSlider = new System.Windows.Forms.Panel();
            this.homePanel = new System.Windows.Forms.Panel();
            this.iconRestore = new System.Windows.Forms.PictureBox();
            this.iconExit = new System.Windows.Forms.PictureBox();
            this.iconMax = new System.Windows.Forms.PictureBox();
            this.iconMin = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(180)))), ((int)(((byte)(236)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnBudget);
            this.panel1.Controls.Add(this.btnTransactions);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 583);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(0, 451);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(209, 101);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBudget
            // 
            this.btnBudget.FlatAppearance.BorderSize = 0;
            this.btnBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBudget.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBudget.ForeColor = System.Drawing.Color.White;
            this.btnBudget.Image = ((System.Drawing.Image)(resources.GetObject("btnBudget.Image")));
            this.btnBudget.Location = new System.Drawing.Point(0, 344);
            this.btnBudget.Name = "btnBudget";
            this.btnBudget.Size = new System.Drawing.Size(209, 101);
            this.btnBudget.TabIndex = 3;
            this.btnBudget.Text = "Budget";
            this.btnBudget.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBudget.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBudget.UseVisualStyleBackColor = true;
            this.btnBudget.Click += new System.EventHandler(this.btnBudget_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.FlatAppearance.BorderSize = 0;
            this.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactions.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.ForeColor = System.Drawing.Color.White;
            this.btnTransactions.Image = ((System.Drawing.Image)(resources.GetObject("btnTransactions.Image")));
            this.btnTransactions.Location = new System.Drawing.Point(0, 237);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(209, 101);
            this.btnTransactions.TabIndex = 2;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTransactions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 130);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(209, 101);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(76)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Vivaldi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(76)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 104);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vladimir Script", 33F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(180)))), ((int)(((byte)(236)))));
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Finance";
            // 
            // panelSlider
            // 
            this.panelSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(76)))));
            this.panelSlider.Location = new System.Drawing.Point(209, 130);
            this.panelSlider.Name = "panelSlider";
            this.panelSlider.Size = new System.Drawing.Size(12, 101);
            this.panelSlider.TabIndex = 2;
            // 
            // homePanel
            // 
            this.homePanel.ForeColor = System.Drawing.Color.Black;
            this.homePanel.Location = new System.Drawing.Point(227, 34);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(716, 549);
            this.homePanel.TabIndex = 8;
            // 
            // iconRestore
            // 
            this.iconRestore.Image = ((System.Drawing.Image)(resources.GetObject("iconRestore.Image")));
            this.iconRestore.Location = new System.Drawing.Point(886, 8);
            this.iconRestore.Name = "iconRestore";
            this.iconRestore.Size = new System.Drawing.Size(20, 20);
            this.iconRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconRestore.TabIndex = 5;
            this.iconRestore.TabStop = false;
            this.iconRestore.Click += new System.EventHandler(this.iconRestore_Click);
            // 
            // iconExit
            // 
            this.iconExit.Image = ((System.Drawing.Image)(resources.GetObject("iconExit.Image")));
            this.iconExit.Location = new System.Drawing.Point(912, 8);
            this.iconExit.Name = "iconExit";
            this.iconExit.Size = new System.Drawing.Size(20, 20);
            this.iconExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconExit.TabIndex = 4;
            this.iconExit.TabStop = false;
            this.iconExit.Click += new System.EventHandler(this.iconExit_Click);
            // 
            // iconMax
            // 
            this.iconMax.Image = ((System.Drawing.Image)(resources.GetObject("iconMax.Image")));
            this.iconMax.Location = new System.Drawing.Point(886, 8);
            this.iconMax.Name = "iconMax";
            this.iconMax.Size = new System.Drawing.Size(20, 20);
            this.iconMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMax.TabIndex = 6;
            this.iconMax.TabStop = false;
            this.iconMax.Visible = false;
            this.iconMax.Click += new System.EventHandler(this.iconMax_Click);
            // 
            // iconMin
            // 
            this.iconMin.Image = ((System.Drawing.Image)(resources.GetObject("iconMin.Image")));
            this.iconMin.Location = new System.Drawing.Point(860, 8);
            this.iconMin.Name = "iconMin";
            this.iconMin.Size = new System.Drawing.Size(20, 20);
            this.iconMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMin.TabIndex = 7;
            this.iconMin.TabStop = false;
            this.iconMin.Click += new System.EventHandler(this.iconMin_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 583);
            this.Controls.Add(this.iconMax);
            this.Controls.Add(this.iconMin);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.iconExit);
            this.Controls.Add(this.panelSlider);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconRestore);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBudget;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelSlider;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.PictureBox iconRestore;
        private System.Windows.Forms.PictureBox iconExit;
        private System.Windows.Forms.PictureBox iconMax;
        private System.Windows.Forms.PictureBox iconMin;
    }
}

