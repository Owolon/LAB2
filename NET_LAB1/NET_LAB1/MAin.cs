using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace NET_LAB1
{
    class File
    {
        static void Main()
        {
            int choice;

            while (true)
            {
                Console.WriteLine("\nВыберите задание:");
                Console.WriteLine("1. Задание 1.Функция");
                Console.WriteLine("2. Задание 2.Площадь и периметр треугольника");
                Console.WriteLine("3. Задание 3.Сортировка введённых чисел в убывание и нахождение max");
                Console.WriteLine("4. Задание 4.День недели");
                Console.WriteLine("5. Задание 5.Структура Auto");
                Console.WriteLine("0. Выход");
                Console.Write("Ваш выбор: ");

                if (ValidateInput<int>(Console.ReadLine(), out choice) == 0)
                {
                    Console.WriteLine("Ошибка! Введите число от 0 до 4.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        int number;
                        string input, input2, input3;
                        Console.WriteLine("Задание 1");
                        do
                        {
                            Console.WriteLine("Введите число первое:");
                            input = Console.ReadLine();
                        } while (ValidateInput<int>(input, out number) == 0);
                        Console.WriteLine("Введена переменная: " + input, "\n");
                        do
                        {
                            Console.WriteLine("Введите число второе:");
                            input2 = Console.ReadLine();
                        } while (ValidateInput<int>(input2, out number) == 0);
                        Console.WriteLine("Введена переменная: " + input2, "\n");
                        do
                        {
                            Console.WriteLine("Введите число третье:");
                            input3 = Console.ReadLine();
                        } while (ValidateInput<int>(input3, out number) == 0);
                        Console.WriteLine("Введена переменная: " + input3, "\n");

                        double inputDouble = Convert.ToDouble(input);
                        double input2Double = Convert.ToDouble(input2);
                        double input3Double = Convert.ToDouble(input3);

                        double a = 2 * Math.Pow(Math.Cos(inputDouble - (Math.PI / 6)), 4) / ((1 / 2) + Math.Pow(Math.Sin(input2Double), 2));
                        double b = 1 + Math.Pow(input3Double, 2) / (3 + (Math.Pow(input3Double, 2) / 5));
                        Console.WriteLine("Результат {0}, {1}", a, b);
                        break;
                    case 2:
                        Console.WriteLine("Задание 2");
                        Console.Write("Введите количество элементов массива (i)(j): ");
                        int n, m;

                        while (ValidateInput<int>(Console.ReadLine(), out n) == 0 || n <= 0)
                        {
                            Console.Write("Ошибка! Введите положительное число (i): ");
                        }
                        while (ValidateInput<int>(Console.ReadLine(), out m) == 0 || m <= 0)
                        {
                            Console.Write("Ошибка! Введите положительное число (j): ");
                        }

                        double[,] arr_point = new double[n, m];
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"Введите вершины x{i + 1}, y{i + 1}: ");
                            for (int j = 0; j < m; j++)
                            {
                                while (ValidateInput<double>(Console.ReadLine(), out arr_point[i, j]) == 0)
                                {
                                    Console.Write("Ошибка! Введите корректное число: ");
                                }
                            }
                        }

                        Console.WriteLine("Введенный массив:");
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                                Console.Write(arr_point[i, j].ToString(CultureInfo.InvariantCulture) + " ");
                            Console.WriteLine();
                        }

                        double areaCoord = Math.Abs((arr_point[0, 0] * (arr_point[1, 1] - arr_point[2, 1]) + arr_point[1, 0] * (arr_point[2, 1] - arr_point[0, 1]) + arr_point[2, 0] * (arr_point[0, 1] - arr_point[1, 1])) / 2.0);
                        double AB = Math.Sqrt(Math.Pow(arr_point[1, 0] - arr_point[0, 0], 2) + Math.Pow(arr_point[1, 1] - arr_point[0, 1], 2));
                        double BC = Math.Sqrt(Math.Pow(arr_point[2, 0] - arr_point[1, 0], 2) + Math.Pow(arr_point[2, 1] - arr_point[1, 1], 2));
                        double CA = Math.Sqrt(Math.Pow(arr_point[0, 0] - arr_point[2, 0], 2) + Math.Pow(arr_point[0, 1] - arr_point[2, 1], 2));
                        double perimeter = areaCoord != 0 ? AB + BC + CA : 0;
                        Console.WriteLine("Площадь треугольника > {0} Периметр треугольника > {1}", areaCoord, perimeter);
                        break;
                    case 3:
                        Console.WriteLine("Задание 3");

                        Console.WriteLine("Введите рандомные числа N (до 3)> ");
                        double[] numb = new double[3];
                        for (int i = 0; i < 3; i++)
                        {
                            while (ValidateInput<double>(Console.ReadLine(), out numb[i]) == 0)
                                Console.Write("Ошибка! Введите корректное число: ");
                        }
                        double max = 0;
                        for (int i = 0; i < 3; i++)
                        {
                            if (numb[i] > max)
                            {
                                max = numb[i];
                            }
                        }

                        Console.WriteLine("Максимальное значение > " + max);

                        for (int i = 1; i < 3; i++)
                        {
                            for (int j = 0; j < 3 - i; j++)
                            {
                                if (numb[j] < numb[j + 1])
                                {
                                    double temp = numb[j];
                                    numb[j] = numb[j + 1];
                                    numb[j + 1] = temp;
                                }
                            }
                        }

                        Console.WriteLine("Масив отсортированный в убывание \\/");
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 1; j++)
                            {
                                Console.Write(numb[i].ToString(CultureInfo.InvariantCulture) + " ");
                            }
                            Console.WriteLine(" ");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Задание 4 \nВведите число дня недели (1-7)");
                        int Day;
                        while (ValidateInput<int>(Console.ReadLine(), out Day) == 0 || Day < 1 || Day > 7)
                            Console.Write("Ошибка! Введите число от 1 до 7: ");

                        switch (Day)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Понедельник - рабочий день");
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("Вторник - рабочий день");
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine("Среда - рабочий день");
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("Четверг - рабочий день");
                                    break;
                                }
                            case 5:
                                {
                                    Console.WriteLine("Пятница - рабочий день");
                                    break;
                                }
                            case 6:
                                {
                                    Console.WriteLine("Суббота - выходной день");
                                    break;
                                }
                            case 7:
                                {
                                    Console.WriteLine("Воскресенье - выходной день");
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Не верный ввод.");
                                    break;
                                }
                        }
                        break;
                    case 5:
                        Auto one = new Auto();
                        one.Get();
                        one.Print();
                        break;
                    case 0:
                        Console.WriteLine("Выход из программы...");
                        return;
                    default:
                        Console.WriteLine("Ошибка! Выберите номер от 0 до 4.");
                        break;
                }
            }
        }

        static int ValidateInput<T>(string input, out T result)
        {
            try
            {
                result = (T)Convert.ChangeType(input, typeof(T));
                return 1;
            }
            catch
            {
                result = default(T);
                return 0;
            }
        }

        struct Auto
        {
            public string model;
            public double weigth;
            public void Get()
            {
                Console.WriteLine("Введите модель автомобиля : ");
                model = Console.ReadLine();
                Console.WriteLine("Введите вес автомобиля : ");
                while (ValidateInput<double>(Console.ReadLine(), out weigth) == 0 || weigth <= 0)
                {
                    Console.Write("Ошибка! Введите положительное число: ");
                }
            }
            public void Print()
            {
                Console.WriteLine($"Модель : {model}, Вес : {weigth}");
            }
        }

    }
}
