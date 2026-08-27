using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        const string inputFilePath = @".\input.txt";
        const string outputFilePath = @".\output.txt";
        StreamReader reader = new StreamReader(inputFilePath);
        double accuracy = 0;
        int matrixSize = 0;
        double[,] elements;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            accuracy = double.Parse(reader.ReadLine()); //чтение точности из файла

            //создание области рисования графиков
            accuracyChart.ChartAreas.Add(new ChartArea("Math functions"));
            initialApproximationChart.ChartAreas.Add(new ChartArea("Math functions"));
        }
        /// <summary>
        /// Метод GetYakobiIterations(int matrixSize, double[,] elements, double accuracy, double initialApproximation) производит поиск переменных СЛАУ методом Якоби и возвращает количество проведённых итераций.
        /// </summary>
        /// <param name="matrixSize">Количество уравнений системы.</param>
        /// <param name="elements">Двумерная матрица из коэффициентов перед переменными и свободных членов.</param>
        /// <param name="accuracy">Точность.</param>
        /// <param name="initialApproximation">Начальное приближение.</param>
        /// <returns>Количество итераций метода. </returns> 
        private int GetYakobiIterations(int matrixSize, double[,] elements, double accuracy, double initialApproximation)
        {
            //Задаю первый массив X
            double[] x = new double[matrixSize];
            for (int i = 0; i < matrixSize; i++)
                x[i] = initialApproximation;

            //Вычисление новых x i-ых и проверка точности
            double[] x_k = new double[matrixSize];
            double sum, sumOfSqueresOfDeffernces, sumOfx_k;
            int iterations = 0;
            sum = 0;
            do
            {
                sumOfx_k = 0;
                iterations++;

                for (int i = 0; i < matrixSize; i++)
                {
                    for (int j = 0; j < matrixSize; j++)
                        if (i != j) sum += elements[i, j] / elements[i, i] * x[j];
                    x_k[i] = elements[i, matrixSize] / elements[i, i] - sum;
                    sum = 0;
                }

                //вычисление наибольшей разницы между старым и новых x для проверки точности
                for (int i = 0; i < matrixSize; i++)
                {
                    sumOfSqueresOfDeffernces = Math.Abs(x_k[i] - x[i]);
                    if (sumOfSqueresOfDeffernces > sumOfx_k) sumOfx_k = sumOfSqueresOfDeffernces;
                }

                for (int i = 0; i < matrixSize; i++) x[i] = x_k[i];
            } while (sumOfx_k >= accuracy && iterations < 100);

            return iterations;
        }
        /// <summary>
        /// Метод GetYakobiSolution(int matrixSize, double[,] elements, double accuracy, double initialApproximation) производит поиск переменных СЛАУ методом Якоби и возвращает массив с решениями.
        /// </summary>
        /// <param name="matrixSize">Количество уравнений системы.</param>
        /// <param name="elements">Двумерная матрица из коэффициентов перед переменными и свободных членов.</param>
        /// <param name="accuracy">Точность.</param>
        /// <param name="initialApproximation">Начальное приближение.</param>
        /// <returns>Массив решений СЛАУ.</returns>          
        private double[] GetYakobiSolution(int matrixSize, double[,] elements, double accuracy, double initialApproximation)
        {
            // Задаю первый массив X
            double[] x = new double[matrixSize];
            for (int i = 0; i < matrixSize; i++)
                x[i] = initialApproximation;

            //Вычисление новых x i-ых и проверка точности
            double[] x_k = new double[matrixSize];
            double sum, sumOfSqueresOfDeffernces, sumOfx_k;
            int iterations = 0;
            sum = 0;
            do
            {
                sumOfx_k = 0;
                iterations++;

                //вычисление новых х
                for (int i = 0; i < matrixSize; i++)
                {
                    for (int j = 0; j < matrixSize; j++)
                        if (i != j) sum += elements[i, j] / elements[i, i] * x[j];
                    x_k[i] = elements[i, matrixSize] / elements[i, i] - sum;
                    sum = 0;
                }

                //вычисление максимальной разницы между старым и новым х
                for (int i = 0; i < matrixSize; i++)
                {
                    sumOfSqueresOfDeffernces = Math.Abs(x_k[i] - x[i]);
                    if (sumOfSqueresOfDeffernces > sumOfx_k) sumOfx_k = sumOfSqueresOfDeffernces;
                }

                for (int i = 0; i < matrixSize; i++) x[i] = x_k[i];

            } while (sumOfx_k >= accuracy && iterations < 100);

            return x_k;
        }
        /// <summary>
        /// Метод GetZeidelIterations(int matrixSize, double[,] elements) производит поиск переменных СЛАУ методом Зейделя и возвращает количество итераций.
        /// </summary>
        /// <param name="matrixSize">Количество уравнений системы.</param>
        /// <param name="elements">Двумерная матрица из коэффициентов перед переменными и свободных членов.</param>
        /// <param name="accuracy">Точность.</param>
        /// <param name="initialApproximation">Начальное приближение.</param>
        /// <returns>Массив решений СЛАУ.</returns>        
        private int GetZeidelIterations(int matrixSize, double[,] elements)
        {
            // Задаю первый массив X
            double[] x = new double[matrixSize];
            for (int i = 0; i < matrixSize; i++)
                x[i] = 1;


            double[] x_k = new double[matrixSize];
            x.CopyTo(x_k, 0);

            double sum, sumOfSqueresOfDeffernces, sumOfx_k;
            int iterations = 0;
            sum = 0;
            do
            {
                sumOfx_k = 0;
                iterations++;

                //вычисление новых х
                for (int i = 0; i < matrixSize; i++)
                {
                    for (int j = 0; j < matrixSize; j++)
                    {
                        if (j < i) sum += elements[i, j] / elements[i, i] * x_k[j];
                        else if (i != j) sum += elements[i, j] / elements[i, i] * x[j];
                    }
                    x_k[i] = elements[i, matrixSize] / elements[i, i] - sum;
                    sum = 0;
                }

                //вычисление максимальной разницы между старым и новым х
                for (int i = 0; i < matrixSize; i++)
                {
                    sumOfSqueresOfDeffernces = Math.Abs(x_k[i] - x[i]);
                    if (sumOfSqueresOfDeffernces > sumOfx_k) sumOfx_k = sumOfSqueresOfDeffernces;
                }

                for (int i = 0; i < matrixSize; i++) x[i] = x_k[i];

            } while (sumOfx_k >= 0.0001 && iterations < 100);

            return iterations;
        }
        /// <summary>
        /// Метод readFileButton_Click(object sender, EventArgs e) обрабатывает нажатие кнопки чтения количества переменных, коэффициентов перед переменными и свободных членов из файла и выполняет вычисления.
        /// </summary>
        private void readFileButton_Click(object sender, EventArgs e)
        {
            readFileButton.Enabled = false;

            matrixSize = int.Parse(reader.ReadLine()); //чтение количества переменных
            elements = new double[matrixSize, matrixSize + 1];

            List<double> buffer = new List<double>();
            for (int i = 0; i < matrixSize; i++)
                foreach (var number in reader.ReadLine().Split(' '))
                    buffer.Add(double.Parse(number));

            elements = new double[matrixSize, matrixSize + 1];
            for (int i = 0; i < matrixSize; i++)
                for (int j = 0; j < matrixSize + 1; j++)
                    elements[i, j] = buffer[i * (matrixSize + 1) + j];

            doMagic();
        }
        /// <summary>
        /// Метод generateMatrixButton_Click(object sender, EventArgs e) читает из TextBox количество переменных, генерирует случайные коэффициенты перед переменными и свободные члены уравнений, после чего выполняет вычисления.
        /// </summary>
        private void generateMatrixButton_Click(object sender, EventArgs e)
        {
            matrixSize = int.Parse(textBox1.Text); //чтение количества переменных
            elements = new double[matrixSize, matrixSize + 1];

            //генерация свободных членов и коэффициентов
            Random random = new Random();
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize + 1; j++)
                    if (i == j) elements[i, j] = Math.Round((random.NextDouble() + 0.5) * matrixSize * 100);

                for (int j = 0; j < matrixSize; j++)
                    if (i != j) elements[i, j] = Math.Round(random.NextDouble() * 100);

                elements[i, matrixSize] = Math.Round((random.NextDouble()+0.5) * matrixSize * 100);
            }

            doMagic();
        }
        /// <summary>
        /// Метод doMagic() решает систему, рисует графики и вычисляет значения для исследований.
        /// </summary>
        private void doMagic()
        {
            checkingLabel.Text = "Достаточное условие сходимости метода Якоби выполняется.";
            checkingLabel.ForeColor = Color.DarkGreen;

            double sumOfStrokeElements;
            double diagonalDominances = 0;
            for (int i = 0; i < matrixSize; i++)
            {
                sumOfStrokeElements = 0;

                //подсчёт суммы модулей недиагональных элементов строки
                for (int j = 0; j < matrixSize; j++)
                    if (i != j) sumOfStrokeElements += Math.Abs(elements[i, j]);

                //сложение отношений суммы модулей недиагональных элементов строки к модулю диагонального
                //используется для вычисления среднего отношения
                diagonalDominances += sumOfStrokeElements / Math.Abs(elements[i, i]);

                // если сумма модулей недиагональных элементов строки больше модуля диагонального, то сообщение меняется
                if (Math.Abs(elements[i, i]) <= sumOfStrokeElements)
                {
                    checkingLabel.Text = "Достаточное условие сходимости метода Якоби не выполняется.";
                    checkingLabel.ForeColor = Color.Red;
                    break;
                }
            }

            //Создаем и настраиваем набор точек для рисования графика
            Series mySeriesOfPoint = new Series();
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            mySeriesOfPoint.ChartArea = "Math functions";
            mySeriesOfPoint.BorderWidth = 3;

            Series initialApproximationSeries = new Series();
            initialApproximationSeries.ChartType = SeriesChartType.Line;
            initialApproximationSeries.ChartArea = "Math functions";
            initialApproximationSeries.BorderWidth = 3;

            for (double x = 0.0001; x <= 1; x += 0.01)
                mySeriesOfPoint.Points.AddXY(x, GetYakobiIterations(matrixSize, elements, x, 1));

            for (double x = -50; x <= 100; x += 1)
                initialApproximationSeries.Points.AddXY(x, GetYakobiIterations(matrixSize, elements, accuracy, x));
            
            //Добавляем созданный набор точек в Chart
            accuracyChart.Series.Add(mySeriesOfPoint);
            initialApproximationChart.Series.Add(initialApproximationSeries);

            yakobiLabel.Text = $"Количество итераций методом Якоби при точности, равной {accuracy}, и начальному приближению, равном 1 — {GetYakobiIterations(matrixSize, elements, 0.0001, 1)}.";
            zeidelLabel.Text = $"Количество итераций методом Зейделя при точности, равной {accuracy}, и начальному приближению, равном 1 — {GetZeidelIterations(matrixSize, elements)}.";

            //вывод решений в файл
            double[] x_k = GetYakobiSolution(matrixSize, elements, accuracy, 1);
            StreamWriter writer = new StreamWriter(outputFilePath, false);
            writer.Write("Решение системы линейных уравнений: ");
            for (int i = 0; i < matrixSize; i++)
                writer.WriteLine($"x{i + 1} = {(Math.Round(x_k[i], 4))}");
            writer.Close();

            //подсчёт нормы невязки как максимальной невязки
            double residialNorm = 0;
            double residialVector;
            double sum = 0;

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                    sum += x_k[j] * elements[i, j];
                residialVector = elements[i, matrixSize] - sum;
                if (residialVector > residialNorm) residialNorm = residialVector;
                sum = 0;
            }
            ResidialNormLabel.Text = $"Норма невязки — {residialNorm}.";

            middleLabel.Text = $"Среднее отношения суммы модулей недиагональных элементов строки к модулю диагонального элемента — {diagonalDominances / matrixSize}.";

            accuracyChart.Visible = true;
            initialApproximationChart.Visible = true;
            yakobiLabel.Visible = true;
            zeidelLabel.Visible = true;
            checkingLabel.Visible = true;
            ResidialNormLabel.Visible = true;
            middleLabel.Visible = true;
        }
    }
}
