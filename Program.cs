﻿using System;
using Atividade.Essencial;

namespace UsoAtividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Endereco endereco = new Endereco();
            Aluno aluno = new Aluno();
            Professor professor = new Professor();
            Materia materias = new Materia();
            Turma turma = new Turma();
            Sala sala = new Sala();

            int opcao = 0;
            while(opcao!=9){
                Console.Clear();
                Console.WriteLine("Programa de Cadastro de Escola");
                Console.WriteLine("");
                Console.WriteLine("Digite uma das opções abaixo para prosseguir: ");
                Conosle.WriteLine("1-Cadastro de Alunos\n2-Cadastro de Professores\n3-Cadastro de Materias\n4-Cadastro de Turmas\n9-Sair");
                opcao = int.Parse(Console.ReadLine());
                switch(opcao){
                    case 1:
                    Console.WriteLine("Digite um código para o aluno");
                    aluno.Id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o nome do aluno:");
                    aluno.Nome = Console.ReadLine();
                    Console.WriteLine("Digite o email do aluno:");
                    aluno.Email = Console.ReadLine();
                    Console.WriteLine("Digite a idade do aluno:");
                    aluno.Idade = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a rua onde o aluno mora:");
                    endereco.Logradouro = Console.ReadLine();
                    Console.WriteLine("Digite o número da residência:");
                    endereco.Numero = Console.ReadLine();
                    Console.WriteLine("Digite o complemento:");
                    endereco.Complemento = Console.ReadLine();
                    Console.WriteLine("Digite o bairro:");
                    endereco.Bairro = Console.ReadLine();
                    Console.WriteLine("Digite a cidade");
                    endereco.Cidade = Console.ReadLine();
                    aluno.End = endereco;

                    Console.WriteLine(aluno.Salvar());
                    break;

                    case 2:
                    Console.WriteLine("Digite um código para o professor:");
                    professor.Id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o nome do professor:");
                    professor.Nome = Console.ReadLine();
                    Console.WriteLine("Digite a formação do professor:");
                    professor.Formacao = Console.ReadLine();
                    Console.WriteLine("Digite o telefone:");
                    professor.Telefone = Console.ReadLine();
                    Console.WriteLine("Digite a rua da residência:");
                    endereco.Logradouro = Console.ReadLine();
                    Console.WriteLine("Digite o número da residência:");
                    endereco.Numero = Console.ReadLine();
                    Console.WriteLine("Digite o complemento:");
                    endereco.Complemento = Console.ReadLine();
                    Console.WriteLine("Digite o bairro:");
                    endereco.Bairro = Console.ReadLine();
                    Console.WriteLine("Digite a cidade:");
                    endereco.Cidade = Console.ReadLine();
                    professor.End = endereco;

                    Console.WriteLine(professor.Salvar());
                    break;

                    case 3:
                    Console.WriteLine("Digite um código para a matéria:");
                    materias.Id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o título da matéria:");
                    materias.Titulo = Console.ReadLine();
                    Console.WriteLine("Digite a carga horária da matéria:");
                    materias.Carga.Horaria = Console.ReadLine();

                    Console.WriteLine(materias.salvar());
                    break;

                    case 4:
                    Console.WriteLine("Digite um código para a turma:");
                    turma.Id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o título da turma:");
                    turma.TituloTurma = Console.ReadLine();
                    int adicionar = -1;
                    int qtd = 0;
                    Aluno[] novosAlunos = new Aluno[20];
                    while(adicionar!=0){
                        Console.WriteLine("Essa turma comporta 20 alunos. Digite os ids dos alunos que farão parte desta turma. Para sair digite 0(zero)\nFaltao:"+(20-qtd));
                        adicionar = int.Parse(Console.ReadLine());
                        if(aluno.Pesquisar(adicionar)==null){
                            Console.WriteLine("Este aluno não existe.");
                            Console.WriteLine("Pressione qualquer tecla para continuar:");
                        }
                        else
                        {
                            novosAlunos[qtd] = aluno.Pesuisar(adicionar);
                            qtd++;
                        }
                    }
                    turma.Alunos = novosAlunos;
                    Console.WriteLine("Digite o id do professor:");
                    professor.Id = int.Parse(Console.ReadLine());

                    Console.WriteLine("Nome do Professor:");
                    professor.Nome = Console.ReadLine();

                    turma.Prof = professor;

                    qtd = 0;
                    adicionar = -1;
                    Materia[] novaMateria = new Materia[5];
                    while(adicionar!=0){
                        Console.WriteLine("Digite no máximo 5 metérias. Digite os ids das matérias para adicioná-las. Para sair digite SAIR\nFaltam "+(5-qtd));
                        adicionar = int.Parse(Console.ReadLine());
                        if(materias.Pesuisar(adicionar)==null){
                            Console.WriteLine("Matéria não encontrada.");
                            Console.WriteLine("Pressione uma tecla para continuar.");
                        }
                        else{
                            novaMateria[qtd] = materias.Pesquisar(adicionar);
                            qtd++;
                        }
                    }

                    turma.Materias = novaMateria;

                    Console.WriteLine("Digite os dados da sala SEPARADOS POR (;) como segue: Id; Número da sala; Tipo de sala; Capacidade e tecle ENTER:");
                    string[] dadosSala = Console.ReadLine().Split(';');
                    sala.Id = int.Parse(dadosSala[0]);
                    sala.Numero = int.Parse(dadosSala[1]);
                    sala.tipoSala = dadosSala[2];
                    sala.Capacidade = int.Parse)dadosSala[3];

                    turma.Sal = sala;

                    Console.WriteLine(turma.Salvar());
                    break;
                }
            }
        }
    }
}
