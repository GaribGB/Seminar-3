Console.WriteLine("Введите число: ");

bool D = false;

while (D == false)
{
    int A = Convert.ToInt32(Console.ReadLine());

    if (A<100000 && A>9999)
    {
        D = true;
        int N1 = A/10000;
        int N5 = A%10;
        int N2 = (A/1000)%10;
        int N4 = (A/10)%10;

        if(N1 == N5 && N2 == N4 )
        {   
            Console.WriteLine("Да, число является палиндромом");
        }

        else
        {
            Console.WriteLine("Нет, число не является палиндромом");
        }
    }

    else
    {
        Console.WriteLine ("Число не верное, введите пятизначное число");
    }  
}  
