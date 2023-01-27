/*Задача 68: Напишите программу 
вычисления функции Аккермана с 
помощью рекурсии. Даны два неотрицательных 
числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
int getUserMsg(string msg)
{
    Console.WriteLine(msg);
    int messege = int.Parse(Console.ReadLine()!);
    return messege;
}
int GetCalculateAkkermanFunction(int m, int n)
	{
		if(m == 0)
			{
				return n + 1;
			}
		if(m > 0 && n == 0)
			{
				return GetCalculateAkkermanFunction(m - 1, 1);
			}
		return GetCalculateAkkermanFunction(m - 1, GetCalculateAkkermanFunction(m, n - 1));
	}
int numN = getUserMsg("Введите число n ");
int numM = getUserMsg("Введите число m ");
int result = GetCalculateAkkermanFunction(numN,numM);		
Console.WriteLine($"Результат вычисления функции Акермана чисел {numN} и {numM} равен {result}.");
