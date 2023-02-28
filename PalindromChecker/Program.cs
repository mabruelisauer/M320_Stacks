using Stack;

namespace PalindromChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var MyStack = new MyGenericStack<int>(3);
            if (MyStack.IsPalindrome("malajalam"))
            {
                Console.WriteLine("This word is a palindrome!");
            }
            else
            {
                Console.WriteLine("This word is NOT a palindrome!");
            }
            
        }
    }
}