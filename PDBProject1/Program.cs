using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 – Sorting the matrix using a strategic pattern");
                Console.WriteLine("2 – Sending messages to a subscriber using the observer pattern");
                Console.WriteLine("3 - Exit");

                switch (char.ToLower(Console.ReadKey(true).KeyChar))
                {
                    case '1':
                        SortingMatrixWithStrategy();
                        break;
                    case '2':
                        CountdownWithObserver();
                        break;
                    case '3':
                        return;
                    default:
                        break;
                }
            }
        }

        static void SortingMatrixWithStrategy()
        {
            Matrix matrix = new Matrix(new BubleSort(), new MaxType(true));

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Matrix sorting using a strattegic pattern");
                Console.WriteLine("1 – Select the type of sorting");
                Console.WriteLine("2 – Sort the matrix");
                Console.WriteLine("3 - Back");

                switch (char.ToLower(Console.ReadKey(true).KeyChar))
                {
                    case '1':
                        ChoseType(ref matrix);
                        break;

                    case '2':
                        Console.Clear();
                        Console.WriteLine("BEFORE:");

                        matrix.Show();
                       
                        matrix.SortMatrix();

                        Console.WriteLine("AFTER:");

                        matrix.Show();

                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case '3':
                        return;

                    default:
                        break;
                }
            }

        }

        static void ChoseType(ref Matrix mat)
        {

            Console.Clear();
            Console.WriteLine("Select the sort type:");
            Console.WriteLine("1 – В порядке возрастания сумм элементов строк матрицы");
            Console.WriteLine("2 – В порядке убывания сумм элементов строк матрицы");
            Console.WriteLine("3 - По возрастанию максимального элемента в строке матрицы");
            Console.WriteLine("4 – По убыванию максимального элемента в строке матрицы");
            Console.WriteLine("5 - В порядке возрастания минимального элемента в строке матрицы");
            Console.WriteLine("6 – В порядке убывания минимального элемента в строке матрицы");
            Console.WriteLine("7 - Back");

            switch (char.ToLower(Console.ReadKey(true).KeyChar))
            {
                case '1':
                    mat.setType(new SumType(true));
                    break;
                case '2':
                    mat.setType(new SumType(false));
                    break;
                case '3':
                    mat.setType(new MaxType(true));
                    break;
                case '4':
                    mat.setType(new MaxType(false));
                    break;
                case '5':
                    mat.setType(new MinType(true));
                    break;
                case '6':
                    mat.setType(new MinType(false));
                    break;
                case '7':
                    return;
                default:
                    break;
            }
        }
        static void CountdownWithObserver()
        {
            int defaultDelay = 5;
            string message = "Aboba";

            Countdown cd = new Countdown();

            cd.Subscribe(new FirstSubscriber());
            cd.Subscribe(new SecondSubscriber());

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Observer");
                Console.WriteLine("1 – Set a message");
                Console.WriteLine("2 – Set a delay");
                Console.WriteLine("3 – Send a message to subscribers");
                Console.WriteLine("4 - Back");

                switch (char.ToLower(Console.ReadKey(true).KeyChar))
                {
                    case '1':
                        Console.Clear();
                        Console.Write("Enter your message message: ");
                        message = Console.ReadLine();
                        break;

                    case '2':
                        Console.Clear();
                        Console.Write("Set the delay time in seconds: ");
                        Int32.TryParse(Console.ReadLine(), out defaultDelay);
                        break;

                    case '3':
                        Console.Clear();
                        cd.SendMessagesWithDelay(message, defaultDelay);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;

                    case '4':
                        return;

                    default:
                        break;
                }
            }
        }
    }
}
