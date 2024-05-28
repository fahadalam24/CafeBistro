using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2db
{
    public class MenuItem
    {
       
            public int MenuItemID { get; set; }
            public string ItemName { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
            public string Category { get; set; }
            // Add other properties as needed
        
    }
}
