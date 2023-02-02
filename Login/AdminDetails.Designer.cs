namespace Login
{
    partial class AdminDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDetails));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtrepass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.btnCreAdmin = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnUpdPass = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelAdmin = new System.Windows.Forms.Button();
            this.btnCheckRec = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(77, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(77, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtrepass
            // 
            this.txtrepass.Location = new System.Drawing.Point(289, 232);
            this.txtrepass.Name = "txtrepass";
            this.txtrepass.Size = new System.Drawing.Size(303, 27);
            this.txtrepass.TabIndex = 5;
            this.txtrepass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(77, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Re-Enter Password";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(289, 163);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(303, 27);
            this.txtpass.TabIndex = 6;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(289, 99);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(303, 27);
            this.txtuser.TabIndex = 7;
            // 
            // btnCreAdmin
            // 
            this.btnCreAdmin.BackColor = System.Drawing.Color.Azure;
            this.btnCreAdmin.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnCreAdmin.Location = new System.Drawing.Point(81, 397);
            this.btnCreAdmin.Name = "btnCreAdmin";
            this.btnCreAdmin.Size = new System.Drawing.Size(225, 51);
            this.btnCreAdmin.TabIndex = 8;
            this.btnCreAdmin.Text = "Create Admin";
            this.btnCreAdmin.UseVisualStyleBackColor = false;
            this.btnCreAdmin.Click += new System.EventHandler(this.btnCreAdmin_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.Color.Azure;
            this.checkBox1.Location = new System.Drawing.Point(289, 274);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(164, 24);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnUpdPass
            // 
            this.btnUpdPass.BackColor = System.Drawing.Color.Azure;
            this.btnUpdPass.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnUpdPass.Location = new System.Drawing.Point(358, 397);
            this.btnUpdPass.Name = "btnUpdPass";
            this.btnUpdPass.Size = new System.Drawing.Size(234, 51);
            this.btnUpdPass.TabIndex = 10;
            this.btnUpdPass.Text = "Update Password";
            this.btnUpdPass.UseVisualStyleBackColor = false;
            this.btnUpdPass.Click += new System.EventHandler(this.btnUpdPass_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(676, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(499, 510);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnDelAdmin
            // 
            this.btnDelAdmin.BackColor = System.Drawing.Color.Azure;
            this.btnDelAdmin.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnDelAdmin.Location = new System.Drawing.Point(81, 502);
            this.btnDelAdmin.Name = "btnDelAdmin";
            this.btnDelAdmin.Size = new System.Drawing.Size(225, 51);
            this.btnDelAdmin.TabIndex = 12;
            this.btnDelAdmin.Text = "Delete Admin";
            this.btnDelAdmin.UseVisualStyleBackColor = false;
            this.btnDelAdmin.Click += new System.EventHandler(this.btnDelAdmin_Click);
            // 
            // btnCheckRec
            // 
            this.btnCheckRec.BackColor = System.Drawing.Color.Azure;
            this.btnCheckRec.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnCheckRec.Location = new System.Drawing.Point(358, 502);
            this.btnCheckRec.Name = "btnCheckRec";
            this.btnCheckRec.Size = new System.Drawing.Size(234, 51);
            this.btnCheckRec.TabIndex = 13;
            this.btnCheckRec.Text = "No Of Records";
            this.btnCheckRec.UseVisualStyleBackColor = false;
            this.btnCheckRec.Click += new System.EventHandler(this.btnCheckRec_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Azure;
            this.btnBack.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBack.Location = new System.Drawing.Point(997, 667);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(178, 50);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Azure;
            this.btnHome.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnHome.Location = new System.Drawing.Point(219, 597);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(234, 51);
            this.btnHome.TabIndex = 15;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // AdminDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.yrselec_BackGround_Image1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1199, 740);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCheckRec);
            this.Controls.Add(this.btnDelAdmin);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdPass);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnCreAdmin);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtrepass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminDetails";
            this.Text = "Admin Details";
            this.Load += new System.EventHandler(this.AdminDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtrepass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Button btnCreAdmin;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnUpdPass;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelAdmin;
        private System.Windows.Forms.Button btnCheckRec;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnHome;
    }
}