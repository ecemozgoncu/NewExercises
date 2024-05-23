namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<string> list = new List<string> { "ecem", "ada", "adam"};
            List<string> Newlist = new List<string>(list);
            List<int> numList = new List<int> { 1, 2, 3 };


            List<object> objectIntList = numList.Cast<object>().ToList();
            List<object>objectStringlist = list.Cast<object>().ToList();

            List<object> mergedList = objectIntList.Concat(objectStringList).ToList();

            string k = "ecem";
            Newlist.RemoveAll(x => x == k);
            Console.WriteLine($"New list : [{string.Join(",", Newlist)}]");


            string name = Console.ReadLine();

            list.Add(name);
            Console.WriteLine($"New list : [{string.Join(",", list)}]");
        }
    }
}
