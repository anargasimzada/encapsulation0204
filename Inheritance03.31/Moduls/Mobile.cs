namespace Inheritance03._31.Moduls
{
    internal class Mobile:Device
    {
        public string[] SimCards;
        public int Min;
        public Mobile(int simCardCount,double width,double height ,double weight ) : base( width,height,weight)
        {
           if (simCardCount <1 || simCardCount> 2 )
            {
                
            }
            SimCards=new string[simCardCount];
        }

        public void SimCardCount(int min,int max) 
        {
            min = 1;
            max = 2;

        }
        
        public void AddNumber(int index, string number)
        {
            if (index < 0 || index >= SimCards.Length)
            {
                Console.WriteLine();
            }
            SimCards[index] = number;
        }
        public void RemoveNumber(int index)
        {
            if ( index >= SimCards.Length)
            {

            }
            SimCards[index] = null;
        }
        public void GetNumbers()
        {
        }
    }
}
