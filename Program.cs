// See https://aka.ms/new-console-template for more information




int [] numbers ={23,6,87,12,4,43,66};

Console.WriteLine("Sayıların Normal Dizilimi:");
foreach (var number in numbers)
{
    Console.WriteLine(number);
}

Array.Sort(numbers);

Console.WriteLine("Sayıların Sıralı Dizilimi:");
foreach (var number in numbers)
{
    Console.WriteLine(number);
}

Array.Reverse(numbers);

Console.WriteLine("Sayıların Reverse Dizilimi:");
foreach (var number in numbers)
{
    Console.WriteLine(number);
}


Console.WriteLine("23 numarasının indexi: " +  Array.IndexOf (numbers, 23));

Array.Resize<int>(ref numbers,9);
numbers[8]=55;
foreach (var number in numbers)
{
    Console.WriteLine(number);
}