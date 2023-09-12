namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int number1 = (int)(r.NextSingle() * 100 - 50), number2 = (int)(r.NextSingle() * 100 - 50);

            Console.WriteLine("Calculate: ({0} - {1})^3 = {2}", number1, number2, SubtractingAndPowCubeNumbers(number1, number2));
        }

        /// <summary>
        /// Функция вычисления разности и возведения в куб чисел
        /// </summary>
        /// <param name="number1">Первый множитель</param>
        /// <param name="number2">Второй множитель</param>
        /// <returns>Разность и возведение в куб</returns>
        public static double SubtractingAndPowCubeNumbers(int number1, int number2)
        {
            int degree = 3;

            return Math.Pow((number1 - number2), degree);
        }
    }
}