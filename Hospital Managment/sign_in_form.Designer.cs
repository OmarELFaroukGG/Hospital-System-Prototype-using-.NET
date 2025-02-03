namespace Hospital_Managment
{
    partial class sign_in_form
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
            this.Welcome = new System.Windows.Forms.Label();
            this.log_in = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picture_name = new System.Windows.Forms.PictureBox();
            this.sign_in_button = new System.Windows.Forms.Button();
            this.text_password = new System.Windows.Forms.TextBox();
            this.text_name = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.log_in.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_name)).BeginInit();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.BackColor = System.Drawing.Color.Transparent;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.Welcome.Location = new System.Drawing.Point(195, 46);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(686, 44);
            this.Welcome.TabIndex = 1;
            this.Welcome.Text = "Welcome To Hospital Managment System";
            this.Welcome.Click += new System.EventHandler(this.Welcome_Click);
            // 
            // log_in
            // 
            this.log_in.BackColor = System.Drawing.Color.Transparent;
            this.log_in.Controls.Add(this.pictureBox1);
            this.log_in.Controls.Add(this.picture_name);
            this.log_in.Controls.Add(this.sign_in_button);
            this.log_in.Controls.Add(this.text_password);
            this.log_in.Controls.Add(this.text_name);
            this.log_in.Controls.Add(this.Password);
            this.log_in.Controls.Add(this.Name_label);
            this.log_in.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_in.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.log_in.Location = new System.Drawing.Point(193, 148);
            this.log_in.Margin = new System.Windows.Forms.Padding(4);
            this.log_in.Name = "log_in";
            this.log_in.Padding = new System.Windows.Forms.Padding(4);
            this.log_in.Size = new System.Drawing.Size(688, 374);
            this.log_in.TabIndex = 17;
            this.log_in.TabStop = false;
            this.log_in.Text = "Log In";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Hospital_Managment.Properties.Resources.icons8_key_30;
            this.pictureBox1.Location = new System.Drawing.Point(84, 171);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 46);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // picture_name
            // 
            this.picture_name.BackColor = System.Drawing.Color.Transparent;
            this.picture_name.Image = global::Hospital_Managment.Properties.Resources.icons8_person_30;
            this.picture_name.Location = new System.Drawing.Point(84, 66);
            this.picture_name.Margin = new System.Windows.Forms.Padding(4);
            this.picture_name.Name = "picture_name";
            this.picture_name.Size = new System.Drawing.Size(51, 54);
            this.picture_name.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picture_name.TabIndex = 22;
            this.picture_name.TabStop = false;
            this.picture_name.Click += new System.EventHandler(this.picture_name_Click);
            // 
            // sign_in_button
            // 
            this.sign_in_button.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_in_button.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.sign_in_button.Location = new System.Drawing.Point(267, 265);
            this.sign_in_button.Margin = new System.Windows.Forms.Padding(4);
            this.sign_in_button.Name = "sign_in_button";
            this.sign_in_button.Size = new System.Drawing.Size(111, 39);
            this.sign_in_button.TabIndex = 21;
            this.sign_in_button.Text = "Log in";
            this.sign_in_button.UseVisualStyleBackColor = true;
            this.sign_in_button.Click += new System.EventHandler(this.sign_in_button_Click_2);
            // 
            // text_password
            // 
            this.text_password.Location = new System.Drawing.Point(267, 171);
            this.text_password.Margin = new System.Windows.Forms.Padding(4);
            this.text_password.Name = "text_password";
            this.text_password.PasswordChar = '*';
            this.text_password.Size = new System.Drawing.Size(287, 39);
            this.text_password.TabIndex = 20;
            // 
            // text_name
            // 
            this.text_name.BackColor = System.Drawing.Color.White;
            this.text_name.Location = new System.Drawing.Point(267, 84);
            this.text_name.Margin = new System.Windows.Forms.Padding(4);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(287, 39);
            this.text_name.TabIndex = 19;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.White;
            this.Password.Location = new System.Drawing.Point(143, 181);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(101, 26);
            this.Password.TabIndex = 18;
            this.Password.Text = "Password";
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.BackColor = System.Drawing.Color.Transparent;
            this.Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_label.ForeColor = System.Drawing.Color.White;
            this.Name_label.Location = new System.Drawing.Point(143, 84);
            this.Name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(68, 25);
            this.Name_label.TabIndex = 17;
            this.Name_label.Text = "Name";
            // 
            // sign_in_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hospital_Managment.Properties.Resources.wallpaperflare_com_wallpaper;
            this.ClientSize = new System.Drawing.Size(1091, 678);
            this.Controls.Add(this.log_in);
            this.Controls.Add(this.Welcome);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "sign_in_form";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.sign_in_form_Load);
            this.log_in.ResumeLayout(false);
            this.log_in.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_name)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.GroupBox log_in;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picture_name;
        private System.Windows.Forms.Button sign_in_button;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Name_label;
    }
}