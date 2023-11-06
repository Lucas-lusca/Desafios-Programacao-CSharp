namespace DesafiosCSharp
{
    public class Desafio7
    {
        private int[] numbers = new int[] {1, 2, 2, 3, 3, 1, 4 };

        public Desafio7()
        {
            Console.WriteLine("Primeiro número único: " + FirstUniqueNumber(numbers));
        }

        public static int FirstUniqueNumber(int[] numbers)
        {
            for (int x = 0; x < numbers.Length; x++)
            {
                int teste1 = numbers[x];
                Console.WriteLine("X = " + teste1);

                // Array.FindAll retorna todos os número iguais.
                // O for esta percorrendo todo o array e verificando se o valor da chave
                // possui mais iguais.
                int[] result = Array.FindAll(numbers, element => element == numbers[x]);

                Console.WriteLine("Numero de elementos = " + result.Length);

                if (result.Length < 2)
                {
                    return numbers[x];
                }

            }
            return -1;
        }

    }
}

/* O código comentado abaixo, é a lógica que eu estava tentando usar para resolver esse desafio.
 * O problema é que estava com problema na lógica e resolvi abandonar e usar outra lógica que vei
 * na cabeça.

    /*
    for (int y = x + 1; y < numbers.Length; y++)
    {
        int teste2 = numbers[y];
        Console.WriteLine("Y = " + teste2);

        if (teste2 == teste1)
        {
            Console.WriteLine($"Colidiu!!! T2 {teste1} = {teste2}");
        }
    }

    for (int z = x - 1; z > 0; z--)
    {
        int teste3 = numbers[z];
        Console.WriteLine("Z = " + teste3);

        if (teste3 == teste1)
        {
            Console.WriteLine($"Colidiu!!! T3 {teste3} = {teste1}");
        }
        else
        {
            return teste1;
        }
    }

}
/*
private static bool CheckForward(int numberToTeste, int[] numbers)
{
    for (int x = 0; x < numbers.Length; x++)
    {
        int teste1 = numbers[x];
        Console.WriteLine("X = " + teste1);

        for (int y = x + 1; y < numbers.Length; y++)
        {
            int teste2 = numbers[y];
            Console.WriteLine("Y = " + teste2);

            if (teste2 == teste1)
            {
                Console.WriteLine($"Colidiu!!! T2 {teste1} = {teste2}");
                return false;
            }
        }
    }

    return true;
}

private static bool CheckBack(int[] numbers)
{
    for (int x = 0; x < numbers.Length; x++)
    {
        int teste1 = numbers[x];
        Console.WriteLine("X = " + teste1);

        for (int y = x + 1; y < numbers.Length; y++)
        {
            int teste2 = numbers[y];
            Console.WriteLine("Y = " + teste2);

            if (teste2 == teste1)
            {
                Console.WriteLine($"Colidiu!!! T2 {teste1} = {teste2}");
                return false;
            }
        }
    }
    return true;
}
*/