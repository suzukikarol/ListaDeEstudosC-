using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExereciciosAParte
{
    class Program
    {
        static void Main(string[] args)
        {
            //imprimindo uma frase simples
            Console.WriteLine("\nÉ PRECISO FAZER TODOS OS EXERCÍCIOS PARA APRENDER!");

            //imprimindo nome
            Console.WriteLine("\nKaroline Suzuki");

            //calculando o produto da multiplicação de 2 numeros e imprimindo o resultado
            double produto;
            produto = 28 * 43;
            Console.WriteLine("\nO produto da mutiplicação de 28 por 43 é: " + produto);
            //outra forma de fazer o mesmo
            int x = 28;
            int y = 43;
            Console.WriteLine("\nProduto dos números : {0}", x*y);
            
            //algoritmo que imprima a media de 3 numeros
            int a = 8;
            int b = 7;
            int z = 9;
            int soma = a + b + z;
            int media = soma / 3;
            Console.WriteLine("\nA média aritmética desses três valores foi de : " + media);
            

            //Ler um número inteiro a partir do que usuário digita
            int numero = 0;
            Console.Write("\n Digite um número qualquer: ");
            //pega o valor digitado que é uma string
            //depois converte em inteiro
            numero = int.Parse(Console.ReadLine());
            //imprime na tela o resultado
            Console.WriteLine("\n Você digitou este número: {0}", numero);

            //Ler dois números int e imprimir na tela
            int n1, n2 = 0;
            Console.WriteLine("\n Digite um números inteiros : ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Digite outro número inteiro : ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Você digitou os seguintes números {0} e {1} : ",n1, n2);

            //ler um número inteiro e imprimir se antecessor e sucessor
            int ante, atual, proximo = 0;
            Console.WriteLine("\n Digite um número que vc deseja : ");
            atual = int.Parse(Console.ReadLine());
            Console.WriteLine("O número digitado foi : "+atual);

            ante = atual - 1;
            Console.WriteLine("O antecessor do numero digitado é: "+ante);

            proximo = atual + 1;
            Console.WriteLine("O sucesso dele é : "+ proximo);

            //ler um n real e imprimir a terceira parte
            double n = 0;
            Console.WriteLine("\n Digite um número real : ");
            n = double.Parse(Console.ReadLine());
            double resultado;
            resultado = n / 3;
            Console.WriteLine("\n A terceira parte do número digitado é "+resultado);

            //entrar com dois números reais e imprimir a media aritmética
            double num1, num2;
            Console.WriteLine("\n Digite o primeiro valor a ser processado: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("\n Digite o segundo valor para chegar a média; ");
            num2 = double.Parse(Console.ReadLine());
            double mediarit;
            mediarit = (num1 + num2) / 2;
            Console.WriteLine("A média aritmética dos numeros reais digitados é de " + mediarit);

            //imprimir o saldo de uma aplicação com 1% de ajuste, sendo que todos os valores serão dados entradas
            double saldo, reajuste, juros;
            saldo = 0;
            reajuste = 0;
            juros = 0;
            Console.WriteLine("Digite o valor que deseja para saldo : ");
            saldo = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite valor de juros a ser implementado: ");
            juros = double.Parse(Console.ReadLine());
            reajuste = saldo * (juros / 100);
            saldo = saldo + reajuste;
            Console.WriteLine("O valor calculado foi de R$ " + saldo);

            //entrar com um nome e imprimir algumas coisas
            string Nome = "";
            Console.WriteLine("Digite seu primeiro nome !");
            Nome = Console.ReadLine();

            //todo o nome
            Console.WriteLine("Todo o nome "+Nome);
            //primeiro caracter
            Console.WriteLine("Primeiro caractere ", Nome.Substring(0,1));
            //quantidade de caracteres
            Console.WriteLine("Quantidade de caracteres " , Nome.Length);
            Console.WriteLine("Último Caracter: {0}", Nome.Substring(Nome.Length - 1, 1));
            Console.WriteLine("Do Primeiro ate o Terceiro: {0}", Nome.Substring(0, 3));
            Console.WriteLine("O Quarto Caracter: {0}", Nome.Substring(3, 1));
            Console.WriteLine("Todos menos o Primeiro: {0}", Nome.Substring(1, Nome.Length - 1));
            Console.WriteLine("Os dois Último: {0}", Nome.Substring(Nome.Length - 2, 2));


            Console.ReadLine();
        }
    }
}
