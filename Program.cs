using System;

namespace MyDictionary_DersDort
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> Ogrenci = new MyDictionary<int, string>();
            Ogrenci.Add(134, "Sule Camurcu");
            Ogrenci.Add(158, "Burak Ozcelik");
            Ogrenci.Add(115, "Rümeysa Kabaoğlu");
            Ogrenci.Add(174, "Gamze Karatas");
            Ogrenci.List();
        }
    }
}
