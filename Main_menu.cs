using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Probabilistyka_projekt
{
    public partial class Main_menu : Form
    {
        public Main_menu()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void open_simulatoin_form_Click(object sender, EventArgs e)
        {
            Simulation s = new Simulation();
            s.ShowDialog();
        }
    }
}
