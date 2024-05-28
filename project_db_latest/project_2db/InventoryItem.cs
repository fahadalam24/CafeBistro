using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2db
{
    public class InventoryItem
    {
        public int InventoryID { get; set; }
        public int MenuItemID { get; set; }
        public string IngredientName { get; set; }
        public int Quantity { get; set; }
        public int Threshold { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
