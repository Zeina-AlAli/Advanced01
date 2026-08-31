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

            #region Q5 : Generic Method FindMax
            //Console.WriteLine("int Example: ");
            //int max = GenericMethod.FindMax<int>(10, 20);
            //Console.WriteLine($"Max number : {max}");

            //Console.WriteLine("string example: ");
            //string Max = GenericMethod.FindMax<string>("Apple", "Banana");
            //Console.WriteLine($"Max value : {Max}");


            #endregion

            #region Q6 : Generic Interface
            //Console.WriteLine("Generic interface is an interface that uses type parameter, so it can work with different data types");
            //Console.WriteLine("For Example:");
            //IRepository<string> prdt =new ProductRepository();
            //prdt.Add("Smartphone");
            //string GetItem = prdt.Get();
            //Console.WriteLine($"The product : {GetItem}");
            #endregion

            #region Q7 : Struct Constraint

            //Console.WriteLine("The struct constraint restrict the generic type to value type only");
            //Console.WriteLine("For Esxample");
            //StructValue<double> stv = new StructValue<double>(3.5);
            //Console.WriteLine(stv.Value);
            ////StructValue<string> stv2 = new StructValue<string>("struct"); //Error reference type not allowed

            #endregion

            #region Q8 : Calss Constraints
            //Console.WriteLine("Class Constraints restricts the generic type to reference type only.");
            //Console.WriteLine("\nFor Example");
            //ReferenceValue<string> rfv = new ReferenceValue<string>("class");
            //Console.WriteLine(rfv.Value);

            //ReferenceValue<int> rfv2 = new ReferenceValue<int>(2); //Error
            #endregion

            #region Q9 : new() Constraints

            //Console.WriteLine("The new() constraint forces the generic type to have a parameterless constructor");
            //Console.WriteLine("For Example:");
            //Person<Student> person = new Person<Student>();//Student class have parameterless constructor
            //person.create();

            #endregion

            #region Q10 : Interface Constraint
            //Console.WriteLine("Interface constraint requirs the generic type Parameter to implement a specific interface");
            //Console.WriteLine("for Example:"); //>>>>>>>>>>>>>>>>>>>>>> Interface class: IPrintable - "T" that Implement the Interface: ImplementInterface - Interface Constraint class: InterfaceConstraint
            //InterfaceConstraint<ImplementInterface> ifc = new InterfaceConstraint<ImplementInterface>();
            //ImplementInterface imp = new ImplementInterface();
            //ifc.PrintText(imp);

            #endregion

            #region Q11 : Base Class Constraint

            //Console.WriteLine("Base class Constraint requires the genefric type parameter to inherit from specific base class\n.");
            //// For Example:  >>>>>>>>>>>>>>>>>>>> Base class : Animal - Child class : Dog - Base Class Constraint : Animal Container

            //AnimalContainer<Dog> D = new AnimalContainer<Dog>();
            //Dog dog = new Dog();
            //D.Feed(dog);

            #endregion

            #region Q12 : Multiple Constraints

            //Console.WriteLine("\nTo apply (Combine) multiple constraints , you are supposed to aplly them in a specific order if the constraints are different:\n1) Base class\n2) Interfaces\n3) new()");
            //// For Example  >>>>>>>>>>>>>>>>>>>>>>>>> The generic class with multi cons. : Manager - the "T" that implement all Cons. : Document class

            //Manager<Document> mng = new Manager<Document>();
            //Document doc = new Document();
            //mng.GetAndPrint();

            #endregion

            #region Q13 : Default Keyword

            // Console.WriteLine(" 'default'  keyword returns the default value of a specific type.");

            #endregion

            #region Q14 : List<> returns default

            //SafeList<int> list = new SafeList<int>();
            //list.AddItem(10);
            //list.AddItem(20);
            //list.AddItem(30);
            //list.GetItem(0);
            //list.GetItem(5);

            #endregion

            #region Q15 : Covariance and 'out' Keyword

            //Console.WriteLine("Covariance : Allows generic interface and generic delegates to use a more derived type when less derived type expected, it uses the 'out' keyword.\n'out' keyword : used when the type is only returned.");

            #endregion
           
        }
    }
}
