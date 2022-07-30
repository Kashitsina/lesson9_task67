
void Zadacha67()
{
  // Напишите программу ,которая будет принимать на вход число и возвращать сумму его цифр
  Console.Write("Введите числа");
  int n = Convert.ToInt32(Console.ReadLine());
  int summa = FindSum(n) ;
  int FindSum(int num)
  {
    if (num / 10 > 0) return FindSum(num / 10)+ num%10;

    return num;
  }
  Console.WriteLine(summa);


} 


Zadacha67();
