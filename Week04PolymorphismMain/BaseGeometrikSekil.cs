using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04PolymorphismMain
{
    public class BaseGeometrikSekil
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public BaseGeometrikSekil(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public virtual double AreaCalculator()
        {
            return Height * Width;
        }

        public virtual string ShapeName => "Bilinmeyen Şekil";

        public virtual void DisplayArea()
        {
            Console.WriteLine($"{ShapeName} Alanı: {AreaCalculator()}");
        }
    }

    // Kare sınıfı
    public class Square : BaseGeometrikSekil
    {
        public Square(double height, double width) : base(height, width) { }

        public override string ShapeName => "Kare";

        public override void DisplayArea()
        {
            if (Height != Width)
            {
                Console.WriteLine("Uyarı: Karenin kenarları eşit olmalı!");
            }
            base.DisplayArea();
        }
    }

    // Dikdörtgen sınıfı
    public class Rectangle : BaseGeometrikSekil
    {
        public Rectangle(double height, double width) : base(height, width) { }

        public override string ShapeName => "Dikdörtgen";
    }

    // Dik Üçgen sınıfı
    public class RightTriangle : BaseGeometrikSekil
    {
        public RightTriangle(double height, double width) : base(height, width) { }

        public override double AreaCalculator()
        {
            return 0.5 * Height * Width;
        }

        public override string ShapeName => "Dik Üçgen";
    }
}

