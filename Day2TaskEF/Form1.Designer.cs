namespace Day2TaskEF
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
            this.Instructor_ID = new System.Windows.Forms.TextBox();
            this.Instructor_Salary = new System.Windows.Forms.TextBox();
            this.Instructor_Degree = new System.Windows.Forms.TextBox();
            this.Instructor_Name = new System.Windows.Forms.TextBox();
            this.Department_ID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewInstructor = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.CompInstructor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstructor)).BeginInit();
            this.SuspendLayout();
            // 
            // Instructor_ID
            // 
            this.Instructor_ID.Location = new System.Drawing.Point(125, 30);
            this.Instructor_ID.Name = "Instructor_ID";
            this.Instructor_ID.Size = new System.Drawing.Size(150, 20);
            this.Instructor_ID.TabIndex = 0;
            // 
            // Instructor_Salary
            // 
            this.Instructor_Salary.Location = new System.Drawing.Point(125, 130);
            this.Instructor_Salary.Name = "Instructor_Salary";
            this.Instructor_Salary.Size = new System.Drawing.Size(150, 20);
            this.Instructor_Salary.TabIndex = 2;
            // 
            // Instructor_Degree
            // 
            this.Instructor_Degree.Location = new System.Drawing.Point(125, 100);
            this.Instructor_Degree.Name = "Instructor_Degree";
            this.Instructor_Degree.Size = new System.Drawing.Size(150, 20);
            this.Instructor_Degree.TabIndex = 3;
            // 
            // Instructor_Name
            // 
            this.Instructor_Name.Location = new System.Drawing.Point(125, 65);
            this.Instructor_Name.Name = "Instructor_Name";
            this.Instructor_Name.Size = new System.Drawing.Size(150, 20);
            this.Instructor_Name.TabIndex = 4;
            // 
            // Department_ID
            // 
            this.Department_ID.FormattingEnabled = true;
            this.Department_ID.Location = new System.Drawing.Point(125, 162);
            this.Department_ID.Name = "Department_ID";
            this.Department_ID.Size = new System.Drawing.Size(150, 21);
            this.Department_ID.TabIndex = 5;
            this.Department_ID.SelectedIndexChanged += new System.EventHandler(this.Department_ID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Instructor_ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Instructor_Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Instructor_Degree";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Instructor_Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Department_ID";
            // 
            // dataGridViewInstructor
            // 
            this.dataGridViewInstructor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInstructor.Location = new System.Drawing.Point(61, 204);
            this.dataGridViewInstructor.Name = "dataGridViewInstructor";
            this.dataGridViewInstructor.Size = new System.Drawing.Size(609, 211);
            this.dataGridViewInstructor.TabIndex = 15;
            this.dataGridViewInstructor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInstructor_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(503, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(143, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(503, 62);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(503, 103);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(143, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // CompInstructor
            // 
            this.CompInstructor.FormattingEnabled = true;
            this.CompInstructor.Location = new System.Drawing.Point(316, 20);
            this.CompInstructor.Name = "CompInstructor";
            this.CompInstructor.Size = new System.Drawing.Size(156, 21);
            this.CompInstructor.TabIndex = 19;
            this.CompInstructor.Text = "Choose Instructor";
            this.CompInstructor.SelectedIndexChanged += new System.EventHandler(this.CompInstructor_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CompInstructor);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridViewInstructor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Department_ID);
            this.Controls.Add(this.Instructor_Name);
            this.Controls.Add(this.Instructor_Degree);
            this.Controls.Add(this.Instructor_Salary);
            this.Controls.Add(this.Instructor_ID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstructor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Instructor_ID;
        private System.Windows.Forms.TextBox Instructor_Salary;
        private System.Windows.Forms.TextBox Instructor_Degree;
        private System.Windows.Forms.TextBox Instructor_Name;
        private System.Windows.Forms.ComboBox Department_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewInstructor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox CompInstructor;
    }
}

