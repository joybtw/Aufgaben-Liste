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
        }

        private void TaskControl_Load(object sender, EventArgs e)
        {

        }
    }
}
