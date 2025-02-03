namespace Hospital_Managment
{
    partial class Display_all_patients
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
            this.components = new System.ComponentModel.Container();
            this.Back_button_displayform = new System.Windows.Forms.Button();
            this.PatientsGrid = new System.Windows.Forms.DataGridView();
            this.Display_All_patients_label = new System.Windows.Forms.Label();
            this.patientsDataSet = new Hospital_Managment.PatientsDataSet();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new Hospital_Managment.PatientsDataSetTableAdapters.PatientsTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_choose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_button_displayform
            // 
            this.Back_button_displayform.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button_displayform.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Back_button_displayform.Location = new System.Drawing.Point(735, 556);
            this.Back_button_displayform.Name = "Back_button_displayform";
            this.Back_button_displayform.Size = new System.Drawing.Size(189, 44);
            this.Back_button_displayform.TabIndex = 22;
            this.Back_button_displayform.Text = "Back";
            this.Back_button_displayform.UseVisualStyleBackColor = true;
            this.Back_button_displayform.Click += new System.EventHandler(this.Back_button_displayform_Click);
            // 
            // PatientsGrid
            // 
            this.PatientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsGrid.Location = new System.Drawing.Point(83, 63);
            this.PatientsGrid.Name = "PatientsGrid";
            this.PatientsGrid.Size = new System.Drawing.Size(783, 433);
            this.PatientsGrid.TabIndex = 23;
            this.PatientsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientsGrid_CellContentClick);
            // 
            // Display_All_patients_label
            // 
            this.Display_All_patients_label.AutoSize = true;
            this.Display_All_patients_label.BackColor = System.Drawing.Color.Transparent;
            this.Display_All_patients_label.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display_All_patients_label.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.Display_All_patients_label.Location = new System.Drawing.Point(340, 16);
            this.Display_All_patients_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Display_All_patients_label.Name = "Display_All_patients_label";
            this.Display_All_patients_label.Size = new System.Drawing.Size(260, 34);
            this.Display_All_patients_label.TabIndex = 24;
            this.Display_All_patients_label.Text = "Display all patients";
            this.Display_All_patients_label.Click += new System.EventHandler(this.Display_All_patients_label_Click);
            // 
            // patientsDataSet
            // 
            this.patientsDataSet.DataSetName = "PatientsDataSet";
            this.patientsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.patientsDataSet;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(420, 568);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 21);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label_choose
            // 
            this.label_choose.AutoSize = true;
            this.label_choose.BackColor = System.Drawing.Color.Transparent;
            this.label_choose.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_choose.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label_choose.Location = new System.Drawing.Point(44, 557);
            this.label_choose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_choose.Name = "label_choose";
            this.label_choose.Size = new System.Drawing.Size(325, 34);
            this.label_choose.TabIndex = 26;
            this.label_choose.Text = "Choose Clinic To display";
            // 
            // Display_all_patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hospital_Managment.Properties.Resources.wallpaperflare_com_wallpaper;
            this.ClientSize = new System.Drawing.Size(944, 623);
            this.Controls.Add(this.label_choose);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Display_All_patients_label);
            this.Controls.Add(this.PatientsGrid);
            this.Controls.Add(this.Back_button_displayform);
            this.Name = "Display_all_patients";
            this.Text = "Display_all_patients";
            this.Load += new System.EventHandler(this.Display_all_patients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PatientsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Back_button_displayform;
        private System.Windows.Forms.DataGridView PatientsGrid;
        private System.Windows.Forms.Label Display_All_patients_label;
        private PatientsDataSet patientsDataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private PatientsDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_choose;
    }
}