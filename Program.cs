internal class Program
{
    enum EvenOdd { EVEN, ODD };
    private static void Main(string[] args)
    {

        Console.WriteLine(ToCamelCase("the-stealth_warrior"));
        //Console.WriteLine(ReverseString("test"));
        Console.WriteLine(EvenOrOdd(44));

        string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            string reversed = "";
            for (int i = charArray.Length; i > 0; i--)
            {
                reversed += charArray[i-1];
            }
            return reversed;
        }
        EvenOdd EvenOrOdd(int number)
        {
            
            if (number % 2 == 0)
            {
                return EvenOdd.EVEN;
            }
            else
            {
                return EvenOdd.ODD;
            }
        }
        //the-stealth_warrior
        string ToCamelCase(string str)
        {
            char[] charArray = str.ToCharArray();
            string camelCased = "";
            bool switcher = false;
            
            for (int i = 0; i < charArray.Length; i++)
            {
                string c = charArray[i].ToString();

                if (i == 0) c = c.ToUpper();

                if (switcher)
                {
                    c = c.ToUpper();
                }


                if (charArray[i] == '-' || charArray[i] == '_')
                {
                    switcher = true;

                }
                else {
                    switcher = false;
                    camelCased += c;
                } 
                

            }
            return camelCased;
            
        }


    }
}