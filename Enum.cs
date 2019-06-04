namespace PrimeiiroProjeto.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
//----------------------------------------------------
using System;
using PrimeiiroProjeto.Entities.Enums;

namespace PrimeiiroProjeto.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}
//----------------------------------------------------
using PrimeiiroProjeto.Entities;
using PrimeiiroProjeto.Entities.Enums;
using System;

namespace PrimeiiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um Enum setando os valores
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //Converter um Enum para string
            string txt = OrderStatus.Processing.ToString();
            Console.WriteLine("Enum converted to string: " + txt);

            //Converter uma string para Enum
            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");
            Console.WriteLine(os);
        }
    }
}
