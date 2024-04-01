namespace Inheritance03._31.Moduls
{
    internal class Device
    {
        bool isOpened = false;
        public double Width;
        public double Height;
        public double Weight;

        public Device(double width,double height,double weight)
        {
           
            Width=width;
            Height=height;
            Weight=weight;

        }
        

        public void OpenDevice()
        {
            if (!isOpened)
            {
                Console.WriteLine("Device opening...");
                isOpened = true;
               
            }
            else
            {
                Console.WriteLine("Device already opened");
               
            }
              


        }
        public void CloseDevice()
        {
            if (isOpened)
            {
                Console.WriteLine("Device closing...");
                isOpened = false;
                
            }
            else
            {
                Console.WriteLine("Device already closed");
            }
        }
    }
}
