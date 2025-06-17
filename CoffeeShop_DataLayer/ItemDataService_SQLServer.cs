using CoffeeShopCommon;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop_DataLayer
{
    public class ItemDataService_SQLServer : IItemDataService
    {
        List<Item> items;
        protected string[] itemTypes = { "Beverage", "Snack" };

        static string connectionString
        = "Data Source =DESKTOP-55DMAU9\\SQLEXPRESS02; Initial Catalog = CoffeeShop; Integrated Security = True; TrustServerCertificate=True;";
        static SqlConnection sqlConnection = new SqlConnection(connectionString);

        public ItemDataService_SQLServer()
        {
            items = new List<Item>(InitializeData());
        }

        List<Item> InitializeData()
        {
            string selectStatement = "SELECT name, cost, soldCount, type FROM items";

            List<Item> _items = new List<Item>();
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();
            while (reader.Read())
            {
                //Serealize data from database to Item object

                Item item = new Item();
                item.itemID = Convert.ToInt32(reader["itemID"]);
                item.name = reader["name"].ToString().Trim(); //fix later why it doesn't work without trim
                item.cost = Convert.ToDouble(reader["cost"].ToString());
                item.soldCount = Convert.ToInt32(reader["soldCount"].ToString());
                item.type = reader["type"].ToString().Trim(); // 
                _items.Add(item);
            }
            sqlConnection.Close();
            return _items;
        }

        public void AddItem(string itemName, double itemCost, string itemType)
        {
            var insertStatement = "INSERT INTO items VALUES (@name, @cost, @soldCount, @type)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@name", itemName);
            insertCommand.Parameters.AddWithValue("@cost", itemCost);
            insertCommand.Parameters.AddWithValue("@soldCount", 0);
            insertCommand.Parameters.AddWithValue("@type", itemType);
            sqlConnection.Open();

            insertCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }


        public void AddSoldCount(string name, int orderQuantity)
        {

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].name == name)
                {
                    items[i].soldCount += orderQuantity;

                    var updateStatement = $"UPDATE items SET soldCount = @soldCount WHERE name = @name";

                    SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);

                    updateCommand.Parameters.AddWithValue("@name", name);
                    updateCommand.Parameters.AddWithValue("@soldCount", items[i].soldCount);
                    sqlConnection.Open();
                    updateCommand.ExecuteNonQuery();

                }
            }
            sqlConnection.Close();
        }
        public bool DeleteItem(string itemName)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].name == itemName)
                {
                    items.RemoveAt(i);
                    var insertStatement = "DELETE FROM items VALUES WHERE name = @name";
                    SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);
                    insertCommand.Parameters.AddWithValue("@name", itemName);
                    sqlConnection.Open();
                    insertCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    return true;
                }
            }
            return false;
        }



        //will be remove later

        public string[] GetItemTypes()
        {
            return itemTypes;
        }
        public List<Item> GetItemsPerType(string itemType)
        {
            List<Item> _items = new List<Item>();
            foreach (Item i in items)
            {
                if (i.type == itemType)
                {
                    _items.Add(i);
                }
            }
            return _items;
        }

        public List<Item> GetItems()
        {
            return items;
        }

        public int GetItemCount()
        {
            return items.Count;
        }

        public double GetItemCost(string itemName)
        {
            foreach (Item item in items)
            {
                if (item.name == itemName)
                {
                    return item.cost;
                }
            }
            return 0; //null
        }

        public string GetItemType(string itemName)
        {
            foreach (Item item in items)
            {
                if (item.name == itemName)
                {
                    return item.type;
                }
            }
            return null;
        }
    }
}
