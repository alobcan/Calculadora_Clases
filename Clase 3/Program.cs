using System;

namespace Clase_3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Calculadora calc = new Calculadora();
            Operadores op = new Operadores();

            string a, b;
            string c = null;
            Console.WriteLine("Ingrese parametro 1: ");
            a = Console.ReadLine();
           

            Console.WriteLine("Ingrese parametro 2: ");
            b = Console.ReadLine();
            

            Console.WriteLine("Ingrese operacion[+ - * /]: ");
            char operacion = char.Parse(Console.ReadLine());

            switch(operacion)
            {
                case '+':
                    op.Op1 = int.Parse(a);
                    op.Op2 = int.Parse(b);
                    Console.WriteLine("el resultado es: {0}", calc.Sumar(op));
                    break;
                case '-':
                    op.Op1 = int.Parse(a);
                    op.Op2 = int.Parse(b);
                    Console.WriteLine("el resultado es: {0}", calc.Restar(op));
                    break;
                case '*':
                    op.Op1 = int.Parse(a);
                    op.Op2 = int.Parse(b);
                    Console.WriteLine("el resultado es: {0}", calc.Mult(op));
                    break;
                case '/':
                    op.Op1 = int.Parse(a);
                    op.Op2 = int.Parse(b);
                    Console.WriteLine("el resultado es: {0}", calc.Div(op));
                    break;
                case 'a':
                    Console.WriteLine("el resultado es: {0}", calc.Sumar(a,b));
                    break;
                default:
                    Console.WriteLine("Operacion invalida");
                    break;
            }

            
            
            Console.ReadKey();
        }
        
    }
    class Operadores
    {
        int op1;
        int op2;

        public int Op1{get => op1; set => op1 = value;}
        public int Op2{get => op2; set => op2 = value;}
    }

    class Calculadora
    {
        //#region -> crea una pequeña region
        #region Calculadora
        public string Sumar(string a, string b)
        {
            return a + b;
        }
        public int Sumar(Operadores kth)
        {
            return kth.Op1 + kth.Op2;
        }
        public int Restar(Operadores kth)
        {
            return kth.Op1 - kth.Op2;
        }
        public int Mult(Operadores kth)
        {
            return kth.Op1 * kth.Op2;
        }
        public int Div(Operadores kth)
        {
            int i = 0;
            try
            {
                i = kth.Op1 / kth.Op2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir por 0");
                Console.ReadKey();
            }
            return i; 
        }
        #endregion

    }
}
