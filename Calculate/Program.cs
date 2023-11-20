using Calculate.Interfaces;
using Microsoft.Win32.SafeHandles;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.SymbolStore;
using System.Security.Cryptography.X509Certificates;

namespace Calculate
{
    internal class Program
    {
        delegate void Message(string message);
        delegate string Choice();
        delegate double InputNum();

        public static void Main(string[] args)
        {
            Calculater calculater = new Calculater();
            calculater.start();
        }


        /*
        
        static void showMessage(string message)
        {
            Console.WriteLine(message);
        }

        static string inputChoice()
        { return Console.ReadLine(); }

        static void showListOfComands(string numComand)
        {
            Console.Write(numComand);
        }

        static double inputNum()
        {
            string num = Console.ReadLine();
            try
            {
                return Convert.ToDouble(num);
            }
            catch
            {
                Console.WriteLine("Некорректно введенное число");
                return inputNum();
            }
        }

        public static void Main(string[] args)
        {
            bool work;
            while (work = true) 
            {
                ShowComands();
                work = MakeChoice(work);
            }

        }

        public static void ShowComands()
        {
            Message? mess = showMessage;
            mess.Invoke("Выберите действие\nВведите соответствующую команду:");

            List<string> listComands = new List<string> {"    /sum - Сложение", "    /sub - Вычитание", "    /mult - Умножение", "    /div - Деление", "    /cancel - Отмена"};
            listComands.ForEach(new Action<string>(showListOfComands));
            Console.WriteLine();
        }

        public static bool MakeChoice(bool work)
        {
            Choice choice = new Choice(inputChoice);

            string deistvie = choice();

            if(deistvie == "sum")
            {
                Console.WriteLine($"Результат = {sum()}");
                return true;
            }
            if(deistvie == "sub")
            {
                Console.WriteLine($"Результат = {sub()}");
                return true; 
            }
            if(deistvie == "mult")
            {
                Console.WriteLine($"Результат = {mult()}");
                return true;
            }
            if(deistvie == "div")
            {   
                Console.WriteLine($"Результат = {div()}");
                return true;
            }
            if (deistvie == "cancel" || deistvie == ""|| deistvie == " ")
            {
                Console.WriteLine("Выход");
                Environment.Exit(0);

            }
            if (deistvie != "sum" && deistvie != "sub" && deistvie != "mult" && deistvie != "div" && deistvie != "cancel" && deistvie != "" && deistvie != " ")
        {
Console.WriteLine($"Неизвестная команда");
}
return false;
}

public static double sum()
{
InputNum num1 = new InputNum(inputNum);
InputNum num2 = new InputNum(inputNum);
double n1 = num1();
Console.Write($"{n1 } + ");
double n2 = num2();
return n1 + n2;
}

public static double sub()
{
InputNum num1 = new InputNum(inputNum);
InputNum num2 = new InputNum(inputNum);
double n1 = num1();
Console.Write($"{n1} - ");
double n2 = num2();
return n1 - n2;
}

public static double mult()
{
InputNum num1 = new InputNum(inputNum);
InputNum num2 = new InputNum(inputNum);
double n1 = num1();
Console.Write($"{n1} * ");
double n2 = num2();
return n1 * n2;
}
public static double div()
{
InputNum num1 = new InputNum(inputNum);
InputNum num2 = new InputNum(inputNum);
double n1 = num1();
Console.Write($"{n1} / ");
double n2 = num2();
return n1 / n2;
}*/
    }
}
