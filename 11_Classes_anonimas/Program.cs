public class Program
{
     
     public static void Main()
     { 
        var pessoa1 = new{
            nome = "João",
            idade = 20
        };
        var pessoa2 = new {
            nome = "Maria",
            idade = "17"
        };
        Console.WriteLine($"A Pessoa 1 se chama {pessoa1.nome} e a Pessoa 2 {pessoa2.nome}");

        Console.WriteLine("Digite a marca do veículo: ");
        string marca = Console.ReadLine();

        Console.WriteLine("Digite o modelo do veículo: ");
        string modelo = Console.ReadLine();

        Console.WriteLine("Digite o ano do veículo: ");
        string ano = Console.ReadLine();

        var possante = new
        {
            marca,
            modelo,
            Ano = ano
        };

        Console.WriteLine($"O carro {modelo} é da marca {marca} e do ano {ano}");
     }
}