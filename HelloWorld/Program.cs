using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static string meuNomeCompleto = "Vinicius Moraes Zaki";

        // TRABALHANDO COM ENUM
        enum Cor { Preto, Branco, Azul, Amarelo, Rosa, Verde, Vermelho }

        // FAZENDO MENU COM ENUM
        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }

        static void Main(string[] args)
        {
            // Int
            // exemplo: -156 como 32334
            // Float
            // exemplo: -15.6 como 232.132
            // Bool
            // exemplo: - true or false
            // String
            // exemplo: - "Texto"
            // Char
            // exemplo: - 'a'

            // A-Z
            // 0-9
            // @ $ . (não posso)
            // _ 
            // não pode ter palavras reservadas

            /*
            int segundaGuerraMundial = 1942;
            string corFavorita = "Preto";
            float velocidadeF1 = 294.48f;
            bool segundaGuerraMundialAconteceu = true;

            Console.WriteLine(segundaGuerraMundial);
            Console.WriteLine(corFavorita);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(segundaGuerraMundialAconteceu);

            velocidadeF1 = 348.29f;
            corFavorita = "azul";

            Console.WriteLine(corFavorita);
            Console.WriteLine(velocidadeF1);


            */

            /*
            var cor_favorita = "Vermelho";
            var modeloDoProduto = 2323;
            */

            /*
            dynamic cor_favorita = "Vermelho";

            Console.WriteLine(cor_favorita);

            cor_favorita = 123456789;

            Console.WriteLine(cor_favorita);

            cor_favorita = 4567.5678;

            Console.WriteLine(cor_favorita);

            cor_favorita = true;

            Console.WriteLine(cor_favorita);
            */

            //const float PI = 3.1415f;

            /*
            string nome = "";
            Console.WriteLine("Escreva seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Seu nome é: ");
            Console.WriteLine(nome);
            */

            /*
            int numeroQualquer = 20 + 20 - 80;
            int numeroMult = 10 * 90;
            int numeroDiv = 5 / 2;
            float numeroDivDecimal = 5.0f / 2;

            int teste = 2+2*10;

            // 6 / 2 => 3   //int
            // 5 / 2 => 2.5 //float

            Console.WriteLine(numeroQualquer);
            Console.WriteLine(numeroMult);
            Console.WriteLine(numeroDiv);
            Console.WriteLine(numeroDivDecimal);
            Console.WriteLine(teste);
            */

            /*
            int a = 10;
            int b = 20;
            int c = 2;

            if (a < b) {
                Console.WriteLine("É verdade!");
            }
            else if (a > c)
            {
                Console.WriteLine("Executou else if!");
            }else
            {
                Console.WriteLine("É mentira! plaft");
            }
            */

            /*
            Console.WriteLine("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 0 && idade <= 11)
            {
                Console.WriteLine("Você é uma criança");
            }else if (idade >= 12 && idade <= 18)
            {
                Console.WriteLine("Você é um adolescente");
            }else if (idade >= 19 && idade <= 60)
            {
                Console.WriteLine("Você é um adulto");
            }
            else
            {
                Console.WriteLine("Você é um idoso");
            }
            */

            /*
            exibirMsg();

            gerarPreco(-20);
            */

            //string valor = Console.ReadLine();

            //Console.WriteLine(valorv);

            /*
            int soma1 = Somar(1,2,3);
            int soma2 = Somar(10,20,30);
            int soma3 = Somar(100,200,300);

            Console.WriteLine(soma1);
            Console.WriteLine(soma2);
            Console.WriteLine(soma3);
            */

            /*
            //AULA DE ARRAYS

            string produto1 = "Sea of thieves";
            string produto2 = "FIFA";
            string produto3 = "Minecraft";
            string produto4 = "Half-life";
            string produto5 = "Portal";
            string produto6 = "CS";


            // ESSE AQUI EM BAIXO É UM ARRAY
            string[] produtos = new string[6] {
                "Sea of thieves", // 0 
                "FIFA", // 1
                "Minecraft", // 2
                "Half-life", // 3
                "Portal", // 4
                "CS" // 5
            };
            // DEFININDO NOVO VALOR PARA POSIÇÃO [1] DO ARRAY
            produtos[1] = "FIFA 2021";

            // OUTRO TIPO DE DEFINIR UM ARRAY (SIMPLIFICADO)

            int[] valores = {1,2,3,4,5,6}; //MELHOR JEITO DE USAR

            // APRESENTANDO A POSIÇÃO NA MATRIZ DENTRO DO ARREY
            Console.WriteLine(produtos[1]);
            // APRESENTANDO A POSIÇÃO NA MATRIZ DENTRO DO ARREY (SIMPLIFICADO) 
            Console.WriteLine(valores[0]);
            */

            // TRABALHANDO COM SWITCH CASE
            /*
            string cor = "Verde";

            switch (cor)
            {
                case "Vermelho":
                    Console.WriteLine("Sua cor favorita é Vermelho");
                    break;
                case "Amarelo":
                    Console.WriteLine("Sua cor favorita é Amarelo");
                    break;
                case "Azul":
                    Console.WriteLine("Sua cor favorita é Azul");
                    break;
                default:
                    Console.WriteLine("Sua cor favorita eu não sei!");
                    break;
            }
            */

            /*
            //aplicando enum
            Cor corFavorita = Cor.Preto;
            Cor corFavoritaDaCarla = Cor.Azul;

            Console.WriteLine(corFavorita);
            // fazendo cast com enum
            Console.WriteLine((int)corFavorita);
            Console.WriteLine((Cor)2);
            Console.WriteLine(corFavoritaDaCarla);
            */

            // FAZENDO MENU COM ENUM (APLICANDO)
            /*
            Console.WriteLine("Selecione uma das opções abaixo: ");

            Console.WriteLine("1 - Cria\n2 - Deletar\n3 - Editar\n4 - Listar\n5 - Atualizar\n");

            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;


            //Console.WriteLine(opcaoSelecionada);

            switch (opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("\nVocê quer Criar algo!");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("\nDelete imediatamente!");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("\nEditar é muito bom!");
                    break;
                case Opcao.Atualizar:
                    Console.WriteLine("\nPartiu Atualizar!");
                    break;
                case Opcao.Listar:
                    Console.WriteLine("\nVocê quer Listar algo!");
                    break;
                default:
                            Console.WriteLine("\nOpção não encontrada!");
                    break;
            }
            */

            /*
            // APRENDENDO A MANIPULAR WHILE
            int contador = 0;
            while(contador < 20) // ENQUANTO FOR VERDADE, FAÇA!
            {
                Console.WriteLine(contador);
                Console.WriteLine("Rodando while!");
                //contador = contador + 1; //primeira forma de utilizar
                //contador += 1; // segunda forma de utilizar
                contador++; // 3ª forma de utilizar (MAIS USADA)
            }
            Console.WriteLine("Fim do programa");
            Console.ReadLine();
            */

            /*
            //MANIPULANDO DO WHILE
            int contador2 = 0;
            do
            {
                Console.WriteLine("do while");
                contador2++;
            } while (contador2 < 20);
            Console.ReadLine();
            */


            /*
            // MANIPULANDO FOREACH

            string[] palavras = {"Vinicius", "Zaki", "Guia do Prog","Formação","Node","Curso de C#", "udemy" };

            foreach(string palavra in palavras) // para cada palavra no array palavras, repita o bloco de codigo.
            {
                Console.WriteLine(palavra);
            }
            Console.ReadLine();
            */

            /*

            // MANIPULANDO FOR

            // PERCORRENDO ARRAY DE FORMA CRESCENTE
            string[] palavras = { "Vinicius", "Zaki", "Guia do Prog", "Formação", "Node", "Curso de C#", "udemy" };

            for (int contador = 0; contador < palavras.Length; contador++)
            {
                Console.WriteLine("Rodando For");
                Console.WriteLine(contador);
                Console.WriteLine(palavras[contador]);
            }

            Console.WriteLine("============================================");
            
            
            // PERCORRENDO ARRAY DE FORMA DECRESCENTE
            for (int contador2 = palavras.Length-1; contador2 >= 0; contador2--)
            {
                Console.WriteLine(contador2);
                Console.WriteLine(palavras[contador2]);
            }
            Console.WriteLine("Fim do programa");
            Console.ReadLine();
            */
           
            
            Console.WriteLine(meuNomeCompleto);


            Console.ReadLine();
        }
        static void exibirMsg()
        {
            Console.WriteLine("estou usando funções");
            Console.WriteLine("bem vindo");
            Console.WriteLine("teste");
            Console.WriteLine(meuNomeCompleto);
        }
        static void gerarPreco(int preco)
        {
            int precoAbs = Math.Abs(preco);
            int valorFinal = precoAbs + (2 * precoAbs);
            Console.WriteLine("Valor final: " + valorFinal);
            Console.WriteLine(meuNomeCompleto);

        }

        static int Somar(int a, int b, int c)
        {
            int resultadoFinal = a + b + c;
            return resultadoFinal;
        }
    }
}
