namespace DesafiosCSharp
{
    public class Desafio3
    {

        private int[] numbers = new int[]{
           1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12
        };

        public Desafio3()
        {
            int evenNumbers = EvenNumbersCounter(numbers);

            Console.WriteLine("Quantidade de pares: " + evenNumbers);
            Console.ReadLine();
        }

        public static int EvenNumbersCounter(int[] numbers)
        {
            int evenNumbers = 0;

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers++;
                }
            }

            return evenNumbers;
        }

    }

}
