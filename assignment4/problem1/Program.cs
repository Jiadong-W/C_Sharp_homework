namespace C_homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 创建一个整数类型的链表
            GenericList<int> intList = new GenericList<int>();
            intList.Add(5);
            intList.Add(7);
            intList.Add(4);
            intList.Add(1);
            intList.Add(2);

            // 打印链表元素
            Console.WriteLine("链表元素:");
            intList.ForEach(x => Console.WriteLine(x));

            // 求最大值
            int max = int.MinValue;
            intList.ForEach(x => { if (x > max) max = x; });
            Console.WriteLine($"最大值: {max}");

            // 求最小值
            int min = int.MaxValue;
            intList.ForEach(x => { if (x < min) min = x; });
            Console.WriteLine($"最小值: {min}");

            // 求和
            int sum = 0;
            intList.ForEach(x => sum += x);
            Console.WriteLine($"和: {sum}");
        }
    }

    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public GenericList()
        {
            tail = head = null;
        }
        public Node<T> Head
        {
            get => head;
        }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public void ForEach(Action<T> action)   //ForEach方法
        {
            Node<T> current = head;
            while (current != null)
            {
                action(current.Data);
                current = current.Next;
            }
        }
    }
}