using EnumCSHARP.Entities;
using EnumCSHARP.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumCSHARP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.Processing

            };
            Console.WriteLine(order);
            string txt = order.Status.ToString();
            int num = (int) order.Status;
            OrderStatus os;
            Enum.TryParse<OrderStatus>("Delivered",out os);
            Console.WriteLine(num);
            Console.WriteLine(txt);
            Console.ReadKey();


        }
    }
}
