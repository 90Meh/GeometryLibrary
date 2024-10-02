namespace GeometryLibrary
{
    public static class GeometryCalculator
    {
        /// <summary>
        /// Вычисляет площадь круга по заданному радиусу.
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        /// <returns>Площадь круга.</returns>
        public static double CalculateCircleArea(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус не может быть отрицательным.");
            }

            return Math.PI * Math.Pow(radius, 2);
        }

        /// <summary>
        /// Вычисляет площадь треугольника по трем сторонам.
        /// </summary>
        /// <param name="sideA">Первая сторона треугольника.</param>
        /// <param name="sideB">Вторая сторона треугольника.</param>
        /// <param name="sideC">Третья сторона треугольника.</param>
        /// <returns>Площадь треугольника.</returns>
        public static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Длины сторон треугольника должны быть положительными числами.");
            }

            if (!IsTriangleValid(sideA, sideB, sideC))
            {
                throw new ArgumentException("Треугольник с такими сторонами не существует.");
            }

            double semiPerimeter = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
        }

        /// <summary>
        /// Проверяет, является ли треугольник с заданными сторонами допустимым.
        /// </summary>
        /// <param name="sideA">Первая сторона треугольника.</param>
        /// <param name="sideB">Вторая сторона треугольника.</param>
        /// <param name="sideC">Третья сторона треугольника.</param>
        /// <returns>True, если треугольник допустим, иначе False.</returns>
        private static bool IsTriangleValid(double sideA, double sideB, double sideC)
        {
            return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
        }
    }
}