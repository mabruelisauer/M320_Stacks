namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyStack myStack = new MyStack(4);
            //myStack.push(15);
            //myStack.push(8);
            //myStack.push(2);
            //myStack.isEmpty();
            //myStack.Pop();
            //myStack.push(3);
            //myStack.Clear();
            //myStack.isEmpty();
            //myStack.push(69);
            //myStack.push(45);
            //myStack.push(90);
            //myStack.isFull();
            //myStack.SwappXY();
            //myStack.push(40);
            //myStack.isFull();
            //myStack.Peek();
            //Console.WriteLine(myStack.ToString());

            //var genStack = new MyGenericStack<int>(4);
            //genStack.push(15);
            //genStack.push(8);
            //genStack.push(2);
            //genStack.isEmpty();
            //genStack.Pop();
            //genStack.push(3);
            //genStack.Clear();
            //genStack.isEmpty();
            //genStack.push(69);
            //genStack.push(45);
            //genStack.push(90);
            //genStack.isFull();
            //genStack.SwappXY();
            //genStack.push(40);
            //genStack.isFull();
            //Console.WriteLine(genStack.ToString());

            var genStack = new MyGenericStack<string>(4);
            genStack.push("a");
            genStack.push("a");
            genStack.push("a");
            genStack.isEmpty();
            genStack.Pop();
            genStack.push("a");
            genStack.Clear();
            genStack.isEmpty();
            genStack.push("a");
            genStack.push("b");
            genStack.push("c");
            genStack.isFull();
            genStack.SwappXY();
            genStack.push("d");
            genStack.isFull();
            Console.WriteLine(genStack.ToString());
        }
    }
}