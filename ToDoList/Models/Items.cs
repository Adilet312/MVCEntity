using System.Collections.Generic; 
using MySql.Data.MySqlClient;

namespace ToDoList.Models
{
    public class Item
    {
        public string Description { get; set; }
        public int ItemId { get; set; }

        // public Item()
        // {

        // }

        // public Item(string Description)
        // {
        //     this.Description = Description;  
        // }
        public Item(string Description, int ItemId)
        {
            this.Description = Description;
            this.ItemId = ItemId;
        }

        //  public string getDescription()
        // {
        //     return this.Description;
        // }

        // public void  setDescription(string new_des)
        // {
        //     this.Description = new_des;
        // }

        // public string toString()
        // {
        //     return "Item Description is "+this.Description;
        // }

        // public int getItemId()
        // {
        //     return this.ItemId;
        // }

        // public void setItemId(int newItemId)
        // {
        //     this.ItemId = newItemId;
        // }

        

    }
}




 // public overrItemIde bool Equals(System.Object otherItem)
    // {
    //   if (!(otherItem is Item))
    //   {
    //     return false;
    //   }
    //   else
    //   {
    //     Item newItem = (Item) otherItem;
    //     bool ItemIdEquality = (this.ItemId == newItem.ItemId);
    //     bool DescriptionEquality = (this.getDescription() == newItem.getDescription());
    //     return (ItemIdEquality && DescriptionEquality);
    //   }
    // }



 // public static List<Item> getAllItems()
        // {
        //     List<Item> allItems = new List<Item> { };
        //     MySqlConnection conn = DB.Connection();
        //     conn.Open();
        //     MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
        //     cmd.CommandText = @"SELECT * FROM items;";
        //     MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
        //     while (rdr.Read())
        //     {
        //         int itemItemId = rdr.GetInt32(0);
        //         string itemDescription = rdr.GetString(1);
        //         Item newItem = new Item(itemDescription, itemItemId);
        //         allItems.Add(newItem);
        //     }
        //     conn.Close();
        //     if (conn != null)
        //     {
        //         conn.Dispose();
        //     }
        //     return allItems;
        // }



  // public static voItemId clearAllItems()
        // {
        //     MySqlConnection conn = DB.Connection();
        //     conn.Open();
        //     MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
        //     cmd.CommandText = @"DELETE FROM items;";
        //     cmd.ExecuteNonQuery();
        //     conn.Close();
        //     if (conn != null)
        //     {
        //     conn.Dispose();
        //     }
        // }


        // public static Item Find(int searchItemId)
        // {
        //     return null;
        // }

        // public static Item Find(int ItemId)
        // {
        //     // We open a connection.
        //     MySqlConnection conn = DB.Connection();
        //     conn.Open();

        //     // We create MySqlCommand object and add a query to its CommandText property. We always need to do this to make a SQL query.
        //     var cmd = conn.CreateCommand() as MySqlCommand;
        //     cmd.CommandText = @"SELECT * FROM `items` WHERE ItemId = @thisItemId;";

        //     // We have to use parameter placeholders (@thisItemId) and a `MySqlParameter` object to prevent SQL injection attacks. This is only necessary when we are passing parameters into a query. We also dItemId this with our Save() method.
        //     MySqlParameter thisItemId = new MySqlParameter();
        //     thisItemId.ParameterName = "@thisItemId";
        //     thisItemId.Value = ItemId;
        //     cmd.Parameters.Add(thisItemId);

        //     // We use the ExecuteReader() method because our query will be returning results and we need this method to read these results. This is in contrast to the ExecuteNonQuery() method, which we use for SQL commands that don't return results like our Save() method.
        //     var rdr = cmd.ExecuteReader() as MySqlDataReader;
        //     int itemItemId = 0;
        //     string itemDescription = "";
        //     while (rdr.Read())
        //     {
        //         itemItemId = rdr.GetInt32(0);
        //         itemDescription = rdr.GetString(1);
        //     }
        //     Item foundItem= new Item(itemDescription, itemItemId);

        //     // We close the connection.
        //     conn.Close();
        //     if (conn != null)
        //     {
        //         conn.Dispose();
        //     }
        //     return foundItem;
        // }
        //  public voItemId Save()
        // {
        //       MySqlConnection conn = DB.Connection();
        //         conn.Open();
        //         var cmd = conn.CreateCommand() as MySqlCommand;

        //         // Begin new code

        //         cmd.CommandText = @"INSERT INTO items (Description) VALUES (@ItemDescription);";
        //         MySqlParameter Description = new MySqlParameter();
        //         Description.ParameterName = "@ItemDescription";
        //         Description.Value = this.getDescription();
        //         cmd.Parameters.Add(Description);    
        //         cmd.ExecuteNonQuery();
        //         setItemId((int) cmd.LastInsertedItemId);

        //         // End new code

        //         conn.Close();
        //         if (conn != null)
        //         {
        //             conn.Dispose();
        //         }
        // }


//  namespace ToDoListItem.Models
// {
//     public class Item
//     {
//         private string Description;

//         public Item(string Description)
//         {
//             this.Description = Description;
            
            
//         }
//         public string getDescription()
//         {
//             return this.Description;
//         }

//         public voItemId setDescription(string new_des)
//         {
//             this.Description = new_des;
//         }

//         public string toString()
//         {
//             return "Item is  "+this.Description;
//         }


//     }
// }