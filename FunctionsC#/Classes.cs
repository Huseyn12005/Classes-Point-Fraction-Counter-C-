
namespace FunctionsC_
{
    //POINT
    internal class Point
    {
        private int x;
        public int X { get { return x; } set { x = value; } }

        private int y;
        public int Y { get { return y; } set { y = value; } }

        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void ShowData()
        {
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
        }
        public override string ToString()
        {
            return $"{x},{y}";
        }
    }

    //FRACTION
    internal class Fraction
    {

        private int _numerator;
        public int N { get { return _numerator; } set { _numerator = value; } }

        private int _denominator;
        public int D { get { return _denominator; } set { _denominator = value; } }

        public Fraction()
        {
            _numerator = 0;
            _denominator = 1;
        }

        public Fraction(int num, int den)
        {
            N = num;
            D = den;
            Simplify();
        }

        public Fraction Add( Fraction other)
        {
            int um_mexrec = _denominator * other._denominator;
            int suret1 = _numerator * other._denominator;
            int suret2 = other._numerator * _denominator;
            Fraction result = new(suret1 +suret2, um_mexrec);
            result.Simplify();
            return result;
        }

        public Fraction Minus( Fraction other)
        {
            int um_mexrec = _denominator * other._denominator;
            int suret1 = _numerator * other._denominator;
            int suret2 = other._numerator * _denominator;
            Fraction result = new(suret1 -suret2, um_mexrec);
            result.Simplify();
            return result;
        }
 
        public Fraction Multiply(Fraction other) {

            Fraction result = new(_numerator * other._numerator, _denominator * other._denominator);
            result.Simplify();
            return result; 
        }

        public Fraction Divide( Fraction other)
        {
            Fraction result = new(_numerator* other._denominator, _denominator* other._numerator);
            result.Simplify();
            return result;
        }

    void Simplify()
        {
            for (int i = _numerator; i != 0; i--)
            {
                if (_numerator % i == 0 && _denominator % i == 0)
                {

                    _numerator /= i;
                    _denominator /= i;
                }
            }
        }

    }

    //COUNTER
    internal class Counter
    {
        private int _min;
        public int MIN { get; set; }

        private int _max;
        public int MAX { get { return _max; } set { _max = value; } }

        private int _currentValue;
        public int Current 
        { 
            get { return _currentValue; } 
            set 
            { 
                if(value > _min && value < _max)
                    _currentValue = value; 
            } 
        }

        public Counter()
        {

            _min = 0;
            _max = 100;
            _currentValue = _min;
        }

        Counter(int min, int max)
        {

            MIN = min;
            MAX = max;
            Current = min;
        }
        public void increment()
        {

            if (_currentValue < _max)
            {
                _currentValue++;
            }
        }
        public void decrement()
        {
            if (_currentValue > _min)
            {
                _currentValue--;
            }
        }
    }

}
