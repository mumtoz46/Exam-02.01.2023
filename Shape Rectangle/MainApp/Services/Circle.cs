using System.Drawing;
public class Circle : Shape
{
    public double radius = 1.0;
    public Circle()
    {

    }
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public Circle(double radius, string color, bool filled) : base(color, filled)
    {
        this.radius = radius;
    }
    public double GetRadius()
    {
        return radius;
    }
    // public void SetRadius(double radius)
    // {
    //     this.radius = radius;
    // }
    public override double GetArea()
    {
         return radius * radius * Math.PI;
    }
    public override double GetPerimetr()
    {
      return  2 * Math.PI * radius;
    }
    public override string ToString()
    {
        return $"Circle:[Shape [{color} {filled}] {radius}]";
    }
}
