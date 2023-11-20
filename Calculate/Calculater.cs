using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculate.Exeptions;
using Calculate.Interfaces;

namespace Calculate.Interfaces
{
    public class Calculater : IStarter, IClose, IInputData, IChoiceCommand, ICalculate 
    {
        DoubleTryParse doubleTryPars = new DoubleTryParse();
        List<string> commands = new List<string>();

        delegate void Message(string message);
        static void showMessage(string message)
        {
            Console.WriteLine(message);
        }
        static void showListOfComands(string numComand)
        {
            Console.Write(numComand);
        }
        
        public void start()
        {
            Console.WriteLine();
            commands.Add("sum");
            commands.Add("sub");
            commands.Add("mult");
            commands.Add("div");
            commands.Add("cancel");

            while (true)
            {
                ShowComands();
                var res = choiceCommand();
                showResult(res);
            }
        }
        public static void ShowComands()
        {
            Message? mess = showMessage;
            mess.Invoke("Выберите действие\nВведите соответствующую команду:");

            List<string> listComands = new List<string> { "    /sum - Сложение", "    /sub - Вычитание", "    /mult - Умножение", "    /div - Деление", "    /cancel - Отмена" };
            listComands.ForEach(new Action<string>(showListOfComands));
            Console.WriteLine();
        }

        public void close()
        {
            Console.WriteLine("Выход");
            Environment.Exit(0);
        }

        public double calculateDiv(double num1, double num2)
        {
            try
            {
                if (num2 == 0)
                {
                    throw new DivisionByZeroException("Деление на 0 невозможно");
                }
                return num1 / num2;
            }
            catch (DivisionByZeroException ex) 
            {
                Console.WriteLine(ex);
                return 0;
            }
            
        }

        public double calculateMult(double num1, double num2)
        {
            return num1 * num2;
        }

        public double calculateSub(double num1, double num2)
        {
            return num1 - num2;
        }

        public double calculateSum(double num1, double num2)
        {
            return num1 + num2;
        }

        public double inputData()
        {
            double number = doubleTryPars.doubleTryParse(Console.ReadLine());
            return number;
        }

        public double choiceCommand()
        {
            string command = Console.ReadLine();

            if (commands.Contains(command))
            {
                if (command == "cancel")
                {
                    close();
                    return 0;
                }
                Console.WriteLine("Введите данные");

                double num1 = inputData();
                double num2 = inputData();

                if (command.Contains("sum"))
                {
                    return calculateSum(num1, num2);
                }
                if (command == "sub")
                {
                    return calculateSub(num1, num2);
                }
                if (command == "mult")
                {
                    return calculateMult(num1, num2);
                }
                if (command == "div")
                {
                    return calculateDiv(num1, num2);
                }
                else { return 0; }
            }
            else
            {
                throw new NoFindCommandException("Команда не найдена");
            }
        }
           
    
        public void showResult(double res)
        {
            Console.Write($"Результат = {res}\n");
        }
    }
}
