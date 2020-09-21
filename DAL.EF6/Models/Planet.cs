using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF6.Models.Base;

namespace DAL.EF6.Models
{
    public class Planet: Item
    {
        public Galaxy Galaxy { get; set; }
    }
}
