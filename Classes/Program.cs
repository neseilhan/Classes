using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.SetAdi("Çağıl");
            ogrenci.Memleket = "Ankara";
            Console.WriteLine(ogrenci.GetAd() + " - " + ogrenci.Memleket);


            Ogrenci yeniOgrenci = new Ogrenci();
            yeniOgrenci.SetAdi("Neşe");
            yeniOgrenci.Memleket = "İzmir";
            yeniOgrenci.KartNo = "123 456 789 012 345";
            Console.WriteLine(yeniOgrenci.GetAd() + "-" + yeniOgrenci.Memleket);
            Console.WriteLine(yeniOgrenci.KartNo);

            Ogrenci TembelOgrenci = new Ogrenci();
            TembelOgrenci.Ad = "Neşe";
            TembelOgrenci.Soyad = "İlhan";
            Console.WriteLine(TembelOgrenci.AdSoyad);

            Ogrenci caliskanOgrenci = new Ogrenci()
            {
                Ad = "ali",
                Soyad = "vefa",
                Memleket = "istanbul",
                ErkekMi = true
            };
            Console.WriteLine(caliskanOgrenci.Unvan + " " + caliskanOgrenci.AdSoyad + "" + caliskanOgrenci.Memleket);

            Console.ReadLine();
        }
    }

    class Ogrenci


    {
        string _ad; // field, alan
        string soyad;
        int yaş;
        string _kartno;
        public string KartNo
        {
            get
            {
                return "**** **** ****" + _kartno.Substring(15);
            }
            set
            {
                _kartno = value;
            }
        
        
        
        
        }
        public string Memleket { get; set; } //özellik, property
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string AdSoyad 
        {
            get
            {
                return Ad + " " + Soyad;
            }
        }

    public bool ErkekMi { get; set; }

    public string Unvan 
    {
        get
        {
            return ErkekMi ? "Bay" : "Bayan";
        }
    }
    // encapsulation
    //public void SetAdi(string ad) // method, davranış, behavior
    //{
    //    _ad = ad;
    //}

    //public string GetAd()

    //{
    //    return _ad;
    //}


}
}
