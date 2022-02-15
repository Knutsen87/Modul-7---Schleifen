// See https://aka.ms/new-console-template for more information

string[] names = new string[]
{
    "Sebastian",
    "Sabrina",
    "Horst",
    "Claudia",
    "Kim",
    "Marci"
};

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
    Console.WriteLine("\n");
}


string[,] products = new string[,]
{
    {
        "Apfel",
        "Smartphone",
        "Schokolade"
    },
    {
        "Lebensmittel",
        "Elektronik",
        "Lebensmittel"
    }
};

for(int zeile = 0; zeile < products.GetLength(1); zeile++)
{
    for (int spalte = 0; spalte < products.GetLength(0); spalte++)
    {
        Console.WriteLine(products[spalte, zeile]);
        Console.Write(" ");
    }

    Console.WriteLine();
}

Console.ReadKey();