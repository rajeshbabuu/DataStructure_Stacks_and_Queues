namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            Console.WriteLine("-----------------");
            stack.peak();
            stack.Display();
            Console.WriteLine("-----------------");
            stack.pop();
            Console.WriteLine("-----------------");
            stack.peak();
            stack.Display();
        }
    }
}