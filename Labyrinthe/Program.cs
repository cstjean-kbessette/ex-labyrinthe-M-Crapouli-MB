namespace Labyrinthe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            View view = new View();
            Labyrinthe labyrinthe = new Labyrinthe();
            Controller controller = new Controller(view, labyrinthe);
            controller.Run();
        }
    }
}
