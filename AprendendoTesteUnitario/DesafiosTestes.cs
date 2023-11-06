using DesafiosCSharp;

namespace AprendendoTesteUnitario
{
    public class DesafiosTestes
    {

        [Fact]
        public void NameMouthTest()
        {
            Assert.Equal("October", Desafio1.NameMouth("10"));
        }

        [Fact]
        public void FindAverageTest()
        {
            int[] FNumbersLow3 = { 4, 3 };
            int[] FNumbers = { 4, 6, 8, 12 };

            Assert.Equal(-1, Desafio2.FindAverage(FNumbersLow3));
            Assert.Equal(7.5, Desafio2.FindAverage(FNumbers));
        }

        [Fact]
        public void GetEvenNumbersTest()
        {
            int[] ENumbers = { -2, 1, 2, 4};

            Assert.Equal(3, Desafio3.EvenNumbersCounter(ENumbers));
        }
        
        [Fact]
        public void StringInversorTest()
        {
            Assert.Equal("ssap", Desafio4.StringInversor("pass"));
        }

        [Fact]
        public void ChangeCharactersTest()
        {
            Assert.Equal("Digite algo!", Desafio5.ChangeCharacters(""));
            Assert.Equal("?????", Desafio5.ChangeCharacters("AeIoU"));
        }

        [Fact]
        public void GrowingNumbersTest()
        {
            int[] NNumbers = new int[] { 3, 1, 2 };
            
            int[] YNumbers = new int[] { 1, 2, 3 };

            Assert.Equal(YNumbers, Desafio6.GrowingNumbers(NNumbers));
        }

        [Fact]
        public void FirstUniqueNumberTest()
        {
            int[] FUNumbers = new int[] { 3, 1, 2, 1,};

            int[] EFUNumbers = new int[] { 3, 1, 2, 1, 2, 3 };

            Assert.Equal(3, Desafio7.FirstUniqueNumber(FUNumbers));
            Assert.Equal(-1, Desafio7.FirstUniqueNumber(EFUNumbers));
        }

        [Fact]
        public void CheckBinaryTest()
        { //                                    OK                  NÂO                 OK              
            string[] lines = new string[] { "011010111010001", "11010010101001", "010101101010000101" };

            Assert.Equal(2, Desafio8.CheckBinary(lines));
        }
    }
}