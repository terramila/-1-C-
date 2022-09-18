/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
 какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7 min = 5
a = 2 b = 10 -> max = 10 min = 2
a = -9 b = -3 -> max = -3 min = -9
*/

 Console.WriteLine("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
 
            if(num1 > num2)
            {
                Console.WriteLine($"{num1}= max {num2} = min");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num2} = max {num1} = min");
            }
            else
            {
                Console.WriteLine($"{num1} = {num2}");
            }
