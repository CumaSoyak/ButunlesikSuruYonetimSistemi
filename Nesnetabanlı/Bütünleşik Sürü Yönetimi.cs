using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesnetabanlı
{
    public partial class Bütünleşik_Sürü_Yönetimi : Form
    {
        public Bütünleşik_Sürü_Yönetimi()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pedigri_Bilgileri frm = new Pedigri_Bilgileri();
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Süt_bilgileri frm = new Süt_bilgileri();
            frm.Show();
            this.Hide();
        }
    }
}
