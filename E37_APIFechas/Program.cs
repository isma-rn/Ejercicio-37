using System;

namespace E37_APIFechas
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            Console.WriteLine("Esta es la fecha y hora:\t{0}", myValue.ToString());
            Console.WriteLine("Esta es la hora en formato corto:\t{0}", myValue.ToShortTimeString());
            Console.WriteLine("Esta es la hora  en formato largo:\t{0}", myValue.ToLongTimeString());            
            Console.WriteLine("Esta es la fecha en formato corto:\t{0}", myValue.ToShortDateString());
            Console.WriteLine("Esta es la fecha en formato largo:\t{0}", myValue.ToLongDateString());

            Console.WriteLine("Esta es la fecha en formato largo más 3 dias:\t{0}", myValue.AddDays(3).ToLongDateString());
            Console.WriteLine("Esta es la hora en formato largo más 5 horas:\t{0}", myValue.AddHours(5).ToLongTimeString());
            Console.WriteLine("Esta es la fecha en formato largo menos 3 dias y mas 2 meses:\t{0}", myValue.AddDays(-3).AddMonths(2).ToLongDateString());

            Console.WriteLine("El día es: {0}", myValue.Day);
            Console.WriteLine("Este es el mes: {0}", myValue.Month);
            Console.WriteLine("nombre del día de hoy: {0}", myValue.DayOfWeek);
            Console.WriteLine("Estamos en dia {0} del año", myValue.DayOfYear);

            DateTime myBirthday = new DateTime(1991, 12, 19);
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine("Esta es mi fecha de nacimiento: {0}\nTengo {1:#.#} dias, qeu equivalen a {2:#.#} horas", myBirthday.ToShortDateString(), myAge.TotalDays, myAge.TotalHours);
            
            Console.ReadLine();
        }
    }
}
