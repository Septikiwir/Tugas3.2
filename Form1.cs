using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiLatihanTugas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Tampilkan_Click(object sender, EventArgs e)
        {
            var name = Name.Text;
            var pnedidikan = Pendidikan.Text;
            var pekerja = ListPekerja.Text;

            pesan1.Text = string.Format("halo {0}", name);
            pesan2.Text = string.Format("pendidikan anda  {0} ya?", pnedidikan);
            pesan3.Text = string.Format("anda seorang {0}, hebat", pekerja);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ListPekerja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
