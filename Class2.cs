using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp4
{
    internal class Class2
    {






        //========================================

        //private static long factorial (int n) 
        //{
        //    long result = 1;

        //    if(n == 0 || n == 1)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        for (int i = 2; i <= n; i++)
        //        {
        //            result *= i;
        //        }
        //    }

        //    return result;

        //}

        //public static double rad(double x)
        //{
        //    return x * Math.PI / 180;
        //}

        //public static void cos(double x, int n)
        //{
        //    double cos = 0;
            
        //    for (int i = 0; i <= n; i++)
        //    {
        //        cos += (Math.Pow(-1, i) * Math.Pow(x, 2*i)) / factorial(2*i);
        //    }
            
        //    Console.WriteLine("Косинус: "+cos);
        //}

        //public static void hyperSin(double x, int n)
        //{
        //    double sh = 0;

        //    for(int i = 0;i <= n;i++)
        //    {
        //        sh += (Math.Pow(x, (2*i+1))) / factorial(2*i+1);
        //    }

        //    Console.WriteLine("Гиперболичейский синус: "+sh);
        //}

        //public static void hyperCos(double x, int n)
        //{
        //    double ch = 0;

        //    for (int i = 0; i <= n; i++)
        //    {
        //        ch += (Math.Pow(x, (2*i))) / factorial(2*i);
        //    }

        //    Console.WriteLine("Гиперболичейский косинус: "+ch);
        //}




        //====================================

        //public static void max(params int[] array)
        //{
        //    int max = -1;

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] > max)
        //        {
        //            max = array[i];
        //        }

        //    }

        //    Console.WriteLine("Максимальное значение: "+max);
        //}

        //public static void min(params int[] array)
        //{
        //    int min = 9999;

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] < min)
        //        {
        //            min = array[i];
        //        }

        //    }

        //    Console.WriteLine("Минимальное значение: "+min);
        //}

        //public static void average(params int[] array)
        //{
        //    int sum = 0;

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //       sum += array[i];

        //    }


        //    Console.WriteLine("Среднее значение: "+(sum / array.Length));
        //}



        //==============================

        //private static int num = 0;

        //private Class2() { }

        //public static void set()
        //{
        //    Console.WriteLine("Текущее значение num: "+num);
        //    num++;
        //    Console.WriteLine("Значение увеличено");
        //    Console.WriteLine();
        //}


        //===========================


        //private string str;
        //private char c;

        //public Class2()
        //{
        //    str = "NULL";
        //    c = 'N';
        //}

        //public void set(string str)
        //{
        //    this.str = str;
        //}

        //public void set(char c)
        //{
        //    this.c = c;
        //}

        //public void set(char[] array)
        //{
        //    if (array.Length == 1)
        //    {
        //        this.c = array[0];
        //    }
        //    else
        //    {
        //        foreach (char c in array)
        //        {
        //            str += c;
        //        }
        //    }


        //}

        //public void show(string objName)
        //{
        //    Console.WriteLine("Имя объекта: "+objName);

        //    Console.WriteLine("STR аргумент: "+str+"\nChar аргумент: "+c);
        //    Console.WriteLine();
        //}


        //=========================================

        //private int max, min;

        //public Class2()
        //{
        //    max = 1;
        //    min = -1;
        //}

        //public Class2(int first)
        //{
        //    if (max < min)
        //    {
        //        Console.WriteLine("Такого не может быть");
        //    }
        //    else
        //    {
        //        max = first > max ? first : max;
        //        min = first < min ? first : min;
        //    }
        //}

        //public Class2(int first, int second)
        //{
        //    if (max < min)
        //    {
        //        Console.WriteLine("Такого не может быть");
        //    }
        //    else
        //    {
        //        max = first > max ? first : max;
        //        max = second > max ? second : max;

        //        min = second < min ? second : min;
        //        min = first < min ? first : min;
        //    }
        //}


        //public void set(int first, int second)
        //{

        //    if(max < min)
        //    {
        //        Console.WriteLine("Такого не может быть");
        //    }
        //    else
        //    {
        //        max = first > max ? first : max;
        //        max = second > max ? second : max;

        //        min = second < min ? second : min;
        //        min = first < min ? first : min;
        //    }
        //}

        //public void set(int first)
        //{
        //    if (max < min)
        //    {
        //        Console.WriteLine("Такого не может быть");
        //    }
        //    else
        //    {
        //        max = first > max ? first : max;
        //        min = first < min ? first : min;
        //    }
        //}

        //public void show(string objName)
        //{
        //    Console.WriteLine("Имя объекта: "+objName);

        //    Console.WriteLine("Max аргумент: "+max+"\nMin аргумент: "+min);
        //    Console.WriteLine();    
        //}

        //=======================================================

        //private int num;

        //public Class2 ()
        //{
        //    this.num = 0;
        //}

        //public Class2 (int num)
        //{
        //    if (num < 100)
        //    {
        //        this.num = num;
        //    }else
        //    {
        //        this.num = 100;
        //    }
        //}


        //public void numSet()
        //{
        //    this.num = 0;
        //}

        //public void numSet(int num)
        //{
        //    if (num < 100)
        //    {
        //        this.num = num;
        //    }
        //    else
        //    {
        //        this.num = 100;
        //    }
        //}


        //public void displayNum()
        //{
        //    Console.WriteLine("Число: " + this.num);
        //}


        //===============================================

        //private int integerVar;
        //private char charVar;



        //public Class2(int integerVar, char charVar)
        //{
        //    this.integerVar=integerVar;
        //    this.charVar=charVar;

        //    Console.WriteLine(integerVar + " " + charVar);
        //}

        //public Class2(double multiVar)
        //{
        //    Console.WriteLine("Символ по переменной: " +(char)multiVar);

        //    Console.WriteLine("Дробная часть числа: " + (int)100*Math.Round((multiVar-Math.Floor(multiVar)), 2));
        //}












        //==================================================

        //private int first;
        //private int second;


        //public Class2()
        //{
        //    Console.WriteLine("Все переменные пустые :( ");

        //}

        //public Class2(int first)
        //{
        //    this.first = first;
        //    Console.WriteLine("Одна перменная: "+ this.first);
        //}

        //public Class2(int first, int second)
        //{
        //    this.first = first;
        //    this.second=second;

        //    Console.WriteLine("Две переменные \n1: " + this.first + "\n" + "2: " + this.second);
        //}




        //==============================================


        //private char charFirst;
        //private char charFinish;

        //public Class2(char charFirst, char charFinish)
        //{
        //    this.charFirst=charFirst;
        //    this.charFinish=charFinish;
        //}

        //public void charSubsequence()
        //{
        //    for(char i = this.charFirst;  i <= this.charFinish; i++)
        //    {
        //        Console.Write("|| " + i + " ||");
        //    }

        //}






        //===========================================

        //private char charA;


        //public Class2()
        //{
        //    this.charA= 'A';
        //    Console.WriteLine("Задано значение по умолчанию А");
        //}

        //public void equating(char charA)
        //{
        //    this.charA = charA;
        //    Console.WriteLine("Задано новое значение: "+this.charA);
        //}

        //public void charId()
        //{
        //    Console.WriteLine((int)charA);
        //}

        //public void charName()
        //{
        //    Console.WriteLine("Значение: "+charA);
        //}


        //===========================================



        //private int i;
        //private int j;

        //public Class2(int i)
        //{
        //    this.i = i;
        //    Console.WriteLine("Вы ввели один аргумент " + this.i);
        //}

        //public Class2 ( int i, int j) : this (i)
        //{
        //    this.j = j;
        //    Console.WriteLine("Вы ввели два аргумента " + this.j);
        //}


        //======================================


        //private int number;

        //public string name;

        //public void show()
        //{
        //    Console.WriteLine("Ваше число: " + number);
        //    Console.WriteLine("Ваше имя: " + name);
        //}

    }
}
