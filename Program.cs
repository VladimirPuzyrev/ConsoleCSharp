
using ConsoleApp4;



// переписать все статически методы на обычные


//Console.WriteLine("Введите размер первого массива: ");
//int first = Int32.Parse(Console.ReadLine());


//Console.WriteLine("Введите размер вложенного массива: ");
//int second = Int32.Parse(Console.ReadLine());

//Random rnd = new Random();

//int firstInt, secondInt;
//int[] arrayInt;

//char firstChar, secondChar;
//char[] arrayChar;


Console.WriteLine();
// ------------------------------------------------

/* static int dubFаc(int x)
{
    int sum = 1;
    for (int i = 0; i < x; i++)
    {
        sum *= x - i;
        i++;
        Console.WriteLine(sum);
    }

    return sum;
}

// Рекурсия 

Console.WriteLine(dubFаc(n)); */

/* static int dubFаcRec(int x)
{
    if (x <= 1) return 1;
    else return x * dubFаcRec(x-2);

}


Console.WriteLine(dubFаcRec(n)); */

// ------------------------------------------------

/* static double pow(int x)
{
    double sum = 0;
    for (int i = 1; i <= x; i++)
    {
        sum += Math.Pow(i, 2);
    }

    return sum;
}

Console.WriteLine(pow(n)); */

// Рекурсия 
/* static double pow(int x)
{
    if (x == 1) return 1;
    else return Math.Pow(x,2) + pow(x-1);
}

Console.WriteLine(pow(n)); */

// ------------------------------------------------

/* static int[] massiv(int[] array, int a)
{

    if(a > array.Length)
    {
        int[] arrayCopy = array;
        return arrayCopy;
    }
    else
    {
        int[] newArray = new int[a];
        for (int i = 0; i < newArray.Length; i++)
        {
            newArray[i] = array[i];
        }
        return newArray;
    }
}

int[] final = massiv(mainArray, second);

for ( int i = 0; i < final.Length; i++)
{
    Console.WriteLine(final[i]);
} */


// ------------------------------------------------

/*

char[] mainArray = new char[first];
int randomChar;

Random rnd = new Random();

for(int i = 0; i < mainArray.Length; i++)
{
    randomChar = rnd.Next(1, 127);
    mainArray[i] = (char)randomChar;

    Console.Write(mainArray[i] + " | ");
}

Console.WriteLine();
Console.WriteLine("--------------");


static int[] parseArray(char[] charArray)
{
    int[] intArray = new int[charArray.Length];
    for(int i = 0; i < charArray.Length; i++)
    {
        intArray[i] = (int)charArray[i];
    }

    return intArray;
}

int[] final = new int[mainArray.Length];

final = parseArray(mainArray);

for (int i = 0; i < final.Length; i++)
{
    Console.WriteLine(final[i]);
}

*/

// ------------------------------------------------


/*

Random rnd = new Random();

int[] mainArray = new int[first];

for (int i = 0; i < mainArray.Length; i++)
{
    mainArray[i] = rnd.Next(0, 100);
}

for (int i = 0; i < mainArray.Length; i++)
{
    Console.Write(mainArray[i] + " | ");
}

Console.WriteLine();


static int average(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }

    sum /= array.Length;

    return sum;

}

Console.Write(average(mainArray));

*/

// ------------------------------------------------



//int[,] mainArray = new int[first, second];

//for (int i = 0; i < mainArray.GetLength(0); i++)
//{
//    for (int j = 0; j < mainArray.GetLength(1); j++)
//    {
//        mainArray[i, j] = rnd.Next(0, 255);
//    }
//}

//for (int i = 0; i < mainArray.GetLength(0); i++)
//{
//    for (int j = 0; j < mainArray.GetLength(1); j++)
//    {
//        Console.Write(mainArray[i, j] + " | ");
//    }
//    Console.WriteLine();
//}



//Console.WriteLine();

//static int findMaxElement(int[,] array, out int iIndex, out int jIndex)
//{
//    int max = -1;

//    iIndex = 0;
//    jIndex = 0;

//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            if (array[i, j] > max)
//            {
//                max = array[i, j];
//                iIndex = i;
//                jIndex = j;
//            }
//        }

//    }

//    return max;
//}


//int iIndex, jIndex;

//int maxElement = findMaxElement(mainArray, out iIndex, out jIndex);

//Console.WriteLine($" Максимальный элемент {maxElement}");
//Console.WriteLine($" I максимального элемента {iIndex}");
//Console.WriteLine($" J максимального элемента {jIndex}");

// ------------------------------------------------


//char[] mainCharArray = new char[first];


//for (int i = 0; i < mainCharArray.Length; i++)
//{
//    mainCharArray[i] = (char)rnd.Next(97, 123);
//}


//for (int i = 0; i < mainCharArray.Length; i++)
//{
//    Console.Write(mainCharArray[i] + " || ");
//}




//static char[] charMethod(char[] array)
//{

//    char[] chars = new char[array.Length];
//    for(int i  = 0; i < array.Length; i++)
//    {
//        chars[i] = array[(array.Length-1) - i];
//    }

//    return chars;

//}


//char[] reversArray = charMethod(mainCharArray);


//for (int i = 0; i < reversArray.Length; i++)
//{
//    Console.Write(reversArray[i] + " || ");
//}



// ------------------------------------------------


//Console.WriteLine("Введите тип массива: \n 1 - Численный \n 2 - Символьный");  //Проблема решилась переносом методов в отдельный класс, как понимаю из за того что методы в методе Main как то криво определяются либо, определяються как функции
//int typeCheck = Int32.Parse(Console.ReadLine());

//if (typeCheck == 1)
//{
//    Console.WriteLine("Введите с какого числа начинать: ");
//    firstInt = Int32.Parse(Console.ReadLine());

//    Console.WriteLine("Введите каким числом закончить: ");
//    secondInt = Int32.Parse(Console.ReadLine());

//    arrayInt = Class1.writeMethod(firstInt, secondInt);

//    foreach (int i in arrayInt)
//    {
//        Console.Write(i + " || ");
//    }

//}
//else if (typeCheck == 2)
//{
//    Console.WriteLine("Введите с какого символа начинать: ");
//    firstChar = Char.Parse(Console.ReadLine());

//    Console.WriteLine("Введите каким символом закончить: ");
//    secondChar =Char.Parse(Console.ReadLine());

//    arrayChar = Class1.writeMethod(firstChar, secondChar);

//    foreach (char i in arrayChar)
//    {
//        Console.Write(i + " || ");
//    }

//}

//------------------------------------------------


//int[] returnElement = Class1.mmElement(2, 5, 123);

//Console.Write("Максимальный элемент: " + returnElement[0] + "\n" + "Минимальный элемент: " + returnElement[1]);


//------------------------------------------------

//Console.Write(Class1.addChar("ннн", 'ы', 'ы', 'ы'));


//------------------------------------------------
