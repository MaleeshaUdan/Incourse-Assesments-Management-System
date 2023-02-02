namespace Login
{
    partial class AppIt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppIt));
            this.Dashbord = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.dashBoardPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dashBoardPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Dashbord
            // 
            this.Dashbord.AutoSize = true;
            this.Dashbord.BackColor = System.Drawing.Color.Transparent;
            this.Dashbord.Font = new System.Drawing.Font("Bernard MT Condensed", 55.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashbord.ForeColor = System.Drawing.Color.Azure;
            this.Dashbord.Location = new System.Drawing.Point(233, 19);
            this.Dashbord.Name = "Dashbord";
            this.Dashbord.Size = new System.Drawing.Size(434, 111);
            this.Dashbord.TabIndex = 0;
            this.Dashbord.Text = "Dashboard";
            this.Dashbord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.Font = new System.Drawing.Font("Abhaya Libre", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(249, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(375, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "ICA Details";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Azure;
            this.btnback.Font = new System.Drawing.Font("Abhaya Libre", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.Navy;
            this.btnback.Location = new System.Drawing.Point(249, 415);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(375, 63);
            this.btnback.TabIndex = 3;
            this.btnback.Text = "Back To Login Page";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.button3_Click);
            // 
            // dashBoardPicBox
            // 
            this.dashBoardPicBox.BackColor = System.Drawing.Color.Transparent;
            this.dashBoardPicBox.Image = global::Login.Properties.Resources.dashBoardPicBox;
            this.dashBoardPicBox.Location = new System.Drawing.Point(38, 152);
            this.dashBoardPicBox.Name = "dashBoardPicBox";
            this.dashBoardPicBox.Size = new System.Drawing.Size(606, 401);
            this.dashBoardPicBox.TabIndex = 4;
            this.dashBoardPicBox.TabStop = false;
            // 
            // AppIt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::Login.Properties.Resources.LoginFrm_Background_Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 593);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dashbord);
            this.Controls.Add(this.dashBoardPicBox);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppIt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Applied Science IT";
            this.Load += new System.EventHandler(this.AppIt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dashBoardPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dashbord;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.PictureBox dashBoardPicBox;
    }
}