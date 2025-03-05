// See https://aka.ms/new-console-template for more information
const int max = 100;
int[] data = new int[max+1];//都初始默认为0
data[0] = 1;
data[1] = 1;//0代表是素数，1代表不是素数
int p = 2;//不断增加的指针，指向当前找到的最大素数
while (p <= max)
{
    for(int i = p*2; i <= max; i += p)
    {
        data[i] = 1;//将p的倍数对应的值改为1
    }
    do
    {
        p++;
    } while (p<=max&&data[p] == 1);//找到下一个p
   
}
for (int i = 1; i <= max; i++)
{
    if (data[i] == 0) Console.Write(i + " ");
}