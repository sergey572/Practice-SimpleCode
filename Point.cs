namespace Practice
{
    //строки 519-526 из файла MainSpace.cs
    internal class Point
    {
        public Point()
        {

        }

        public Point(int id, int x, int y)
        {
            this.id = id;
            this.x = x;
            this.y = y;
            this.id = id;
        }

        public Colour colour;
        private int id;
        private int x;
        private int y;

        public void Print()
        {
            Console.WriteLine($"Координаты точки {id}:   X: {x} | Y: {y}");
        }

    }
    enum Colour
    {
        Red, Green, Orange, Yellow, Blue
    }
}
