using System;
namespace palindronium
{
    public class ClassalC

    {
        private string inputtedText = "";
        private char[] brokenWordArray;

        public static void Main()
        {
            while (true)
            {
                ClassalC charClass = new ClassalC();
                charClass.GetInputtedText();
                charClass.PushInputToArray();
                Console.WriteLine(charClass.IsPalindrome());
            }

        }

        public void GetInputtedText()

        {
            Console.WriteLine("Enter text to test for palindrome-ness!");
            inputtedText = Console.ReadLine();

        }

        public void PushInputToArray()
        {
            brokenWordArray = inputtedText.ToCharArray();

        }

        public string IsPalindrome()
        {
            char[] reversedArray = inputtedText.ToCharArray();

            Array.Reverse(reversedArray);

            string response = "This is a palindrome";

            for (int i = 0; i < brokenWordArray.GetLength(0); i++) {
                if(brokenWordArray[i] != reversedArray[i]) {
                    response = "This is not a palindrome!";
                    break;
                } 
            }

            return response;

        }

    }

}
