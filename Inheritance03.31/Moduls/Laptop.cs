namespace Inheritance03._31.Moduls
{
    internal class Laptop:Device
    {
        public int PortCount;

        public Laptop(int portcount, double width, double height, double weight) : base(width, height, weight)
        {
            PortCount = portcount;
        }
    }
}
