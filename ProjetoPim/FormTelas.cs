using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPim
{
    public partial class FormTelas : Form
    {
        private FormHospede JanelaHospede;
        private FormReserva JanelaReserva;
        private FormQuarto JanelaQuarto;
        public FormTelas()
        {
            InitializeComponent();
            JanelaHospede = new FormHospede();
            JanelaReserva = new FormReserva();
            JanelaQuarto = new FormQuarto();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JanelaHospede.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JanelaReserva.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            JanelaQuarto.ShowDialog();
        }
    }
}
