//Peça ao usuário para digitar três notas. Em seguida, calcule e exiba a média aritmética dessas notas

class Program {
    static void  Main(String[] args){

        Console.WriteLine("Digite sua primeira nota: ");
        double nota1 = double.Parse(
            Console.ReadLine());
        Console.WriteLine("Digite sua segunda nota: ");
        double nota2 = double.Parse(
            Console.ReadLine());
        Console.WriteLine("Digite sua terceira nota: ");
        double nota3 = double.Parse(
            Console.ReadLine());

        double media = (nota1+nota2+nota3)/3;

        Console.WriteLine($"\nParabens sua media foi de: {media}\n");

    }
}