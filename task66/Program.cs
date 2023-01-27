/*Задача 66: Задайте значения M и N.
 Напишите программу, которая найдёт 
 сумму натуральных элементов в 
 промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int getUserMsg(string msg)
{
    Console.WriteLine(msg);
    int messege = int.Parse(Console.ReadLine()!);
    return messege;
}
int GetCalculateSumOfGapBetweenNum(int numN, int numM)
       { 
            if(numN > numM)  return 0;
            
            return numN + GetCalculateSumOfGapBetweenNum(numN + 1, numM); 
       }
       
int numN = getUserMsg("Введите число n ");
int numM = getUserMsg("Введите число m ");
int result = GetCalculateSumOfGapBetweenNum(numN,numM);		
Console.WriteLine($"Сумма элементов в промежутке от {numN } до {numM}] равна {result}");	       
    
