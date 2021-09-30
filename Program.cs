using System;

namespace Questão_sete____desconto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aula de Sábado: Algoritmo");
          
           

            
            Console.WriteLine();


            double valorDoProduto, primeira, parcelado, desconto1, desconto2, desconto3, desconto,  segunda, terceira, quarta, formaDePagamento;

              Console.Write("digite a forma de pagamento :");
              formaDePagamento = double.Parse(Console.ReadLine());
              Console.Write("Digite o valor do Produto :");
              valorDoProduto = double.Parse(Console.ReadLine());
              

                desconto1 = valorDoProduto / 100 * 10;
                desconto2 = valorDoProduto / 100 * 8;
                desconto3 = valorDoProduto / 100 * 5;
                parcelado = valorDoProduto / 100 * 5;

               primeira = valorDoProduto - desconto;
               segunda  = valorDoProduto - desconto;
               terceira = valorDoProduto - desconto;
               quarta   = valorDoProduto + acrescimo;

                if (formaDePagamento == primeira) 
                {
                  Console.WriteLine("Pagamento à Vista !");
                  Console.WriteLine("desconto de 10% ");
                  Console.WriteLine("total à pagar é :");
                }      
                else if (formaDePagamento == segunda)
                {
                  Console.Write("pagamento com Cartão de Débito !");
                  Console.WriteLine("desconto de 8% ");
                  Console.WriteLine("total à pagar é :");
                }
                else if (formaDePagamento == terceira)
                {
                  Console.Write("forma de pagamento com Cartão de Crédito !");
                   Console.WriteLine("desconto de 5% ");
                  Console.WriteLine("total à pagar é :");
                }
                else if (formaDePagamento == quarta)
                {
                  Console.Write("pagamento Parcelado em 12 vezes !");
                   Console.WriteLine("acréscimo de 5% ");
                  Console.WriteLine("total à pagar é :");
                  Console.WriteLine("valor da Parcela será de :");
                }   
                     
                                
           
          
        }
    }
}
