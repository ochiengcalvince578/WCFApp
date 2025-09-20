using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using GettingStartedLib;


namespace GettingStartedHost
{
    class Program
    {

        static void Main(string[] args)
        {

            // Step 1: Create a URI to serve as the base address.
            Uri baseAddress = new Uri("http://localhost:8000/GettingStarted/");


            //Step 2: Create a SericeHost instance.
            ServiceHost selfHost = new ServiceHost(typeof(CalculatorService), baseAddress);


            try 
            {

                //Step 3: Add a service endpoint
                selfHost.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "CalculatorService");


            }


        }
    }
}