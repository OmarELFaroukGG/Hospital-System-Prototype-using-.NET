namespace Hospital_Managment
{
    partial class add_new_patient
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
            this.new_patient_info = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Patient_Phone = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Patient_Status = new System.Windows.Forms.Label();
            this.clinics_list = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picture_name = new System.Windows.Forms.PictureBox();
            this.sign_in_button = new System.Windows.Forms.Button();
            this.text_name = new System.Windows.Forms.TextBox();
            this.patient_clinic = new System.Windows.Forms.Label();
            this.patient_name = new System.Windows.Forms.Label();
            this.adding_new_patient = new System.Windows.Forms.Label();
            this.Back_add_patient = new System.Windows.Forms.Button();
            this.new_patient_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_name)).BeginInit();
            this.SuspendLayout();
            // 
            // new_patient_info
            // 
            this.new_patient_info.BackColor = System.Drawing.Color.Transparent;
            this.new_patient_info.Controls.Add(this.pictureBox3);
            this.new_patient_info.Controls.Add(this.textBox1);
            this.new_patient_info.Controls.Add(this.Patient_Phone);
            this.new_patient_info.Controls.Add(this.comboBox1);
            this.new_patient_info.Controls.Add(this.pictureBox2);
            this.new_patient_info.Controls.Add(this.Patient_Status);
            this.new_patient_info.Controls.Add(this.clinics_list);
            this.new_patient_info.Controls.Add(this.pictureBox1);
            this.new_patient_info.Controls.Add(this.picture_name);
            this.new_patient_info.Controls.Add(this.sign_in_button);
            this.new_patient_info.Controls.Add(this.text_name);
            this.new_patient_info.Controls.Add(this.patient_clinic);
            this.new_patient_info.Controls.Add(this.patient_name);
            this.new_patient_info.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_patient_info.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.new_patient_info.Location = new System.Drawing.Point(149, 120);
            this.new_patient_info.Name = "new_patient_info";
            this.new_patient_info.Size = new System.Drawing.Size(516, 404);
            this.new_patient_info.TabIndex = 19;
            this.new_patient_info.TabStop = false;
            this.new_patient_info.Text = "New Patient Info";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Hospital_Managment.Properties.Resources.icons8_phone_30;
            this.pictureBox3.Location = new System.Drawing.Point(39, 145);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(200, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 33);
            this.textBox1.TabIndex = 29;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Patient_Phone
            // 
            this.Patient_Phone.AutoSize = true;
            this.Patient_Phone.BackColor = System.Drawing.Color.Transparent;
            this.Patient_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patient_Phone.ForeColor = System.Drawing.Color.White;
            this.Patient_Phone.Location = new System.Drawing.Point(77, 152);
            this.Patient_Phone.Name = "Patient_Phone";
            this.Patient_Phone.Size = new System.Drawing.Size(122, 20);
            this.Patient_Phone.TabIndex = 28;
            this.Patient_Phone.Text = "Patient Phone";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Normal",
            "Urgent",
            "Super Urgent"});
            this.comboBox1.Location = new System.Drawing.Point(200, 277);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 34);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hospital_Managment.Properties.Resources.icons8_heart_monitor_30;
            this.pictureBox2.Location = new System.Drawing.Point(39, 275);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 31);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // Patient_Status
            // 
            this.Patient_Status.AutoSize = true;
            this.Patient_Status.BackColor = System.Drawing.Color.Transparent;
            this.Patient_Status.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patient_Status.ForeColor = System.Drawing.Color.White;
            this.Patient_Status.Location = new System.Drawing.Point(77, 285);
            this.Patient_Status.Name = "Patient_Status";
            this.Patient_Status.Size = new System.Drawing.Size(116, 21);
            this.Patient_Status.TabIndex = 25;
            this.Patient_Status.Text = "Patient Status";
            // 
            // clinics_list
            // 
            this.clinics_list.FormattingEnabled = true;
            this.clinics_list.Items.AddRange(new object[] {
            "Dental Clinic",
            "Internist Clinic",
            "Orthopedic Clinic",
            "Eye Clinic"});
            this.clinics_list.Location = new System.Drawing.Point(200, 213);
            this.clinics_list.Name = "clinics_list";
            this.clinics_list.Size = new System.Drawing.Size(271, 34);
            this.clinics_list.TabIndex = 24;
            this.clinics_list.SelectedIndexChanged += new System.EventHandler(this.clinics_list_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hospital_Managment.Properties.Resources.icons8_clinic_30;
            this.pictureBox1.Location = new System.Drawing.Point(39, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 31);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // picture_name
            // 
            this.picture_name.BackColor = System.Drawing.Color.Transparent;
            this.picture_name.Image = global::Hospital_Managment.Properties.Resources.icons8_person_30;
            this.picture_name.Location = new System.Drawing.Point(39, 68);
            this.picture_name.Name = "picture_name";
            this.picture_name.Size = new System.Drawing.Size(32, 33);
            this.picture_name.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picture_name.TabIndex = 22;
            this.picture_name.TabStop = false;
            this.picture_name.Click += new System.EventHandler(this.picture_name_Click);
            // 
            // sign_in_button
            // 
            this.sign_in_button.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_in_button.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.sign_in_button.Location = new System.Drawing.Point(200, 351);
            this.sign_in_button.Name = "sign_in_button";
            this.sign_in_button.Size = new System.Drawing.Size(110, 32);
            this.sign_in_button.TabIndex = 21;
            this.sign_in_button.Text = "Add Patient";
            this.sign_in_button.UseVisualStyleBackColor = true;
            this.sign_in_button.Click += new System.EventHandler(this.sign_in_button_Click);
            // 
            // text_name
            // 
            this.text_name.BackColor = System.Drawing.Color.White;
            this.text_name.Location = new System.Drawing.Point(200, 68);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(271, 33);
            this.text_name.TabIndex = 19;
            this.text_name.TextChanged += new System.EventHandler(this.text_name_TextChanged);
            // 
            // patient_clinic
            // 
            this.patient_clinic.AutoSize = true;
            this.patient_clinic.BackColor = System.Drawing.Color.Transparent;
            this.patient_clinic.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_clinic.ForeColor = System.Drawing.Color.White;
            this.patient_clinic.Location = new System.Drawing.Point(77, 221);
            this.patient_clinic.Name = "patient_clinic";
            this.patient_clinic.Size = new System.Drawing.Size(120, 21);
            this.patient_clinic.TabIndex = 18;
            this.patient_clinic.Text = "Clinic Number";
            // 
            // patient_name
            // 
            this.patient_name.AutoSize = true;
            this.patient_name.BackColor = System.Drawing.Color.Transparent;
            this.patient_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_name.ForeColor = System.Drawing.Color.White;
            this.patient_name.Location = new System.Drawing.Point(77, 75);
            this.patient_name.Name = "patient_name";
            this.patient_name.Size = new System.Drawing.Size(117, 20);
            this.patient_name.TabIndex = 17;
            this.patient_name.Text = "Patient Name";
            this.patient_name.Click += new System.EventHandler(this.patient_name_Click);
            // 
            // adding_new_patient
            // 
            this.adding_new_patient.AutoSize = true;
            this.adding_new_patient.BackColor = System.Drawing.Color.Transparent;
            this.adding_new_patient.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adding_new_patient.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.adding_new_patient.Location = new System.Drawing.Point(254, 42);
            this.adding_new_patient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.adding_new_patient.Name = "adding_new_patient";
            this.adding_new_patient.Size = new System.Drawing.Size(233, 34);
            this.adding_new_patient.TabIndex = 18;
            this.adding_new_patient.Text = "Add New Patient";
            // 
            // Back_add_patient
            // 
            this.Back_add_patient.Location = new System.Drawing.Point(26, 505);
            this.Back_add_patient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Back_add_patient.Name = "Back_add_patient";
            this.Back_add_patient.Size = new System.Drawing.Size(74, 27);
            this.Back_add_patient.TabIndex = 20;
            this.Back_add_patient.Text = "Back";
            this.Back_add_patient.UseVisualStyleBackColor = true;
            this.Back_add_patient.Click += new System.EventHandler(this.Back_add_patient_Click);
            // 
            // add_new_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hospital_Managment.Properties.Resources.wallpaperflare_com_wallpaper;
            this.ClientSize = new System.Drawing.Size(818, 551);
            this.Controls.Add(this.Back_add_patient);
            this.Controls.Add(this.new_patient_info);
            this.Controls.Add(this.adding_new_patient);
            this.Name = "add_new_patient";
            this.Text = "Add New Patient";
            this.Load += new System.EventHandler(this.add_new_patient_Load);
            this.new_patient_info.ResumeLayout(false);
            this.new_patient_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_name)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox new_patient_info;
        private System.Windows.Forms.PictureBox picture_name;
        private System.Windows.Forms.Button sign_in_button;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label patient_clinic;
        private System.Windows.Forms.Label patient_name;
        private System.Windows.Forms.Label adding_new_patient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox clinics_list;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Patient_Status;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Patient_Phone;
        private System.Windows.Forms.Button Back_add_patient;
    }
}