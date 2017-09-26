using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2labaOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            String liniya = "===============================================";
            Console.WriteLine(liniya);


            sbyte sbyteValue1 = 1;//От -128 до 127
            Console.WriteLine(sbyteValue1);

            int intValue1 = 10;
            Console.WriteLine(intValue1);

            byte byteValue1 = 201;//От 0 до 255
            Console.WriteLine(byteValue1);

            short shortValue1 = 1034;//          1034
            Console.WriteLine(shortValue1);

            short shortValue2 = 0x040A;//          1034
            Console.WriteLine(shortValue2);

            ushort ushortValue1 = 65034;//      65034
            Console.WriteLine(ushortValue1);

            ushort ushortValue2 = 0xFE0A;//     65034
            Console.WriteLine(ushortValue2);

            uint uintValue1 = 3000000000;//     3_000_000_000
            Console.WriteLine(uintValue1);

            uint uintValue2 = 0xB2D05E00;//     3_000_000_000
            Console.WriteLine(uintValue2);

            String liniya2 = "==============---------------=================";
            Console.WriteLine(liniya2);


            Console.WriteLine("Явное");


            double x = 1234.7;
            int a = (int)x;
            System.Console.WriteLine("было {0} стало {1}", x, a);

            ulong x2 = 1231231221;
            int a2 = (int)x2;
            System.Console.WriteLine("было {0} стало {1}", x2, a2);

            double x3 = 1234.7;
            long a1 = (long)x3;
            System.Console.WriteLine("было {0} стало {1}", x3, a1);
            Console.WriteLine(liniya2);


            Console.WriteLine("неявное");

            int num = 2147483647;
            double bigNum = num;
            System.Console.WriteLine("было {0} стало {1}", num, bigNum);

            int num1 = 2147483647;
            long bigNum1 = num1;
            System.Console.WriteLine("было {0} стало {1}", num, bigNum1);

            byte num2 = 214;
            int bigNum2 = num2;
            System.Console.WriteLine("было {0} стало {1}", num, bigNum2);
            Console.WriteLine(liniya2);

            Console.WriteLine("Упаковка");
            int w = 5;
            Object o = w; //Упаковкаx o ссылается на упакованный объект 
            byte m = (byte)(int)o;//распаковка, а затем приведение типа

            Console.WriteLine(liniya2);

            Console.WriteLine("неявно типизированная переменная");

            //var myList = new List<int>();
            //myList.Add(1);
            //myList.Add(2);
            //myList.Add(3);
            //foreach(var i in myList)
            //{ Console.WriteLine(i); }

            var arr = new[] { 2, 4, 5.6 };
            Console.Write(arr.GetType()); Console.WriteLine();

            Console.WriteLine(liniya2);


            Console.WriteLine("Nullable");
            Console.WriteLine("Проверка на равеносво объектов");

            int? z = null;
            int? z1 = null;
            int z2 = 2;

            Console.Write("Cравнение null и null  :");
            Console.WriteLine(z == z1);

            Console.Write("Cравнение null и 2  :");
            Console.WriteLine(z == z2);


            Console.WriteLine("Преобразование");

            if (z.HasValue)
            {
                int z3 = (int)z;// явное

            }

            Console.WriteLine("null объединение");

            int y = z ?? 1;// вывод на консоль


            Console.WriteLine("Второе задание");


            Console.WriteLine(liniya);

            // перенос строки \n
            Console.WriteLine(" yes\\no\n yes\\no");
            Console.WriteLine(" yes\\no \t yes\\no");
            Console.WriteLine(" yes\\nooooooo \t yes\\noooooo");
            Console.WriteLine("\"yes?\", - no");

            Console.WriteLine(liniya2);

            string one = "ONE qwe";
            string two = "TWO";
            string free = "FREE";
            Console.WriteLine("\nпервоя строка = '{0}'", one);
            Console.WriteLine("вторая строка = '{0}'", two);
            two = String.Copy(one);
            Console.WriteLine("two строка после копирования = '{0}'", two);
            Console.Write("слияние: ");
            Console.WriteLine(one + free);


            string four = "four";
            char four1 = four[2];
            Console.WriteLine("вторая буква(начиная с 0):{0}", four1);
            Console.WriteLine(liniya2);

            string pusto = "";
            string nulll = null;
            Console.WriteLine("Cдияние null и не пустой строкм: {0}", nulll + one);
            Console.WriteLine(one.Replace("ONE", pusto));//ЗАМЕНА

            Console.WriteLine(liniya2);

            StringBuilder five = new StringBuilder("FIVE", 20);
            five.Append(new char[] { 's', 's' });//добавление в конец два СИМВОЛА
            Console.WriteLine(five);
            five.Remove(1, 2);
            Console.WriteLine("Удаление 1-2 элемента: {0}", five);

            Console.WriteLine(liniya);

            Console.Write("X : ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Y : ");
            int y1 = int.Parse(Console.ReadLine());

            var rand = new Random();
            int[,] A = new int[x1, y1];
            for (int i = 0; i < x1; i++)
                for (int j = 0; j < y1; j++)
                    A[i, j] = rand.Next(-10, 10);

          
            for (int i = 0; i < x1; i++)
            {
                for (int j = 0; j < y1; j++)
                {  Console.Write("\t{0}",A[i, j]);}
                Console.WriteLine();
            }
            Console.WriteLine("Строковый массив: ");
            string[] number = new string[10] { "one", "two", "free", "four", "five", "six", "seven", "eight", "nine", "ten" };
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\t{0}",number[i]);
               
            }
            Console.WriteLine();
            Console.WriteLine("Длина массива :{0}", number.Length);

            Console.WriteLine("Замена элемента");
            Console.WriteLine("Введите позицию :");
            int numm = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите замену:");
            string zam = Console.ReadLine();
            number[numm] = zam;
            Console.WriteLine("Массив с заменой :");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\t{0}", number[i]);

            }
            Console.WriteLine();
            Console.WriteLine("\t ступенчатый массив\t");
            int[][] array = new int[3][];
            array[0]=new int[2];
            array[1] = new int[3];
            array[2] = new int[4];

            for (int i = 0; i < 2; i++ )
            {
                Console.WriteLine("Введите число: ");
                int n =  int.Parse(Console.ReadLine());
                  array[0][i] = n;
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите число: ");
                int n = int.Parse(Console.ReadLine());
                array[1][i] = n;
            }
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Введите число: ");
                int n = int.Parse(Console.ReadLine());
                array[2][i] = n;
            }
            Console.WriteLine("\tВывод массива\t");
            Console.WriteLine("{0} {1}", array[0][0], array[0][1]);
            Console.WriteLine("{0} {1} {2}", array[1][0], array[1][1], array[1][2]);
            Console.WriteLine("{0} {1} {2} {3}", array[2][0], array[2][1], array[2][2], array[2][3]);


            var array1 = new string[10] { "one", "two", "free", "four", "five", "six", "seven", "eight", "nine", "ten" };
            for(int i=0;i<array1.Length; i++)
            {
                Console.Write("\t{0}",array1[i]);
            }
            Console.WriteLine();
            Console.WriteLine(liniya);

         
                Console.Read();// задержка консоля

            }
        }
    }

