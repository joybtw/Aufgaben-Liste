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
    public partial class TaskControl : UserControl
    {
        private MainForm _mainForm;
        public TaskControl(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            Dock = DockStyle.Fill;
        }

        private void TaskControl_Load(object sender, EventArgs e)
        {

        }

        private void btnAusloggen_Click(object sender, EventArgs e)
        {
        }

        private void btnHinzufügen_Click(object sender, EventArgs e)
        {
        }

        private void btnBearbeiten_Click(object sender, EventArgs e)
        {
        }

        private void btnLöschen_Click(object sender, EventArgs e)
        {
        }
    }
}
