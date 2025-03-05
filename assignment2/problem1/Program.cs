namespace C_homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int data=0;
            Input(ref data);
            int dividend = 2;
            int tempData = data;
            while (true)
            {
                bool success = GetNewData(ref dividend, ref tempData);
                if (!success)
                {
                    Console.WriteLine(tempData);
                    return;
                }
                Console.WriteLine(dividend);
            }
        }

        static void Input(ref int data)  //带有循环检查机制的输入函数
        {
            while (true)
            {
                Console.Write("请输入数据：");
                try
                {
                    data = int.Parse(Console.ReadLine());
                    return;
                }
                catch
                {
                    Console.WriteLine("输入错误，请重新输入！");
                }
            }
        }

        static bool GetNewData(ref int dividend,ref int tempData)  //该函数用于获取新的被除数和除数
        {
            while(tempData % dividend != 0&&dividend*dividend<tempData)
            {
                dividend++;
            }         
            if (tempData % dividend == 0)
            {
                tempData = tempData / dividend;
                return true;
            }
            else return false;
        }
    }
}