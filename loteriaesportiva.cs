using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      int i, j;
        int[,] apostas = new int[13, 3];
        
        
            Console.WriteLine("Coloque os elementos 1 por 1 :"); //lembrando que é por linha, depois de completar a linha ele vai para proxoma coluna
            for (i = 0; i < 13; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    apostas[i, j] = int.Parse(Console.ReadLine());
                }
    }
}
}
//Tentando fazer algo
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      int i, j;
        int[,] resultadooficial = new int[13, 3];
      resultadooficial[0,0] = "1";
      resultadooficial[0,1] = "0";
      resultadooficial[0,2] = "0";
      
      resultadooficial[1,0] = "0";
      resultadooficial[1,1] = "1";
      resultadooficial[1,2] = "0";
      
      resultadooficial[2,0] = "0";
      resultadooficial[2,1] = "1";
      resultadooficial[2,2] = "0";
      
      resultadooficial[3,0] = "0";
      resultadooficial[3,1] = "0";
      resultadooficial[3,2] = "1";
      
      resultadooficial[4,0] = "1";
      resultadooficial[4,1] = "0";
      resultadooficial[4,2] = "0";
      
        int[,] apostas = new int[13, 3];
        
        
            Console.WriteLine("Coloque os elementos 1 por 1 :"); //lembrando que é por linha, depois de completar a linha ele vai para proxoma coluna
            for (i = 0; i < 13; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    apostas[i, j] = int.Parse(Console.ReadLine());
                }
            }
            
}
}
