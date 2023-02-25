//Напишите программу,которая создает массив из 8 элементов и выводит их на экран 
int[]array = GetMassive(8,1,100);
Console.WriteLine($"{String.Join(" , ",array)}->[ {String.Join(" , ",array)} ]");

int[] GetMassive(int size, int a, int b){
    int []result = new int[size];
    for(int i=0;i<size;i++){
        result[i]=new Random().Next(a,b+1);
    }
    return result;
}