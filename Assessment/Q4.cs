using System;

namespace Assessment
{
    class Q4
    {
        delegate string StringManipulator(string input);

        public void Dele()
        {
            StringManipulator replaceSpaceWithHyphen = (input) => input.Replace(' ', '-');

            StringManipulator reverseString = (input) =>
            {
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };

            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string result = replaceSpaceWithHyphen(input);
            Console.WriteLine("After replacing spaces with hyphens: " + result);

            result = reverseString(result);
            Console.WriteLine("After reversing the string: " + result);
        }
    }
}