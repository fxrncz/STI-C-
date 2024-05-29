using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication.ItemNamespace
{
    public class DiscountedItem : Item 
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

        public DiscountedItem(string name, double price, int quantity, double discount) : base (name, price, quantity)
        {
            this.item_discount = discount;
        }


        public override double getTotalPrice()
        {
            double discount = this.item_discount * 0.01;
            double discountPrice = base.item_price * this.item_quantity * discount;
            double totalAmount = (base.item_price * this.item_quantity) - discountPrice;
            return this.discounted_price = totalAmount;
        }

        public override void setPayment(double amount)
        {
            this.payment_amount = amount;
        }

        public double getChange()
        {
            change = payment_amount - getTotalPrice();
            return change;
        }


    }
}
