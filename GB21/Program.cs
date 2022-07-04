
Console.Clear();

int x1=Input("Введите кординату x1:");
int y1=Input("Введите кординату y1:");
int z1=Input("Введите кординату z1:");
int x2=Input("Введите кординату x2:");
int y2=Input("Введите кординату y2:");
int z2=Input("Введите кординату z2:");

int distanceX = Distance(x2,x1);
int distanceY = Distance(y2,y1);
int distanceZ = Distance(z2,z1);

int squareX = Square(distanceX);
int squareY = Square(distanceY);
int squareZ = Square(distanceZ);

int summ = squareX + squareY + squareZ;

double result = Math.Sqrt(summ);

Console.WriteLine("Расстояние между точками = " + result);

int Square(int number)
{
    return number*number;
}

int Distance(int a2, int a1)
{
    return a2 - a1;
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
