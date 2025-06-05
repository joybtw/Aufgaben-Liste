namespace AufgabenListe_Forms.Steuerungen
{
    partial class RegisterControl
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBenutzername = new System.Windows.Forms.Label();
            this.lblPasswort = new System.Windows.Forms.Label();
            this.lblPasswortWiederholen = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbBenutzername = new System.Windows.Forms.TextBox();
            this.tbPasswort = new System.Windows.Forms.TextBox();
            this.tbPasswortWiederholen = new System.Windows.Forms.TextBox();
            this.lblNameValid = new System.Windows.Forms.Label();
            this.lblBenutzernameValid = new System.Windows.Forms.Label();
            this.lblPasswortValid = new System.Windows.Forms.Label();
            this.lblPasswortWiederholenValid = new System.Windows.Forms.Label();
            this.btnRegistrieren = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(204, 43);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(135, 24);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "Registrierung";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(95, 107);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name: ";
            // 
            // lblBenutzername
            // 
            this.lblBenutzername.AutoSize = true;
            this.lblBenutzername.Location = new System.Drawing.Point(95, 146);
            this.lblBenutzername.Name = "lblBenutzername";
            this.lblBenutzername.Size = new System.Drawing.Size(78, 13);
            this.lblBenutzername.TabIndex = 2;
            this.lblBenutzername.Text = "Benutzername:";
            // 
            // lblPasswort
            // 
            this.lblPasswort.AutoSize = true;
            this.lblPasswort.Location = new System.Drawing.Point(95, 190);
            this.lblPasswort.Name = "lblPasswort";
            this.lblPasswort.Size = new System.Drawing.Size(53, 13);
            this.lblPasswort.TabIndex = 3;
            this.lblPasswort.Text = "Passwort:";
            // 
            // lblPasswortWiederholen
            // 
            this.lblPasswortWiederholen.AutoSize = true;
            this.lblPasswortWiederholen.Location = new System.Drawing.Point(95, 244);
            this.lblPasswortWiederholen.Name = "lblPasswortWiederholen";
            this.lblPasswortWiederholen.Size = new System.Drawing.Size(116, 13);
            this.lblPasswortWiederholen.TabIndex = 4;
            this.lblPasswortWiederholen.Text = "Passwort Wiederholen:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(239, 100);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 5;
            this.tbName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbBenutzername
            // 
            this.tbBenutzername.Location = new System.Drawing.Point(239, 139);
            this.tbBenutzername.Name = "tbBenutzername";
            this.tbBenutzername.Size = new System.Drawing.Size(100, 20);
            this.tbBenutzername.TabIndex = 7;
            // 
            // tbPasswort
            // 
            this.tbPasswort.Location = new System.Drawing.Point(239, 183);
            this.tbPasswort.Name = "tbPasswort";
            this.tbPasswort.Size = new System.Drawing.Size(100, 20);
            this.tbPasswort.TabIndex = 8;
            // 
            // tbPasswortWiederholen
            // 
            this.tbPasswortWiederholen.Location = new System.Drawing.Point(239, 237);
            this.tbPasswortWiederholen.Name = "tbPasswortWiederholen";
            this.tbPasswortWiederholen.Size = new System.Drawing.Size(100, 20);
            this.tbPasswortWiederholen.TabIndex = 9;
            // 
            // lblNameValid
            // 
            this.lblNameValid.AutoSize = true;
            this.lblNameValid.Location = new System.Drawing.Point(236, 123);
            this.lblNameValid.Name = "lblNameValid";
            this.lblNameValid.Size = new System.Drawing.Size(63, 13);
            this.lblNameValid.TabIndex = 10;
            this.lblNameValid.Text = "Name gültig";
            this.lblNameValid.Visible = false;
            // 
            // lblBenutzernameValid
            // 
            this.lblBenutzernameValid.AutoSize = true;
            this.lblBenutzernameValid.Location = new System.Drawing.Point(236, 167);
            this.lblBenutzernameValid.Name = "lblBenutzernameValid";
            this.lblBenutzernameValid.Size = new System.Drawing.Size(103, 13);
            this.lblBenutzernameValid.TabIndex = 11;
            this.lblBenutzernameValid.Text = "Benutzername gültig";
            this.lblBenutzernameValid.Visible = false;
            // 
            // lblPasswortValid
            // 
            this.lblPasswortValid.AutoSize = true;
            this.lblPasswortValid.Location = new System.Drawing.Point(236, 206);
            this.lblPasswortValid.Name = "lblPasswortValid";
            this.lblPasswortValid.Size = new System.Drawing.Size(78, 13);
            this.lblPasswortValid.TabIndex = 12;
            this.lblPasswortValid.Text = "Passwort gültig";
            this.lblPasswortValid.Visible = false;
            // 
            // lblPasswortWiederholenValid
            // 
            this.lblPasswortWiederholenValid.AutoSize = true;
            this.lblPasswortWiederholenValid.Location = new System.Drawing.Point(236, 260);
            this.lblPasswortWiederholenValid.Name = "lblPasswortWiederholenValid";
            this.lblPasswortWiederholenValid.Size = new System.Drawing.Size(109, 13);
            this.lblPasswortWiederholenValid.TabIndex = 13;
            this.lblPasswortWiederholenValid.Text = "Wiederholung korrekt";
            this.lblPasswortWiederholenValid.Visible = false;
            // 
            // btnRegistrieren
            // 
            this.btnRegistrieren.Location = new System.Drawing.Point(208, 343);
            this.btnRegistrieren.Name = "btnRegistrieren";
            this.btnRegistrieren.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrieren.TabIndex = 14;
            this.btnRegistrieren.Text = "Registrieren";
            this.btnRegistrieren.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Zurück";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegistrieren);
            this.Controls.Add(this.lblPasswortWiederholenValid);
            this.Controls.Add(this.lblPasswortValid);
            this.Controls.Add(this.lblBenutzernameValid);
            this.Controls.Add(this.lblNameValid);
            this.Controls.Add(this.tbPasswortWiederholen);
            this.Controls.Add(this.tbPasswort);
            this.Controls.Add(this.tbBenutzername);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblPasswortWiederholen);
            this.Controls.Add(this.lblPasswort);
            this.Controls.Add(this.lblBenutzername);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitel);
            this.Name = "RegisterControl";
            this.Size = new System.Drawing.Size(500, 640);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBenutzername;
        private System.Windows.Forms.Label lblPasswort;
        private System.Windows.Forms.Label lblPasswortWiederholen;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbBenutzername;
        private System.Windows.Forms.TextBox tbPasswort;
        private System.Windows.Forms.TextBox tbPasswortWiederholen;
        private System.Windows.Forms.Label lblNameValid;
        private System.Windows.Forms.Label lblBenutzernameValid;
        private System.Windows.Forms.Label lblPasswortValid;
        private System.Windows.Forms.Label lblPasswortWiederholenValid;
        private System.Windows.Forms.Button btnRegistrieren;
        private System.Windows.Forms.Button button1;
    }
}
