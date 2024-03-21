// See https://aka.ms/new-console-template for more information
// int value = 100; 
// Console.WriteLine(value);
// //Console.WriteLine("Hello, World!");

// double d = 5.5;
// char c = '!';
// bool b = true;
// Console.WriteLine(d);
// Console.WriteLine(c);
// Console.WriteLine(b); 


//task 2 
// int i1 = 5;
// int i2 = 7; 
// int sum = i2 + i1;
// Console.WriteLine(sum);


//  long l1 = 4;
//  int i1 = 5;
//  long sum = l1 + i1;
//  Concole.WriteLine(sum);



// double d1 = 5.5;
// int i1 = 4;
// double sum = d1 + i1;
// Console.WriteLine(sum);


// int N = 4; 
//  for (int i = 1; i <= N; i++) 
//  {
//     Console.Write(i);
//     Console.Write(' ');
//  }





// int n = 4;
// int[] arr = new int [n];
// for (int i = 1; i <= n; i++) {
//     arr[i - 1] = i; 
//     Console.WriteLine(arr[i-1]);
// }
// var str = string.Join(" ", arr);
// Console.WriteLine(str);





// int[] arr = { 4, 7, 8, 9, 4, 6, 2, 4, 1, 9 };
// for (int i = 0; i < arr.Length; i++){
//     if (arr[i] % 2 == 0)
//     Console.Write($"{arr[i]} ");
// }



// System.Console.Write("Введите число: ");
// int fn = Convert.ToInt32(Console.ReadLine());



// if (fn % 7 == 0 && fn % 23 == 0) 
//     System.Console.Write("да");
// else
//     System.Console.Write("нет");




// // Задайте массив. Напишите программу, которая определяет,
// // присутствует ли заданное число в массиве. Программа
// // должна выдать ответ: Да/Нет.
// // Примеры
// // [1 3 4 19 3], 8 => Нет
// // [-4 3 4 1], 3 => Да 

// System.Console.Write("Введите размер массива: ");
// int arraySize = Convert.ToInt32(Console.ReadLine());

// int[] myArray = new int[arraySize];
// Random rand = new Random();

// for (int i = 0; i < myArray.Length; i++)
// {
//     myArray[i] = rand.Next(0, 10); // 0, 1, 2 ... 8, 9
// }

// for (int i = 0; i < myArray.Length; i++)
// {
//     System.Console.Write(myArray[i] + " ");
// }

// System.Console.Write("\nВведите искомое число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// bool numberIsFinded = false;

// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i] == number)
//     {
//         numberIsFinded = true;
//         break;
//     }
// }

// if (numberIsFinded)
// {
//     System.Console.WriteLine("Да");
// }
// else
// {
//     System.Console.WriteLine("Нет");
// }



// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

// System.Console.Write("Введите размер массива: ");
// int arraySize = Convert.ToInt32(Console.ReadLine());

// int[] myArray = new int[arraySize];
// Random rand = new Random();

// for (int i = 0; i < myArray.Length; i++)
// {
//     myArray[i] = rand.Next(-10, 11); // 0, 1, 2 ... 8, 9
// }

// for (int i = 0; i < myArray.Length; i++)
// {
//     Console.Write(myArray[i] + "\t");
// }

// for(int i = 0; i < myArray.Length; i++)
// {
//     myArray[i] *= -1;
// }

// System.Console.WriteLine();

// for (int i = 0; i < myArray.Length; i++)
// {
//     Console.Write(myArray[i] + "\t");
// }