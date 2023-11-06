namespace DesafiosCSharp
{
    public class Desafio2
    {

        private int[] numbers = { 4, 6, 8};

        public Desafio2()
        {
            Console.WriteLine("A média é: " + FindAverage(numbers));
            Console.ReadLine();
        }

        public static double FindAverage(int[] numbers)
        {

            double sum = 0;

            if (numbers.Length < 3)
            {
                return -1;
            }

            foreach (int number in numbers)
            {
                sum += number;
            }

            double average = sum / numbers.Length;

            return average;
        }
    }
}
