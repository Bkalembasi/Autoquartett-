namespace Autoquartett
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            GUI gui = new GUI();
            gui.WriteRectangle(System.Console.WindowWidth - 1,System.Console.WindowHeight - 1);

            System.Console.ReadLine();
        }
    }
}