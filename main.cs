using System;

namespace cipher{
    public static class Program{
        public static void Main(String[] args){
            Cipher cipher = new Cipher();
            UserInterface userInterface = new UserInterface();
            int shift = userInterface.askingShift();
            while(shift == 0){
                Console.WriteLine("Invalid input");
                shift = userInterface.askingShift();
            }
            string text = userInterface.askingInput();
            while(text == null){
                Console.WriteLine("Invalid input");
                text = userInterface.askingInput();
            }
            Console.WriteLine("The coded message is: ");
            cipher.printTranslation(text, shift);
        }        
    }
}