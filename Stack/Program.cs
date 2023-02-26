namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack myStack = new MyStack(4);
            myStack.push(15);
            myStack.push(8);
            myStack.push(2);
            myStack.isEmpty();
            myStack.Pop();
            myStack.push(3);
            myStack.Clear();
            myStack.isEmpty();
            myStack.push(69);
            myStack.push(45);
            myStack.push(90);
            myStack.isFull();
            myStack.SwappXY();
            myStack.push(40);
            myStack.isFull();
            myStack.Peek();
            Console.WriteLine(myStack.ToString());
        }
    }
}