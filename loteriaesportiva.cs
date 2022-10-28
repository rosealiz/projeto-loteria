using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      int i, j;
        int[,] a = new int[13, 3];
        
        
            Console.WriteLine("Coloque os elementos 1 por 1 :"); //lembrando que é por linha, depois de completar a linha ele vai para proxoma coluna
            for (i = 1; i <= 13; i++)
            {
                for (j = 1; j <= 3; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
    }
}
}
