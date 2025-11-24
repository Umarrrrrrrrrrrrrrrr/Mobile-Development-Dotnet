namespace  Task_3;
class Program
{
    static void Main(string[] args)
    {
        Printer printer = new Printer();
        printer.Print("Hello World!");
        printer.Print(50);
        printer.Print("Hey count till 10: ",10);
    }
}