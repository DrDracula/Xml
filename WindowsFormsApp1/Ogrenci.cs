using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Ogrenci
    {
        private Guid id;

        public Guid ID
        {
            get { return id; }
            set { id = value; }
        }

        private string adi;

        public string Adi
        {
            get { return adi; }
            set { adi = value; }
        }

        private string soyad;

        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        private DateTime dogumtarihi;

        public DateTime DogumTarihi
        {
            get { return dogumtarihi; }
            set { dogumtarihi = value; }
        }
        private cinsiyet cins;

        public cinsiyet Cinsiyet
        {
            get { return cins; }
            set { cins = value; }
        }




    }

    public enum cinsiyet
    {
        Kadin=1,
        Erkek=2
        
    }
}
