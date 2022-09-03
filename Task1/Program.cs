Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int SecondPosition(int num)
{
    int result = num / 10 - num / 100 * 10;
    return(result);
}
Console.Write("Второе число ");
Console.WriteLine(SecondPosition(number));