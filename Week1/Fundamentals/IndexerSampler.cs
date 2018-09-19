namespace ClassMaterial.Week1.Fundamentals
{
    public class IndexerSampler
    {
        private int[] _rooms = new int[5] {100,125,130,135,140};

        public int Length
        {
            get
            {
                return _rooms.Length;
            }
        }


        //if index is out of range, the array will throw an exception
        public int this[int index]
        {
            get{ return _rooms[index];}
            set{ _rooms[index] = value; }

        }


    }
}