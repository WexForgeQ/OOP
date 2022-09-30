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
                }
            }
        }