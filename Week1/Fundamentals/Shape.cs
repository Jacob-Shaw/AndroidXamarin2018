namespace ClassMaterial.Week1.Fundamentals
{
    public abstract class Shape : IMyInterface
    {
        public abstract int Sides { set; get;}

        public virtual double Area() { return 2.2;}

        public abstract void MyCoolMethod();

        public void CalculateArea(int length, int height) {}

    }
}