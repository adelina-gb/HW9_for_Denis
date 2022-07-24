
void Zadacha64()
{
    /*
    Задача 64: Задайте значения M и N. Напишите программу, 
    которая выведет все натуральные числа в промежутке от M до N, кратные трём.
    M = 1; N = 5. -> ""1, 2, 3, 4, 5""
    M = 4; N = 8. -> ""4, 6, 7, 8""
    */

    Console.WriteLine("Введите число:");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число:");
    int N = Convert.ToInt32(Console.ReadLine());
    RecMultipleThree(M, N);
}

void RecMultipleThree(int M, int N)
{
    if(M>N) return;
    if(M%3==0)
    Console.Write(M +" ");
    M++;
    RecMultipleThree(M, N);
}

void Zadacha66()
{
    /*
    Задача 66: Задайте значения M и N. Напишите программу, 
    которая найдёт сумму натуральных элементов в промежутке от M до N.
    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30
    */
    Console.WriteLine("Введите число:");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число:");
    int N = Convert.ToInt32(Console.ReadLine());
    RecursoinSum(M, N);
}

void RecursoinSum(int M, int N, int sum=0)
{
    if(M > N)
    {
    Console.Write(sum); 
    return;
    }

    sum += M;
    M ++;
    RecursoinSum(M, N, sum); 
}



void Zadacha68()
{
    /*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
    Даны два неотрицательных числа m и n.
    m = 3, n = 2 -> A(m,n) = 29
    */

    Console.WriteLine("Введите первое число: ");
    int M =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int N =Convert.ToInt32(Console.ReadLine());      
    Console.Write(Recursion(M,N));
    int Recursion(int M, int N)
    {
    if (M == 0)
        {
            return N + 1;
        } 
    else if (N == 0 && M > 0)
        {
            return Recursion(M - 1, 1);
        } 
    else
        {
            return Recursion(M - 1, Recursion(M, N - 1));
        }
    }
}

//Zadacha64();
//Zadacha66();
Zadacha68(); 