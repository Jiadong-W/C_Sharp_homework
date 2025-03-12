using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_homework3
{
    internal class Factory
    {
        private static Random _random = new Random();

        public static IShape CreateShape()
        {
            // 随机生成一个形状类型
            int shapeType = _random.Next(0, 3); // 0: Rectangle, 1: Square, 2: Triangle

            switch (shapeType)
            {
                case 0:
                    double width = _random.Next(1, 10);
                    double height = _random.Next(1, 10);
                    return new Rectangle(width, height);

                case 1:
                    double side = _random.Next(1, 10);
                    return new Square(side);

                case 2:
                    double sideA = _random.Next(1, 10);
                    double sideB = _random.Next(1, 10);
                    double sideC = _random.Next(1, 10);
                    return new Triangle(sideA, sideB, sideC);

                default:
                    throw new InvalidOperationException("Invalid shape type");
            }
        }
    }
}
