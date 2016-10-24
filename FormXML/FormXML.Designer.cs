namespace FormXML
{
    partial class FormXML
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
            this.dataGridViewXML = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXML)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewXML
            // 
            this.dataGridViewXML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewXML.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewXML.Name = "dataGridViewXML";
            this.dataGridViewXML.Size = new System.Drawing.Size(934, 457);
            this.dataGridViewXML.TabIndex = 0;
            // 
            // FormXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 457);
            this.Controls.Add(this.dataGridViewXML);
            this.Name = "FormXML";
            this.Text = "Retrieve XML";
            this.Load += new System.EventHandler(this.FormXML_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXML)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewXML;
    }
}

