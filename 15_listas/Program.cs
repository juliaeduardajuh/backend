using System.Collections.Generic;
using Sesi.Models;
public class Program
{
    public static void Main()
    {
     //criando uma lista de numeros inteiros
     List<string> listaNomes = new List<string>();
     listaNomes.Add("luana"); //posição 0
     listaNomes.Add("julia");
     listaNomes.Add("agnes");
     Console.WriteLine($"{listaNomes}");
     Console.WriteLine($"neste momento temos {listaNomes.Count} nrs");
     foreach (string item in listaNomes)
     {
        Console.WriteLine(item);
     }

     Console.WriteLine("-------------------------------");
     

     List<int> listaNumeros = new List<int>();
     listaNumeros.Add(10); //posição 0
     listaNumeros.Add(3);
     listaNumeros.Add(4);

     
     //acessando os dados da lista
     Console.WriteLine(listaNumeros[1]);

     listaNumeros.Add(80);
     Console.WriteLine($"neste momento temos {listaNumeros.Count} nrs");

     List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9,};
     numeros.Add(10);

     foreach (int item in numeros)
     {
        Console.WriteLine(item);
     }

     numeros.Remove(2);
     numeros.RemoveAt(4);
     numeros.RemoveRange(2, 2);

      foreach (int item in numeros)
     {
        Console.WriteLine(item);
     }

     List<Aluno> listaAlunos = new List<Aluno>();

    Aluno novoAluno = new Aluno("Luana", 16);
    listaAlunos.Add(novoAluno);

    listaAlunos.Add(new Aluno("Julia", 17));
    listaAlunos.Add(new Aluno("Agnes", 16));
    listaAlunos.Add(new Aluno("Douglas", 35));

    Console.WriteLine("Lista de Alunos:");
    foreach (Aluno item in listaAlunos)
    {
        Console.WriteLine($"Nome aluno: {item.nome}");
    }
    var consulta = from aluno in listaAlunos
                   where aluno.idade > 18
                   orderby aluno.nome
                   select aluno;
    
    Console.WriteLine($"Lista de alunos maiores de 18");
    foreach (Aluno item in consulta)
    {
        Console.WriteLine($"Nome aluno: {item.nome} idade {item.idade}");
    }
    
    var metodo = listaAlunos
                        .Where(aluno => aluno.idade < 18)
                        .OrderBy(aluno => aluno.nome);
    Console.WriteLine($"Lista de alunos menores de 18");
    foreach (var item in metodo)
    {
        Console.WriteLine($"Nome aluno: {item.nome} idade {item.idade}");
    }
    
    }
}