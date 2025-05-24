using CoffeeShopCommon;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop_DataLayer
{
    public class ItemProcess_SQLServer : IItemProcess
    {
        protected List<Item> items;
        protected string[] itemTypes = { "Beverage", "Snack" };

        static string connectionString
        = "Data Source =DESKTOP-55DMAU9\\pc; Initial Catalog = items; Integrated Security = False; TrustServerCertificate=True;";

        static SqlConnection sqlConnection;

         void InitializeData()
        {
            string selectStatement = "SELECT AccountNumber, AccountName, Bank, PIN, Balance FROM BankDetails";

            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();
            while (reader.Read())
            {
                //deserialize

                Item item = new Item();
                item.name = reader["name"].ToString();
                item.cost = Convert.ToDouble(reader["cost"].ToString());
                item.soldCount = Convert.ToInt32(reader["soldCount"].ToString());
                item.type = reader["type"].ToString();
                items.Add(item);
            }

            sqlConnection.Close();
        }


        public ItemProcess_SQLServer()
        {
            sqlConnection = new SqlConnection(connectionString);
            InitializeData();
        }
        public void AddItem(string itemName, double itemCost, string itemType)
        {
            var insertStatement = "INSERT INTO BankDetails VALUES (@name, @cost, @soldCount, @type)";
            Item item = new Item(itemName, itemCost, itemType);
            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@name", item.name);
            insertCommand.Parameters.AddWithValue("@cost", item.cost);
            insertCommand.Parameters.AddWithValue("@soldCount", item.soldCount);
            insertCommand.Parameters.AddWithValue("@type", item.type);
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


        //Delete

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
