// O namespace é um nome em que usaremos para fazer referência quandp usarmos
namespace Sesi.Model
{
    public class Aluno
    {
        //Declarando os atributos (propriedades) da classe Aluno
        public string nome { get; set; }
        public int idade { get; set; }
        public string turma { get; set; }

        public int nrFaltas { get; set; }

        //Criando um método
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {nome}, eu tenho {idade} anos e estudo na {turma}, e tenho {nrFaltas} faltas");
        }

        public void AdicionarFaltas(int nr)
        {
            Console.WriteLine($"O aluno {nome} faltou hoje e somou {nr}");
            nrFaltas = nrFaltas + nrFaltas;
        }
         public void faltas(){
            Console.WriteLine($"O aluno {nome} tem {nrFaltas} faltas");
         }

    }
}