
namespace library_mngt
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btncancel = new MetroFramework.Controls.MetroButton();
            this.btnlogin = new MetroFramework.Controls.MetroButton();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lbldatabase = new System.Windows.Forms.Label();
            this.lblserver = new System.Windows.Forms.Label();
            this.txtpassword = new MetroFramework.Controls.MetroTextBox();
            this.txtusername = new MetroFramework.Controls.MetroTextBox();
            this.txtdatabase = new MetroFramework.Controls.MetroTextBox();
            this.txtserver = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel1.Controls.Add(this.btncancel);
            this.metroPanel1.Controls.Add(this.btnlogin);
            this.metroPanel1.Controls.Add(this.lblpassword);
            this.metroPanel1.Controls.Add(this.lblUsername);
            this.metroPanel1.Controls.Add(this.lbldatabase);
            this.metroPanel1.Controls.Add(this.lblserver);
            this.metroPanel1.Controls.Add(this.txtpassword);
            this.metroPanel1.Controls.Add(this.txtusername);
            this.metroPanel1.Controls.Add(this.txtdatabase);
            this.metroPanel1.Controls.Add(this.txtserver);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(9, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(344, 382);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(224, 239);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 11;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseSelectable = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(117, 239);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 10;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseSelectable = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(34, 200);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(86, 23);
            this.lblpassword.TabIndex = 9;
            this.lblpassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(24, 156);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(91, 23);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Username";
            // 
            // lbldatabase
            // 
            this.lbldatabase.AutoSize = true;
            this.lbldatabase.BackColor = System.Drawing.Color.Transparent;
            this.lbldatabase.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatabase.Location = new System.Drawing.Point(24, 109);
            this.lbldatabase.Name = "lbldatabase";
            this.lbldatabase.Size = new System.Drawing.Size(84, 23);
            this.lbldatabase.TabIndex = 7;
            this.lbldatabase.Text = "Database";
            // 
            // lblserver
            // 
            this.lblserver.AutoSize = true;
            this.lblserver.BackColor = System.Drawing.Color.Transparent;
            this.lblserver.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblserver.Location = new System.Drawing.Point(24, 66);
            this.lblserver.Name = "lblserver";
            this.lblserver.Size = new System.Drawing.Size(62, 23);
            this.lblserver.TabIndex = 6;
            this.lblserver.Text = "Server";
            // 
            // txtpassword
            // 
            // 
            // 
            // 
            this.txtpassword.CustomButton.Image = null;
            this.txtpassword.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtpassword.CustomButton.Name = "";
            this.txtpassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtpassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpassword.CustomButton.TabIndex = 1;
            this.txtpassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpassword.CustomButton.UseSelectable = true;
            this.txtpassword.CustomButton.Visible = false;
            this.txtpassword.Lines = new string[] {
        "12345"};
            this.txtpassword.Location = new System.Drawing.Point(145, 200);
            this.txtpassword.MaxLength = 32767;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '.';
            this.txtpassword.PromptText = "Password";
            this.txtpassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpassword.SelectedText = "";
            this.txtpassword.SelectionLength = 0;
            this.txtpassword.SelectionStart = 0;
            this.txtpassword.ShortcutsEnabled = true;
            this.txtpassword.Size = new System.Drawing.Size(154, 23);
            this.txtpassword.TabIndex = 5;
            this.txtpassword.Text = "12345";
            this.txtpassword.UseSelectable = true;
            this.txtpassword.WaterMark = "Password";
            this.txtpassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown_click);
            // 
            // txtusername
            // 
            // 
            // 
            // 
            this.txtusername.CustomButton.Image = null;
            this.txtusername.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtusername.CustomButton.Name = "";
            this.txtusername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtusername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtusername.CustomButton.TabIndex = 1;
            this.txtusername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtusername.CustomButton.UseSelectable = true;
            this.txtusername.CustomButton.Visible = false;
            this.txtusername.Lines = new string[] {
        "bijay"};
            this.txtusername.Location = new System.Drawing.Point(145, 156);
            this.txtusername.MaxLength = 32767;
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.PromptText = "Username";
            this.txtusername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtusername.SelectedText = "";
            this.txtusername.SelectionLength = 0;
            this.txtusername.SelectionStart = 0;
            this.txtusername.ShortcutsEnabled = true;
            this.txtusername.Size = new System.Drawing.Size(154, 23);
            this.txtusername.TabIndex = 4;
            this.txtusername.Text = "bijay";
            this.txtusername.UseSelectable = true;
            this.txtusername.WaterMark = "Username";
            this.txtusername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtusername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtdatabase
            // 
            // 
            // 
            // 
            this.txtdatabase.CustomButton.Image = null;
            this.txtdatabase.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtdatabase.CustomButton.Name = "";
            this.txtdatabase.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtdatabase.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtdatabase.CustomButton.TabIndex = 1;
            this.txtdatabase.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtdatabase.CustomButton.UseSelectable = true;
            this.txtdatabase.CustomButton.Visible = false;
            this.txtdatabase.Lines = new string[0];
            this.txtdatabase.Location = new System.Drawing.Point(145, 109);
            this.txtdatabase.MaxLength = 32767;
            this.txtdatabase.Name = "txtdatabase";
            this.txtdatabase.PasswordChar = '\0';
            this.txtdatabase.PromptText = "Database";
            this.txtdatabase.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtdatabase.SelectedText = "";
            this.txtdatabase.SelectionLength = 0;
            this.txtdatabase.SelectionStart = 0;
            this.txtdatabase.ShortcutsEnabled = true;
            this.txtdatabase.Size = new System.Drawing.Size(154, 23);
            this.txtdatabase.TabIndex = 3;
            this.txtdatabase.UseSelectable = true;
            this.txtdatabase.WaterMark = "Database";
            this.txtdatabase.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtdatabase.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtserver
            // 
            // 
            // 
            // 
            this.txtserver.CustomButton.Image = null;
            this.txtserver.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtserver.CustomButton.Name = "";
            this.txtserver.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtserver.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtserver.CustomButton.TabIndex = 1;
            this.txtserver.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtserver.CustomButton.UseSelectable = true;
            this.txtserver.CustomButton.Visible = false;
            this.txtserver.Lines = new string[0];
            this.txtserver.Location = new System.Drawing.Point(145, 66);
            this.txtserver.MaxLength = 32767;
            this.txtserver.Name = "txtserver";
            this.txtserver.PasswordChar = '\0';
            this.txtserver.PromptText = "Server";
            this.txtserver.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtserver.SelectedText = "";
            this.txtserver.SelectionLength = 0;
            this.txtserver.SelectionStart = 0;
            this.txtserver.ShortcutsEnabled = true;
            this.txtserver.Size = new System.Drawing.Size(154, 23);
            this.txtserver.TabIndex = 2;
            this.txtserver.UseSelectable = true;
            this.txtserver.WaterMark = "Server";
            this.txtserver.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtserver.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 450);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Login";
            this.Text = "Login";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lbldatabase;
        private System.Windows.Forms.Label lblserver;
        private MetroFramework.Controls.MetroTextBox txtpassword;
        private MetroFramework.Controls.MetroTextBox txtusername;
        private MetroFramework.Controls.MetroTextBox txtdatabase;
        private MetroFramework.Controls.MetroTextBox txtserver;
        private MetroFramework.Controls.MetroButton btncancel;
        private MetroFramework.Controls.MetroButton btnlogin;
    }
}

