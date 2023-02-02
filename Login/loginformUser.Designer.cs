namespace Login
{
    partial class loginformUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginformUser));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.extbtn = new System.Windows.Forms.Button();
            this.logbtn = new System.Windows.Forms.Button();
            this.btnclr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(792, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "ICA Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Abhaya Libre", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(133, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Abhaya Libre", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(133, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // usertxt
            // 
            this.usertxt.Font = new System.Drawing.Font("Abhaya Libre", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxt.Location = new System.Drawing.Point(366, 196);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(353, 31);
            this.usertxt.TabIndex = 3;
            // 
            // passtxt
            // 
            this.passtxt.Font = new System.Drawing.Font("Abhaya Libre", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.Location = new System.Drawing.Point(366, 294);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(353, 31);
            this.passtxt.TabIndex = 4;
            this.passtxt.UseSystemPasswordChar = true;
            // 
            // extbtn
            // 
            this.extbtn.BackColor = System.Drawing.Color.Azure;
            this.extbtn.Font = new System.Drawing.Font("Abhaya Libre", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extbtn.ForeColor = System.Drawing.Color.Navy;
            this.extbtn.Location = new System.Drawing.Point(139, 470);
            this.extbtn.Name = "extbtn";
            this.extbtn.Size = new System.Drawing.Size(155, 55);
            this.extbtn.TabIndex = 5;
            this.extbtn.Text = "Back";
            this.extbtn.UseVisualStyleBackColor = false;
            this.extbtn.Click += new System.EventHandler(this.extbtn_Click);
            // 
            // logbtn
            // 
            this.logbtn.BackColor = System.Drawing.Color.Azure;
            this.logbtn.Font = new System.Drawing.Font("Abhaya Libre", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logbtn.ForeColor = System.Drawing.Color.Navy;
            this.logbtn.Location = new System.Drawing.Point(564, 470);
            this.logbtn.Name = "logbtn";
            this.logbtn.Size = new System.Drawing.Size(155, 55);
            this.logbtn.TabIndex = 6;
            this.logbtn.Text = "Log";
            this.logbtn.UseVisualStyleBackColor = false;
            this.logbtn.Click += new System.EventHandler(this.logbtn_Click);
            // 
            // btnclr
            // 
            this.btnclr.BackColor = System.Drawing.Color.Azure;
            this.btnclr.Font = new System.Drawing.Font("Abhaya Libre", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclr.ForeColor = System.Drawing.Color.Navy;
            this.btnclr.Location = new System.Drawing.Point(612, 358);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(107, 44);
            this.btnclr.TabIndex = 7;
            this.btnclr.Text = "Clear";
            this.btnclr.UseVisualStyleBackColor = false;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // loginformUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::Login.Properties.Resources.LoginFrm_Background_Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(862, 573);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.logbtn);
            this.Controls.Add(this.extbtn);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loginformUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Login";
            this.Load += new System.EventHandler(this.loginfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Button extbtn;
        private System.Windows.Forms.Button logbtn;
        private System.Windows.Forms.Button btnclr;
    }
}

