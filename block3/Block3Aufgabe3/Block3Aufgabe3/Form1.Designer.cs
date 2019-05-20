namespace Block3Aufgabe3
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.sABox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sBBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.flaecheBox = new System.Windows.Forms.TextBox();
            this.umfangBox = new System.Windows.Forms.TextBox();
            this.umfangLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sABox
            // 
            this.sABox.Location = new System.Drawing.Point(102, 45);
            this.sABox.Name = "sABox";
            this.sABox.Size = new System.Drawing.Size(100, 20);
            this.sABox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seite A";
            // 
            // sBBox
            // 
            this.sBBox.Location = new System.Drawing.Point(102, 118);
            this.sBBox.Name = "sBBox";
            this.sBBox.Size = new System.Drawing.Size(100, 20);
            this.sBBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Seite B";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(333, 72);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 11;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // flaecheBox
            // 
            this.flaecheBox.Location = new System.Drawing.Point(606, 45);
            this.flaecheBox.Name = "flaecheBox";
            this.flaecheBox.Size = new System.Drawing.Size(100, 20);
            this.flaecheBox.TabIndex = 12;
            // 
            // umfangBox
            // 
            this.umfangBox.Location = new System.Drawing.Point(606, 115);
            this.umfangBox.Name = "umfangBox";
            this.umfangBox.Size = new System.Drawing.Size(100, 20);
            this.umfangBox.TabIndex = 13;
            // 
            // umfangLabel
            // 
            this.umfangLabel.AutoSize = true;
            this.umfangLabel.Location = new System.Drawing.Point(532, 121);
            this.umfangLabel.Name = "umfangLabel";
            this.umfangLabel.Size = new System.Drawing.Size(44, 13);
            this.umfangLabel.TabIndex = 14;
            this.umfangLabel.Text = "Umfang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fläche";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 230);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.umfangLabel);
            this.Controls.Add(this.umfangBox);
            this.Controls.Add(this.flaecheBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sBBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sABox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox sABox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sBBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox flaecheBox;
        private System.Windows.Forms.TextBox umfangBox;
        private System.Windows.Forms.Label umfangLabel;
        private System.Windows.Forms.Label label2;
    }
}

