using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      int i, j;
      int pontuacao = 0;
      int[,] resultadooficial = new int[13, 3];
      resultadooficial[0,0] = int.Parse("1");
      resultadooficial[0,1] = int.Parse("0");
      resultadooficial[0,2] = int.Parse("0");
      
      resultadooficial[1,0] = int.Parse("0");
      resultadooficial[1,1] = int.Parse("1");
      resultadooficial[1,2] = int.Parse("0");
      
      resultadooficial[2,0] = int.Parse("0");
      resultadooficial[2,1] = int.Parse("1");
      resultadooficial[2,2] = int.Parse("0");
      
      resultadooficial[3,0] = int.Parse("0");
      resultadooficial[3,1] = int.Parse("0");
      resultadooficial[3,2] = int.Parse("1");
      
      resultadooficial[4,0] = int.Parse("1");
      resultadooficial[4,1] = int.Parse("0");
      resultadooficial[4,2] = int.Parse("0");
      
      resultadooficial[5,0] = int.Parse("1");
      resultadooficial[5,1] = int.Parse("0");
      resultadooficial[5,2] = int.Parse("0");
      
      resultadooficial[6,0] = int.Parse("0");
      resultadooficial[6,1] = int.Parse("0");
      resultadooficial[6,2] = int.Parse("1");
      
      resultadooficial[7,0] = int.Parse("0");
      resultadooficial[7,1] = int.Parse("1");
      resultadooficial[7,2] = int.Parse("0");
      
      resultadooficial[8,0] = int.Parse("0");
      resultadooficial[8,1] = int.Parse("0");
      resultadooficial[8,2] = int.Parse("1");
      
      resultadooficial[9,0] = int.Parse("1");
      resultadooficial[9,1] = int.Parse("0");
      resultadooficial[9,2] = int.Parse("0");
      
      resultadooficial[10,0] = int.Parse("0");
      resultadooficial[10,1] = int.Parse("0");
      resultadooficial[10,2] = int.Parse("1");
      
      resultadooficial[11,0] = int.Parse("0");
      resultadooficial[11,1] = int.Parse("0");
      resultadooficial[11,2] = int.Parse("1");
      
      resultadooficial[12,0] = int.Parse("1");
      resultadooficial[12,1] = int.Parse("0");
      resultadooficial[12,2] = int.Parse("0");
      
      
        int[,] apostas = new int[13, 3];
        
        
            Console.WriteLine("Coloque os elementos 1 por 1 :"); //lembrando que é por linha, depois de completar a linha ele vai para proxoma coluna
            for (i = 0; i < 13; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    apostas[i, j] = int.Parse(Console.ReadLine());
                }
            }
            
            for (i = 0; i < 13; i++)
            {
                for (j = 0; j < 3; j++)
               
             {
              if(apostas[i, j] == 1 && resultadooficial[i, j] == 1)
                  {
                  pontuacao = pontuacao +1;
                  }
                Console.WriteLine(pontuacao);
             }
            
            }
    }
}
