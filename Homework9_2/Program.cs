/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29 */

int A(int m, int n)
{
     if (m == 0)
        {
            return n + 1;
        }
    else if ((m > 0) && (n == 0))
        {
            return A(m - 1, 1);
        }
    else if ((m > 0) && (n > 0))
        {
            return A(m - 1, A(m, n - 1));
        } else
    return n + 1;
}


Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (m < 0)
    m = m * -1;
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 0)
    n = n * -1;
Console.WriteLine(A(m, n));
