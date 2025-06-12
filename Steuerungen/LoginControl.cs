using AufgabenListe_Forms.Klassen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AufgabenListe_Forms.Steuerungen
{
    public partial class LoginControl : UserControl
    {
        // Referenz auf MainForm
        private MainForm _mainForm;
        public LoginControl(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            Dock = DockStyle.Fill;
        }

        private void LoginControl_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbPasswort_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnmelden_Click(object sender, EventArgs e)
        {

        }
        private void btnRegistrieren_Click(object sender, EventArgs e)
        {
        }
    }
}
