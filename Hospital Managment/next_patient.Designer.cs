namespace Hospital_Managment
{
    partial class next_p_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(next_p_form));
            this.label1 = new System.Windows.Forms.Label();
            this.clinic4 = new System.Windows.Forms.Button();
            this.clinic3 = new System.Windows.Forms.Button();
            this.internist_q = new System.Windows.Forms.Button();
            this.clinic1 = new System.Windows.Forms.Button();
            this.new_p_label = new System.Windows.Forms.Label();
            this.back_next_pateint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(371, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose the clinic";
            // 
            // clinic4
            // 
            this.clinic4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clinic4.Location = new System.Drawing.Point(607, 453);
            this.clinic4.Margin = new System.Windows.Forms.Padding(4);
            this.clinic4.Name = "clinic4";
            this.clinic4.Size = new System.Drawing.Size(228, 156);
            this.clinic4.TabIndex = 9;
            this.clinic4.Text = "Eye Clinic";
            this.clinic4.UseVisualStyleBackColor = true;
            this.clinic4.Click += new System.EventHandler(this.clinic4_Click);
            // 
            // clinic3
            // 
            this.clinic3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clinic3.Location = new System.Drawing.Point(241, 453);
            this.clinic3.Margin = new System.Windows.Forms.Padding(4);
            this.clinic3.Name = "clinic3";
            this.clinic3.Size = new System.Drawing.Size(228, 156);
            this.clinic3.TabIndex = 8;
            this.clinic3.Text = "Orthopedic Clinic\n";
            this.clinic3.UseVisualStyleBackColor = true;
            this.clinic3.Click += new System.EventHandler(this.clinic3_Click);
            // 
            // internist_q
            // 
            this.internist_q.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.internist_q.Location = new System.Drawing.Point(607, 244);
            this.internist_q.Margin = new System.Windows.Forms.Padding(4);
            this.internist_q.Name = "internist_q";
            this.internist_q.Size = new System.Drawing.Size(228, 154);
            this.internist_q.TabIndex = 7;
            this.internist_q.Text = "Internist Clinic\n";
            this.internist_q.UseVisualStyleBackColor = true;
            this.internist_q.Click += new System.EventHandler(this.internist_q_Click);
            // 
            // clinic1
            // 
            this.clinic1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clinic1.Location = new System.Drawing.Point(241, 244);
            this.clinic1.Margin = new System.Windows.Forms.Padding(4);
            this.clinic1.Name = "clinic1";
            this.clinic1.Size = new System.Drawing.Size(228, 154);
            this.clinic1.TabIndex = 6;
            this.clinic1.Text = "Dental Clinic\n";
            this.clinic1.UseVisualStyleBackColor = true;
            this.clinic1.Click += new System.EventHandler(this.clinic1_Click);
            // 
            // new_p_label
            // 
            this.new_p_label.AutoSize = true;
            this.new_p_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_p_label.Location = new System.Drawing.Point(373, 138);
            this.new_p_label.Name = "new_p_label";
            this.new_p_label.Size = new System.Drawing.Size(342, 36);
            this.new_p_label.TabIndex = 10;
            this.new_p_label.Text = "Next patient name here";
            // 
            // back_next_pateint
            // 
            this.back_next_pateint.Location = new System.Drawing.Point(35, 605);
            this.back_next_pateint.Name = "back_next_pateint";
            this.back_next_pateint.Size = new System.Drawing.Size(110, 47);
            this.back_next_pateint.TabIndex = 11;
            this.back_next_pateint.Text = "Back";
            this.back_next_pateint.UseVisualStyleBackColor = true;
            this.back_next_pateint.Click += new System.EventHandler(this.back_next_pateint_Click);
            // 
            // next_p_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1091, 678);
            this.Controls.Add(this.back_next_pateint);
            this.Controls.Add(this.new_p_label);
            this.Controls.Add(this.clinic4);
            this.Controls.Add(this.clinic3);
            this.Controls.Add(this.internist_q);
            this.Controls.Add(this.clinic1);
            this.Controls.Add(this.label1);
            this.Name = "next_p_form";
            this.Text = "Next patient";
            this.Load += new System.EventHandler(this.next_p_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clinic4;
        private System.Windows.Forms.Button clinic3;
        private System.Windows.Forms.Button internist_q;
        private System.Windows.Forms.Button clinic1;
        private System.Windows.Forms.Label new_p_label;
        private System.Windows.Forms.Button back_next_pateint;
    }
}