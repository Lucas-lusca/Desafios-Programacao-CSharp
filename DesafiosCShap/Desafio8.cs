namespace DesafiosCSharp
{
    public class Desafio8
    {
        string[] lines = File.ReadAllLines("data.dat");

        public Desafio8()
        {
            Console.WriteLine("Linhas que atendem as condições: " + CheckBinary(lines));
        }

        public static int CheckBinary(string[] lines)
        {
            int okLines = 0;

            foreach (var line in lines)
            {

                int totalOfZero = 0;
                int totalOfOne = 0;

                foreach (var character in line)
                {
                    if (character == '0')
                    {
                        totalOfZero += 1;
                    }

                    if (character == '1')
                    {
                        totalOfOne += 1;
                    }
                }

                if (totalOfZero % 3 == 0 || totalOfOne % 2 == 0)
                {
                    okLines += 1;
                }
            }

            return okLines;
        }
    }
}
