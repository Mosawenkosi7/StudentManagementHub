namespace StudentManagementHub
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StudentIdTxtBox = new System.Windows.Forms.TextBox();
            this.NamesTxtBox = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.NumericUpDown();
            this.Course = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ViewAll = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SummaryBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Course";
            // 
            // StudentIdTxtBox
            // 
            this.StudentIdTxtBox.Location = new System.Drawing.Point(47, 96);
            this.StudentIdTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentIdTxtBox.Name = "StudentIdTxtBox";
            this.StudentIdTxtBox.Size = new System.Drawing.Size(281, 26);
            this.StudentIdTxtBox.TabIndex = 4;
            // 
            // NamesTxtBox
            // 
            this.NamesTxtBox.Location = new System.Drawing.Point(47, 181);
            this.NamesTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NamesTxtBox.Name = "NamesTxtBox";
            this.NamesTxtBox.Size = new System.Drawing.Size(281, 26);
            this.NamesTxtBox.TabIndex = 5;
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(47, 242);
            this.Age.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(161, 26);
            this.Age.TabIndex = 6;
            // 
            // Course
            // 
            this.Course.FormattingEnabled = true;
            this.Course.Location = new System.Drawing.Point(47, 306);
            this.Course.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(281, 28);
            this.Course.TabIndex = 7;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.ForeColor = System.Drawing.Color.Transparent;
            this.AddBtn.Location = new System.Drawing.Point(47, 356);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(114, 50);
            this.AddBtn.TabIndex = 8;
            this.AddBtn.Text = "Add Student";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ViewAll
            // 
            this.ViewAll.BackColor = System.Drawing.Color.DarkCyan;
            this.ViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewAll.ForeColor = System.Drawing.Color.Transparent;
            this.ViewAll.Location = new System.Drawing.Point(141, 440);
            this.ViewAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewAll.Name = "ViewAll";
            this.ViewAll.Size = new System.Drawing.Size(99, 51);
            this.ViewAll.TabIndex = 9;
            this.ViewAll.Text = "Refresh";
            this.ViewAll.UseVisualStyleBackColor = false;
            this.ViewAll.Click += new System.EventHandler(this.ViewAll_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.ForeColor = System.Drawing.Color.Transparent;
            this.UpdateBtn.Location = new System.Drawing.Point(244, 358);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(94, 49);
            this.UpdateBtn.TabIndex = 10;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.ForeColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.Location = new System.Drawing.Point(734, 335);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(138, 41);
            this.DeleteBtn.TabIndex = 11;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // SummaryBtn
            // 
            this.SummaryBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.SummaryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SummaryBtn.ForeColor = System.Drawing.Color.Transparent;
            this.SummaryBtn.Location = new System.Drawing.Point(734, 404);
            this.SummaryBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SummaryBtn.Name = "SummaryBtn";
            this.SummaryBtn.Size = new System.Drawing.Size(138, 42);
            this.SummaryBtn.TabIndex = 12;
            this.SummaryBtn.Text = "Summary";
            this.SummaryBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkTurquoise;
            this.dataGridView1.Location = new System.Drawing.Point(534, 90);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(548, 229);
            this.dataGridView1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(525, 11);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(557, 55);
            this.label5.TabIndex = 14;
            this.label5.Text = "Student Registration";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1153, 505);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SummaryBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ViewAll);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.NamesTxtBox);
            this.Controls.Add(this.StudentIdTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StudentIdTxtBox;
        private System.Windows.Forms.TextBox NamesTxtBox;
        private System.Windows.Forms.NumericUpDown Age;
        private System.Windows.Forms.ComboBox Course;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ViewAll;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SummaryBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
    }
}

