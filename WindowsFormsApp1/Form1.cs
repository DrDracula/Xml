using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Ogrenci> olist = new List<Ogrenci>();
        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci();
            Guid guid = new Guid();
            o.ID = Guid.NewGuid();
            o.Adi = textBox2.Text;
            o.Soyad = textBox3.Text;
            o.DogumTarihi = dateTimePicker1.Value;
            if (radioButton1.Checked)
            { o.Cinsiyet = cinsiyet.Erkek; }
            else  
            {
                o.Cinsiyet = cinsiyet.Kadin;
            }
            olist.Add(o);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = olist;
       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Ogrenci Bilgileri Kayıt";
            saveFileDialog1.Filter = "*.xml|*.xml";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            XmlSerializer srl = new XmlSerializer(typeof(List<Ogrenci>));
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                TextWriter tw = new StreamWriter(saveFileDialog1.FileName);
                srl.Serialize(tw, olist);
                tw.Close();
                MessageBox.Show("Kaydedildi.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Ogrenci> okunanogrenciler = new List<Ogrenci>();
            XmlSerializer srl = new XmlSerializer(typeof(List<Ogrenci>));
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                TextReader tr = new StreamReader(openFileDialog1.FileName);
                okunanogrenciler = (List<Ogrenci>)srl.Deserialize(tr);
                tr.Close();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = okunanogrenciler;
            }
        }
    }
}
