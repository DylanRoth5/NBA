using NBA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA.Controllers
{
    public static class ISpot
    {
        public static Spot GetSpotByPosition(Panel panel, int Row, int Column)
        {
            var spot = new Spot();
            foreach (Spot s in panel.Controls)
            {
                if (s.Row == Row && s.Column == Column)
                {
                    spot = s; break;
                }
            }
            return spot;
        }
    }
}
