using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ladies_GYM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void addNewPaticipantsToolStripMenuItem_Click (object sender, EventArgs e)
        {
            Form frm2 = new FrmAddnewClient();
            frm2.ShowDialog();
        }

        private void displayAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmShowAllPersons();
           frm.ShowDialog();
        }

        private void onlyParticipantToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
