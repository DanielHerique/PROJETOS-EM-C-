//Solicite que o usuário informe o seu ano de nascimento e calcule a idade considerando o ano atual como 2024

class Program {
    static void  Main(String[] args){

        Console.WriteLine("Digite o seu ano de nascimento: ");
        int anoNascimento = int.Parse(
            Console.ReadLine());
        int idade = 2024 - anoNascimento;
        Console.WriteLine($"\nSua idade é de: {idade}\n");

    }
}