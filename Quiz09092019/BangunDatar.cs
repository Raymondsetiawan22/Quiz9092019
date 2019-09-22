using system;

    namespace Quiz09092019
    {
     class BangunDatar
     {
         public void Luas_Pesegi ()
         {
             Console.Writeline("Menghitung Luas Persegi");
             Console.Writeline("-----------------------");

            int sisi;
            Console.Write("Masukkin Nilai sisi : ");
            sisi = Convet.ToInt32(Console.ReadLine());

            int luas = sisi * sisi

            Console.Writeline("Luas Persegi adalah ="+luas);
            }
        
         public void Luas_Segitiga ()
         {
        int alas,tinggi,a,b,lu,luas;

             Console.Writeline("Menghitung Luas Segitiga");
             Console.Writeline("-----------------------");

            int sisi;

            Console.Write("Masukan alas : ");
            alas = Convet.ToInt32(Console.ReadLine());

            Console.Write("Masukan tinggi : ");
            tinggi = CConvert.ToInt32(Console.Readline());
            } 
            
            a = 1
            b = 2

            lu = a * alas * tinggi;
            luas = lu / b;

             public void Luas_Segitiga()
         {
             Console.Writeline("Luas Segitiga adalah ="+luas);
         }

         public void luas_lingkaran()
         {
             Console.Writeline("menghitung Luas Lingkaran");
            Console.Writeline("-------------------------");

            int k,l,z,ruas,luas;

            k = 22;
            l = 7;
            Console.Writeline("masukan nilai ruas : ");
            ruas = Convert.ToInt32(Console.ReadLine());

            z = k * ruas * ruas;
            luas = z / l;

            Console.Writeline("Luas lingkaran adalah "+luas);
         }
        
    }
    
}