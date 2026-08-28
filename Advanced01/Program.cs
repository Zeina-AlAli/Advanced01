namespace Advanced01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 : Generic Class
            //Console.WriteLine("- Generic class is a class that allows us to write with type parameters where the actual type is specified when the is used.");
            //Console.WriteLine(("- We use Generics because it provides Type safety, code reusability, better performance and cleaner code");
            #endregion

            #region Q2 : Use Generic class
            //Container<int> container = new Container<int>();
            //container.Add(1);
            //int GetNum = container.Get();
            //Console.WriteLine(GetNum);
            #endregion

            #region Q3 : Multiple Type Parameter
            //Console.WriteLine("Multiple parameter is when generic class has more than one type parameters.");
            //Console.WriteLine("\nFor Example:");
            //Pair<string, int> pair = new Pair<string, int>("Iphone", 30000);
            //Console.WriteLine(pair.ToString());

            //Pair<int, string> pair2 = new Pair<int, string>(1, "Zeina");
            //Console.WriteLine(pair2.ToString());


            #endregion

            #region Q4 : Generic Method
            //Console.WriteLine("\nGeneric method is a method that can work with different type parameter, method can be generic even if class isnt");
            //Console.WriteLine("\nFor Example");
            //int a = 2;
            //int b = 3;
            //Console.WriteLine($"Before Swapping : a = {a}, b = {b}");
            //GenericMethod.Swap<int>(ref a, ref b);
            //Console.WriteLine($"After Swapping : a = {a}, b = {b}");

            //string st1 = "clean";
            //string st2 = "code";
            //Console.WriteLine($"\nBefore swapping : st1 = {st1}, st2 = {st2}");
            //GenericMethod.Swap<string> (ref st1, ref st2);
            //Console.WriteLine($"After swapping : st1 = {st1}, st2 = {st2}");

            #endregion
        }
    }
}
