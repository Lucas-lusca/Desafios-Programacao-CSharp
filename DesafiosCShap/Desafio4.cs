namespace DesafiosCSharp
{
    public class Desafio4
    {
        public Desafio4()
        {
            Console.WriteLine("Escreva algo:");
            string? stringValor = Console.ReadLine();
            Console.WriteLine(StringInversor(stringValor));
        }

        public static char[] StringInversor(string str)
        {
            return str.Reverse().ToArray();
        }
    }
}
