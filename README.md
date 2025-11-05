# -dev
togü ödev

namespace kanguru;

class Program
{
    static void Main(string[] args)
    {
        int kangurusayaç = 1;
        

        Console.Write("Birinci kangurunun konumunu giriniz: ");
        int konum1 = int.Parse(Console.ReadLine());

        Console.Write("Kaç metre gideceğini giriniz: ");
        int mesafe1 = int.Parse(Console.ReadLine());

        Console.Write("İkinci kangurunun konumunu giriniz: ");
        int konum2 = int.Parse(Console.ReadLine());

        Console.Write("Kaç metre gideceğini giriniz: ");
        int mesafe2 = int.Parse(Console.ReadLine());

        int yenikonum1 = mesafe1 + konum1;
        int yenikonum2 = mesafe2 +konum2;

        for (int i = 0; i < 999; i++)
        {

            if (yenikonum1 == yenikonum2)
            {
                Console.WriteLine("YES");

                Console.WriteLine(kangurusayaç + " zıplamada buluşmuşlardır.. ve konumları: " + yenikonum2);

                break;
               
            }


            yenikonum1 += mesafe1;

            yenikonum2 += mesafe2;

            kangurusayaç++;

        }

        if (yenikonum1 != yenikonum2)
        {
            Console.WriteLine("NO");
        }


    } 
}


