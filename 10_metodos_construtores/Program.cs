using Models;

public class Program
{
    public static void Main()
    {
        /*
        Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Taylor Swift";
        pessoa1.idade = 33;
       */

       //

       Pessoa pessoa1 = new Pessoa("Taylor Swift", 33);
        pessoa1.Cantar();

       Pessoa pessoa2 = new Pessoa("Olivia Rodrigo", 20);
        pessoa2.Cantar();

       Pessoa pessoa3 = new Pessoa("Harry Styles", 29);
        pessoa3.Cantar();
    
    }
}