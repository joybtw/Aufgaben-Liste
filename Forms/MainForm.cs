using AufgabenListe_Forms.Steuerungen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AufgabenListe_Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        // Methode, die das Anmeldefenster anzeigt
        public void ShowLoginControl()
        {
            // Entferne alle Steuerelemente aus dem Formular
            Controls.Clear();
            // Erstelle ein neues Objekt von LoginControl
            // Dem Konstruktor wird das Formular mit dem Schlüsselwort 'this' übergeben
            // Da wir uns derzeit in der Hauptformularklasse befinden
            // und 'this' sich auf das Objekt bezieht, in dem wir uns gerade befinden
            // Das neu erstellte Objekt dem Steuerelement des Formulars hinzufügen
            Controls.Add(new LoginControl(this));
        }
}
