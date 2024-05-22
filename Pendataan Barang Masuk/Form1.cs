using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendataan_Barang_Masuk
{
    public partial class SaveButton : Form
    {
        public SaveButton()
        {
            InitializeComponent();
        }

        private void SaveButton_Load(object sender, EventArgs e)
        {
            jeniscombo.Items.Add("Makanan");
            jeniscombo.Items.Add("Minuman");

            jeniscombo.SelectedIndex = 0;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void HapusButton_Click(object sender, EventArgs e)
        {
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex);
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            string namabarang = namatext.Text;
            int jumlahbarang = int .Parse(jumlahtext.Text);
            string waktu = tanggalbox.Value + "";
            string jenis = jeniscombo.SelectedItem.ToString();
            string batas = "              ||                ";


            ListBox1.Items.Add(waktu + batas + jenis + batas + jumlahbarang + batas + namabarang);


            namatext.Clear();
            jumlahtext.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
