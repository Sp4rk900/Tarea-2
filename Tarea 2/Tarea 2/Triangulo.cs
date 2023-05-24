using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2
{
    class Triangulo : Figura
    {

        private double _area;
        private double _bas ;
        private double _alt;
        private double _per;
        private double _a,_b,_c;

        public double _area_1 { get; set; }

        public double _bas_1 { get; set; }

        public double _alt_1 { get; set; }                

        public double _a_1 { get ; set; }

        public double _b_1 { get; set; }

        public double _c_1 { get; set; }

        public double _peri { get; set; }
       
        public Triangulo(double a, double b, double c, string color) : base(color)
        {

            _b = b;
            _a = a;
            _per = 0;
            _c = c;
            _bas = 0.1;
            _alt = 0.1;
            _area = 0.1;
            
        }


        public override double GetPerimetro()
        {
            return _per = _a + _b + _c;
        }

        public double menor_lado()
        {
             if (_a<_b && _a<_c)
            {
                _bas = _a;
            }
            else
            {
                if (_b<_a && _b<_c)
                {
                    _bas = _b;
                }
                else
                {
                    if (_c<_a && _c<_b)
                    {
                        _bas = _c;
                    }
                }
            }

            return _bas;

        }
        
        public double GetAlt()
        {
            return _alt = Math.Sqrt(Math.Pow(_a, 2) - (Math.Pow(_b, 2) / 4));
        }

        public override double GetArea()
        {
                 
            _area = (_b * GetAlt()) / 2;

            return _area;
        }

        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy un Triangulo de Color {GetColor()}, Area {GetArea()}, Perimetro {GetPerimetro()}");
        }

    }

    class Triangulo_e : Triangulo
    {

        public Triangulo_e(double a, double b, double c, string color) : base(a, b, c, color)
        {
            _a_1 = a;
            _b_1 = b;
            _c_1 = c;
            _peri = 0;
            _area_1 = 0.1;
            _bas_1 = 0.1;
            _alt_1 = 0.1;
 
        }

        public override double GetArea()
        {
            return base.GetArea();
        }

        public override double GetPerimetro()
        {

           return base.GetPerimetro();

        }

        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy un Triangulo Equilatero de Color {GetColor()}, Area {GetArea()}, Perimetro {GetPerimetro()}");
        }

    }

    class Triangulo_i : Triangulo
    {

        public Triangulo_i(double a, double b, double c, string color) : base(a, b, c, color)
        {
            _a_1 = a;
            _b_1 = b;
            _c_1 = c;
            _peri = 0;
            _area_1 = 0.1;
            _bas_1 = 0.1;
            _alt_1 = 0.1;
        }

        public override double GetArea()
        {
            //return (_b_1 * Math.Sqrt(Math.Pow(_a_1,2) - (Math.Pow(_b_1, 2) / 4))) / 2;
            return (_b_1 * GetAlt()) / 2;
        }

        public override double GetPerimetro()
        {

            return _peri = 2*_a_1 + _b_1;


        }

        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy un Triangulo Isosceles de Color {GetColor()}, Area {GetArea()}, Perimetro {GetPerimetro()}");
        }

    }

    class Triangulo_es : Triangulo
    {

        private double semi_p;

        public Triangulo_es(double a, double b, double c, string color) : base(a, b, c, color)
        {
            _a_1 = a;
            _b_1 = b;
            _c_1 = c;
            _peri = 0;
            _area_1 = 0.1;
            _bas_1 = 0.1;
            _alt_1 = 0.1;
            semi_p = 0;
        }

        public override double GetArea()
        {

            semi_p = GetPerimetro() / 2;

            return  Math.Sqrt(semi_p * (semi_p - _a_1) * (semi_p - _b_1) * (semi_p - _c_1));

        }

        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy un Triangulo Escaleno de Color {GetColor()}, Area {GetArea()}, Perimetro {GetPerimetro()}");
        }

    }

}



