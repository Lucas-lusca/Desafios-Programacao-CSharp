namespace DesafiosCSharp
{
    public class Desafio5
    {

        public string[] vowels = new string[] { "a", "e", "i", "o", "u" };

        public Desafio5()
        {
            Console.WriteLine("Escreva algo:");

            string phrase = Console.ReadLine();
            
            Console.WriteLine(ChangeCharacters(phrase));
        }

        public static string ChangeCharacters(string phrase)
        {
            if (phrase == "")
            {
                return "Digite algo!";
            }

            phrase = phrase.ToLower();

            phrase = phrase.Replace("a", "?");
            phrase = phrase.Replace("e", "?");
            phrase = phrase.Replace("i", "?");
            phrase = phrase.Replace("o", "?");
            phrase = phrase.Replace("u", "?");

            return phrase;
        }

        // Consegui encontrar um bug usando testes nesse desafio!

        // O problema estava quando eu passava a string para minusculo. Isso não era
        // realizado se chamasse apenas a função ChangeCharacters.
        // Resolvi o problema apenas alterando o local onde a string erra passada pra minuscula,
        // agora isso acontece dentro do método.
    }
}
