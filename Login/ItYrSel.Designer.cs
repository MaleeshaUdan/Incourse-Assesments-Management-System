namespace Login
{
    partial class ItYrSel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItYrSel));
            this.btnit1yr = new System.Windows.Forms.Button();
            this.btnit2yr = new System.Windows.Forms.Button();
            this.btnit3yr = new System.Windows.Forms.Button();
            this.btnit4yr = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnit1yr
            // 
            this.btnit1yr.BackColor = System.Drawing.Color.Azure;
            this.btnit1yr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnit1yr.Location = new System.Drawing.Point(401, 31);
            this.btnit1yr.Name = "btnit1yr";
            this.btnit1yr.Size = new System.Drawing.Size(298, 51);
            this.btnit1yr.TabIndex = 0;
            this.btnit1yr.Text = "1 Year";
            this.btnit1yr.UseVisualStyleBackColor = false;
            this.btnit1yr.Click += new System.EventHandler(this.btnit1yr_Click);
            // 
            // btnit2yr
            // 
            this.btnit2yr.BackColor = System.Drawing.Color.Azure;
            this.btnit2yr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnit2yr.Location = new System.Drawing.Point(401, 128);
            this.btnit2yr.Name = "btnit2yr";
            this.btnit2yr.Size = new System.Drawing.Size(298, 51);
            this.btnit2yr.TabIndex = 1;
            this.btnit2yr.Text = "2 Year";
            this.btnit2yr.UseVisualStyleBackColor = false;
            this.btnit2yr.Click += new System.EventHandler(this.btnit2yr_Click);
            // 
            // btnit3yr
            // 
            this.btnit3yr.BackColor = System.Drawing.Color.Azure;
            this.btnit3yr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnit3yr.Location = new System.Drawing.Point(401, 228);
            this.btnit3yr.Name = "btnit3yr";
            this.btnit3yr.Size = new System.Drawing.Size(298, 51);
            this.btnit3yr.TabIndex = 2;
            this.btnit3yr.Text = "3 Year";
            this.btnit3yr.UseVisualStyleBackColor = false;
            this.btnit3yr.Click += new System.EventHandler(this.btnit3yr_Click);
            // 
            // btnit4yr
            // 
            this.btnit4yr.BackColor = System.Drawing.Color.Azure;
            this.btnit4yr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnit4yr.Location = new System.Drawing.Point(401, 332);
            this.btnit4yr.Name = "btnit4yr";
            this.btnit4yr.Size = new System.Drawing.Size(298, 51);
            this.btnit4yr.TabIndex = 3;
            this.btnit4yr.Text = "4 Year";
            this.btnit4yr.UseVisualStyleBackColor = false;
            this.btnit4yr.Click += new System.EventHandler(this.btnit4yr_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Azure;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Blue;
            this.btnBack.Location = new System.Drawing.Point(339, 453);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(423, 51);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Login.Properties.Resources.garduate_hat_Image;
            this.pictureBox1.Location = new System.Drawing.Point(36, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 432);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ItYrSel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.yrselec_BackGround_Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 533);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnit4yr);
            this.Controls.Add(this.btnit3yr);
            this.Controls.Add(this.btnit2yr);
            this.Controls.Add(this.btnit1yr);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItYrSel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Year Selection Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnit1yr;
        private System.Windows.Forms.Button btnit2yr;
        private System.Windows.Forms.Button btnit3yr;
        private System.Windows.Forms.Button btnit4yr;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}