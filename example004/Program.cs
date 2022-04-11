Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
//int b = a - (a * 2);
int b = -a; 


 while (b <= a)
 {
    Console.Write(b);
    b++; 
    if (b <= a)
    {
        Console.Write(", ");
    }
 }
