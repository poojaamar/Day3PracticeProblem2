using LineComparisonComputation;

CalculateLength line1 = new CalculateLength(); 
CalculateLength line2 = new CalculateLength(); 
double length1 = line1.Length(); 
double length2 = line2.Length();  
Console.WriteLine("The Equals method ans is : " + length1.Equals(length2)); 
Console.WriteLine("The CompareTo method ans is : " + length1.CompareTo(length2));