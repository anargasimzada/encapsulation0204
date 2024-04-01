using Inheritance03._31.Moduls;

namespace Inheritance03._31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Device dev = new Device(14, 23.5,45) ;
           dev.OpenDevice();
            Mobile mob = new Mobile(50,34,23,67);
            mob.AddNumber(0, "0708585565");


        }
    }
}
