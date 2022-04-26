using System;
namespace dotnetcore
{
    class Program
   {
        static void main(string[] args){
            int conta,taxa,resultado = 0   //declarando e inicializando
            
            Console.Write("Digite o valor da conta");
            conta = Console.ReadLine(); //atribuindo a conta
            
            Console.Write("Digite o valor da taxa de garcom");
            taxa = Console.ReadLine(); //atribuindo a taxa entrada do usario
            
            resultado =  conta + ((conta * taxa )/100);
            
            Console.Write($ "Sua conta: R{conta:c} + {taxa:%} da o valor total de R{resultado:c}");
	    //mostrando o resultado da conta digitada,taxa escolhida e preco total a pagar
        }
   }
}
