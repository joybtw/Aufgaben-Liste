namespace AufgabenListe_Forms.Steuerungen
{
    partial class TaskControl
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
            this.lblEingeloggt = new System.Windows.Forms.Label();
            this.lblEingeloggterBenutzer = new System.Windows.Forms.Label();
            this.btnAusloggen = new System.Windows.Forms.Button();
            this.btnHinzufügen = new System.Windows.Forms.Button();
            this.btnBearbeiten = new System.Windows.Forms.Button();
            this.btnLöschen = new System.Windows.Forms.Button();
            this.lvAufgaben = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblEingeloggt
            // 
            this.lblEingeloggt.AutoSize = true;
            this.lblEingeloggt.Location = new System.Drawing.Point(105, 35);
            this.lblEingeloggt.Name = "lblEingeloggt";
            this.lblEingeloggt.Size = new System.Drawing.Size(76, 13);
            this.lblEingeloggt.TabIndex = 0;
            this.lblEingeloggt.Text = "Eingeloggt als:";
            // 
            // lblEingeloggterBenutzer
            // 
            this.lblEingeloggterBenutzer.AutoSize = true;
            this.lblEingeloggterBenutzer.Location = new System.Drawing.Point(187, 35);
            this.lblEingeloggterBenutzer.Name = "lblEingeloggterBenutzer";
            this.lblEingeloggterBenutzer.Size = new System.Drawing.Size(45, 13);
            this.lblEingeloggterBenutzer.TabIndex = 1;
            this.lblEingeloggterBenutzer.Text = "Anonym";
            // 
            // btnAusloggen
            // 
            this.btnAusloggen.Location = new System.Drawing.Point(363, 35);
            this.btnAusloggen.Name = "btnAusloggen";
            this.btnAusloggen.Size = new System.Drawing.Size(75, 23);
            this.btnAusloggen.TabIndex = 2;
            this.btnAusloggen.Text = "Ausloggen";
            this.btnAusloggen.UseVisualStyleBackColor = true;
            // 
            // btnHinzufügen
            // 
            this.btnHinzufügen.Location = new System.Drawing.Point(363, 101);
            this.btnHinzufügen.Name = "btnHinzufügen";
            this.btnHinzufügen.Size = new System.Drawing.Size(75, 23);
            this.btnHinzufügen.TabIndex = 3;
            this.btnHinzufügen.Text = "Hinzufügen";
            this.btnHinzufügen.UseVisualStyleBackColor = true;
            this.btnHinzufügen.Click += new System.EventHandler(this.btnHinzufügen_Click);
            // 
            // btnBearbeiten
            // 
            this.btnBearbeiten.Location = new System.Drawing.Point(363, 147);
            this.btnBearbeiten.Name = "btnBearbeiten";
            this.btnBearbeiten.Size = new System.Drawing.Size(75, 23);
            this.btnBearbeiten.TabIndex = 4;
            this.btnBearbeiten.Text = "Bearbeiten";
            this.btnBearbeiten.UseVisualStyleBackColor = true;
            this.btnBearbeiten.Click += new System.EventHandler(this.btnBearbeiten_Click);
            // 
            // btnLöschen
            // 
            this.btnLöschen.Location = new System.Drawing.Point(363, 195);
            this.btnLöschen.Name = "btnLöschen";
            this.btnLöschen.Size = new System.Drawing.Size(75, 23);
            this.btnLöschen.TabIndex = 5;
            this.btnLöschen.Text = "Löschen";
            this.btnLöschen.UseVisualStyleBackColor = true;
            this.btnLöschen.Click += new System.EventHandler(this.btnLöschen_Click);
            // 
            // lvAufgaben
            // 
            this.lvAufgaben.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colTitel,
            this.colDone});
            this.lvAufgaben.FullRowSelect = true;
            this.lvAufgaben.GridLines = true;
            this.lvAufgaben.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvAufgaben.HideSelection = false;
            this.lvAufgaben.Location = new System.Drawing.Point(27, 101);
            this.lvAufgaben.MultiSelect = false;
            this.lvAufgaben.Name = "lvAufgaben";
            this.lvAufgaben.ShowGroups = false;
            this.lvAufgaben.Size = new System.Drawing.Size(330, 513);
            this.lvAufgaben.TabIndex = 6;
            this.lvAufgaben.UseCompatibleStateImageBehavior = false;
            this.lvAufgaben.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "Id";
            // 
            // colTitel
            // 
            this.colTitel.Text = "Titel";
            // 
            // colDone
            // 
            this.colDone.Text = "Done";
            // 
            // TaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvAufgaben);
            this.Controls.Add(this.btnLöschen);
            this.Controls.Add(this.btnBearbeiten);
            this.Controls.Add(this.btnHinzufügen);
            this.Controls.Add(this.btnAusloggen);
            this.Controls.Add(this.lblEingeloggterBenutzer);
            this.Controls.Add(this.lblEingeloggt);
            this.Name = "TaskControl";
            this.Size = new System.Drawing.Size(500, 640);
            this.Load += new System.EventHandler(this.TaskControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEingeloggt;
        private System.Windows.Forms.Label lblEingeloggterBenutzer;
        private System.Windows.Forms.Button btnAusloggen;
        private System.Windows.Forms.Button btnHinzufügen;
        private System.Windows.Forms.Button btnBearbeiten;
        private System.Windows.Forms.Button btnLöschen;
        private System.Windows.Forms.ListView lvAufgaben;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colTitel;
        private System.Windows.Forms.ColumnHeader colDone;
    }
}
