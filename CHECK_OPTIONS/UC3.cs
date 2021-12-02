
namespace SnakeLadder
{
    class SnakeLadder
    {
        public static void Main(string[] args)
        {

            Throw myObj = new Throw();
            myObj.Roll1();
            int diceroll = myObj.Rollingdie;

            Random random = new Random();
            int option = random.Next(1, 4);
            Console.WriteLine("Checking Options :" + option);
        
            
            switch(option)

            {   
              case 1:

                Console.WriteLine("NO PLAY / SAME POSITION");
                  
                    break;
               case 2:
           
                Console.WriteLine("LADDER / MOVES AHEAD POSITIONS:" + diceroll);
                    
                    break;
           
                case 3:
        
                Console.WriteLine("SNAKE / MOVES BEHIND POSTIONS:" + diceroll);
                    
                    break;
            }




        }
    }
}
          
