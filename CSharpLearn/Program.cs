using System;

namespace CSharpLearn
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            //задание 7.7
        }
    }

    class Address
    {
        public string Country { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        int house;
        public int House
        {
            get => house;

            set => house = (value > 0) ? value : 1;
        }

        int flat;
        public int Flat
        {
            get => flat;

            set => flat = (value < 0) ? value : 1;
        }

        public void DisplayAddress() => Console.WriteLine
            ($"Страна: {Country}, город: {City}, Адрес: {Street}, {House} - {Flat}");
    }

    abstract class Delivery
    {
        public Address DeliveryAddress { get; set; }

        public DateTime ArriveDate { get; set; }

        public abstract void DeliveryInfo();
    }

    class HomeDelivery : Delivery
    {
        public string CourierName { get; set; }

        public override void DeliveryInfo() => Console.WriteLine
            ($"Доставка на дом. Курьер: {CourierName}");
    }

    class PickPointDelivery : Delivery
    {
        public string PickPoint { get; set; }

        public override void DeliveryInfo() => Console.WriteLine
            ($"Доставка в ПВЗ. Адрес ПВЗ: {PickPoint}");
    }

    class ShopDelivery : Delivery
    {
        public string ShopAddress { get; set; }

        public override void DeliveryInfo() => Console.WriteLine
            ($"Доставка в магазин. Адрес магазина: {ShopAddress}");
    }

    abstract class Order<TDelivery, TStruct> where TDelivery : Delivery
    {
        protected TDelivery Delivery; //вид доставки

        int orderNumber;

        public string Description { get; set; }

        public DateTime DeliveryDate { get; set; }

        public bool IsDelivered { get; set; } //приехал или нет

        public Customer OrderCustomer { get; set; }

        public double[] ProductList { get; set; } //массив для записи цен товаров

        public double this[int index] //индексатор - сумма товаров в заказе
        {
            get { return ProductList[index]; }
            set { ProductList[index] = value; }
        }

        public double CalculateTotalPrice()
        {
            double totalPrice = 0;

            foreach (double price in ProductList)
            {
                totalPrice += price;
            }

            return totalPrice;
        }

        public void DisplayAddress() => Console.WriteLine(Delivery.DeliveryAddress);
    }

    class ExtraHomeOrder : Order<HomeDelivery, int> { }

    public static class OrderInfo
    {
        public static int OrderCount { get; private set; }

        public static void IncreaseOrders() => OrderCount++;
    }

    static class OrderExtensions
    {
        public static double GetAveragePrice<TDelivery, TStruct>
            (this Order<TDelivery, TStruct> order) where TDelivery : Delivery
        {
            double total = order.CalculateTotalPrice();
            return total / order.ProductList.Length;
        }
    }

    class Product
    {
        public Product(int productID, string name, double price, double size)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            Size = size;
        }

        public int ProductID { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public double Size { get; set; }

        public static double operator +(Product product1, Product product2) =>
            product1.Price + product2.Price;

        public static bool operator >(Product product1, Product product2)
        {
            if (product1.Price > product2.Price)
            {
                return true;
            }
            return false;
        }

        public static bool operator <(Product product1, Product product2)
        {
            if (product1.Price < product2.Price)
            {
                return true;
            }
            return false;
        }

        public void DisplayProductInfo() => Console.WriteLine
            ($"{Name}, цена {Price} рублей. {Size} размер");
    }

    class Customer
    {
        public Customer(string customerName, int customerPhone, string customerEmail)
        {
            CustomerName = customerName;
            CustomerPhone = customerPhone;
            CustomerEmail = customerEmail;
        }

        public string CustomerName { get; set; }

        public int CustomerPhone { get; set; }

        public string CustomerEmail { get; set; }

        public void DisplayCustomerInfo() => Console.WriteLine
            ($"{CustomerName}, {CustomerPhone}, {CustomerEmail}");
    }
}