using System;

public class LOTERIAESPORTIVA
{
    static void Comeco() //TEXTOS
    {
        Console.WriteLine("faça suas apostas:");
        Console.WriteLine("digite 0 para vitoria do Time 1");
        Console.WriteLine("digite 1 para empate");
        Console.WriteLine("digite 2 para vitoria do Time 2");
  
    }
    static void Apostas(int [,] _aposta) //ENTRADA DE DADOS
    {

        int entrada; 
        for (int i = 0; i < 13; i++)
          {
              Console.WriteLine("Digite um numero para o jogo "+(i+1));
              entrada = int.Parse(Console.ReadLine());
              _aposta[i,entrada] = 1;
        
          }
            Console.WriteLine("Suas apostas:");
            Console.WriteLine();
             for (int i = 0; i < 13; i++)
         {
             for (int j = 0; j < 3; j++)
            {
                Console.Write("\t{0}", _aposta[i, j]);
            }
            Console.WriteLine();
        }
    }
    static void Resultados(int [,] _resultado) //RESULTADOS
    {

    Random randresult = new Random();
      for(int i=0; i<13; i++)
      {
          int posicao = randresult.Next (0,3);
          _resultado [i, posicao] = 1;
      }
         Console.WriteLine($"\nResultados: ");
         Console.WriteLine();
         for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t{0}", _resultado[i, j]);
                }
            Console.WriteLine();
            }

    }
static void Main() //CORPO
    { 

    int pontos = 0;
    int[,] aposta = new int[13, 3];
    int[,] resultado = new int[13, 3];
    
    Comeco();
    Apostas(aposta);
    Resultados(resultado);
    
     for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    {
                        if(aposta[i,j] == resultado[i,j] && aposta[i,j] == 1){
                            pontos++;
                        }
                    }
            
                }
    
            }

            Console.WriteLine("A pontuacao total foi:");
            Console.WriteLine(pontos);

    }
}
