// ЗАДАЧА 2

// Console.Write("Input first number: ");
// int number_1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int number_2 = Convert.ToInt32(Console.ReadLine());

// if (number_1 > number_2)
// {Console.WriteLine(number_1 + "->" + "Большее число");
// Console.WriteLine(number_2 + "->" + "Меньшее число");}
// else if (number_1 < number_2){
// Console.WriteLine(number_2 + "->" + "Большее число");
// Console.WriteLine(number_1 + "->" + "Меньшее число");}

// else if (number_1 == number_2)
// {Console.WriteLine(number_1 + "->" + "Числа равны");}

// ЗАДАЧА 4

// Console.Write("Input first number: ");
// int number_1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int number_2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input third number: ");
// int number_3 = Convert.ToInt32(Console.ReadLine());


// if (number_1 > number_2 & number_1 > number_3 )
// Console.WriteLine(number_1 + "->" + "Большее число");

// else if (number_2 > number_1 & number_2 > number_3 )
// Console.WriteLine(number_2 + "->" + "Большее число");

// else if (number_3 > number_1 & number_3 > number_2 )
// Console.WriteLine(number_3 + "->" + "Большее число");

// else if (number_1 == number_2 & number_2 == number_3)
// {Console.WriteLine(number_1 + "->" + "Числа равны");}



// ЗАДАЧА 6
//  Console.Write("Input number: ");
//   int number = Convert.ToInt32(Console.ReadLine());

//   if (number % 2 ==0)
//    Console.WriteLine("Число четное");

//    else 
//     Console.WriteLine("Число нечетное");


// ЗАДАЧА 8
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int even = 2;
while (even <= number){
Console.WriteLine(even +"");
even = even + 2; }