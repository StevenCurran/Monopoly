using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trolopoloy
{
    class StationSquare : PropertySquare
    {
        public StationSquare()
        {
            Console.WriteLine("New station square");
        }
        public override void PerformAction(Player inhabitant)
        {
            throw new NotImplementedException();
        }

        public override int CalculateRent()
        {
            throw new NotImplementedException();
        }

        public override bool AllGroupOwned()
        {
            throw new NotImplementedException();
        }

        public override void Mortgage()
        {
            throw new NotImplementedException();
        }

        public override void Unmortgage()
        {
            throw new NotImplementedException();
        }
    }
}
