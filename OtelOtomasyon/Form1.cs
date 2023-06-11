using OtelOtomasyon.OtelOtomasyonuDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Degistir()
        {
            var textler = groupBoxGirdiler.Controls.OfType<Label>();
            var boxlar = groupBoxGirdiler.Controls.OfType<TextBox>();

            foreach (var nesne in textler)
            {
                nesne.Visible = false;
            }
            foreach (var nesne in boxlar)
            {
                nesne.Visible = false;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            Degistir();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboboxsec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboboxsec.SelectedIndex == 0)
            {
                Degistir();
                lblad.Visible = true;
                textBoxad.Visible = true;

            }
            else if (comboboxsec.SelectedIndex == 1)
            {
                Degistir();
                lblad.Visible = true;
                textBoxad.Visible = true;
                lblSoyad.Visible = true;
                textBoxsoyad.Visible = true;
                lblSehir.Visible = true;
                textBoxsehir.Visible = true;
                lblPostaKod.Visible = true;
                textBoxPostaKod.Visible=true;

            }
            else if(comboboxsec.SelectedIndex == 2)
            {
                Degistir();
                lblad.Visible = true;
                textBoxad.Visible = true;
            }
            else if (comboboxsec.SelectedIndex == 3)
            {
                Degistir();
                var textler = groupBoxGirdiler.Controls.OfType<Label>();
                var boxlar = groupBoxGirdiler.Controls.OfType<TextBox>();

                foreach (var nesne in textler)
                {
                    nesne.Visible = true;
                    
                }
                foreach (var nesne in boxlar)
                {
                    nesne.Visible = true;
                }
                lblBirimFiyat.Visible = false;
                textBoxBirimFiyat.Visible=false;

            }
            else if (comboboxsec.SelectedIndex == 4)
            {
                Degistir();
                lblSehir.Visible = true;
                textBoxsehir.Visible = true;    

            }
            else if (comboboxsec.SelectedIndex == 5)
            {
                Degistir();
                lblad.Visible = true;
                textBoxad.Visible = true;
                lblSehir.Visible = true;
                textBoxsehir.Visible = true;
                lblUlke.Visible = true;
                textBoxulke.Visible = true;
                lblTelNo.Visible = true;
                textBoxTelNo.Visible = true;

            }
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {

        }

        private void btnsil_Click(object sender, EventArgs e)
        {

        }

        private void btnekle_Click(object sender, EventArgs e)
        {

        }

        private void dgvliste_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {

        }

        private void dgvliste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvliste_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var textler = groupBoxGirdiler.Controls.OfType<Label>();
            foreach(var textBox in textler)
            {
                if (textBox.Visible == true)
                {
                    textBox.Text = dgvliste.CurrentRow.Cells[e.RowIndex].Value.ToString();
                }
            }
        }
    }
}
