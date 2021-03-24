using System;

namespace AlunosConceitoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];

            int studentIndex = 0;

            string chosenOption = catchUserOption();

            while (chosenOption.ToUpper() != "X")
            {
                switch (chosenOption)
                {
                    case "1"://To do?: list students
                        Console.WriteLine("Informe o nome do aluno:");
                        Student student = new Student();
                        student.Name = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno:");

                        if (decimal.TryParse(Console.ReadLine(), out decimal grade))
                        {

                            student.Score = grade;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota precisa ser decimal!");
                        }


                        students[studentIndex] = student;
                        studentIndex++;

                        Console.WriteLine();
                        Console.WriteLine("Aluno cadastrado com sucesso!");

                        break;

                    case "2"://To do?: list students
                        foreach (var s in students)
                        {
                            if (!string.IsNullOrEmpty(s.Name))
                            {
                                Console.WriteLine($"Aluno: {s.Name} - Nota: {s.Score}");
                            }

                        }
                        break;

                    case "3"://To do?: calculate class average

                        decimal totalScore = 0;
                        var studentsNumber = 0;
                        for (int i = 0; i < students.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(students[i].Name))
                            {
                                totalScore = totalScore + students[i].Score;
                                studentsNumber++;
                            }
                        }

                        var totalAverage = totalScore / studentsNumber;

                        Conceito conceptAll;
                        if (totalAverage < 2)
                        {
                            conceptAll = Conceito.F;

                        } else if(totalAverage < 4){
                            conceptAll = Conceito.D;

                        } else if(totalAverage < 6){
                            conceptAll = Conceito.C;
                            
                        }else if(totalAverage < 8){
                            conceptAll = Conceito.B;
                            
                        } else{
                            conceptAll = Conceito.A;
                        }


                        Console.WriteLine($"Média Geral: {totalAverage} - Conceito: {conceptAll}");


                        //To do?: calculate class average
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }




                //reading the chosen option

                chosenOption = catchUserOption();
            }
        }

        private static string catchUserOption()
        {
            //Setting options
            Console.WriteLine();
            Console.WriteLine("Escolha a opção desejada:");
            Console.WriteLine("1 - Cadastrar novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral dos alunos");
            Console.WriteLine("X - Sair");
            Console.WriteLine();


            //reading the chosen option

            string chosenOption = Console.ReadLine();
            Console.WriteLine();
            return chosenOption;
        }
    }
}
