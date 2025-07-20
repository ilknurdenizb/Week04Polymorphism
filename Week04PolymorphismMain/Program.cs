using System;
using System.Security.Cryptography.X509Certificates;
using Week04PolymorphismMain;
class Program
{
    static void Main()
    {
        BaseGeometrikSekil square = new Square(4, 4);
        BaseGeometrikSekil rectangle = new Rectangle(5, 12);
        BaseGeometrikSekil rightTriangle = new RightTriangle(5, 10);

        square.DisplayArea();       // 16
        rectangle.DisplayArea();    // 60
        rightTriangle.DisplayArea(); // 25
    }
}