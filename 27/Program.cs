//напишите программу , которая принимает на вход число и выдает сумму цифр в числе
Console.WriteLine("Введите число:");
int num=int.Parse(Console.ReadLine());
int sum=0;
for(int i=1;i>0;i++)
{ 
   sum=sum+num%10;
   num=num/10;

}
Console.WriteLine($"{num}->{sum}");