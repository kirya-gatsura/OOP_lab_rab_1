using System.ComponentModel.DataAnnotations;
using System.Net.Cache;
using System.Text; //работа с StringBuilder

class Program
{
    static void Main()
    {
        {
            bool parm1 = bool.Parse(Console.ReadLine()); // true - false
            Console.WriteLine("\nbool\t parm1 = " + parm1);
            byte parm2 = 42; // 0 - 255
            Console.WriteLine("byte\t parm2 = " + parm2);
            sbyte parm3 = 42; // -128 - 127
            Console.WriteLine("sbyte\t parm3 = " + parm3);
            char parm4 = 'A';
            Console.WriteLine("char\t parm4 = " + parm4);
            short parm5 = 4200;
            Console.WriteLine("short\t parm5 = " + parm5);
            ushort parm6 = 42000;
            Console.WriteLine("ushort\t parm6 = " + parm6);
            int parm7 = int.MaxValue;
            Console.WriteLine("int\t parm7 = " + parm7);
            uint parm8 = uint.MaxValue;
            Console.WriteLine("uint\t parm8 = " + parm8);
            long parm9 = long.MaxValue;
            Console.WriteLine("long\t parm9 = " + parm9);
            ulong parm10 = ulong.MaxValue;
            Console.WriteLine("ulong\t parm10 = " + parm10);
            nint parm11 = nint.MaxValue; // nint, nuint - целые числа, размер которых зависит от разрядности платформы
            Console.WriteLine("nint\t parm11 = " + parm11);
            nuint parm12 = nuint.MaxValue;
            Console.WriteLine("nuint\t parm12 = " + parm12);
            float parm13 = 42.42F; // нужен суффикс F
            Console.WriteLine("float\t parm13 = " + parm13);
            double parm14 = 1.23456789101112131415161718;
            Console.WriteLine("double\t parm14 = " + parm14);
            decimal parm15 = 1.1M; // нужен суффикс M
            Console.WriteLine("decimal\t parm15 = " + parm15);
        }// 1.a
        {
            int tempInt = int.Parse("42");

            char tempChar = (char)tempInt;

            tempInt = Convert.ToInt32("123");

            long tempLong = Convert.ToInt64(null);

            bool tempBool = Convert.ToBoolean(0);
            //-----------------------------------------------------
            tempInt = 10;
            tempLong = tempInt;

            tempChar = 'A';
            tempInt = tempChar;

            float tempFloat = 42.42F;
            double tempDouble = tempFloat;

            tempInt = 150000;
            decimal tempDecimal = tempInt;

            string tempString = "" + tempInt;
        }// 1.b
        {
            int dataI = 20;
            object boxedData = dataI; // неявно
            int unboxedDataI = (int)boxedData; // явно

            char dataC = 'A';
            boxedData = dataC;
            char unboxedDataC = (char)boxedData;
        }// 1.c
        {   //нельзя использовать для полей классов
            var parm1 = 10;
            var parm2 = 'A';
            var parm3 = 1.111;

            double result = (parm1 + parm2) * parm3;
        }// 1.d
        {
            int? flewToMarsCount = null;
            string? great_great_grandsonName = null;
            long? girlfrendCount = null;

            int result = flewToMarsCount ?? 0; // если flewToMarsCount == null, верни 0
        }// 1.e
        {   // тип закрепляется за переменной в момент инициализации и
            // в дальнейшем считается строгим (без инициализации = ошибка)
            var age = 25;
            //age = "двадцать пять";
        }// 1.f

        {
            string str1 = "Кот", str2 = "Собака";
            if (str1 == str2)
                Console.WriteLine("\nСтроки равны\n");
            else
            {
                Console.WriteLine("\nСтроки различны\n");
            }
        }// 2.a
        {
            string sentence1 = "Я очень люблю кушац пельмени!",
                   sentence2 = "А ты любишь?",
                   sentence3 = " нуууу, как тебе сказать...";

            string concat = sentence1 + " Я их просто обожаю! " + sentence2;    // конкатенация (сцепление)
            string copy = sentence3;                                            // копирование
            string substr = sentence3.Substring(8, 3);                          // подстрока
            string[] strsplit = sentence1.Split(' ');                           // разделение на слова
            string strinsert = sentence3.Insert(0, "Пу-пу-пу...");              // вставка подстроки
            string strremove = sentence1.Remove(2, 6);                          // удаление подстроки

            int a = 6; char b = 'A';
            string interpol = $"В крике \"AAAAAA!!!\" {a} букв {b} :D";

            Console.WriteLine(concat + "\n" +
                              copy + "\n" +
                              substr + "\n" +
                              strsplit[2] + "\n" +
                              strinsert + "\n" +
                              strremove + "\n" +
                              interpol + "\n");
        }// 2.b
        {
            string emptystr = "", nullstr = null;

            Console.WriteLine(string.IsNullOrEmpty(emptystr));  //True
            Console.WriteLine(string.IsNullOrEmpty(nullstr));   //True
            Console.WriteLine(string.IsNullOrEmpty("Привет"));  //False

            Console.WriteLine(emptystr == nullstr); //не одно и то же
            Console.WriteLine(emptystr + nullstr + "БГТУ <3\n"); //корректно складываются
            int? nullLen = nullstr?.Length; //nullLen будет равен null и не выдаст ошибку
        }// 2.c
        {
            StringBuilder sb = new StringBuilder("Изучаем язык С# - день 42.");
            Console.WriteLine(sb);

            sb.Remove(8, 5);
            Console.WriteLine(sb);

            sb.Insert(8, "ГЕНИАЛЬНЫЙ ЯЗЫЧИЩЕ");
            Console.WriteLine(sb + "\n");

            string str = sb.ToString();
        }// 2.d

        {
            int[,] matrix3x3 = {
                        {1, 2, 3},
                        {4, 5, 6},
                        {7, 8, 9}};

            for (int i = 0; i < matrix3x3.GetLength(0); i++)
            {
                for (int j = 0; j < matrix3x3.GetLength(1); j++)
                {
                    Console.Write(matrix3x3[i, j] + " ");
                }
                Console.WriteLine();
            }
        }// 3.a
        {
            string[] words = new string[] { "Очень", "Люблю", "Программировать" };
            Console.WriteLine("\nВведите позицию заменяемого элемента...");
            int pos = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("\nВведите слово, на которое вы хотите заменить...");
            string word = Console.ReadLine();

            words[pos] = word;

            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }// 3.b
        {
            int[][] mass = new int[][] {
                        new int[2],
                        new int[3],
                        new int[4]};

            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass[i].Length; j++)
                {
                    Console.Write($"Введите значение для элемента [{i}][{j}]: ");
                    mass[i][j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
        }// 3.c
        {
            var ints = new[] { 1, 2, 3, 4, 5 }; // ints хранит указатель int* на массив
            var str = "Absolute Cinema";
        }// 3.d

        {
            (int numb, string str1, char symb, string str2, ulong bigNumb) tuple1 = (10, "string", 'F', "another one", 4242424242);

            Console.WriteLine(tuple1);
            Console.WriteLine($"{tuple1.numb}, {tuple1.symb}, {tuple1.str2}");

            (int numb1, string str11, char symb1, string str21, ulong bigNumb1) = tuple1;
            var (Num, Str1, Symb, Str2, BigNumb) = tuple1;

            var (Num1, _, _, Str21, _) = tuple1;
        }// 4.a + 4.b + 4.c

        {
            int[] ints1 = { 1, 2, 3, 4, 5 };
            string str1 = "Привет";

            (int Min, int Max, int Sum, char Symb) Turple(int[] ints1, string str1)
            {
                int Min = ints1.Min();
                int Max = ints1.Max();
                int Sum = ints1.Sum();
                char Symb = str1[0];

                return (Min, Max, Sum, Symb);
            }

            (int Min, int Max, int Sum, char Symb) tuple = Turple(ints1, str1);
        }// 5

        {
            int Sum1(int a, int b)
            {
                int c = unchecked(a + b);
                return c;
            }

            int Sum2(int a, int b)
            {
                int c = checked(a + b);
                return c;
            }

            int result;
            result = Sum1(int.MaxValue, 3);

            try
            {
                result = Sum2(int.MaxValue, 3);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }

        }// 6.a
    }
}
