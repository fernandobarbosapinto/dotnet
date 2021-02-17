using System;
using enum1.Entities;
using enum1.Entities.Enums;

namespace enum1
{
    class Program
    {
        static void Main (string[] args)
        {
            Order order = new Order
            {
                Id = 1800,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //fazendo a conversão de um valor enumerado para string

            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(txt);

            //fazendo a conversão de uma string para um valor enumerado

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
        }
    }
}
