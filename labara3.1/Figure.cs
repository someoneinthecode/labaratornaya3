class Figure
{
    private Point[] points;

    // Конструктори класу Figure
    public Figure(Point A, Point B, Point C)
    {
        points = new Point[] { A, B, C };
    }

    public Figure(Point A, Point B, Point C, Point D)
    {
        points = new Point[] { A, B, C, D };
    }

    public Figure(Point A, Point B, Point C, Point D, Point E)
    {
        points = new Point[] { A, B, C, D, E };
    }

    // Метод для розрахунку довжини сторони багатокутника
    private double GetSideLength(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    // Метод для розрахунку периметру багатокутника
    public void CalculatePerimeter()
    {
        double perimeter = 0;

        for (int i = 0; i < points.Length - 1; i++)
        {
            perimeter += GetSideLength(points[i], points[i + 1]);
        }

        perimeter += GetSideLength(points[points.Length - 1], points[0]); // Замикання фігури

        Console.WriteLine($"Назва багатокутника: {points.Length}-кут");
        Console.WriteLine($"Периметр багатокутника: {perimeter}");
    }
}