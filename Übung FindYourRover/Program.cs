string direction = Console.ReadLine()!;
int east = 0;
int north = 0;
int south = 0;
int west = 0;

for (int i = 0; i < direction.Length; i++)
{
    if (direction[i] == '<' || direction[i] == '>' || direction[i] == '^' || direction[i] == 'V')
    {
        switch (direction[i])
        {
            case '<': west--; break;
            case '>': east++; break;
            case '^': north++; break;
            case 'V': south--; break;
        }
    }
}

Console.Write("The rover is ");
int westeast = west + east;
int northsouth = north + south;

if (westeast == 0 || northsouth == 0) { Console.WriteLine("in the base station"); }
else
{
    Console.Write($"{Math.Abs(westeast)}m to the ");
    if (westeast < 0) { Console.Write("west"); }
    else { Console.Write("east"); }

    Console.Write($" and {Math.Abs(northsouth)}m to the ");
    if (northsouth > 0) { Console.WriteLine("north"); }
    else { Console.WriteLine("south"); }
}

double Linear_Distance = Math.Sqrt(Math.Abs(westeast) * Math.Abs(westeast) + Math.Abs(northsouth) * Math.Abs(northsouth));
Console.Write($"Linear distance = {Math.Round(Linear_Distance, 2)}m, ");

int Manhattan_Distance = Math.Abs(westeast) + Math.Abs(northsouth);
Console.Write($"Manhattan distance = {Math.Abs(Manhattan_Distance)}m");
