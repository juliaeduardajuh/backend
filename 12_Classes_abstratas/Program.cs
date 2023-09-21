 abstract class Animal
{
    public string cor{ get; set; }
    public virtual void EmitirSom()
    {
        Console.WriteLine($"Animal da cor {cor} fazendo algum som");
    }
}
class Cachorro: Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine($"Cachorro da cor {cor} está latindo! Au au au");
    }
}
class Gato: Animal
{
public override void EmitirSom()
    {
        Console.WriteLine($"Gato da cor {cor} está miando! Miau miau");
    }
public void Ronronar()
    {
        Console.WriteLine("O gato está ronronando");
    }
}
class Program
{
     public static void Main()
     {
        /*
        Animal animalGenerico = new Animal();
        animalGenerico.cor = "Preto";
        animalGenerico.EmitirSom();
        */
        Cachorro meuCachorro = new Cachorro();
        meuCachorro.cor = "Caramelo";
        meuCachorro.EmitirSom();
        
        Gato meuGato = new Gato();
        meuGato.cor = "Cinza";
        meuGato.EmitirSom();
        meuGato.Ronronar();
     }
}



