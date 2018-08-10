namespace DeleteOrderUtility
{
    public class OrderHandler
    {
        private readonly IExcelProcessor _processor;

        public OrderHandler(IExcelProcessor processor)
        {
            _processor = processor;
        }

        public void Handle(string filePath)
        {
            _processor.Send(filePath);
        }
    }
}
