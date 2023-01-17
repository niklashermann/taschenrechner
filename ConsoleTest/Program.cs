Console.WriteLine(@"Geben Sie ihre Rechenweise an (+,-,*,:,!): ");
string weise = Console.ReadLine();
if (weise == "+" || weise == "-" || weise == "*" || weise == ":" || weise == "!")
{ }
else
{
    Console.WriteLine("Falsche Eingabe. Du darfst nur +, -, *, : oder ! verwenden!");
    return;
}
Console.WriteLine("Hallo, bitte geben Sie ihre Erste Zahl ein.");
//string? tmp = Console.ReadLine();
double value1 = 0;
try
{
    value1 = Convert.ToDouble(Console.ReadLine());
}
catch (FormatException) //FormatExeption achtet darauf, dass man nur Zahlen verwenden kann.
{
    Console.WriteLine("Falsche Eingabe. Du darfst nur Zahlen verwenden.");
    return;
}

double ergebnis = 0;

if (weise == "+" || weise == "-" || weise == "*" || weise == ":")
{
    Console.WriteLine("Bitte geben Sie ihre Zweite Zahl ein.");
    double value2 = 0;
    try
    {
        value2 = Convert.ToDouble(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("Falsche Eingabe. Du darfst nur Zahlen verwenden.");
        return;
    }
    if (value2 == 0 && weise == ":")
    {
        Console.WriteLine("Rechnung: {0} : {1} = \'0\'", value1, value2, ergebnis);
        return;
    }
    if (weise == "+") //Wenn eine Weise mit dem "+" usw. beginnt, wird ein bestimmter Rechenweg genutzt.
    {
        ergebnis = addition(value1, value2);
    }
    else if (weise == "-")
    {
        ergebnis = subtraktion(value1, value2);
    }
    else if (weise == "*")
    {
        ergebnis = multiplikation(value1, value2);
    }
    else if (weise == ":")
    {
        ergebnis = division(value1, value2);
    }
    else
    {

        Console.WriteLine("Die Eingabe {0} ist inkorrekt.", weise);
        return;
    }

    if (weise == "+")
    {
        Console.WriteLine("Rechnung: {0} + {1} = \'{2}\'", value1, value2, ergebnis);
    }
    else if (weise == "-")
    {
        Console.WriteLine("Rechnung: {0} - {1} = \'{2}\'", value1, value2, ergebnis);
    }
    else if (weise == "*")
    {
        Console.WriteLine("Rechnung: {0} * {1} = \'{2}\'", value1, value2, ergebnis);
    }
    else if (weise == ":")
    {
        Console.WriteLine("Rechnung: {0} : {1} = \'{2}\'", value1, value2, ergebnis);
    }
}


else if (weise == "!") //Dieser Rechenweg macht eine ganz andere Rechnung, deswegen muss sie abgetrennt sein.
{
    if (weise == "!")
    {
        ergebnis = fakultät(value1);
    }
    else
    {

        Console.WriteLine("Die Eingabe {0} ist inkorrekt.", weise);
        return;
    }

    if (weise == "!")
    {
        Console.WriteLine("Rechnung: {0}! = \'{1}\'", value1, ergebnis);
    }
}


//Console.WriteLine("Ihr Ergebnis ist \'{0}\'", ergebnis);

//Programmende

/// <summary>
/// Funktionsbereich
/// </summary>

static double addition(double value1, double value2) //Es ist eine neue Methode, die oben eingesetzt wird.
{

    double ergebnis = value1 + value2; // WARNUNG!! Das ist ein NEUES Ergebnis, es hat nichts mit dem Ergebnis, welches oben erstellt wurde
                                       //zutun. 

    return ergebnis;

}

static double subtraktion(double value1, double value2)
{

    double ergebnis = value1 - value2;

    return ergebnis;

}

static double multiplikation(double value1, double value2)
{

    double ergebnis = value1 * value2;

    return ergebnis;

}

static double division(double value1, double value2)
{

    double ergebnis = value1 / value2;

    return ergebnis;

}

static double fakultät(double value1)
{
    int temp = 1;
    for (int i = 1; i <= value1; i++)
    {
        temp = temp * i;
    }
    double ergebnis = temp;

    return ergebnis;

}

