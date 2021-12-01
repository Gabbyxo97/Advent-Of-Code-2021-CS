using System;
using System.IO;

var rapportRaw = File.ReadAllLines("Day1/input_day1.txt");
var rapport = Array.ConvertAll(rapportRaw, int.Parse);


// part 1
var increments = 0;

for (var i = 1; i < rapport.Length; i++)
{
    var previous = rapport[i - 1];
    if (rapport[i] > previous)
        increments++;
}

Console.WriteLine(increments);

// part 2

increments = 0;

for (var i = 0; i < rapport.Length; i++)
{
    if (rapport.Length - i < 4)
        break;

    var sum1 = rapport[i] + rapport[i + 1] + rapport[i + 2];
    var sum2 = rapport[i + 1] + rapport[i + 2] + rapport[i + 3];

    if (sum2 > sum1)
        increments++;
}

Console.WriteLine(increments);