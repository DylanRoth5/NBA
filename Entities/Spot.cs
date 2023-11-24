using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA.Entities
{
    public class Spot : Button
    {
        public int Id { get; set; }
        public int Row {  get; set; }
        public int Column { get; set; }
        public bool IsBombed { get; set; }
        public int MapId { get; set; }
        public int? Ship {  get; set; }
        public Spot() { }
    }
}
