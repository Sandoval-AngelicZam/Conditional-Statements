

/*Pracitce 1.3*/

Console.Write("Enter your age: ");
int Age = Convert.ToInt32(Console.ReadLine());

if (Age == 25 && Age <= 35)
{
    Console.WriteLine("You are a young professional and has an income greater than 50,000 pesos");
}
else if (Age == 36 && Age <= 55)
{
    Console.WriteLine("You are a middle-aged professional and has an income greater than 70,000 pesos");
}

else if (Age >= 56)
{
    Console.WriteLine("You are a senior citizen and has an income less than 30,000 pesos");
}

else if (Age == 21 && Age <= 24)
{
    Console.WriteLine("You are a rookie and has an income less than 20,000 pesos");
}

else
{
    Console.WriteLine("You are an Unemployed Final Boss");
}
