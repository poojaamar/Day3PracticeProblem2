int x1 = 4, x2 = 4, y1 = 9, y2 = 7;
int x3 = 3, x4 = 5, y3 = 5, y4 = 8;
double line1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
double line2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
Console.WriteLine(line1.CompareTo(line2));