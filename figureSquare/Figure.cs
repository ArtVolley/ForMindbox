using System;

namespace figureSquare
{
    public class Figure
    {
        public int radius;
        public int a;
        public int b;
        public int c;
        public bool isItCircle = false;
        public bool isItTriangle = false;

        public Figure(int radius) // создание круга 
        {
            this.radius = radius;
            this.isItCircle = true;
        }

        public Figure(int a, int b, int c) // создание треугольника
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.isItTriangle = true;
        }


        public double Square() // площадь 
        {
            double square = 0;
            if (isItTriangle == true) // если треугольник
            {
                int semper = (a + b + c) / 2;
                square = Math.Sqrt(semper * (semper - a) * (semper - b) * (semper - c));
            }
            else if (isItCircle == true) // если круг
            {
                square = Math.PI * radius * radius;
            }
            return square;
        }

        public bool IsRightTriangle() // проверка на прямоугольность треугольника
        {
            bool isRightTriangle = false;
            if (isItTriangle == true)
            {
                if (a * a == b * b + c * c) // т. Пифагора
                {
                    isRightTriangle = true;
                }
                else if (b * b == a * a + c * c)
                {
                    isRightTriangle = true;
                }
                else if (c * c == b * b + a * a)
                {
                    isRightTriangle = true;
                }
            }
            return isRightTriangle;
        }
    }
}
