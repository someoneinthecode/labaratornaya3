class Program
{
    static void Main()
    {
        // Створюємо точки
        Point pointA = new Point(0, 0, "A");
        Point pointB = new Point(0, 4, "B");
        Point pointC = new Point(3, 0, "C");

        // Створюємо багатокутник з трьох точок
        Figure triangle = new Figure(pointA, pointB, pointC);

        // Розраховуємо та виводимо периметр багатокутника
        triangle.CalculatePerimeter();

        Console.ReadLine(); // Чекаємо, поки користувач натисне Enter
    }
}
