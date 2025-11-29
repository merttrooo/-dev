namespace _20;
//2x2 boyutunda bir matrisi parametre olarak alan ve transpozunu alıp
//sonucu geriye döndüren bir metot yazınız...
class Program
{
    static void Main(string[] args)
    {
        matris();
    }

    static void matris()
    {
        Console.WriteLine("Matrisi giriniz: ");
        int[,] matris = new int[2, 2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                matris[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Oluşan matris...");
        Console.WriteLine("-----------------");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(matris[i,j] + "  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("-----------------");

        Console.WriteLine("Oluşan matrisin trasnpozu");

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(matris[j,i] + "  ");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}

