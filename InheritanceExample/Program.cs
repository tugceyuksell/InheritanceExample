using System;

namespace InheritanceExample
{
    class Sekil//base class
    {
        protected int genislik;
        protected int yukseklik;
        public void genislikAyarla(int g)
        {
            genislik = g;
        }
        public void yukseklikAyarla(int y)
        {
            yukseklik = y;
        }
    }
    class Dikdortgen : Sekil
    {
        public int AlanHesapla()
        {
            return (genislik * yukseklik);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.genislikAyarla(4);
            dikdortgen.yukseklikAyarla(6);


            Console.WriteLine("Alan : {0}", dikdortgen.AlanHesapla());

            Console.ReadKey();
        }
    }
    
}
