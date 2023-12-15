namespace Inheritance
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
            this.CreateEmployeeObject = new System.Windows.Forms.Button();
            this.CreateStudentObject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateEmployeeObject
            // 
            this.CreateEmployeeObject.Location = new System.Drawing.Point(41, 40);
            this.CreateEmployeeObject.Name = "CreateEmployeeObject";
            this.CreateEmployeeObject.Size = new System.Drawing.Size(245, 23);
            this.CreateEmployeeObject.TabIndex = 0;
            this.CreateEmployeeObject.Text = "Create Employee Object";
            this.CreateEmployeeObject.UseVisualStyleBackColor = true;
            this.CreateEmployeeObject.Click += new System.EventHandler(this.CreateEmployeeObject_Click);
            // 
            // CreateStudentObject
            // 
            this.CreateStudentObject.Location = new System.Drawing.Point(41, 79);
            this.CreateStudentObject.Name = "CreateStudentObject";
            this.CreateStudentObject.Size = new System.Drawing.Size(245, 23);
            this.CreateStudentObject.TabIndex = 1;
            this.CreateStudentObject.Text = "Create Student Object";
            this.CreateStudentObject.UseVisualStyleBackColor = true;
            this.CreateStudentObject.Click += new System.EventHandler(this.CreateStudentObject_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateStudentObject);
            this.Controls.Add(this.CreateEmployeeObject);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateEmployeeObject;
        private System.Windows.Forms.Button CreateStudentObject;
    }
}

