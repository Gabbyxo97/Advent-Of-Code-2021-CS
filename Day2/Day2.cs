#if true

using System;
using System.Diagnostics;
using System.IO;

var rapportRaw = File.ReadAllLines("Day2/input_day2.txt");

// part 1

var depth = 0;
var horizontalPos = 0;

foreach (var line in rapportRaw)
{
    var data = line.Split(' ');
    var direction = data[0];
    var amountRaw = data[1];
    
    if (!int.TryParse(amountRaw, out var amount))
        Debugger.Break();

    switch (direction)
    {
        case "forward":
            horizontalPos += amount;
            break;
        case "down":
            depth += amount;
            break;
        case "up":
            depth -= amount;
            break;
    }
}

Console.WriteLine(horizontalPos * depth);

// part 2

var aim = 0;
horizontalPos = 0;
depth = 0;

foreach (var line in rapportRaw)
{
    var data = line.Split(' ');
    var direction = data[0];
    var amountRaw = data[1];
    
    if (!int.TryParse(amountRaw, out var amount))
        Debugger.Break();

    switch (direction)
    {
        case "forward":
            horizontalPos += amount;
            depth += aim * amount;
            break;
        case "down":
            aim += amount;
            break;
        case "up":
            aim -= amount;
            break;
    }
}

Console.WriteLine(horizontalPos * depth);

#endif