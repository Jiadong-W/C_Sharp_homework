namespace C_homework4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("闹钟开始！");
            Clock clock = new Clock();
            clock.Tick += (sender, e) =>
            {
                Console.WriteLine("嘀嗒...");
            };
            clock.Alarm += (sender, e) =>
            {
                Console.WriteLine("响铃！！！时间到！");
            };

            // 设置闹钟在 5 秒后响铃
            int alarmAfterSeconds = 5;
            Console.WriteLine($"闹钟将在 {alarmAfterSeconds} 秒后响铃。");

            // 启动闹钟
            clock.Run(alarmAfterSeconds);
            Console.WriteLine("闹钟模拟结束。");
        }
    }

    public class Clock
    {
        
        public event EventHandler Tick;// Tick事件
        public event EventHandler Alarm;// Alarm事件

        // 闹钟运行方法
        public void Run(int alarmAfterSeconds)
        {
            int seconds = 0;

            while (true)
            {
                // 每秒触发一次 Tick 事件
                OnTick();
                seconds++;

                // 检查是否到达响铃时间
                if (seconds >= alarmAfterSeconds)
                {
                    OnAlarm(); // 触发 Alarm 事件
                    break;    
                }

                Thread.Sleep(1000); // 模拟1秒
            }
        }

        // 触发 Tick 事件
        protected virtual void OnTick()
        {
            Tick?.Invoke(this, EventArgs.Empty);
        }

        // 触发 Alarm 事件
        protected virtual void OnAlarm()
        {
            Alarm?.Invoke(this, EventArgs.Empty);
        }
    }
}