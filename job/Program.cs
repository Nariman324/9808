void PrintArray(string[] array) // метод для вывода массива с учетом расстановки скобок
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0 & array.Length > 1)
        {
            Console.Write("[" + " " +"\"" + array[i] +"\"" + "," + " ");
        }

        // if (i == 0 & array.Length <2)
        // {
        //     Console.Write("[" + " " + "\"" + array[i] + "\"" + "," + " " + "]");
        // }

        if (i != 0 & i != array.Length-1 )
        {
            Console.Write("\"" +array[i] +"\""+"," + " ");
        }

        if (i == array.Length-1 & array.Length > 1 )
        {
            Console.Write("\"" +array[i] +"\"" + " " + "]");
        }
        if (array.Length == 0)
        {
            Console.WriteLine("[ ]");
        }
        if (array.Length == 1)
        {
            Console.WriteLine("[" + " " +"\"" +array[i] +"\"" + " " + "]");
        }
    }
}

string[] CreateAndPrintStringArray() // генерируем массив, наполненный строками рандомизированной длины
{
    Random rnd = new Random();
    int lengthOfArray = rnd.Next(1, 7); // рандомизируем длину массива
    string[] stringArray = new string[lengthOfArray]; // инициализируем новый массив
    for (int i = 0; i < lengthOfArray; i++)
    {
        int StringLength = rnd.Next(0, 11); // рандомизируем длину новой строки
        string str = ""; // инициализируем новую строку
        char letter; // инициализируем новую букву для новой строки
        for (int j = 0; j < StringLength; j++)
        {
            int randValue = rnd.Next(0, 26); // рандомзируем новую букву
            letter = Convert.ToChar(randValue+30); // переводим ее в тип char
            str +=letter ; // добавляем новую букву к формируемой строке
        }
        stringArray[i] = str; // добавляем новую строку в массив
    }
    PrintArray(stringArray);
    return stringArray;
}

void NotMoreThanThreeSymbolsStringArray () // метод для определения строк заданной длины и записи их в новый массив
{
    string[] stringArray = CreateAndPrintStringArray(); // создаем массив из строк при помощи метода

    int newStringArrayLength = 0;

    for (int i = 0; i < stringArray.Length; i++) // цикл для определения длины массива со строками длиной не больше 3 символов
    {
        int length = stringArray[i].Length;
        if (length <= 3)
        {
            newStringArrayLength++;      
        }
    }

    Console.Write("  --->  ");

    if (newStringArrayLength == 0)
    {
        Console.WriteLine("[ ]");
    }

    string[] newStringArray = new string[newStringArrayLength]; // инициализируем новый массив
    int count = 0; // счетчик для индексации строк в новом массиве
    for (int i = 0; i < stringArray.Length; i++) // цикл для определения строк заданной длины и записи их в новый массив
    {
        int length = stringArray[i].Length;
        if (length <= 3)
        {
            newStringArray[count] = stringArray[i]; // записываем в новый массив строки заданной  длины
            count++;
        }
    }
    PrintArray(newStringArray);
}

NotMoreThanThreeSymbolsStringArray ();
