class ex005{
    public static void Main()
    {
        //Chamar metodo
        ListaDeChurrasco();
    }

    public static void ListaDeChurrasco(){
        //Declarar o vetor com 6 posiçoes tipo string
        string[]listaProdutos = new string[6];

        //receber os produtos que precisam ser comprados
        listaProdutos[0] = "Carne 3kg";
        for (int i = 0; i < listaProdutos.Length; i++)
        {
            Console.WriteLine("Informe o produto:");
            string produto = Console.ReadLine();
            listaProdutos[i] = produto;
        }

        //Ordenar vetor
        Array.Sort(listaProdutos);

        //"Para cada" item na lista exibir no console
        foreach (string item in listaProdutos){
            Console.WriteLine($"item {item}");
        }
    }
}