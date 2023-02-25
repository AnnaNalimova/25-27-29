// Напишите цикл, который принимает на вход два числа(А и В) и возводит число А в натуральную степень В

int GetExponent(int a,int b)
{
  int result =1;
   for(int i=1;i<=b;i++)
   {
      result=result*a;
   }
  return result;
  
}


Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());
int s = GetExponent(A,B);
Console.WriteLine($"{s}");
