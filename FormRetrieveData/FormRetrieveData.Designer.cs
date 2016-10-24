namespace FormRetrieveData
{
    partial class FormRetrieveData
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
            this.dataEmployees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dataEmployees
            // 
            this.dataEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataEmployees.Location = new System.Drawing.Point(0, 0);
            this.dataEmployees.Name = "dataEmployees";
            this.dataEmployees.Size = new System.Drawing.Size(526, 396);
            this.dataEmployees.TabIndex = 0;
            // 
            // FormRetrieveData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 396);
            this.Controls.Add(this.dataEmployees);
            this.Name = "FormRetrieveData";
            this.Text = "Data Retrieved";
            this.Load += new System.EventHandler(this.FormRetrieveData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataEmployees;
    }
}

