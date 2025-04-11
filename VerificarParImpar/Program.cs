// Peça ao usuário que digite um número e informe se ele é par ou ímpar

class Program {
    static void  Main(String[] args){

        Console.WriteLine("Digite seu numero: ");
        int n1 = int.Parse(
            Console.ReadLine());

        Console.WriteLine("\nSera que ele e par ou impar?");


        if (n1 % 2 == 1){Console.WriteLine($"\nO numero {n1} é IMPAR \n");}
        else{Console.WriteLine($"\nO numero {n1} é PAR \n");}
    }
}