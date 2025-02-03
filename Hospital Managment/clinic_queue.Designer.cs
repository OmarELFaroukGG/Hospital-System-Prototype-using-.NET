namespace Hospital_Managment
{
    partial class clinic_queue
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
            this.Clinic2Datagrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back_clinic_queue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Clinic2Datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Clinic2Datagrid
            // 
            this.Clinic2Datagrid.BackgroundColor = System.Drawing.Color.Black;
            this.Clinic2Datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Clinic2Datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.Clinic2Datagrid.Location = new System.Drawing.Point(189, 117);
            this.Clinic2Datagrid.Name = "Clinic2Datagrid";
            this.Clinic2Datagrid.RowHeadersWidth = 51;
            this.Clinic2Datagrid.Size = new System.Drawing.Size(428, 434);
            this.Clinic2Datagrid.TabIndex = 6;
            this.Clinic2Datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Clinic2Datagrid_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Patient Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Patient Status";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Patient Phone";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // back_clinic_queue
            // 
            this.back_clinic_queue.Location = new System.Drawing.Point(40, 514);
            this.back_clinic_queue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back_clinic_queue.Name = "back_clinic_queue";
            this.back_clinic_queue.Size = new System.Drawing.Size(88, 37);
            this.back_clinic_queue.TabIndex = 8;
            this.back_clinic_queue.Text = "Back";
            this.back_clinic_queue.UseVisualStyleBackColor = true;
            this.back_clinic_queue.Click += new System.EventHandler(this.back_clinic_queue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Clinic name will be here";
            // 
            // clinic_queue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hospital_Managment.Properties.Resources.wallpaperflare_com_wallpaper;
            this.ClientSize = new System.Drawing.Size(817, 612);
            this.Controls.Add(this.Clinic2Datagrid);
            this.Controls.Add(this.back_clinic_queue);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "clinic_queue";
            this.Text = "Clinic queue";
            this.Load += new System.EventHandler(this.clinic_queue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Clinic2Datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Clinic2Datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button back_clinic_queue;
        private System.Windows.Forms.Label label1;
    }
}