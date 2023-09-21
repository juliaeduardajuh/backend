//Somente declaramos a variável como inteira e não atribuimos valor 
int numl;

//Declarando uma variável do tipo inteira e atribuimos o valor 5
int num2 = 5;

//Declarando uma variável do tipo string
string nomeAluno;

//variável do tipo lógico (verdadeiro ou falso)
bool resultado = true;

//variável do tipo valor com casas decimais - para valores mais preciosos
double coordenada = 1.80;

//variável do tipo decimal - mais usada para valor monetário
decimal valor = 1.80M;


int idade = 17;
string nome = "Julia";
Console.WriteLine($"Meu nome é {nome} e tenho {idade} anos");

Console.WriteLine("Em que cidade você nasceu?");
//Recebendo uma informação do usuário e atribuindo na varíavel cidade
string cidade = Console.ReadLine();
Console.WriteLine($"Você nasceu em {cidade}");

int novaIdade = idade + 5;
int anoNascimento = 2023 - idade;
Console.WriteLine($"Você nasceu em {anoNascimento} e daqui 5 anos terá {novaIdade}");