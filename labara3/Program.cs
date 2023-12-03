class Program
{
    static void Main()
    {
        // Зчитуємо довжини сторін від користувача
        Console.Write("Введіть довжину першої сторони прямокутника: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть довжину другої сторони прямокутника: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        // Створюємо об'єкт класу Rectangle
        Rectangle rectangle = new Rectangle(side1, side2);

        // Виводимо на екран площу та периметр прямокутника
        Console.WriteLine($"Площа прямокутника: {rectangle.Area}");
        Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");

        Console.ReadLine(); // Чекаємо, поки користувач натисне Enter
    }
}
