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
            this.CourseList = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ViewAll = new System.Windows.Forms.Button();
            this.SummaryBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Course";
            // 
            // StudentIdTxtBox
            // 
            this.StudentIdTxtBox.Location = new System.Drawing.Point(32, 46);
            this.StudentIdTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentIdTxtBox.Name = "StudentIdTxtBox";
            this.StudentIdTxtBox.Size = new System.Drawing.Size(202, 22);
            this.StudentIdTxtBox.TabIndex = 4;
            // 
            // NamesTxtBox
            // 
            this.NamesTxtBox.Location = new System.Drawing.Point(32, 97);
            this.NamesTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NamesTxtBox.Name = "NamesTxtBox";
            this.NamesTxtBox.Size = new System.Drawing.Size(210, 22);
            this.NamesTxtBox.TabIndex = 5;
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(32, 147);
            this.Age.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(210, 22);
            this.Age.TabIndex = 6;
            // 
            // CourseList
            // 
            this.CourseList.FormattingEnabled = true;
            this.CourseList.Items.AddRange(new object[] {
            "Bachelor of Science in Computer Science",
            "Bachelor of Information Technology (BIT)",
            "Bachelor of Science in Information Systems",
            "Bachelor of Software Engineering"});
            this.CourseList.Location = new System.Drawing.Point(32, 197);
            this.CourseList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CourseList.Name = "CourseList";
            this.CourseList.Size = new System.Drawing.Size(210, 24);
            this.CourseList.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridView1.Location = new System.Drawing.Point(289, 78);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(398, 214);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.ForeColor = System.Drawing.Color.Transparent;
            this.AddBtn.Location = new System.Drawing.Point(32, 232);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(111, 35);
            this.AddBtn.TabIndex = 9;
            this.AddBtn.Text = "Add Student";
            this.AddBtn.UseVisualStyleBackColor = false;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.ForeColor = System.Drawing.Color.Transparent;
            this.UpdateBtn.Location = new System.Drawing.Point(165, 300);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(100, 34);
            this.UpdateBtn.TabIndex = 10;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.ForeColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.Location = new System.Drawing.Point(317, 300);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(67, 34);
            this.DeleteBtn.TabIndex = 11;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // ViewAll
            // 
            this.ViewAll.BackColor = System.Drawing.Color.DarkCyan;
            this.ViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewAll.ForeColor = System.Drawing.Color.Transparent;
            this.ViewAll.Location = new System.Drawing.Point(32, 300);
            this.ViewAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewAll.Name = "ViewAll";
            this.ViewAll.Size = new System.Drawing.Size(90, 34);
            this.ViewAll.TabIndex = 12;
            this.ViewAll.Text = "View All";
            this.ViewAll.UseVisualStyleBackColor = false;
            this.ViewAll.Click += new System.EventHandler(this.ViewAll_Click);
            // 
            // SummaryBtn
            // 
            this.SummaryBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.SummaryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SummaryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SummaryBtn.ForeColor = System.Drawing.Color.Transparent;
            this.SummaryBtn.Location = new System.Drawing.Point(441, 300);
            this.SummaryBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SummaryBtn.Name = "SummaryBtn";
            this.SummaryBtn.Size = new System.Drawing.Size(83, 34);
            this.SummaryBtn.TabIndex = 13;
            this.SummaryBtn.Text = "Summary";
            this.SummaryBtn.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(342, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 38);
            this.label5.TabIndex = 14;
            this.label5.Text = "Student Registration";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SummaryBtn);
            this.Controls.Add(this.ViewAll);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CourseList);
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
        private System.Windows.Forms.ComboBox CourseList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ViewAll;
        private System.Windows.Forms.Button SummaryBtn;
        private System.Windows.Forms.Label label5;
    }
}

