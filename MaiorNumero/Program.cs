//Solicite dois números ao usuário e exiba na tela qual deles é o maior.

class Program {
    static void  Main(String[] args){

        Console.WriteLine("Digite seu primeiro numero: ");
        int n1 = int.Parse(
            Console.ReadLine());
        Console.WriteLine("Digite seu segundo numero: ");
        int n2 = int.Parse(
            Console.ReadLine());

        if (n1 > n2){Console.WriteLine($"\nO maior numero é: {n1}\n");}
        else{Console.WriteLine($"\nO maior numero é: {n2}\n");}
    }
}