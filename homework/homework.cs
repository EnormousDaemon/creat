//1 Задача


// System.Console.Write("Введите число: ");
// int fn = Convert.ToInt32(Console.ReadLine());

// if (fn % 7 == 0 && fn % 23 == 0) 
//     System.Console.Write("да");
// else
//     System.Console.Write("нет");



// 2 задача


// System.Console.Write("Введите X: ");
// int X = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите Y: ");
// int Y = Convert.ToInt32(Console.ReadLine());
// if (X > 0 && Y > 0)
//     Console.Write("1");
// if (X > 0 && Y < 0)
//     Console.Write("4");
// if (X < 0 && Y < 0)
//     Console.Write("3");
// if (X < 0 && Y > 0)
//     Console.Write("2");



// 3 задача


// System.Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// if (n > 10 && n < 99){
//     if (n % 10 > n / 10)
//     Console.Write(n % 10);
//     else Console.Write(n / 10);
// }


// 4 задача


 System.Console.Write("Введите число: ");
 long n = Convert.ToInt32(Console.ReadLine());
 long i = 10;
 while (n > i ){
    i = i * 10;
 } i = i / 10;
 while (n > 10){
    Console.Write(n / i + ", ");
    n = n % i;
    i = i / 10;
 } Console.Write(n % 10 + ".");

 