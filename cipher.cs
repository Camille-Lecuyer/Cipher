using System.Collections.Generic;

namespace cipher{
    public class Cipher{

        Dictionary<char, char> alphabet = new Dictionary<char, char>();

        void populateAlphabet(){
            alphabet.Add('A', 'A');
            alphabet.Add('B', 'B');
            alphabet.Add('C', 'C');
            alphabet.Add('D', 'D');            
            alphabet.Add('E', 'E');
            alphabet.Add('F', 'F');            
            alphabet.Add('G', 'G');
            alphabet.Add('H', 'H');            
            alphabet.Add('I', 'I');
            alphabet.Add('J', 'J');            
            alphabet.Add('K', 'K');
            alphabet.Add('L', 'L');            
            alphabet.Add('M', 'M');
            alphabet.Add('N', 'N');           
            alphabet.Add('O', 'O');
            alphabet.Add('P', 'P');            
            alphabet.Add('Q', 'Q');
            alphabet.Add('R', 'R');            
            alphabet.Add('S', 'S');
            alphabet.Add('T', 'T');
            alphabet.Add('U', 'U');
            alphabet.Add('V', 'V');            
            alphabet.Add('W', 'W');
            alphabet.Add('X', 'X');
            alphabet.Add('Y', 'Y');
            alphabet.Add('Z', 'Z');
        }

        void bruteForce(){

        }

        void knownShift(int shift){
            foreach(char letter in alphabet.Keys){
                
            }
        }

    }
}