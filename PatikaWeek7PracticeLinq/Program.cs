
Random random = new Random(); // Creating a list that contains random numbers between -100 to 100.

List<int> randomNumbers = new List<int>();

for (int i = 0; i < 10; i++)
{
    randomNumbers.Add(random.Next(-100,100));
}

Console.WriteLine("Rastgele Sayılar:"); // Displaying all numbers

foreach (int number in randomNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("-----------------");

Console.WriteLine("Çift Sayılar:"); // Displaying only even numbers

var evenNumbers = randomNumbers.Where(num => num % 2 == 0);

foreach (var number in evenNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("----------------------");

Console.WriteLine("Tek Sayılar:"); // Displaying only odd numbers

var oddNumbers = randomNumbers.Where(num => num % 2 != 0);

foreach (var number in oddNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("----------------------");

Console.WriteLine("Negatif Sayılar:"); // Displaying negative numbers

var negativeNumbers = randomNumbers.Where(num => num < 0);

foreach (var number in negativeNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("-----------------------");

Console.WriteLine("Pozitif Sayılar:"); // Displaying positive numbers

var positiveNumbers = randomNumbers.Where(num => num > 0);

foreach (var number in positiveNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("------------------------");

Console.WriteLine("15'ten büyük 22'den küçük sayılar:"); // Displaying number only if they are between 15 to 22.

var numbersBetween15And22 = randomNumbers.Where(num => num > 15 && num < 22);

foreach (var number in numbersBetween15And22)
{
    Console.WriteLine(number);
}

Console.WriteLine("----------------------------");

Console.WriteLine("Sayıların Karesi:"); // Displaying the square of all numbers.

List<int> squaredList = randomNumbers.Select(num => num * num).ToList(); 

foreach (var number in squaredList)
{
    Console.WriteLine(number);
}