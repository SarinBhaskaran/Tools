using Ninject;
using Ninject.Modules;
using Xpo.Common.Logging;
using Xpo.Common.Logging.NLog4;

namespace DeleteOrderUtility
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IExcelProcessor>().To<ExcelProcessor>();
            Bind<ILogManager>().To<NLogLogManager>().InSingletonScope();
            Bind<ILogger>().ToMethod(c => c.Kernel.Get<ILogManager>().Get(c.Request.Target?.Type));
        }
    }
}