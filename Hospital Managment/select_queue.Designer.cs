namespace Hospital_Managment
{
    partial class select_queue
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
            this.back_next_pateint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clinic4 = new System.Windows.Forms.Button();
            this.clinic3 = new System.Windows.Forms.Button();
            this.internist_q = new System.Windows.Forms.Button();
            this.clinic1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back_next_pateint
            // 
            this.back_next_pateint.Location = new System.Drawing.Point(34, 661);
            this.back_next_pateint.Name = "back_next_pateint";
            this.back_next_pateint.Size = new System.Drawing.Size(115, 52);
            this.back_next_pateint.TabIndex = 18;
            this.back_next_pateint.Text = "Back";
            this.back_next_pateint.UseVisualStyleBackColor = true;
            this.back_next_pateint.Click += new System.EventHandler(this.back_next_pateint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(231, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 46);
            this.label1.TabIndex = 17;
            this.label1.Text = "Choose the clinic to view queue";
            // 
            // clinic4
            // 
            this.clinic4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clinic4.Location = new System.Drawing.Point(619, 466);
            this.clinic4.Margin = new System.Windows.Forms.Padding(4);
            this.clinic4.Name = "clinic4";
            this.clinic4.Size = new System.Drawing.Size(267, 189);
            this.clinic4.TabIndex = 16;
            this.clinic4.Text = "Eye Clinic";
            this.clinic4.UseVisualStyleBackColor = true;
            this.clinic4.Click += new System.EventHandler(this.clinic4_Click);
            // 
            // clinic3
            // 
            this.clinic3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clinic3.Location = new System.Drawing.Point(205, 466);
            this.clinic3.Margin = new System.Windows.Forms.Padding(4);
            this.clinic3.Name = "clinic3";
            this.clinic3.Size = new System.Drawing.Size(267, 189);
            this.clinic3.TabIndex = 15;
            this.clinic3.Text = "Orthopedic Clinic\n";
            this.clinic3.UseVisualStyleBackColor = true;
            this.clinic3.Click += new System.EventHandler(this.clinic3_Click);
            // 
            // internist_q
            // 
            this.internist_q.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.internist_q.Location = new System.Drawing.Point(619, 201);
            this.internist_q.Margin = new System.Windows.Forms.Padding(4);
            this.internist_q.Name = "internist_q";
            this.internist_q.Size = new System.Drawing.Size(267, 187);
            this.internist_q.TabIndex = 14;
            this.internist_q.Text = "Internist Clinic\n";
            this.internist_q.UseVisualStyleBackColor = true;
            this.internist_q.Click += new System.EventHandler(this.internist_q_Click);
            // 
            // clinic1
            // 
            this.clinic1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clinic1.Location = new System.Drawing.Point(205, 201);
            this.clinic1.Margin = new System.Windows.Forms.Padding(4);
            this.clinic1.Name = "clinic1";
            this.clinic1.Size = new System.Drawing.Size(267, 187);
            this.clinic1.TabIndex = 13;
            this.clinic1.Text = "Dental Clinic\n";
            this.clinic1.UseVisualStyleBackColor = true;
            this.clinic1.Click += new System.EventHandler(this.clinic1_Click);
            // 
            // select_queue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hospital_Managment.Properties.Resources.wallpaperflare_com_wallpaper;
            this.ClientSize = new System.Drawing.Size(1089, 753);
            this.Controls.Add(this.back_next_pateint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clinic4);
            this.Controls.Add(this.clinic3);
            this.Controls.Add(this.internist_q);
            this.Controls.Add(this.clinic1);
            this.Name = "select_queue";
            this.Text = "select queue";
            this.Load += new System.EventHandler(this.select_queue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_next_pateint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clinic4;
        private System.Windows.Forms.Button clinic3;
        private System.Windows.Forms.Button internist_q;
        private System.Windows.Forms.Button clinic1;
    }
}