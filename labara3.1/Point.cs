using System;

class Point
{
    // Числові та рядкові поля класу Point
    private double x;
    private double y;
    private string name;

    // Конструктор класу Point
    public Point(double x, double y, string name)
    {
        this.x = x;
        this.y = y;
        this.name = name;
    }

    // Властивості для отримання значень полів
    public double X
    {
        get { return x; }
    }

    public double Y
    {
        get { return y; }
    }

    public string Name
    {
        get { return name; }
    }
}

