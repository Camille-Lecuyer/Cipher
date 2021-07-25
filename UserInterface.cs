using System;

namespace cipher{

    public class UserInterface{
        public int askingShift(){
            int shift;
            Console.WriteLine("Enter the shift:");
            shift = Convert.ToInt32(Console.ReadLine());
            if(shift > 0 && shift < 26){
                return shift;
            }
            return 0;
        }

        public string askingInput(){
            string input;
            Console.WriteLine("Enter the message to code:");
            input = Console.ReadLine();
            if(!input.Equals("") && input != null){
                return input;
            }
            return null;
        }
    }
}