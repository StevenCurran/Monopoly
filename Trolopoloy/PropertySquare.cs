using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trolopoloy
{
    abstract class PropertySquare : Square
    {
        private enum Groups
        {
            Brown,
            Blue,
            Pink,
            Orange,
            Red,
            Yellow,
            Green,
            Purple
        } ;

        private int price;
        private Groups group;
        private Boolean mortgaged;
        private Board.TraderID owner;

        public Board.TraderID Owner
        {
            set
            {
                owner = value;
            }

            get
            {
                return owner;
            }
        }

        /*
        public override void PerformAction()
        {
            throw new NotImplementedException();
        }
         */

        public abstract int CalculateRent();

        public abstract Boolean AllGroupOwned();

        public abstract void Mortgage();

        public abstract void Unmortgage();


    }
}
