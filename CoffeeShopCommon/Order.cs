using CoffeeShopCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Order
{
    public int orderID { get; set; }
    public int userID { get; set; }
    public List<Item> items { get; set; } = new List<Item>();
}