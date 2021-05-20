using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1_4_3_Operations_with_matrices
{
    class Program
    {
        static void Main(string[] args)
        {

           Random randy = new Random(); // Pандомайзер

           while (true)
           {
                byte mWidth = 1;
                byte mHeight = 1;
                byte mWidth_2 = 1;
                byte mHeight_2 = 1;
                byte factor = 1;

                int buf;
                byte input;
                byte choise;
                byte exit;

                #region Выбор режима работы

                Write("Какое действие нужно провести с матрицами?" +
                    "\n(1 - Умножение на число; 2 - Сложение; 3 - Вычитание; 4 - Перемножение)" +
                    "\nВыбор: ");

                while (true) // Ввод числа и его проверка
                {
                    // Проверка введенного значения на его соответствие текущим требованиям
                    // (Кароч чтобы число не вылезло за пределы возможностей переменной и нужных нам условий)
                    if (byte.TryParse(ReadLine(), out choise) && choise <= 4 && choise > 0) break;
                    else Write("Кол-во строк должно быть целым числом от 1 до 4, попробуйте еще раз: ");
                }
                WriteLine();

                #endregion

                if (choise == 1)
                {

                    WriteLine("___Умножение матрицы на число___\n");

                    #region Задание размеров матрицы и множителя

                    for (byte count = 1; count <= 3; count++)
                    {
                        switch (count)
                        {
                            case 1:
                                Write("Введите кол-во столбцов первой матрицы ");
                                break;
                            case 2:
                                Write("Введите кол-во строк первой матрицы ");
                                break;
                            case 3:
                                Write("Введите множитель ");
                                break;
                        }

                        while (true) // Ввод числа и его проверка
                        {
                            // Проверка введенного значения на его соответствие текущим требованиям
                            // (Кароч чтобы число не вылезло за пределы возможностей переменной и нужных нам условий)
                            if (byte.TryParse(ReadLine(), out input) && input <= 50 && input > 0) break;
                            else Write("Число должно быть целым от 1 до 50, попробуйте еще раз: ");
                        }
                        WriteLine();

                        switch (count)
                        {
                            case 1:
                                mWidth = input;
                                break;
                            case 2:
                                mHeight = input;
                                break;
                            case 3:
                                factor = input;
                                break;
                        }
                    }

                    #endregion

                    WriteLine("--------------------------------\n");

                    #region Создание матрицы

                    int[,] matrix = new int[mWidth, mHeight];

                    WriteLine("Исходная матрица:\n");
                    for (byte ind_2 = 0; ind_2 < mHeight; ind_2++)
                    {
                        for (byte ind = 0; ind < mWidth; ind++)
                        {
                            matrix[ind, ind_2] = randy.Next(1, 100);
                            Write($"{matrix[ind, ind_2], 3} ");
                        }
                        WriteLine();
                    }
                    WriteLine();

                    #endregion

                    WriteLine("--------------------------------\n");

                    #region Умножение на число и вывод результата на экран

                    WriteLine("Результат:\n");
                    for (byte ind_2 = 0; ind_2 < mHeight; ind_2++)
                    {
                        for (byte ind = 0; ind < mWidth; ind++)
                        {
                            Write($"{matrix[ind, ind_2] * factor, 5} ");
                        }
                        WriteLine();
                    }

                    #endregion

                    WriteLine("________________________________");

                }
                else if (choise == 2 || choise == 3)
                {

                    if (choise == 2) WriteLine("___Сложение матриц___\n");
                    else if (choise == 3) WriteLine("___Вычитание матриц___\n");

                    #region Задание размеров матриц

                    WriteLine("@Складывать можно только матрицы одинакового размера@");

                    for (byte count = 1; count <= 2; count++)
                    {
                        switch (count)
                        {
                            case 1:
                                Write("Введите кол-во столбцов обеих матриц ");
                                break;
                            case 2:
                                Write("Введите кол-во строк обеих матриц ");
                                break;
                        }

                        while (true) // Ввод числа и его проверка
                        {
                            // Проверка введенного значения на его соответствие текущим требованиям
                            // (Кароч чтобы число не вылезло за пределы возможностей переменной и нужных нам условий)
                            if (byte.TryParse(ReadLine(), out input) && input <= 50 && input > 0) break;
                            else Write("Число должно быть целым от 1 до 50, попробуйте еще раз: ");
                        }
                        WriteLine();

                        switch (count)
                        {
                            case 1:
                                mWidth = input;
                                break;
                            case 2:
                                mHeight = input;
                                break;
                        }
                    }

                    #endregion

                    WriteLine("--------------------------------\n");

                    #region Создание матриц

                    int[,] matrix = new int[mWidth, mHeight];

                    WriteLine("Исходные матрицы:\n");
                    for (byte ind_2 = 0; ind_2 < mHeight; ind_2++)
                    {
                        for (byte ind = 0; ind < mWidth; ind++)
                        {
                            matrix[ind, ind_2] = randy.Next(1, 100);
                            Write($"{matrix[ind, ind_2],3} ");
                        }
                        WriteLine();
                    }
                    WriteLine();

                    int[,] matrix_2 = new int[mWidth, mHeight];

                    for (byte ind_2 = 0; ind_2 < mHeight; ind_2++)
                    {
                        for (byte ind = 0; ind < mWidth; ind++)
                        {
                            matrix_2[ind, ind_2] = randy.Next(1, 100);
                            Write($"{matrix_2[ind, ind_2],3} ");
                        }
                        WriteLine();
                    }
                    WriteLine();

                    #endregion

                    WriteLine("--------------------------------\n");

                    #region Сложение/Вычитание матриц и вывод результата на экран

                    WriteLine("Результат:\n");
                    for (byte ind_2 = 0; ind_2 < mHeight; ind_2++)
                    {
                        for (byte ind = 0; ind < mWidth; ind++)
                        {
                            if (choise == 2) Write($"{matrix[ind, ind_2] + matrix_2[ind, ind_2], 3} ");
                            else if (choise == 3) Write($"{matrix[ind, ind_2] - matrix_2[ind, ind_2],3} ");
                        }
                        WriteLine();
                    }

                    #endregion

                    WriteLine("________________________________");

                }
                else if (choise == 4)
                {

                    WriteLine("___Перемножение матриц___\n");

                    #region Задание размеров матриц

                    WriteLine("@Перемножать матрицы можно только если кол-во столбцов первой матрицы равно кол-ву строк второй@");

                    for (byte count = 1; count <= 4; count++)
                    {
                        switch(count)
                        {
                            case 1:
                                Write("Введите кол-во столбцов первой матрицы ");
                                break;
                            case 2:
                                Write("Введите кол-во строк первой матрицы ");
                                break;
                            case 3:
                                Write("Введите кол-во столбцов второй матрицы ");
                                break;
                            case 4:
                                Write("Введите кол-во строк второй матрицы ");
                                break;
                        }

                        while (true) // Ввод числа и его проверка
                        {
                            // Проверка введенного значения на его соответствие текущим требованиям
                            // (Кароч чтобы число не вылезло за пределы возможностей переменной и нужных нам условий)
                            if (byte.TryParse(ReadLine(), out input) && input <= 34 && input > 0) break;
                            else Write("Число должно быть целым от 1 до 34, попробуйте еще раз: ");
                        }
                        WriteLine();

                        switch (count)
                        {
                            case 1:
                                mWidth = input;
                                break;
                            case 2:
                                mHeight = input;
                                break;
                            case 3:
                                mWidth_2 = input;
                                break;
                            case 4:
                                mHeight_2 = input;
                                break;
                        }
                        
                        if (count == 4)
                        {
                            if (mWidth == mHeight_2) break;
                            else
                            {
                                WriteLine("Кол-во столбцов первой и кол-во строк второй матрицы не совпадают, повторите ввод:");
                                count = 0;
                            }
                        }

                    }

                    #endregion

                    WriteLine("--------------------------------\n");

                    #region Создание матриц

                    int[,] matrix = new int[mWidth, mHeight];

                    WriteLine("Исходные матрицы:\n");
                    for (byte ind_2 = 0; ind_2 < mHeight; ind_2++)
                    {
                        for (byte ind = 0; ind < mWidth; ind++)
                        {
                            matrix[ind, ind_2] = randy.Next(1, 100);
                            Write($"{matrix[ind, ind_2],3} ");
                        }
                        WriteLine();
                    }
                    WriteLine();

                    int[,] matrix_2 = new int[mWidth_2, mHeight_2];

                    for (byte ind_2 = 0; ind_2 < mHeight_2; ind_2++)
                    {
                        for (byte ind = 0; ind < mWidth_2; ind++)
                        {
                            matrix_2[ind, ind_2] = randy.Next(1, 100);
                            Write($"{matrix_2[ind, ind_2],3} ");
                        }
                        WriteLine();
                    }
                    WriteLine();

                    #endregion

                    WriteLine("--------------------------------\n");

                    #region Сложение/Вычитание матриц и вывод результата на экран

                    WriteLine("Результат:\n");
                    for (byte ind_2 = 0; ind_2 < mHeight; ind_2++)
                    {
                        for (byte ind = 0; ind < mWidth_2; ind++)
                        {
                            buf = 0;
                            for (byte multip = 0; multip < mWidth; multip++)
                            {

                                buf += matrix[multip, ind_2] * matrix_2[ind, multip]; 

                            }

                            Write($"{buf, 6} ");
                        }
                        WriteLine();
                    }

                    #endregion

                    WriteLine("________________________________");

                }

                WriteLine();

                #region Повтор или выход

                WriteLine("Запустить заново? 1 - Повтор | 0 - Выход");
                while (true) // Ввод числа и его проверка
                {
                    // Проверка введенного значения на его соответствие текущим требованиям
                    // (Кароч чтобы число не вылезло за пределы возможностей переменной и нужных нам условий)
                    if (byte.TryParse(ReadLine(), out exit) && exit <= 1 && exit >= 0) break;
                    else Write("Число должно быть целым в диапазоне от 0 до 1, попробуйте еще раз: ");
                }
                WriteLine();
                if (exit == 0) break; // Завершение программы

                #endregion

            }
        }
    }
}
