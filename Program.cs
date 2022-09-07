// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateRandomArray(int size){
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++){
//         array[i] = new Random().Next(100, 1000);
//     }     
// return array; 
// } 
// void ShowArray(int[] array){
//     Console.Write($"[ ");     
//     for (int i = 0; i < array.Length; i++){
//         Console.Write(array[i]+" ");
//     }     
//     Console.Write($"]"); } 

// void CountChet(int[] array){
//     int count = 0;
//     for(int i = 0; i < array.Length; i++){
//         if(array[i]%2 == 0) count++;
//     }
// Console.WriteLine($"Количество чётных чисел в массиве: {count}");
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomArray(size); 
// ShowArray(array);
// Console.WriteLine();
// CountChet(array);


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] CreateRandomArray(int size, int min, int max){
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++){
//         array[i] = new Random().Next(min, max+1);
//     }
// return array;
// }

// void ShowArray(int[] array){
//     Console.Write($"[ ");
//         for (int i = 0; i < array.Length; i++){
//             Console.Write(array[i]+" ");
//         } 
//     Console.Write($"]"); 
// } 

// void CountNechetPos(int[] array){
//     int count = 0;
//     for(int i = 0; i < array.Length; i +=2){
//         count += array[i];
//     }
// Console.WriteLine($"Сумма элементов на нечетных позициях: {count}");
// }

// Console.Write("input Size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("input min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("input max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateRandomArray(size, min, max); 
// ShowArray(array);
// Console.WriteLine();
// CountNechetPos(array);

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] CreateRandomArray(int size, int min, int max){
    int[] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(min, max+1);
    }
return array;
}

void ShowArray(int[] array){
    Console.Write($"[ ");
        for (int i = 0; i < array.Length; i++){
            Console.Write(array[i]+" ");
        } 
    Console.Write($"]"); 
} 

void CountMinMax(int[] array){
    int maximum = array[0];
    int minimum = array[0];
    for(int i = 1; i < array.Length; i++){
      if(maximum < array[i]) maximum = array[i];
      else if(minimum > array[i]) minimum = array[i];
    }
int result = maximum - minimum;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {result}");
}

Console.Write("input Size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, min, max); 
ShowArray(array);
Console.WriteLine();
CountMinMax(array);
