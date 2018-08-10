using System;
using System.Configuration;
using System.Reflection;
using Ninject;

namespace DeleteOrderUtility
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();

            kernel.Load(Assembly.GetExecutingAssembly());

            var excelProcessor = kernel.Get<ExcelProcessor>();

            var orderHandler = new OrderHandler(excelProcessor);

            var filePath = ConfigurationManager.AppSettings["FilePath"];

            orderHandler.Handle(filePath);

            Console.WriteLine();

            Console.WriteLine("Press any key to exit!!");
            
            Console.ReadKey();

        }
    }
}
