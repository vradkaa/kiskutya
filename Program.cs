List<double> poly = [];
string? input;
int count = 1;

while (true)
{
    Console.WriteLine($"Coordinate {count} X:");
    input = Console.ReadLine();
    if (!double.TryParse(input, out double x))
    {
        break;
    }

    Console.WriteLine($"Coordinate {count} Y:");
    input = Console.ReadLine();
    if (!double.TryParse(input, out double y))
    {
        break;ir2igwurwirigwr
    }

    poly.Add(x);
    poly.Add(y);

    count++;
}

Console.WriteLine(string.Join(',', poly));
//kis kacsa fürdik fekete tóban háp-háp
