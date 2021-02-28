using System;
using System.Net.Http.Headers;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringsFactory factory = new StringsFactory();

            HexString hex =(HexString) factory.GetStrings(StringsFactory.StringTypes.HEXSTRING,"-1");
            HexString hex1 = (HexString)factory.GetStrings(StringsFactory.StringTypes.HEXSTRING, "1a");
            SymbString symb = (SymbString)factory.GetStrings(StringsFactory.StringTypes.SYMBSTRING, "sasddsad");
            SymbString symb1 = (SymbString)factory.GetStrings(StringsFactory.StringTypes.SYMBSTRING, "aeqwed");
            Console.WriteLine("Шестнадцетиричная строка класса HexString 1 ");
            hex.showString();
            Console.WriteLine("Двоичный вид");
            hex.showBin();
            Console.WriteLine("Восмеричный вид");
            hex.showOct();
            Console.WriteLine("Десятичный вид");
            hex.showDec();
            Console.WriteLine("Шестнадцатиричный вид");
            hex.showHex();
            Console.WriteLine("Шестнадцетиричная строка класса HexString 2 ");
            hex1.showString();
            Console.WriteLine("Двоичный вид");
            hex1.showBin();
            Console.WriteLine("Восмеричный вид");
            hex1.showOct();
            Console.WriteLine("Десятичный вид");
            hex1.showDec();
            Console.WriteLine("Шестнадцатиричный вид");
            hex1.showHex();
            Console.WriteLine("Оператор + для Элементов hex1 и hex2");
            Console.WriteLine(hex + hex1);
            Console.WriteLine("Символьная строка класса SymbString 1");
            symb.showString();
            Console.WriteLine("Символьная строка класса SymbString 2");
            symb1.showString();
            Console.WriteLine("Оператор + для Элементов Symb1 и Symb2");
            Console.WriteLine(symb + symb1);
            
            Console.WriteLine("Hello World!");
        }
    }
}
