public class Program
{
    public static void Main()
    {
        try{
        Console.WriteLine("digite um numero inteiro");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine($"Vc digitou o nº {numero}");
        }
        catch(OverflowException)
        {
            Console.WriteLine("O numero digitado é maior que o limite aceito");
        }
        catch (FormatException)
        {
            Console.WriteLine("Digite um numero inteiro");
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro: {erro.Message}");
        }
        finally{
            Console.WriteLine($"No bloco finally o programa entra independentemente de exceção");

        }
    }
}
