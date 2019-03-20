using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
      public  class libreria
        {
            string nombres;
            int num1, num2, multi, divi, resp = 0, i = 0;
            public void metodo1()
            {
                Console.WriteLine("escriba 1 para multiplicar");
                resp = int.Parse(Console.ReadLine());
                while (resp == 1)
                {

                    {
                        Console.WriteLine("escriba primer valor");
                        num1 = int.Parse(Console.ReadLine());
                        if (num1 == 0)
                        {
                            Console.WriteLine("el producto de 0 por cualquier numero es 0");
                        }
                        else
                        {
                            Console.WriteLine("ingrese segudo valor");
                            num2 = int.Parse(Console.ReadLine());
                            multi = num1 * num2;
                            Console.WriteLine("resultado es :" + multi);
                            Console.ReadKey();
                        }
                    }
                }


            }

            public static Class1 obj { get; set; }


            public void metodo2()
            {
                Console.WriteLine("escriba 2 para dividir");
                resp = int.Parse(Console.ReadLine());
                while (resp == 2)
                {

                    {
                        Console.WriteLine("escriba primer valor");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese segudo valor");
                        num2 = int.Parse(Console.ReadLine());
                        if (num2 == 0)
                        {

                            Console.WriteLine("no se puede dividir");
                        }
                        else
                        {
                            divi = num1 / num2;

                            Console.WriteLine("resultado es :" + divi);
                            Console.ReadKey();
                        }
                    }
                }


            }

           // public static Class1 obj { get; set; }

            public void metodo3()
            {
                Console.WriteLine("escriba 3 para para ingresar nombres");
                resp = int.Parse(Console.ReadLine());
                while (resp == 3)
                {
                    for (i = 0; i <= 5; i++) ;
                    Console.WriteLine("escriba 5 nombres");
                    nombres = Console.ReadLine();


                }



            }
           // public static Class1 obj { get; set; }
        }


       /* public void metodo2()
        {
            throw new NotImplementedException();
        }

        public void metodo1()
        {
            throw new NotImplementedException();
        }

        public void metodo3()
        {
            throw new NotImplementedException();
        }*/
    }
     
}
