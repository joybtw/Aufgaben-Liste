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
    public partial class RegisterControl : UserControl
    {
        private MainForm _mainForm;
        public RegisterControl(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            Dock = DockStyle.Fill;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnZurueck_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrieren_Click(object sender, EventArgs e)
        {

        }
    }
}
