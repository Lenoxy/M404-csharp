namespace OOPEinstieg2L2
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
            this.lstDetails = new System.Windows.Forms.Label();
            this.lstPersonenDetails = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbPersonen = new System.Windows.Forms.ComboBox();
            this.cmdPersonenFuellen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHaarfarbe = new System.Windows.Forms.TextBox();
            this.lblAlter = new System.Windows.Forms.Label();
            this.txtAlter = new System.Windows.Forms.TextBox();
            this.lblVorname = new System.Windows.Forms.Label();
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmdNeuePerson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDetails
            // 
            this.lstDetails.AutoSize = true;
            this.lstDetails.Location = new System.Drawing.Point(23, 225);
            this.lstDetails.Name = "lstDetails";
            this.lstDetails.Size = new System.Drawing.Size(179, 13);
            this.lstDetails.TabIndex = 65;
            this.lstDetails.Text = "Details der gewählten Person zeigen";
            // 
            // lstPersonenDetails
            // 
            this.lstPersonenDetails.FormattingEnabled = true;
            this.lstPersonenDetails.Location = new System.Drawing.Point(22, 241);
            this.lstPersonenDetails.Name = "lstPersonenDetails";
            this.lstPersonenDetails.Size = new System.Drawing.Size(391, 108);
            this.lstPersonenDetails.TabIndex = 64;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(18, 215);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(417, 2);
            this.panel3.TabIndex = 63;
            // 
            // cmbPersonen
            // 
            this.cmbPersonen.FormattingEnabled = true;
            this.cmbPersonen.Location = new System.Drawing.Point(18, 153);
            this.cmbPersonen.Name = "cmbPersonen";
            this.cmbPersonen.Size = new System.Drawing.Size(237, 21);
            this.cmbPersonen.TabIndex = 62;
            this.cmbPersonen.Text = "Person wählen";
            // 
            // cmdPersonenFuellen
            // 
            this.cmdPersonenFuellen.Location = new System.Drawing.Point(285, 143);
            this.cmdPersonenFuellen.Name = "cmdPersonenFuellen";
            this.cmdPersonenFuellen.Size = new System.Drawing.Size(129, 56);
            this.cmdPersonenFuellen.TabIndex = 61;
            this.cmdPersonenFuellen.Text = "Personenobjekte im Kombinationsfeld anzeigen";
            this.cmdPersonenFuellen.UseVisualStyleBackColor = true;
            this.cmdPersonenFuellen.Click += new System.EventHandler(this.cmdPersonenFuellen_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(18, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 2);
            this.panel1.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Haarfarbe";
            // 
            // txtHaarfarbe
            // 
            this.txtHaarfarbe.BackColor = System.Drawing.Color.Black;
            this.txtHaarfarbe.Location = new System.Drawing.Point(92, 96);
            this.txtHaarfarbe.Name = "txtHaarfarbe";
            this.txtHaarfarbe.ReadOnly = true;
            this.txtHaarfarbe.Size = new System.Drawing.Size(64, 20);
            this.txtHaarfarbe.TabIndex = 58;
            // 
            // lblAlter
            // 
            this.lblAlter.AutoSize = true;
            this.lblAlter.Location = new System.Drawing.Point(30, 78);
            this.lblAlter.Name = "lblAlter";
            this.lblAlter.Size = new System.Drawing.Size(28, 13);
            this.lblAlter.TabIndex = 57;
            this.lblAlter.Text = "Alter";
            // 
            // txtAlter
            // 
            this.txtAlter.Location = new System.Drawing.Point(92, 71);
            this.txtAlter.Name = "txtAlter";
            this.txtAlter.Size = new System.Drawing.Size(64, 20);
            this.txtAlter.TabIndex = 56;
            // 
            // lblVorname
            // 
            this.lblVorname.AutoSize = true;
            this.lblVorname.Location = new System.Drawing.Point(30, 52);
            this.lblVorname.Name = "lblVorname";
            this.lblVorname.Size = new System.Drawing.Size(49, 13);
            this.lblVorname.TabIndex = 55;
            this.lblVorname.Text = "Vorname";
            // 
            // txtVorname
            // 
            this.txtVorname.Location = new System.Drawing.Point(92, 45);
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(115, 20);
            this.txtVorname.TabIndex = 54;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 53;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(92, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(115, 20);
            this.txtName.TabIndex = 52;
            // 
            // cmdNeuePerson
            // 
            this.cmdNeuePerson.Location = new System.Drawing.Point(285, 9);
            this.cmdNeuePerson.Name = "cmdNeuePerson";
            this.cmdNeuePerson.Size = new System.Drawing.Size(129, 91);
            this.cmdNeuePerson.TabIndex = 51;
            this.cmdNeuePerson.Text = "Neues Personenobjekt instanziieren und eine Referenz des statischen Arrays darauf" +
    " setzen";
            this.cmdNeuePerson.UseVisualStyleBackColor = true;
            this.cmdNeuePerson.Click += new System.EventHandler(this.cmdNeuePerson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 361);
            this.Controls.Add(this.lstDetails);
            this.Controls.Add(this.lstPersonenDetails);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cmbPersonen);
            this.Controls.Add(this.cmdPersonenFuellen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHaarfarbe);
            this.Controls.Add(this.lblAlter);
            this.Controls.Add(this.txtAlter);
            this.Controls.Add(this.lblVorname);
            this.Controls.Add(this.txtVorname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmdNeuePerson);
            this.Name = "Form1";
            this.Text = "Hauptfenster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lstDetails;
        private System.Windows.Forms.ListBox lstPersonenDetails;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbPersonen;
        private System.Windows.Forms.Button cmdPersonenFuellen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHaarfarbe;
        private System.Windows.Forms.Label lblAlter;
        private System.Windows.Forms.TextBox txtAlter;
        private System.Windows.Forms.Label lblVorname;
        private System.Windows.Forms.TextBox txtVorname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button cmdNeuePerson;
    }
}

