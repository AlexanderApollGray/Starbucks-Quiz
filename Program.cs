// Starbucks Quiz by Xander
#nullable disable
Console.Clear();

// Welcome
Console.WriteLine("Epic Starbucks Quiz!");

// Quiz score variable
int score = 0;

// Question 1
Console.Write("\n1: What is the name of the starbucks blended coffee beverage? ");
string q1 = Console.ReadLine().ToLower();
if (q1 == "frappuccino" || q1 == "frappe")
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine("Incorrect.");
}

// Question 2
Console.Write("\n2: What is the name of the starbucks refresher? ");
string q2 = Console.ReadLine().ToLower();
if (q2 == "mango dragonfruit" || q2 == "dragon drink" || q2 == "strawberry acai" ||
q2 == "pink drink" || q2 == "pineapple passionfruit" || q2 == "paradise drink")
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine("Incorrect.");
}

// Question 3
Console.Write("\n1: What are the standard espresso and milk drinks? ");
string q3 = Console.ReadLine().ToLower();
if (q3 == "caffe latte" || q3 == "latte" || q3 == "capuccino")
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine("Incorrect.");
}

// Question 4
Console.Write("\n1: Who founded starbucks? ");
string q4 = Console.ReadLine().ToLower();
if (q4 == "gordon bowker" || q4 == "jerry baldwin" || q4 == "zev siegl")
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine("Incorrect.");
}

// Quiz score output
Console.WriteLine("\nYour Results:");
if (score == 4)
{
    Console.WriteLine("4 / 4 (100%)");
    Console.WriteLine("Have an amazing day!");
}
else if (score == 3)
{
    Console.WriteLine("3 / 4 (75%)");
    Console.WriteLine("Have a great day!");
}
else if (score == 2)
{
    Console.WriteLine("2 / 4 (50%)");
    Console.WriteLine("Have a good day!");
}
else if (score == 3)
{
    Console.WriteLine("1 / 4 (25%)");
    Console.WriteLine("Have a better day!");
}
else
{
    Console.WriteLine("0 / 4 (0%)");
    Console.WriteLine("Have a day!");
}