
namespace Grocery_Store_Management_System_01
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AdministratorLoginButton = new System.Windows.Forms.Button();
            this.CashierLoginButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Grocery_Store_Management_System_01.Properties.Resources.SuperMartLogo;
            this.pictureBox1.Location = new System.Drawing.Point(326, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Super Mart";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AdministratorLoginButton
            // 
            this.AdministratorLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AdministratorLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdministratorLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdministratorLoginButton.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdministratorLoginButton.ForeColor = System.Drawing.Color.Green;
            this.AdministratorLoginButton.Location = new System.Drawing.Point(300, 344);
            this.AdministratorLoginButton.Name = "AdministratorLoginButton";
            this.AdministratorLoginButton.Size = new System.Drawing.Size(197, 37);
            this.AdministratorLoginButton.TabIndex = 2;
            this.AdministratorLoginButton.Text = "Administrator Login";
            this.AdministratorLoginButton.UseVisualStyleBackColor = false;
            // 
            // CashierLoginButton
            // 
            this.CashierLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CashierLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CashierLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CashierLoginButton.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierLoginButton.ForeColor = System.Drawing.Color.Green;
            this.CashierLoginButton.Location = new System.Drawing.Point(300, 292);
            this.CashierLoginButton.Name = "CashierLoginButton";
            this.CashierLoginButton.Size = new System.Drawing.Size(197, 37);
            this.CashierLoginButton.TabIndex = 2;
            this.CashierLoginButton.Text = "Cashier Login";
            this.CashierLoginButton.UseVisualStyleBackColor = false;
            this.CashierLoginButton.Click += new System.EventHandler(this.CashierLoginButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(544, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grocery Store Management System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExitButton.Location = new System.Drawing.Point(340, 422);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(114, 27);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Grocery_Store_Management_System_01.Properties.Resources.Perfect_White_Gradient_4K_Wallpaper_7314;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 461);
            this.Controls.Add(this.CashierLoginButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AdministratorLoginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(825, 500);
            this.MinimumSize = new System.Drawing.Size(825, 500);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Mart";
            this.Load += new System.EventHandler(this.StartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AdministratorLoginButton;
        private System.Windows.Forms.Button CashierLoginButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExitButton;
    }
}

