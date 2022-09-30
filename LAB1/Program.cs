using System;
using System.Text;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            //Объявления типов
            Console.WriteLine("Enter bool");
            bool b = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(b);
            Console.WriteLine("Enter byte");
            byte bt = Convert.ToByte(Console.ReadLine());
            Console.WriteLine(bt);
            Console.WriteLine("Enter sbyte");
            sbyte sb = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine(sb);
            Console.WriteLine("Enter char");
            char ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(ch);
            Console.WriteLine("Enter double");
            double db = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(db);
            Console.WriteLine("Enter float");
            float f = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(f);
            Console.WriteLine("Enter int");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(i);
            Console.WriteLine("Enter uint");
            uint ui = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine(ui);
            Console.WriteLine("Enter long");
            long l = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(l);
            Console.WriteLine("Enter ulong");
            ulong ul = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine(ul);
            Console.WriteLine("Enter short");
            short sh = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(sh);
            Console.WriteLine("Enter ushort");
            ushort ush = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine(ush);


            //Операции приведения
            l = i;
            i = (int)l;
            i = sh;
            sh = (short)i;
            l = sh;
            sh = (short)l;
            ul = ui;
            ui = (uint)ul;
            ui = ush;
            ush = (ushort)ui;

            //Упаковка значимых типов
            object o1, o2, o3, o4, o5, o6, o7, o8, o9, o10, o11, o12;
            o1 = b;
            o2 = bt;
            o3 = sb;
            o4 = ch;
            o5 = db;
            o6 = f;
            o7 = i;
            o8 = ui;
            o9 = l;
            o10 = ul;
            o11 = sh;
            o12 = ush;
            //Распаковка значимых типов
            bool unpb = (bool)o1;
            byte unpbt = (byte)o2;
            sbyte unpsb = (sbyte)o3;
            char unpch = (char)o4;
            double unpdb = (double)o5;
            float unpfl = (float)o6;
            int unpi = (int)o7;
            uint unpui = (uint)o8;
            long unpl = (long)o9;
            ulong unplong = (ulong)o10;
            short unpsh = (short)o11; 
            ushort unpush = (ushort)o12;  
             *//*

            //Неявно типизированная переменная
            var tpvi = 10;
            Console.WriteLine($"Неявно типиизрованная переменная(int):{tpvi}");
            var tpvch = 'H';
            Console.WriteLine($"Неявно типиизрованная переменная(char):{tpvch}");

            //Nullable переменная
            int? nlb = null;
            Console.WriteLine($"Null-переменная(null):{nlb}");
            nlb = 123;
            Console.WriteLine($"Null-переменная(int):{nlb}");

              //Строковые литералы
            string cmp1 = "A";
            string cmp2 = "B";

            int result = string.Compare(cmp1, cmp2);
            if (result > 0)
            {
                Console.WriteLine("Строка 1 больше строки 2");
            }
            else if (result < 0)
            {
                Console.WriteLine("Строка 2 больше строки 1");
            }
            else
            {
                Console.WriteLine("Строки равны");
            }

            //Работа над string
            string s1, s2, s3;
            s1 = "hello";
            s2 = "world";
            s3 = "bye";
            string coll = s1 + ' ' + s2;
            Console.WriteLine($"Сцепление строк:{coll}");
            string substr = coll.Substring(0, coll.IndexOf(" "));
            Console.WriteLine($"Подстрока:{substr}");
            string [] words = coll.Split(' ');
            foreach (string s in words)
            {
                Console.WriteLine($"Слово:{s}");
            }
            string insert = coll.Insert(coll.IndexOf(' ') + 1, s3 + ' ');
            Console.WriteLine($"Cтрока:{insert}");
            string remove = insert.Remove(insert.IndexOf(' '), insert.IndexOf(' ')-1);
            Console.WriteLine($"Cтрока после удаления:{remove}");
            //Null - строка
            string snull = null;
            bool test = String.IsNullOrEmpty(snull);
            Console.WriteLine(test);
            snull = "A";
            test = String.IsNullOrEmpty(snull);
            Console.WriteLine(test);

            //SB
            StringBuilder sb = new StringBuilder("Привет мир");
            sb.Remove(1, 1);
            sb.Remove(3,1);
            sb.Insert(1, 'A');
            sb.AppendFormat("A");
            Console.WriteLine(sb);
            */
            /*//Массивы
            int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 } };

            int rows = numbers.GetUpperBound(0) + 1;    // количество строк
            int columns = numbers.Length / rows;        // количество столбцов
                                                       
                                                       

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{numbers[i, j]} ");
                }
                Console.WriteLine();
            }


           *//* //Массив строк
            string [] strar = { "bababa", "nananan", "lalalala" };
            Console.WriteLine("Cодержимое массива: ");
            foreach (string s in strar)
                Console.WriteLine(s);
            Console.WriteLine($"Длинна массива строк: {strar.Length}");
            Console.WriteLine("Введите элемент на замену: ");
            int numb = (Convert.ToInt32(Console.ReadLine()));
            for(int k=0; k<strar.Length; k++)
            {
                if(k==numb-1)
                {
                    Console.WriteLine("Введите замену элемента: ");
                    strar[k] = Convert.ToString(Console.ReadLine());
                }
            }
            Console.WriteLine("Cодержимое массива после замены: ");
            foreach (string s in strar)
                Console.WriteLine(s);
            //ступенчатый массив
            int [][] stup = new int[3][];
            stup[0] = new int[2];
            stup[1] = new int[3];
            stup[2] = new int[4];
            for(int i = 0; i<2; i++)
            {
                Console.WriteLine("Введите " + (i+1) + " элемент первой строки");
                stup[0][i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите " + (i + 1) + " элемент второй строки");
                stup[1][i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Введите " + (i + 1) + " элемент третьей строки");
                stup[2][i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Ступенчатый массив:");
            for (int i = 0; i < 2; i++)
            {
                Console.Write(stup[0][i]+ " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Write(stup[1][i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Console.Write(stup[2][i] + " ");
            }
            Console.WriteLine();
            //Неявные массивы
            var ntarr  = new[] { 1, 2, 3 };
            var ntstr = new[] { "1", "rt" };*/

             /*  //Кортежи
              (int, string, char, string, ulong) t = (1, "rr", '1', "yy", 4294967293);
              Console.WriteLine("Кортеж:");
              Console.Write(t);
              Console.WriteLine();
              Console.WriteLine("Первый элемент кортежа: " + t.Item1);
              Console.WriteLine("Второй элемент кортежа: " + t.Item2);
              (int num1, int num2) t2 = (1, 2);
              (int, int) t3 = (1, 3);
              bool rez = t2==t3;
              Console.WriteLine(rez);
              //Распаковка кортежа
              int unb1 = t2.num2;
              int unb2 = t3.Item1;
              Console.WriteLine("Распакованные переменные кортежа: " + unb1 + " " + unb2);
              Console.WriteLine("Кортеж с неназначенной переменной: ");
              (int? _, int) nlv = (null, 1);
              Console.WriteLine(nlv);*/

               /*//Локальная функция
            string s = "Tuple";
            var tuple = LocalFunc(new int[] { 10, 11, 24, 43, 2 }, s);
            static (int max , int min, int sum, char flt) LocalFunc(int [] arr, string s)
            {
                int max = -2147483648;
                int min = 2147483647;
                int sum = 0;
                for(int i=0; i<5;i++)
                {
                    if(arr[i]>max)
                    {
                        max = arr[i];
                    }
                    if(arr[i]<min)
                    {
                        min = arr[i];
                    }
                    sum = sum + arr[i];
                }
                char flt = s[0];
                var tuple = (max, min, sum, flt);
                return tuple;
            }
            Console.WriteLine("Кортеж: "+tuple);*/
              /*//Checked & unchecked
            static void Local1()
            {
                try
                {
                    checked
                    {
                        int num = int.MaxValue;
                        Console.WriteLine(num+1);
                    }
                }
                catch(OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
               
            }
            static void Local2()
            {
                try
                {
                    unchecked
                    {
                        int num = int.MaxValue;
                        Console.WriteLine(num+1);
                    }
                }
                catch(OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
            Local1();//При использовании checked выдаётся ошибка переподнения при unchecked мы пропускаем ошибку и все биты выского порядка обнунляются
            Local2();*/
                }
            }
        }