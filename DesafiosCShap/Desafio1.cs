namespace DesafiosCSharp
{
    public class Desafio1
    {

        private static string[] mouth = new string[]
            {
                "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"
            };

        public Desafio1()
        {
            Console.WriteLine("Enter the month number:");

            string numberMouth = Console.ReadLine();

            Console.WriteLine("Month: " + NameMouth(numberMouth));

            Console.ReadLine();
        }

        public static string NameMouth(string numberMouth)
        {
            switch (numberMouth)
            {

                case "1":
                    return mouth[0];

                case "2":
                    return mouth[1];

                case "3":
                    return mouth[2];

                case "4":
                    return mouth[3];

                case "5":
                    return mouth[4];

                case "6":
                    return mouth[5];

                case "7":
                    return mouth[6];

                case "8":
                    return mouth[7];

                case "9":
                    return mouth[8];

                case "10":
                    return mouth[9];

                case "11":
                    return mouth[10];

                case "12":
                    return mouth[11];

                default:
                    Console.WriteLine("Número incorreto!");
                    break;
            }

            return "Mês não encontrado!";
        
        }
            
    }

}
