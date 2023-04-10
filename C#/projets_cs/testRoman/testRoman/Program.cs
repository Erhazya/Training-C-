
internal class Program
{

    public static void RomanToDecimal(string roman)
    {
            Dictionary<char, int> romanValues = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            int decimalValue = 0;
            int lastRomanValue = 0;

            for (int i = roman.Length - 1; i >= 0; i--)
            {
                int currentRomanValue = romanValues[roman[i]];
                if (currentRomanValue < lastRomanValue)
                {
                    decimalValue -= currentRomanValue;
                }
                else
                {
                    decimalValue += currentRomanValue;
                }
                lastRomanValue = currentRomanValue;
            }


            Console.WriteLine(decimalValue.ToString());



    }



    static void Main(string[] args)
    {

        string roman = "XXXIVII";


        RomanToDecimal(roman);





    }
}
