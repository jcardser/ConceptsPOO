using POOConcepts;

Console.WriteLine("POO Concepts");
Console.WriteLine("====");
// ? la fecha puede ser nula
//Date? date1 = new Date(2022, 2, 11);

try
{
    Console.WriteLine(new Date(2021, 2, 11));
    Console.WriteLine(new Date(1974, 9, 23));
    Console.WriteLine(new Date(1985, 11, 5));
    Console.WriteLine(new Date(1985, 11, 5));
}
catch (Exception error)
{

    Console.WriteLine(error.Message);
}


