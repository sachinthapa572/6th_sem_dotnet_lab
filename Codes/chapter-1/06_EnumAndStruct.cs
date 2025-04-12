namespace EnumAndStruct
{
    enum OrderStatus
    {
        Pending,
        Shipped,
        Delivered,
        Cancelled
    }

    struct Order
    {
        public int OrderId;
        public string CustomerName;
        public OrderStatus Status;

        public void Display()
        {
            Console.WriteLine($"Order ID: {OrderId}");
            Console.WriteLine($"Customer: {CustomerName}");
            Console.WriteLine($"Status: {Status}");
        }
    }

    public class EnumStruct
    {
        public static void RunProgram()
        {
            Order order1;
            order1.OrderId = 101;
            order1.CustomerName = "Sachin Thapa";
            order1.Status = OrderStatus.Shipped;

            order1.Display();

            order1.Status = OrderStatus.Delivered;

            Console.WriteLine("\nAfter Delivery:");
            order1.Display();
        }
    }

}