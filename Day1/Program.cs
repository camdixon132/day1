// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please enter the length of the room");
double length = double.Parse(Console.ReadLine());

Console.WriteLine("Please enter the width of the room");
double width = double.Parse(Console.ReadLine());

double area = length * width;

double perimeter = length + length + width + width;

Console.WriteLine("The perimeter of the room is " + perimeter);

Console.WriteLine("The area of the room is " + area);

if (area <= 250)
{
    Console.WriteLine("This is a small room.");
}
else if (area <= 650)
{
    Console.WriteLine("This is a medium sized room.");
}
else
{
    Console.WriteLine("This is a large room.");    
}

Console.WriteLine("Please enter the height of the room.");
double height = double.Parse(Console.ReadLine());

double volume = length * width * height;

Console.WriteLine("The volume of the room is " + volume);