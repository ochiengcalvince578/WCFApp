using GettingStartedLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Host472
{
    class Program
    {
        static void Main(string[] args)
        {

           //Step 1: Create a URI to serve as the base address
            Uri baseAddress = new Uri("http://localhost:8080/GettinStarted/");


            //Step 2: Create a ServiceHost instance

            ServiceHost selfHost = new ServiceHost(typeof(CalculatorService), baseAddress);

            try
            {

                selfHost.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "CalculatorService");

                //Step 4: Enable metadata exchange
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();

                smb.HttpGetEnabled = true;

                selfHost.Description.Behaviors.Add(smb);

                //Step 5: Start the service.

                selfHost.Open();

                Console.WriteLine("The service is ready");

                // Close the ServiceHost to stop the service
                Console.WriteLine("Press <Enter> to terminate the service");

                Console.WriteLine();
                Console.ReadLine();

                selfHost.Close();
            }

            catch (Exception ex) {

                Console.WriteLine("An exception occurred: {0}", ex.Message);

                selfHost.Abort();
            }
        }
    }
}
