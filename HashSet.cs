using System;
using System.Collections.Generic;
namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();
            Console.Write("Quantos alunos possui o curso A? ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A: ");
            for (int i = 0; i < N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                A.Add(x);
            }
            Console.Write("Quantos alunos possui o curso B? ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B: ");
            for (int i = 0; i < N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                B.Add(x);
            }
            Console.Write("Quantos alunos possui o curso C? ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C: ");
            for (int i = 0; i < N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                C.Add(x);
            }
            HashSet<int> Novo = new HashSet<int>();
            Novo.UnionWith(A);
            Novo.UnionWith(B);
            Novo.UnionWith(C);
            Console.WriteLine("Total de Alunos: " + Novo.Count);
            Console.ReadLine();
        }
    }
}


/*
O curso A possui quantos alunos? 3
Digite os códigos dos alunos do curso A:
21
35
22
O curso B possui quantos alunos? 2
Digite os códigos dos alunos do curso B:
21
50
O curso C possui quantos alunos? 3
Digite os códigos dos alunos do curso C:
42
35
13
Total de alunos: 6
*/
