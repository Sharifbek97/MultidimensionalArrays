

/*var Matrix = new int[8,5];
var rnd=new Random();
for (var i = 0; i < 8; i++)
{
    for (var j = 0; j < 5; j++)
    {
        Matrix[i, j] = rnd.Next(20, 40);
        Console.Write(Matrix[i, j] + " ");
    }
    Console.WriteLine(" ");
}

Console.WriteLine(" ");
var Counts = new int [8];

for (var i = 0; i < 8; i++)
{
    var count = 0;
    for (var j = 0; j < 5; j++)
    {
        if ( Matrix[i, j]% 2 == 0)
        {
            count++;
        }
    }

    Counts[i] = count;
}

var max = 0;
var maxIndex = 0;

for(var i = 0; i < Counts.Length; i++)
{
    if (max < Counts[i])
    {
        max = Counts[i];
        maxIndex = i;
    }
}

for (var j = 0; j < 5; j++)
{
    Console.Write(Matrix[maxIndex, j] + " ");
}*/

//Projecti 2
var Matrix = new int[4,6];
var rnd=new Random();
for (var i = 0; i < 4; i++)
{
    for (var j = 0; j < 6; j++)
    {
        Matrix[i, j] = rnd.Next(1, 10);
        Console.Write(Matrix[i, j] + " ");
    }
    Console.WriteLine(" ");
}
Console.Write("\n");
Console.WriteLine("\tA new array whose elements consist of the sum of the elements of the given array");
var max=0;
var Sums = new int [8];
for (var i = 0; i < 4; i++)
{ 
    var summa = 0;
    for (var j = 0; j < 6; j++)
    {
        summa += Matrix[i, j];
    }
    Sums[i] = summa;
    Console.WriteLine( Sums[i] );
    
    if (max < summa)
    {
        max = summa;
    }
}
Console.Write("\n\tThe bigger's of elements of the new array: " + max);
