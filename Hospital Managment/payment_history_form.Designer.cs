namespace Hospital_Managment
{
    partial class payment_history_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bills_table = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.back_payment_history = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bills_table)).BeginInit();
            this.SuspendLayout();
            // 
            // bills_table
            // 
            this.bills_table.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bills_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bills_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bills_table.Location = new System.Drawing.Point(194, 97);
            this.bills_table.Name = "bills_table";
            this.bills_table.RowHeadersWidth = 51;
            this.bills_table.Size = new System.Drawing.Size(428, 434);
            this.bills_table.TabIndex = 4;
            this.bills_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bills_table_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(272, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Payment History";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // back_payment_history
            // 
            this.back_payment_history.Location = new System.Drawing.Point(32, 493);
            this.back_payment_history.Margin = new System.Windows.Forms.Padding(2);
            this.back_payment_history.Name = "back_payment_history";
            this.back_payment_history.Size = new System.Drawing.Size(80, 37);
            this.back_payment_history.TabIndex = 8;
            this.back_payment_history.Text = "Back";
            this.back_payment_history.UseVisualStyleBackColor = true;
            this.back_payment_history.Click += new System.EventHandler(this.back_payment_history_Click);
            // 
            // payment_history_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hospital_Managment.Properties.Resources.wallpaperflare_com_wallpaper;
            this.ClientSize = new System.Drawing.Size(818, 551);
            this.Controls.Add(this.back_payment_history);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bills_table);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "payment_history_form";
            this.Text = "Payment History history";
            this.Load += new System.EventHandler(this.payment_history_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bills_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bills_table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_payment_history;
    }
}