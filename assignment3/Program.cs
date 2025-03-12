namespace C_homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>();

            // 创建10个随机形状
            for (int i = 0; i < 10; i++)
            {
                IShape shape = Factory.CreateShape();
                shapes.Add(shape);
            }

            // 计算所有形状的面积之和
            double totalArea = 0;
            foreach (var shape in shapes)
            {
                if (shape.IsValid())
                {
                    double area = shape.CalculateArea();
                    Console.WriteLine($"Shape: {shape.GetType().Name}, Area: {area}");
                    totalArea += area;
                }
                else
                {
                    Console.WriteLine($"Shape: {shape.GetType().Name} is invalid.");
                }
            }

            Console.WriteLine($"Total Area of all valid shapes: {totalArea}");
        }
    }
    public interface IShape                        //使用接口
    {
        double CalculateArea();
        bool IsValid();
    }
    public abstract class ShapeBase : IShape       //抽象类
    {
        public abstract double CalculateArea();
        public abstract bool IsValid();
        
    }
    public class Rectangle : ShapeBase             //长方形
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override bool IsValid()
        {
            return Width > 0 && Height > 0;
        }
    }
    public class Square : Rectangle                //正方形(直接继承长方形即可)
    {
        public Square(double side) : base(side, side)
        {
        }

    }
    public class Triangle : ShapeBase               //三角形
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double CalculateArea()
        {
            // 海伦公式
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public override bool IsValid()
        {
            return SideA + SideB > SideC &&
                   SideA + SideC > SideB &&
                   SideB + SideC > SideA;
        }
    }
}