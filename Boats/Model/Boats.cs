using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatsProject
{
    public partial class Boats
    {
        public override string ToString()
        {
            return string.Format(Title + " " + BoatTypes + " " + Colors + " " + WoodTypes + " " + BasePrice);
        }
    }
}
