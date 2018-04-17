/*Задание 8 Требуется:  
* Создать класс Invoice.  
* В теле класса создать три поля int account, string customer, string provider которые должны быть проинициализированы один раз (при создании экземпляра данного класса) без возможности их дальнейшего изменения.  В теле класса создать два закрытых поля string article, int quantity  
* Создать метод расчета стоимости заказа с НДС и без НДС.  
* Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest8
{
    class Invoice {
        static int account;
        static string customer, provider;
        private string[] article = new string[2];
        private int quantity;

        public Invoice(int iacoount, string icustomer, string iprovider, string iarticle, string price, int iquantity) {
            account = iacoount;
            customer = icustomer;
            provider = iprovider;

            article[0] = iarticle;
            article[1] = price;
            quantity = iquantity;
        }

        public void Print() {
            Console.WriteLine("Order #1\nUser Name: " + customer + ", account #" + account + "\nProvider: " + provider + "\nArticle: " + article[0] + "\nTotal sum (with VAT): " + ((Double.Parse(article[1]) * quantity) + (Double.Parse(article[1]) * quantity) * 17 / 100) + "$\nTotal sum (clear): " + (Int32.Parse(article[1]) * quantity) + "$");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Invoice InvoiceEx = new Invoice(13145, "Customer1", "Provider1", "product1", "10", 3);
            InvoiceEx.Print();
            Console.ReadKey();
        }
    }
}
