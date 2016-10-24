namespace FormSearch
{
    partial class FormSearch
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
            this.textBoxEmpNo = new System.Windows.Forms.TextBox();
            this.labelEmpNo = new System.Windows.Forms.Label();
            this.labelEmployeeName = new System.Windows.Forms.Label();
            this.textBoxEmpName = new System.Windows.Forms.TextBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.labelHireDate = new System.Windows.Forms.Label();
            this.textBoxHireDate = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEmpNo
            // 
            this.textBoxEmpNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmpNo.Location = new System.Drawing.Point(200, 46);
            this.textBoxEmpNo.Name = "textBoxEmpNo";
            this.textBoxEmpNo.Size = new System.Drawing.Size(297, 20);
            this.textBoxEmpNo.TabIndex = 0;
            // 
            // labelEmpNo
            // 
            this.labelEmpNo.AutoSize = true;
            this.labelEmpNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpNo.Location = new System.Drawing.Point(47, 46);
            this.labelEmpNo.Name = "labelEmpNo";
            this.labelEmpNo.Size = new System.Drawing.Size(80, 17);
            this.labelEmpNo.TabIndex = 1;
            this.labelEmpNo.Text = "Employee #:";
            // 
            // labelEmployeeName
            // 
            this.labelEmployeeName.AutoSize = true;
            this.labelEmployeeName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeName.Location = new System.Drawing.Point(47, 97);
            this.labelEmployeeName.Name = "labelEmployeeName";
            this.labelEmployeeName.Size = new System.Drawing.Size(107, 17);
            this.labelEmployeeName.TabIndex = 3;
            this.labelEmployeeName.Text = "Employee Name:";
            // 
            // textBoxEmpName
            // 
            this.textBoxEmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmpName.Location = new System.Drawing.Point(200, 97);
            this.textBoxEmpName.Name = "textBoxEmpName";
            this.textBoxEmpName.Size = new System.Drawing.Size(297, 20);
            this.textBoxEmpName.TabIndex = 2;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalary.Location = new System.Drawing.Point(47, 147);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(46, 17);
            this.labelSalary.TabIndex = 5;
            this.labelSalary.Text = "Salary:";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSalary.Location = new System.Drawing.Point(200, 147);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(297, 20);
            this.textBoxSalary.TabIndex = 4;
            // 
            // labelHireDate
            // 
            this.labelHireDate.AutoSize = true;
            this.labelHireDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHireDate.Location = new System.Drawing.Point(47, 200);
            this.labelHireDate.Name = "labelHireDate";
            this.labelHireDate.Size = new System.Drawing.Size(62, 17);
            this.labelHireDate.TabIndex = 7;
            this.labelHireDate.Text = "HireDate:";
            // 
            // textBoxHireDate
            // 
            this.textBoxHireDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHireDate.Location = new System.Drawing.Point(200, 200);
            this.textBoxHireDate.Name = "textBoxHireDate";
            this.textBoxHireDate.Size = new System.Drawing.Size(297, 20);
            this.textBoxHireDate.TabIndex = 6;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(50, 289);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(130, 39);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Khaki;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(209, 289);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(130, 39);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Firebrick;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(367, 289);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(130, 39);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 381);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelHireDate);
            this.Controls.Add(this.textBoxHireDate);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.labelEmployeeName);
            this.Controls.Add(this.textBoxEmpName);
            this.Controls.Add(this.labelEmpNo);
            this.Controls.Add(this.textBoxEmpNo);
            this.Name = "FormSearch";
            this.Text = "Search Employees";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmpNo;
        private System.Windows.Forms.Label labelEmpNo;
        private System.Windows.Forms.Label labelEmployeeName;
        private System.Windows.Forms.TextBox textBoxEmpName;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label labelHireDate;
        private System.Windows.Forms.TextBox textBoxHireDate;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
    }
}

