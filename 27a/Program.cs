// See https://aka.ms/new-console-template for more informatio

int Sum(int arg)
{
   int sum=0;
    for(int i=1;i>0;i++)
    {  
        sum=sum+(arg%10);
        arg=arg/10;
    }
    return sum;}    
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int s = Sum(num);
Console.WriteLine($"{num}->{s}");
