/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int functionAkkerman = A(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int A(int m, int n)
{
  if (m == 0) return n + 1;
  else if (m > 0 && n == 0) return A(m - 1, 1);
  else return A(m - 1, A(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
