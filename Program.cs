using System;

class Fan
{
    private int speed;
    private bool isOn;
    private double radius;
    private string color;

    // Getter và Setter cho thuộc tính speed
    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    // Getter và Setter cho thuộc tính isOn
    public bool IsOn
    {
        get { return isOn; }
        set { isOn = value; }
    }

    // Getter và Setter cho thuộc tính radius
    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    // Getter và Setter cho thuộc tính color
    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    // Phương thức khởi tạo không tham số tạo đối tượng Fan mặc định
    public Fan()
    {
        speed = 1;
        isOn = false;
        radius = 5.0;
        color = "blue";
    }

    // Phương thức ToString()
    public override string ToString()
    {
        if (isOn)
        {
            return $"Speed: {speed}, Color: {color}, Radius: {radius} - Fan is on";
        }
        else
        {
            return $"Color: {color}, Radius: {radius} - Fan is off";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Fan fan1 = new Fan();
        fan1.Speed = 3;
        fan1.Color = "yellow";
        fan1.IsOn = true;
        fan1.Radius = 10.0;

        Fan fan2 = new Fan();
        fan2.Speed = 2;
        fan2.Color = "blue";
        fan2.IsOn = false;
        fan2.Radius = 5.0;

        Console.WriteLine("Fan 1: " + fan1.ToString());
        Console.WriteLine("Fan 2: " + fan2.ToString());
    }
}