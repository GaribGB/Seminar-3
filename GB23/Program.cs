
Console.Clear();

int count=Input("Введите число: ");

int i=0;

while(i<count)
{
    Console.Write(Cube(i) + ", ");
    i++;
}
Console.WriteLine(Cube(count));
int Input(string output)
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}

int Cube(int number)
{
    return number*number*number;
}



