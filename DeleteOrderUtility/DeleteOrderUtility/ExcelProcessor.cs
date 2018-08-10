using System;
using System.Collections.Generic;
using System.Linq;
using FileHelpers;
using Xpo.Common.Logging;
using System.Net;
using System.Configuration;

namespace DeleteOrderUtility
{

    public class ExcelProcessor : IExcelProcessor
    {
        private readonly ILogger _logger;
        public ExcelProcessor(ILogger logger)
        {
        }

        public void Send(string filePath)
        {
            try
            {
                Console.WriteLine("Starting the Delete Operation.");

                var fileHelperEngine = new FileHelperEngine<Order>();

                Console.WriteLine($"Loading file : {filePath}");

                var order = fileHelperEngine.ReadFile(filePath).Skip(1).ToList(); //Skipping the header

                DeleteOrders(order);
            }

            catch (Exception e)
            {
                Console.WriteLine($"Exception occured : {e}");
                throw;
            }

        }

        private void DeleteOrders(IEnumerable<Order> orderNumbers)
        {
            int count = 0;
            var url = ConfigurationManager.AppSettings["Dataserviceurl"];
            foreach (var order in orderNumbers)
            {
                string sURL = $"{url}/XpoConnect.DataServices.Api/orders/{order.id}/mt";

                WebRequest request = WebRequest.Create(sURL);
                request.Method = "DELETE";

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                Console.WriteLine((++count).ToString() + ". Deleted " + order.id.ToString());
            }
        }
    }
}