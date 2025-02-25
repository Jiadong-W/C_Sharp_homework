// See https://aka.ms/new-console-template for more information
double num1=0;
double num2=0;
int operator1=0;
double result = 0;

//输入第一个数
System.Console.Write("请输入第一个数字：");
num1 = double.Parse(Console.ReadLine());

//输入第二个数
Console.Write("请输入第二个数字：");
num2 = double.Parse(Console.ReadLine());

//选择运算符
Console.WriteLine("请选择运算符（输入运算符前的序号）：\n" +
    "（1）+   （2）-   （3）*   （4）/");
Console.Write("我选择：");
operator1 = Int32.Parse(Console.ReadLine());

//保证运算符选择正确
while (operator1 < 1 || operator1 > 4)
{
    Console.WriteLine("请重新选择运算符（输入运算符前的序号）：\n" +
    "（1）+   （2）-   （3）*   （4）/");
    Console.Write("我选择：");
    operator1 = Int32.Parse(Console.ReadLine());
}

switch (operator1)
{
    case 1:result = num1 + num2;break;
    case 2:result = num1 - num2;break;
    case 3:result = num1 * num2;break;
    case 4:result = num1 / num2;break;
}
Console.WriteLine(result);

