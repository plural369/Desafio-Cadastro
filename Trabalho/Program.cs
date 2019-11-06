using System;
using System.Collections.Generic;

namespace Trabalho
{
    class Program
    {
        static void Main(string[] args)
        {
            List<cadastro> usuario = new List<cadastro>();
            int escolha = 0, sair = 0;
            string continuar = "S";
            string excluir;
            var segura = new cadastro();
            var consulta = new cadastro();
            int escolha2 = 0;
            string nome;
            int RA1 = 0;

            while (sair != 4)
            {
                Console.WriteLine("Digite 1 = Incluir\n 2 = Excluir\n 3 = Consultar\n 4 = Sair");
                escolha = Convert.ToInt32(Console.ReadLine());
                continuar = "S";
                // Inclui alunos 

                if (escolha == 1)
                {
                    while (continuar.ToUpper() == "S")
                    {
                        var item = new cadastro();

                        Console.WriteLine("Digite seu RA: ");
                        item.RA = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite seu nome: ");
                        item.Nome = Console.ReadLine();
                        // data na forma DD/MM/YYYY
                        Console.WriteLine("Digite sua data de nascimento: ");
                        item.Datadenasc = Convert.ToDateTime(Console.ReadLine());

                        Console.WriteLine("Digite seu Sexo: ");
                        item.Sexo = Console.ReadLine();

                        Console.WriteLine("Digite seu CPF: ");
                        item.CPF = Console.ReadLine();

                        Console.WriteLine("Digite seu E-mail: ");
                        item.Email = Console.ReadLine();

                        usuario.Add(item);

                        Console.WriteLine("Digite S para continuar ou N para sair: ");
                        continuar = Console.ReadLine();
                    }
                }

                //Exclui usuario desejado

                else if (escolha == 2)
                {
                    Console.WriteLine("Digite o nome da pessoa que deseja excluir: ");
                    excluir = Console.ReadLine();
                    foreach (var item in usuario)
                    {
                        if (excluir == item.Nome)
                        {
                            segura = item;
                        }
                    }
                    usuario.Remove(segura);
                }

                //Consulta pelo nome ou pelo RA

                else if (escolha == 3)
                {
                    Console.WriteLine("Digite 1 = Consultar pelo nome\n 2 = Consultar pelo RA: ");
                    escolha2 = Convert.ToInt32(Console.ReadLine());

                    if (escolha2 == 1)
                    {
                        Console.WriteLine("Digite o nome que deseja consultar: ");
                        nome = Console.ReadLine();
                        foreach (var item in usuario)
                        {
                            if (nome == item.Nome)
                            {
                                Console.WriteLine("\n\n***********************");
                                Console.WriteLine("RA: " + item.RA);
                                Console.WriteLine("Nome: " + item.Nome);
                                Console.WriteLine("Data de nascimento: " + item.Datadenasc);
                                Console.WriteLine("Sexo: " + item.Sexo);
                                Console.WriteLine("E-mail: " + item.Email);
                                Console.WriteLine("CPF: " + item.CPF);
                                Console.WriteLine("****************************");
                            }
                        }
                    }
                    else if (escolha2 == 2)
                    {
                        Console.WriteLine("Digite o RA que deseja consultar: ");
                        RA1 = Convert.ToInt32(Console.ReadLine());
                        foreach (var item in usuario)
                        {
                            if (RA1 == item.RA)
                            {
                                Console.WriteLine("\n\n***********************");
                                Console.WriteLine("RA: " + item.RA);
                                Console.WriteLine("Nome: " + item.Nome);
                                Console.WriteLine("Data de nascimento: " + item.Datadenasc);
                                Console.WriteLine("Sexo: " + item.Sexo);
                                Console.WriteLine("E-mail: " + item.Email);
                                Console.WriteLine("CPF: " + item.CPF);
                                Console.WriteLine("****************************");
                            }
                        }
                    }
                }
                else if (escolha == 4)
                {
                    sair = 4;
                }
                else
                {
                    Console.WriteLine("Operação inválida");
                }

                foreach (var item in usuario)
                {
                    Console.WriteLine("\n\n***********************");
                    Console.WriteLine("RA: " + item.RA);
                    Console.WriteLine("Nome: " + item.Nome);
                    Console.WriteLine("Data de nascimento: " + item.Datadenasc);
                    Console.WriteLine("Sexo: " + item.Sexo);
                    Console.WriteLine("E-mail: " + item.Email);
                    Console.WriteLine("CPF: " + item.CPF);
                    Console.WriteLine("****************************");
                }
            }
        }
    }
}
