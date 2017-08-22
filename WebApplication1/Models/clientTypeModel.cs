using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class clientType
    {
        public int clientTypeId { get; set;}
        public string name { get; set; }
    }

    public class clientTypes
    {
        public static IEnumerable<clientType> Types = new List<clientType> {
            new clientType {
            clientTypeId = 0,
            name = "Customer"
        },
            new clientType {
            clientTypeId = 1,
            name = "Supplier"
        }
        };
    }
    
}