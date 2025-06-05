namespace AufgabenListe_Forms.Steuerungen
{
    partial class LoginControl
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
            this.lblBenutzername = new System.Windows.Forms.Label();
            this.lblPasswort = new System.Windows.Forms.Label();
            this.IblTitel = new System.Windows.Forms.Label();
            this.lblValidierung = new System.Windows.Forms.Label();
            this.tbBenutzername = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbPasswort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBenutzername
            // 
            this.lblBenutzername.AutoSize = true;
            this.lblBenutzername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenutzername.Location = new System.Drawing.Point(44, 81);
            this.lblBenutzername.Name = "lblBenutzername";
            this.lblBenutzername.Size = new System.Drawing.Size(150, 25);
            this.lblBenutzername.TabIndex = 0;
            this.lblBenutzername.Text = "Benutzername: ";
            // 
            // lblPasswort
            // 
            this.lblPasswort.AutoSize = true;
            this.lblPasswort.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswort.Location = new System.Drawing.Point(45, 115);
            this.lblPasswort.Name = "lblPasswort";
            this.lblPasswort.Size = new System.Drawing.Size(101, 22);
            this.lblPasswort.TabIndex = 1;
            this.lblPasswort.Text = "Passwort: ";
            // 
            // IblTitel
            // 
            this.IblTitel.AutoSize = true;
            this.IblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblTitel.Location = new System.Drawing.Point(159, 20);
            this.IblTitel.Name = "IblTitel";
            this.IblTitel.Size = new System.Drawing.Size(178, 37);
            this.IblTitel.TabIndex = 2;
            this.IblTitel.Text = "Todo-Liste";
            // 
            // lblValidierung
            // 
            this.lblValidierung.AutoSize = true;
            this.lblValidierung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidierung.ForeColor = System.Drawing.Color.Orange;
            this.lblValidierung.Location = new System.Drawing.Point(161, 159);
            this.lblValidierung.Name = "lblValidierung";
            this.lblValidierung.Size = new System.Drawing.Size(176, 13);
            this.lblValidierung.TabIndex = 3;
            this.lblValidierung.Text = "Passwort oder Benutzername falsch";
            this.lblValidierung.Visible = false;
            // 
            // tbBenutzername
            // 
            this.tbBenutzername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBenutzername.Location = new System.Drawing.Point(190, 85);
            this.tbBenutzername.Name = "tbBenutzername";
            this.tbBenutzername.Size = new System.Drawing.Size(154, 20);
            this.tbBenutzername.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbPasswort
            // 
            this.tbPasswort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPasswort.Location = new System.Drawing.Point(190, 115);
            this.tbPasswort.Name = "tbPasswort";
            this.tbPasswort.PasswordChar = '*';
            this.tbPasswort.Size = new System.Drawing.Size(154, 20);
            this.tbPasswort.TabIndex = 6;
            this.tbPasswort.TextChanged += new System.EventHandler(this.tbPasswort_TextChanged);
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbPasswort);
            this.Controls.Add(this.tbBenutzername);
            this.Controls.Add(this.lblValidierung);
            this.Controls.Add(this.IblTitel);
            this.Controls.Add(this.lblPasswort);
            this.Controls.Add(this.lblBenutzername);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(500, 640);
            this.Load += new System.EventHandler(this.LoginControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBenutzername;
        private System.Windows.Forms.Label lblPasswort;
        private System.Windows.Forms.Label IblTitel;
        private System.Windows.Forms.Label lblValidierung;
        private System.Windows.Forms.TextBox tbBenutzername;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbPasswort;
    }
}
