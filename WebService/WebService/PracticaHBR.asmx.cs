using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Summary description for PracticaHBR
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class PracticaHBR : System.Web.Services.WebService
    {

        // Method to get the Max double value in an array
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public Int64 MajorNumber()
        {
            bool nextValue = true;
            List<long> values = new List<Int64>();

            do
            {
                Console.Write("\nIngrese el valor que desea insertar: ");
                values.Add(Convert.ToInt64(Console.ReadLine()));

                Console.Write("Le gustaria ingresar otro valor extra? Y/N");
                var next = Console.ReadLine();

                if (next.ToUpper() == "N")
                {
                    nextValue = false;
                }

            } while (nextValue);



            var MajorNumber = values.Max();
            return MajorNumber;
        }

        // Method to get the reflection of a number
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public long InvertNumber(long insertedValue)
        {
            string InvertedNumber = "";


            string Number = insertedValue.ToString();

            foreach (char value in Number)
            {
                // Put the character before the inverted string
                InvertedNumber = value + InvertedNumber;
            }

            if (!string.IsNullOrWhiteSpace(InvertedNumber))
            {
                return Convert.ToInt64(InvertedNumber);
            }
            else
            {
                return 0;
            }
        }
        
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public long InvertNum(int Number)
        {
            long Reverse = 0;
            while (Number > 0)
            {
                int remainder = Number % 10;
                Reverse = (Reverse * 10) + remainder;
                Number = Number / 10;
            }
            return Reverse;
        }

        // Method to get the Sum of two double variables
        [WebMethod]
        public double add(double firstInsertedValue, double secondInsertedValue)
        {
            return (firstInsertedValue + secondInsertedValue);
        }

        // Method to get the difference of two double variables
        [WebMethod]
        public double substract(double firstInsertedValue, double secondInsertedValue)
        {
            return (firstInsertedValue - secondInsertedValue);
        }

        // Method to get the product of two double variables
        [WebMethod]
        public double multiply(double firstInsertedValue, double secondInsertedValue)
        {
            return (firstInsertedValue * secondInsertedValue);
        }

        // Method to get the  two double variables
        [WebMethod]
        public double divide(double a, double b)
        {
            if (b != 0)
            {
                var div = (a / b);
               return div;
            } 
            else
            {
                return 0;
            }
        }

        // Method to get the power of a number (base) elevated to a number (exponent)
        [WebMethod]
        public int pow(int baseValue, int exponentValue)
        {

            int pow = baseValue;

            for (int i = 1; i < exponentValue; i++)
            {
                pow *= baseValue;
            }
            return (pow);
        }

        [WebMethod]
        public string GetDate(string inputDate)
        {
            var date = Convert.ToDateTime(inputDate);
            return date.ToString("dddd, dd MMMM yyyy");
        }
    }
}
