//Peça ao usuário que digite seu nome e, em seguida, exiba uma saudação personalizada utilizando o nome inserido.
class Program {
    static void  Main(String[] args){

        Console.WriteLine("Digite o seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine($"\nOla {nome} Seja Bem vindo ao Exercico em C#\n");
    }
}