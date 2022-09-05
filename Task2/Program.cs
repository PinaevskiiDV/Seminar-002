Console.WriteLine("Введите цифру дня недели от 1 до 7");
int numberA = Convert.ToInt32(Console.ReadLine());

bool Multiple(int num)
{
    if(num == 6 || num == 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}
if(Multiple(numberA)==true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

