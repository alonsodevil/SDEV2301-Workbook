static int MaxValue(int a, int b)
{
    if (a > b)
    {
        return a;
    }

    else if (b > a)
    {
        return b;
    }
    Console.WriteLine("Int method used!");
}

static double MaxValue(double a, double b)
{
    if (a > b)
    {
        return a;
    }

    else if (b > a)
    {
        return b;
    }
    Console.WriteLine("Double method used!");

}
double dMax = MaxValue(2.6, 9.4);
int iMax = MaxValue(2, 9);

Console.WriteLine(dMax);

Console.WriteLine(iMax);
