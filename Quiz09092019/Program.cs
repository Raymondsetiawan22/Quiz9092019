using System;

namespace Quiz09092019
{
    class Program
    {
        static void Main(string[] args)
        {
            BangunRuang obj = new BangunDatar();

            obj.Luas_Persegi();

            obj.Luas_segitiga();

            obj.Luas_lingkaran();

            BangunRuang owo = new BangunRuang();

            owo.Volume_Kubus();

            owo.Volume_Balok();
        }
    }
}
