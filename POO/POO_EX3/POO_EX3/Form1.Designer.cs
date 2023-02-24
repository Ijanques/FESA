namespace POO_EX3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblWage = new System.Windows.Forms.Label();
            this.nUdCode = new System.Windows.Forms.NumericUpDown();
            this.nUDWage = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUdCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDWage)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(224, 34);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(12, 18);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(32, 13);
            this.lblCod.TabIndex = 3;
            this.lblCod.Text = "Code";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(115, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "name";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(221, 18);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(23, 13);
            this.lblRg.TabIndex = 5;
            this.lblRg.Text = "RG";
            // 
            // lblWage
            // 
            this.lblWage.AutoSize = true;
            this.lblWage.Location = new System.Drawing.Point(327, 18);
            this.lblWage.Name = "lblWage";
            this.lblWage.Size = new System.Drawing.Size(36, 13);
            this.lblWage.TabIndex = 6;
            this.lblWage.Text = "Wage";
            this.lblWage.Click += new System.EventHandler(this.label1_Click);
            // 
            // nUdCode
            // 
            this.nUdCode.Location = new System.Drawing.Point(12, 34);
            this.nUdCode.Name = "nUdCode";
            this.nUdCode.Size = new System.Drawing.Size(100, 20);
            this.nUdCode.TabIndex = 8;
            // 
            // nUDWage
            // 
            this.nUDWage.Location = new System.Drawing.Point(330, 34);
            this.nUDWage.Name = "nUDWage";
            this.nUDWage.Size = new System.Drawing.Size(100, 20);
            this.nUDWage.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 138);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 24);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(317, 138);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(113, 24);
            this.btnShow.TabIndex = 12;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 196);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(415, 134);
            this.textBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 384);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nUDWage);
            this.Controls.Add(this.nUdCode);
            this.Controls.Add(this.lblWage);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nUdCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDWage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblWage;
        private System.Windows.Forms.NumericUpDown nUdCode;
        private System.Windows.Forms.NumericUpDown nUDWage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox textBox1;
    }
}

