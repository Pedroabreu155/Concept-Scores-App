using System;

namespace AlunosConceitoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setting options

            Console.WriteLine("Escolha a opção desejada:");
            Console.WriteLine("1 - Cadastrar novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral dos alunos");
            Console.WriteLine("(X) Sair");
            Console.WriteLine();


            //reading the chosen option

            string chosenOption = Console.ReadLine();

            while(chosenOption.ToUpper() != "X"){
                switch(chosenOption){
                    case "1":
                        //To do?: add alumn
                        break;

                    case "2":
                        //To do?: list alumns
                        break;
                        
                    case "3":
                        //To do?: calculate class average
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}
