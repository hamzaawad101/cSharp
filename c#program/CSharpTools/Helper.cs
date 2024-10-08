namespace Test{

public class Helper{
    private string _name;
    public Helper(string name){
      _name = name;
    }
        public void Print()
        {
            Console.WriteLine("Hi " + _name);
        }

        public static void Printv2()
        {
            Console.WriteLine("HIIII");
        }
}
}