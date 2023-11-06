namespace DesafiosCSharp
{
    public class Desafio6
    {

        private int[] numbers = new int[]{ 9, 6, 7, 7, 5, 4, 2, 3, 1 };

        public Desafio6()
        {
            GrowingNumbers(numbers);

            foreach (var number in numbers)
            {
                Console.WriteLine(number.ToString());
            }
        }

        public static int[] GrowingNumbers(int[] numbers)
        {
            Array.Sort(numbers);

            return numbers;
        }
    }
}
