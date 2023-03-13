// Напишите программу, которая выводит массив из 8 элементов
// заполненный нулями и единицами в случайном порядке
// [1,0,1,1,0,1,0,0]
//int a = new.Random().Next()
//int a = new.Random().Next(2) //0 1
//int a = new.Random().Next(2,7) // 2,3,4,5,6

Console.Clear();
int [] array = GetBinaryArray(8);

Console.WriteLine($"[   {String.Join(", ", array)}   ]");

//for (int i = 0; i < array.Length - 1; i++){
//   Console.Write($"{array[i]}, ");
//}
//Console.WriteLine($"{array[array.Length - 1]}");

int [] GetBinaryArray (int size){
    int[] result = new int [size];
    for (int i = 0; i<size;i++)
    {
        result [i] = new Random().Next(2);
    }
    return result;
}


