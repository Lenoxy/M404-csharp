namespace Block3_Aufgabe7
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
            this.label1 = new System.Windows.Forms.Label();
            this.durchmesserTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.onObjectCalculateClock = new System.Windows.Forms.Button();
            this.onStaticCalculateClick = new System.Windows.Forms.Button();
            this.staticOutputTextbox = new System.Windows.Forms.TextBox();
            this.objectOutputTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Durchmesser";
            // 
            // durchmesserTextbox
            // 
            this.durchmesserTextbox.Location = new System.Drawing.Point(89, 13);
            this.durchmesserTextbox.Name = "durchmesserTextbox";
            this.durchmesserTextbox.Size = new System.Drawing.Size(100, 20);
            this.durchmesserTextbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Objektvariabeln";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Statische Variabeln";
            // 
            // onObjectCalculateClock
            // 
            this.onObjectCalculateClock.Location = new System.Drawing.Point(16, 156);
            this.onObjectCalculateClock.Name = "onObjectCalculateClock";
            this.onObjectCalculateClock.Size = new System.Drawing.Size(75, 23);
            this.onObjectCalculateClock.TabIndex = 4;
            this.onObjectCalculateClock.Text = "Calculate";
            this.onObjectCalculateClock.UseVisualStyleBackColor = true;
            // 
            // onStaticCalculateClick
            // 
            this.onStaticCalculateClick.Location = new System.Drawing.Point(16, 344);
            this.onStaticCalculateClick.Name = "onStaticCalculateClick";
            this.onStaticCalculateClick.Size = new System.Drawing.Size(75, 23);
            this.onStaticCalculateClick.TabIndex = 5;
            this.onStaticCalculateClick.Text = "Calculate";
            this.onStaticCalculateClick.UseVisualStyleBackColor = true;
            // 
            // staticOutputTextbox
            // 
            this.staticOutputTextbox.Enabled = false;
            this.staticOutputTextbox.Location = new System.Drawing.Point(611, 344);
            this.staticOutputTextbox.Name = "staticOutputTextbox";
            this.staticOutputTextbox.Size = new System.Drawing.Size(100, 20);
            this.staticOutputTextbox.TabIndex = 6;
            // 
            // objectOutputTextbox
            // 
            this.objectOutputTextbox.Enabled = false;
            this.objectOutputTextbox.Location = new System.Drawing.Point(611, 156);
            this.objectOutputTextbox.Name = "objectOutputTextbox";
            this.objectOutputTextbox.Size = new System.Drawing.Size(100, 20);
            this.objectOutputTextbox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.objectOutputTextbox);
            this.Controls.Add(this.staticOutputTextbox);
            this.Controls.Add(this.onStaticCalculateClick);
            this.Controls.Add(this.onObjectCalculateClock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.durchmesserTextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox durchmesserTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button onObjectCalculateClock;
        private System.Windows.Forms.Button onStaticCalculateClick;
        private System.Windows.Forms.TextBox staticOutputTextbox;
        private System.Windows.Forms.TextBox objectOutputTextbox;
    }
}

