double LinearFunction(double k, double b, double x)
{
    return k * x + b;
}


double[] GetLine()
{
    double[] line = new double[2];
    Console.Write("Input k --> ");
    line[0] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input b --> ");
    line[1] = Convert.ToDouble(Console.ReadLine());
    return line;
}


void PrintIntersection(double[] line1, double[] line2)
{
    if (line1[0] == line2[0])
    {
        if (line1[1] == line2[1])
        {
            Console.WriteLine("Both lines are equal");
        }
        else
        {
            Console.WriteLine("There is no intersection point");
        }
    }
    else
    {
        double xCoordinate = (line2[1] - line1[1])
                             / (line1[0] - line2[0]);
        double yCoordinate = LinearFunction(line1[0], line1[1], xCoordinate);
        Console.WriteLine($"({xCoordinate}, {yCoordinate})");
    }
}


Console.WriteLine("Set the first line");
double[] firstLine = GetLine();
Console.WriteLine("Set the second line");
double[] secondLine = GetLine();
PrintIntersection(firstLine, secondLine);