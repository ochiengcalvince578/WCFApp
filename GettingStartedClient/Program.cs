using GettingStartedClient.ServiceReference1;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStartedClient
{
    class Program
    {
        static void Main(string[] args)
        {

            //Step 1: Create an instanc eof the WCF proxy.

            CalculatorClient client = new CalculatorClient();

            //step 2: Call the service operations.
            //Call the add service operation.

            double value1 = 100.00D;

            double value2 = 15.99D;

            double result = client.Add(value1, value2);

            Console.WriteLine("Add({0}, {1}) = {2}", value1, value2, result);

            //Call the Mutliply Service OPERATION;
            value1 = 9.00D;
            value2 = 81.25D;

            result = client.Multiply(value1, value2);

            Console.WriteLine("Multiply({0}, {1}) = {2}", value1, value2, result);


            // subtract

            value1 = 145.00D;
            value2 = 76.54D;
            result = client.Subtract(value1, value2);

            Console.WriteLine("Subtract({0}, {1}) = {2}", value1, value2, result);

            //divide

            value1 = 22.00D;
            value2 = 7.00D;
           
            result = client.Divide(value1, value2);


            Console.WriteLine("Divide({0}, {1}) = {2}", value1, value2, result);


            //Step 3: Close the client to gracefull close the connection

            Console.WriteLine("\nPRESS <Enter> to terminate the client.");

            Console.ReadLine();

            client.Close();


        }
    }
}
