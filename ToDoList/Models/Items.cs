using System.Collections.Generic; 
namespace ToDoList.Models
{
    public class Item
    {
        private string description;
        private static List<Item> list = new List<Item>{};

        
        public Item(string description)
        {
            this.description = description;
            list.Add(this);
            
        }
        public string getDescription()
        {
            return this.description;
        }

        public void setDescription(string new_des)
        {
            this.description = new_des;
        }

        public static List<Item> getAllItems()
        {
            return list;
        }

        public static void clearAllItems()
        {
            list.Clear();
        }

        public string toString()
        {
            return "Item description is "+this.description;
        }


    }
}








//  namespace ToDoListItem.Models
// {
//     public class Item
//     {
//         private string description;

//         public Item(string description)
//         {
//             this.description = description;
            
            
//         }
//         public string getDescription()
//         {
//             return this.description;
//         }

//         public void setDescription(string new_des)
//         {
//             this.description = new_des;
//         }

//         public string toString()
//         {
//             return "Item is  "+this.description;
//         }


//     }
// }