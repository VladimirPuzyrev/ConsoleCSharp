Console.WriteLine("Введите размер первого массива: ");
int first = Int32.Parse(Console.ReadLine());


Console.WriteLine("Введите размер второго массива: ");
int second = Int32.Parse(Console.ReadLine());


char[] mainArray = new char[first];
int randomChar;

Random rnd = new Random();

for(int i = 0; i < mainArray.Length; i++)
{
    randomChar = rnd.Next(97, 123);
    mainArray[i] = (char)randomChar;
    
    Console.Write(mainArray[i] + "||");
}


Console.WriteLine("--------------");

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


static char[] parseArray(ref char[] array)
{
    
}

static int[] finalArray(int[] array)








