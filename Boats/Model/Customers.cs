using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatsProject
{
    public partial class Customers
    {
        public override string ToString()
        {
            return string.Format(LName + FName + Patronymic + " " + DateOfBirth);
        }
    }
}
