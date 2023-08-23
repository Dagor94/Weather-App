Console.WriteLine("This list that shows the value the number of bytes occupied by a variable and the\n" +
    "maximum number of values that datatype can hold.");
Console.WriteLine("\nPossible types: int, char, float and array\n");

Console.Write("Type in a type you'd like to see: ");
string selectedType = Console.ReadLine();

switch (selectedType)
{
    case "int" or "Int":
        IntType();
        break;
    case "char" or "Char":
        CharType();
        break;
    case "float" or "Float":
        FloatType();
        break;
    case "array" or "Array":
        ArrayType();
        break;
    default:
        // code block
        break;
}


Console.ReadKey();

// Methods
static void IntType()
{
    Console.WriteLine("\nInteger - Int");
    int intSize = sizeof(int);
    Console.WriteLine($"byte size = {intSize}");

    int minIntValue = int.MinValue;
    int maxIntValue = int.MaxValue;
    long numberOfIntValues = (long)maxIntValue - minIntValue + 1;

    Console.WriteLine($"Data type Ínt can hold values between '{minIntValue}' and '{maxIntValue}'.");
    Console.WriteLine($"Number of values that Int can hold: {numberOfIntValues}");
    Console.WriteLine("\n\nDiagram");
    DrawDiagram("Int", intSize);
}

static void CharType()
{
    Console.WriteLine("\nCharacter - Char");
    int charSize = sizeof(char);
    Console.WriteLine($"byte size = {charSize}");

    int minCharValue = char.MinValue;
    long maxCharValue = char.MaxValue;
    long numberOfCharValues = (long)maxCharValue - minCharValue + 1;

    Console.WriteLine($"Data type Char can hold values between '{minCharValue}' and '{maxCharValue}'.");
    Console.WriteLine($"Number of values that Char can hold: {numberOfCharValues}");

    Console.WriteLine("\n\nDiagram");
    DrawDiagram("Char", charSize);
}

static void FloatType()
{
    Console.WriteLine("\nFloat");
    int floatSize = sizeof(char);
    Console.WriteLine($"byte size = {floatSize}");

    double minFloatValue = float.MinValue;
    double maxFloatValue = float.MaxValue;
    long numberOfFloatValues = (long)(Math.Pow(2, 32) - 1);

    Console.WriteLine($"Data type Float can hold values between '{minFloatValue}' and '{maxFloatValue}'.");
    Console.WriteLine($"Number of values that Float can hold: {numberOfFloatValues}");

    Console.WriteLine("\n\nDiagram");
    DrawDiagram("Float", floatSize);
}

static void ArrayType()
{
    Console.WriteLine("\nArray");
    Console.WriteLine("Arrays work differently since there are different types of array." +
        "\nAn array will inheirate the size of the type times the amount of elements in the array. " +
        "\n\nLike an int array with 4 elements will have the byte size of 16 since a single int is 4 byte." +
        "\nBut a char array with the same number of elements will only be 8 because the size of a char in bytes are 2.");

    Console.WriteLine("\nArrays also works differently i terms of max value since it is also tied to the datatype of the array,\n" +
        "while also having to be preset like int array[4] would have a maximum of 4 elements inside and 4*4 = 16 byte in size");
    int intSize = sizeof(int);

    Console.WriteLine("\n\nDiagram");
    DrawDiagram("Array (int array[4])", intSize*4);

}

static void DrawDiagram(string name, int size)
{
    Console.WriteLine($"Type: {name}");
    Console.WriteLine($"Memory diagram ({size} bytes): ");
    Console.WriteLine(" ________________ ");
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("|                |");
        Console.WriteLine("|     1 Byte     |");
        Console.WriteLine("|________________|");

    }
    Console.WriteLine();
}