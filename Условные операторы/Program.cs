//Дано четырехзначное число. Определить: а) равна ли сумма двух первых его цифр сумме двух последних б) кратна ли 7 сумма его цифр.

try
{
    Console.Write("Введите четырехзначное число:");
    int a = int.Parse(Console.ReadLine());
    
    double a1 = a / 1000;
    double a2 = (a % 1000) / 100;
    double a3 = (a % 100) / 10;
    double a4 = a % 10;
    double firstsum = a1 + a2;
    double secondsum = a3 + a4;
    if (firstsum == secondsum) Console.WriteLine($"Суммы равны, {firstsum}={secondsum}");
    else Console.WriteLine($"Суммы не равны; {firstsum} не равно {secondsum}");
    int sum = 0;
    sum += a / 1000; //Первая цифра
    sum += (a / 100) % 10; //Вторая цифра
    sum += (a / 10) % 10; //Третья цифра
    sum += a % 10;  //Четвертая цифра
    if (sum % 7 == 0) Console.WriteLine("Сумма цифр числа кратна 7");
    else Console.WriteLine("Сумма цифр числа не кратна 7");

}
catch
{
    Console.WriteLine("Введите данные правильно!");
}