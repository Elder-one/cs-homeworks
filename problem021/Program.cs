// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние
// между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double getDistance(double[] point1, double[] point2)
{
    double result = 0;
    for(int i = 0; i < 3; i++)
    {
        result += Math.Pow(point1[i] - point2[i], 2);
    }
    result = Math.Sqrt(result);
    return result;
}

double[] get_point()
{
    double[] result = new double[3];
    for(int i = 0; i < 3; i++)
    {
        if(i == 0) Console.Write("x --> ");
        if(i == 1) Console.Write("y --> ");
        if(i == 2) Console.Write("z --> ");
        result[i] = Convert.ToDouble(Console.ReadLine());
    }
    return result;
}

Console.WriteLine("Enter first point");
double[] A = get_point();

Console.WriteLine("Enter second point");
double[] B = get_point();

double distance = getDistance(A, B);
Console.WriteLine($"Your distance is {distance}");