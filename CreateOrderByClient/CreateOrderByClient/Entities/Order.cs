using CreateOrderByClient.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateOrderByClient.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();


        public Order(OrderStatus orderstatus, Client client)
        {
            OrderStatus = orderstatus;
            Client = client;
            Moment = DateTime.Now;
        }


        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItems.Remove(item);
        }

        public double Total()
        {
            double totalOrder = 0;
            foreach (OrderItem item in OrderItems)
            {
                totalOrder += item.SubTotal();
            }
            return totalOrder;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("MM/dd/yyyy HH:mm:ss"));
            sb.Append("Order Status: ");
            sb.AppendLine(OrderStatus.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(" ");
            sb.Append(Client.Birthdate);
            sb.Append(" - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order items:");

            foreach(OrderItem item in OrderItems)
            {
                sb.Append(item.Product.Name);
                sb.Append(", ");
                sb.Append(item.Product.Price.ToString("C2"));
                sb.Append(", Quantity: ");
                sb.Append(item.Quantity);
                sb.Append(", Subtotal: ");
                sb.AppendLine(item.SubTotal().ToString("C2"));

            }

            sb.Append("Total price: ");
            sb.AppendLine(Total().ToString("C2"));

            return sb.ToString();


        }

     
    }

}
