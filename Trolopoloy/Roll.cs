namespace Trolopoloy
{
    public class Roll
    {
        public Roll(int move, bool dub)
        {
            this.move = move;
            this.dub = dub;
        }

        public int Move
        {
            get
            {
                return move;
            }
        }

        public bool Double
        {
            get
            {
                return dub;
            }
        }

        private int move;
        private bool dub;
    }
}