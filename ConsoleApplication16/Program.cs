using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Lista2
{
      /* Atividades : Retorna maior valor inteiro 
                      Retorna Arraylist
                      Retorna maior nota
                      Verificar parametro      */
                
    class Program
    {
        static void Main(string[] args)
        {
            VerificaArray array = new VerificaArray();
            Aluno aluno = new Aluno();
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add(2);
            al.Add(3);
            al.Add(4);
            al.Add(5);

            List<Aluno> alun = new List<Aluno>();

            alun.Add(new Aluno("Joao Paulo", 16, 'M', "Quimica", 2));
            alun.Add(new Aluno("Thiago Teodoro", 19, 'M', "Fisica", 6));
            alun.Add(new Aluno("Homero", 22, 'M', "Ciencias", 8));
            alun.Add(new Aluno("Tulio ", 33, 'M', "Matematica", 1));
            alun.Add(new Aluno("Augusto", 18, 'M', "Portugues", 3));
            alun.Add(new Aluno("Igor", 55, 'M', "Biologia", 7));

            List<Aluno> Turma = new List<Aluno>();
            Turma.Add(new Aluno("Joao PAulo", 16, 'M', "Quimica", 2));
            Turma.Add(new Aluno("Thiago Teodoro", 19, 'M', "Fisica", 6));
            Turma.Add(new Aluno("Homero", 22, 'M', "Ciencias", 8));
            Turma.Add(new Aluno("Tulio ", 33, 'M', "Matematica", 1));
            Turma.Add(new Aluno("Augusto", 18, 'M', "Portugues", 3));
            Turma.Add(new Aluno("Igor", 55, 'M', "Biologia", 7));
            Turma.Add(new Aluno("Jose", 55, 'M', "Matematica", 4));
            Turma.Add(new Aluno("Antonio Almeida", 72, 'M', "Portugues", 3));
            Turma.Add(new Aluno("Gisele", 69, 'F', "Portugues", 8));
            Turma.Add(new Aluno("Anastacia", 42, 'F', "Quimica", 9));
            Turma.Add(new Aluno("Bruna Penido", 20, 'F', "Geologia", 1));
            Turma.Add(new Aluno("Marcela", 19, 'M', "Matematica", 10));
            Turma.Add(new Aluno("Marcelo", 19, 'M', "Historia", 5));
            Turma.Add(new Aluno("Adalto", 22, 'M', "Geografia", 2));
            Turma.Add(new Aluno("Luis", 56, 'M', "Matematica", 7));
            Turma.Add(new Aluno("Joao NEto", 23, 'M', "Filosofia", 9));
            Turma.Add(new Aluno("Junior", 19, 'M', "Fisica", 7));
            Turma.Add(new Aluno("PEdro ", 29, 'M', "Matematica", 10));
            Turma.Add(new Aluno("Adelmo", 33, 'M', "Psicologia", 7));
            
            int menu = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("\t\tLISTA DE EXERCÍCIOS II");
                Console.WriteLine("\n1) Retorna maior valor inteiro");
                Console.WriteLine("2) Retorna Arraylist");
                Console.WriteLine("3) Retorna maior nota");
                Console.WriteLine("4) Verificar parametro");
                Console.WriteLine("\nTecle <ENTER> para fechar o programa");
                Console.Write("Digite o exercicio escolhido: ");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        {
                            Console.Write("\nMaior elemento é: " + array.MaiorValor(al));
                            Console.Write("\nDigite <ENTER> para voltar menu principal");
                            Console.ReadKey();

                            break;
                        }
                    case 2:
                        {
                            array.ParesDeUmArray(al);
                            Console.Write("\nDigite <ENTER> para voltar menu principal");
                            Console.ReadKey();

                            break;
                        }
                    case 3:
                        {
                            Console.Write("\nA maior nota é do aluno " + alun[aluno.MaiorNota(alun)].Nome +
                           ", sua nota é de " + alun[aluno.MaiorNota(alun)].Nota + " pontos.");
                            Console.Write("\nDigite <ENTER> para voltar menu principal");
                            Console.ReadKey();

                            break;
                        }
                    case 4:
                        {
                            if (aluno.VetorContido(alun, Turma))
                            {
                                Console.Write("\nOs alunos estão  na turma");
                            }
                            else
                            {
                                Console.Write("\nOs alunos não estão na turma");
                            }

                            Console.Write("\nDigite <ENTER> para voltar menu principal");

                            Console.ReadKey();

                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                Console.Clear();
            }
            while (menu != 0);
        }
    }

    class VerificaArray
    {
        public int MaiorValor(ArrayList al)
        {
            int maior = 0;
            int posMaior = 0;

            for (int i = 0; i < al.Count; i++)
            {
                if (Convert.ToInt32(al[i]) > maior)
                {
                    maior = Convert.ToInt32(al[i]);
                    posMaior = i;
                }
            }

            return maior;
        }
        public void ParesDeUmArray(ArrayList al)
        {
            int[] vetPar = new int[al.Count];

            for (int i = 0; i < al.Count; i++)
            {
                if (Convert.ToInt32(al[i]) % 2 == 0)
                {
                    vetPar[i] = Convert.ToInt32(al[i]);
                }
            }

            Console.Write("\nNúmeros pares do ArrayList: ");
            for (int i = 1; i < vetPar.Length; i++)
            {
                if (vetPar[i] != 0)
                {
                    Console.Write(vetPar[i] + " ");
                }
            }
        }
    }


    class Aluno
    {
        private string nome;
        private int idade;
        private char sexo;
        private string nomeDisciplina;
        private double nota;


        public Aluno()
        {

        }


        public Aluno(string nome, int idade, char sexo, string nomeDisciplina, double nota)
        {
            Nome = nome;
            Idade = idade;
            Sexo = sexo;
            NomeDisciplina = nomeDisciplina;
            Nota = nota;
        }


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public string NomeDisciplina
        {
            get { return nomeDisciplina; }
            set { nomeDisciplina = value; }
        }
        public double Nota
        {
            get { return nota; }
            set { nota = value; }
        }

        public int MaiorNota(List<Aluno> al)
        {
            double maior = 0;
            int posMaior = 0;

            for (int i = 0; i < al.Count; i++)
            {
                if (al[i].Nota > maior)
                {
                    maior = al[i].Nota;
                    posMaior = i;
                }
            }

            return posMaior;
        }
        
        public bool VetorContido(List<Aluno> al, List<Aluno> al2)
        {
            for (int i = 0; i < al2.Count; i++)
            {
                if (i < al.Count)
                {
                    for (int a = 0; a < al.Count; a++)
                    {
                        if (al2[i].Nome == al[a].Nome)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}