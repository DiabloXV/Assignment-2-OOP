namespace Assignment_2_OOP
{
    internal class Program
    {
        #region Struct With Indexer
        public struct Point
        {
            private double _x;
            private double _y;

            public Point(double x, double y)
            {
                _x = x;
                _y = y;
            }

            public double X
            {
                get { return _x; }
                set { _x = value; }
            }

            public double Y
            {
                get { return _y; }
                set { _y = value; }
            }

            public double this[int index]
            {
                get
                {
                    if (index == 0)
                        return _x;
                    else if (index == 1)
                        return _y;
                    else
                        throw new IndexOutOfRangeException("Index must be 0 or 1");
                }
                set
                {
                    if (index == 0)
                        _x = value;
                    else if (index == 1)
                        _y = value;
                    else
                        throw new IndexOutOfRangeException("Index must be 0 or 1");
                }
            }


            public double DistanceTo(Point other)
            {
                double dx = _x - other._x;
                double dy = _y - other._y;
                return Math.Sqrt(dx * dx + dy * dy);
            }
        }
        #endregion

        #region Struct without an indexer
        public struct Rectangle
        {
            private double _width;
            private double _height;

            public Rectangle(double width, double height)
            {
                _width = width;
                _height = height;
            }

            public double Width
            {
                get { return _width; }
                set { _width = value; }
            }

            public double Height
            {
                get { return _height; }
                set { _height = value; }
            }

            public double GetArea()
            {
                return _width * _height;
            }

            public double GetPerimeter()
            {
                return 2 * (_width + _height);
            }
        }
        #endregion

        static void Main(string[] args)
        {
            #region Main code for Struct with indexer
            Point p1 = new Point(3, 4);
            Point p2 = new Point(6, 8);

            Console.WriteLine($"Distance between points: {p1.DistanceTo(p2)}");
            Console.WriteLine($"p1[0] = {p1[0]}, p1[1] = {p1[1]}");
            p1[0] = 7;
            p1[1] = 10;
            Console.WriteLine($"After modification: p1[0] = {p1[0]}, p1[1] = {p1[1]}");
            #endregion

            #region Main code for struct without an indexer
            Rectangle rect = new Rectangle(5, 10);

            Console.WriteLine($"Width: {rect.Width}, Height: {rect.Height}");
            Console.WriteLine($"Area: {rect.GetArea()}");
            Console.WriteLine($"Perimeter: {rect.GetPerimeter()}");

            rect.Width = 7;
            rect.Height = 12;

            Console.WriteLine($"After modification - Width: {rect.Width}, Height: {rect.Height}");
            Console.WriteLine($"New Area: {rect.GetArea()}");
            Console.WriteLine($"New Perimeter: {rect.GetPerimeter()}");
            #endregion



        }
    }
}
