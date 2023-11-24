using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA.Entities
{
    internal class Match
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int PlayerMapId { get; set; }
        public int PcMapId { get; set; }
        public string Name { get; set; }
        public Match () { }
    }
}
