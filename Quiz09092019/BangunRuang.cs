using system;

namespace Quiz09092019
{
    class BangunRuang
    {
        public void Volume_Kubus()
        {
            Console.Writeline("menghitung volume kubus");
            console.writeline("-----------------------");

            int sisi;
            Console.Write("Masukan Nilai sisi : ");
            sisi = convert.ToInt32(Console>Readline());

            int Volume = sisi * sisi * sisi;

            Console.Writeline("Volume Kubus Adalah = "+Volume);
        }
            public void Volume_Balok()
        {
            int panjang,lebar,tinggi,volume;
            console.Writeline("Menghitung Volume Balok");
            Console.Writeline("-----------------------");

            Console.Write("Masukan panjang : ");
            panjang = Convert.ToInt32(Console.Readline());

            Console.Write("Masukan lebar : "):
            lebar = Convert.ToInt32(Console.Readline());

            Console.Write("Masukan tinggi : ");
            tinggi = Convert.ToInt32(Console.Readline());

            volume = panjang * lebar * tinggi;

            Console.Writeline("Volume Balok Adalah = "+volume);
        }

    }
}