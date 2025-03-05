namespace C_homework2_4
{
    internal class Program
    {
        static int M;
        static int N;
        static int[,] matrix;
        static void Main(string[] args)
        {
            Input();
            if (Judge()) Console.WriteLine("true");
            else Console.WriteLine("false");
        }

        static void Input()
        {
            Console.Write("请输入M:");
            M = int.Parse(Console.ReadLine());
            Console.Write("请输入N:");
            N = int.Parse(Console.ReadLine());
            matrix = new int[M, N];
            Console.WriteLine($"请按顺序输入matrix的{M}×{N}个元素:");
            for(int i = 0; i < M ; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    matrix[i,j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static bool Judge()
        {
            int tep = matrix[0, 0];
            for (int i = 0; i < M && i < N; i++)//此for循环判断经过[0,0]的主对角线是否满足
            {
                if (matrix[i, i] != tep) return false;
            }
            for(int i = 1; i < M; i++)//第二个for循环判断主对角线以下的各个对角线是否满足
            {
                tep = matrix[i, 0];
                for(int j = 1; i + j < M&&j<N; j++)
                {
                    if (matrix[i + j, j] != tep) return false;
                }
            }
            for(int i = 1; i < N; i++)//第三个for循环判断主对角线以上的各个对角线是否满足
            {
                tep = matrix[0, i];
                for(int j = 1; i + j < N&&j<M; j++)
                {
                    if (matrix[j, i + j] != tep) return false;
                }
            }
            return true;
        }
    }
}