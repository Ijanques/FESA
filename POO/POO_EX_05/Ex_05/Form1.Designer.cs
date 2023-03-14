namespace Ex_05
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGrade1 = new System.Windows.Forms.Label();
            this.lblGrade2 = new System.Windows.Forms.Label();
            this.txtGrade2 = new System.Windows.Forms.TextBox();
            this.txtGrade1 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAvg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(74, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(88, 51);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Student name";
            // 
            // lblGrade1
            // 
            this.lblGrade1.AutoSize = true;
            this.lblGrade1.Location = new System.Drawing.Point(239, 51);
            this.lblGrade1.Name = "lblGrade1";
            this.lblGrade1.Size = new System.Drawing.Size(45, 13);
            this.lblGrade1.TabIndex = 2;
            this.lblGrade1.Text = "Grade 1";
            // 
            // lblGrade2
            // 
            this.lblGrade2.AutoSize = true;
            this.lblGrade2.Location = new System.Drawing.Point(384, 51);
            this.lblGrade2.Name = "lblGrade2";
            this.lblGrade2.Size = new System.Drawing.Size(45, 13);
            this.lblGrade2.TabIndex = 3;
            this.lblGrade2.Text = "Grade 2";
            // 
            // txtGrade2
            // 
            this.txtGrade2.Location = new System.Drawing.Point(353, 67);
            this.txtGrade2.Name = "txtGrade2";
            this.txtGrade2.Size = new System.Drawing.Size(100, 20);
            this.txtGrade2.TabIndex = 5;
            // 
            // txtGrade1
            // 
            this.txtGrade1.Location = new System.Drawing.Point(215, 67);
            this.txtGrade1.Name = "txtGrade1";
            this.txtGrade1.Size = new System.Drawing.Size(100, 20);
            this.txtGrade1.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(505, 64);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAvg
            // 
            this.btnAvg.Location = new System.Drawing.Point(586, 65);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(75, 23);
            this.btnAvg.TabIndex = 8;
            this.btnAvg.Text = "Average";
            this.btnAvg.UseVisualStyleBackColor = true;
            this.btnAvg.Click += new System.EventHandler(this.btnAvg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 217);
            this.Controls.Add(this.btnAvg);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtGrade1);
            this.Controls.Add(this.txtGrade2);
            this.Controls.Add(this.lblGrade2);
            this.Controls.Add(this.lblGrade1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGrade1;
        private System.Windows.Forms.Label lblGrade2;
        private System.Windows.Forms.TextBox txtGrade2;
        private System.Windows.Forms.TextBox txtGrade1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAvg;
    }
}

