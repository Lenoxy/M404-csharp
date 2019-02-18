namespace testCalc
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
            this.txtZahl = new System.Windows.Forms.TextBox();
            this.outputTxt = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtZahl
            // 
            this.txtZahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtZahl.Location = new System.Drawing.Point(12, 91);
            this.txtZahl.Name = "txtZahl";
            this.txtZahl.Size = new System.Drawing.Size(198, 30);
            this.txtZahl.TabIndex = 0;
            // 
            // outputTxt
            // 
            this.outputTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.outputTxt.Location = new System.Drawing.Point(364, 91);
            this.outputTxt.Name = "outputTxt";
            this.outputTxt.ReadOnly = true;
            this.outputTxt.Size = new System.Drawing.Size(175, 30);
            this.outputTxt.TabIndex = 1;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonCalc.Location = new System.Drawing.Point(216, 76);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(142, 67);
            this.buttonCalc.TabIndex = 2;
            this.buttonCalc.Text = "input*2";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 168);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.outputTxt);
            this.Controls.Add(this.txtZahl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtZahl;
        private System.Windows.Forms.TextBox outputTxt;
        private System.Windows.Forms.Button buttonCalc;
    }
}

