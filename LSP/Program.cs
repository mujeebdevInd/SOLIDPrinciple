namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape rectangle = new Rectangle { Width = 5, Height = 10 };
            IShape square = new Square { SideLength = 5 };

            Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
            Console.WriteLine($"Square Area: {square.GetArea()}");

            // Both Rectangle and Square can be used interchangeably through IShape
            PrintArea(rectangle);
            PrintArea(square);
        }

        static void PrintArea(IShape shape)
        {
            Console.WriteLine($"Area: {shape.GetArea()}");
        }
    }

}