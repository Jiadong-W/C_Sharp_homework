namespace C_homework2_2
{
    internal class Program
    {
        static List<int> list1 = new List<int>();
        static int n;//数组长度
        static int max;
        static int min;
        static int sum;
        static double average; //double类型，int类型会损失小数点后的精度
        static void Main(string[] args)
        {
            Input();
            OutputMax();
            OutputMin();          
            OutputSum();
            OutputAverage();
        }
        static void Input()
        {
            list1.Clear();           
            Console.Write("请输入数组长度：");
            n = int.Parse(Console.ReadLine());
            Console.Write($"请输入{n}个元素：\n");
            for(int i = 0; i < n; i++)
            {
                list1.Add(int.Parse(Console.ReadLine()));
            }
        }
        static void OutputMax()
        {
            Console.Write("最大值：");
            if (n <= 0)
            {
                Console.WriteLine("无");
                return;
            }
            max = list1[0];
            for(int i = 1; i < list1.Count; i++)
            {
                if (list1[i] > max) max = list1[i];
            }
            Console.WriteLine(max);
        }
        static void OutputMin()
        {
            Console.Write("最小值：");
            if (n <= 0)
            {
                Console.WriteLine("无");
                return;
            }
            min = list1[0];
            for (int i = 1; i < list1.Count; i++)
            {
                if (list1[i] < min) min = list1[i];
            }
            Console.WriteLine(min);
        }

        static void OutputSum()
        {
            Console.Write("和：");
            for(int i = 0; i < list1.Count; i++)
            {
                sum += list1[i];
            }
            Console.WriteLine(sum);
        }
        static void OutputAverage()
        {
            Console.Write("平均值：");
            if (n <= 0)
            {
                Console.WriteLine("无");
                return;
            }
            average = (double)sum / n;//强制类型转化保证精度
            Console.WriteLine(average);
        }
    }
}