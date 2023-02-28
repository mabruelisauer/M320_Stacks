using Stack;

namespace PalindromChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (IsPalindrome("malajalam"))
            {
                Console.WriteLine("This word is a palindrome!");
            }
            else
            {
                Console.WriteLine("This word is NOT a palindrome!");
            }
            
        }
        static bool IsPalindrome(string input)
        {
            var stack = new MyGenericStack<char>(100);
            int middle = input.Length / 2;

            for (int i = 0; i < middle; i++)
            {
                stack.Push(input[i]);
            }

            if (input.Length % 2 != 0)
            {
                middle++;
            }

            for (int i = middle; i < input.Length; i++)
            {
                if (stack.Pop() != input[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}