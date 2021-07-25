using System.Collections.Generic;
using System;
using System.Linq;

namespace cipher{
    public class Cipher{

        Dictionary<char, char> alphabet;

        public Cipher(){
            alphabet = new Dictionary<char, char>();
            populateAlphabet();
        }

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
            int a = 0;
            for(int i = 0; i < alphabet.Keys.Count ; i++){
                if(shift + i < 24){
                    char key = alphabet.ElementAt(i).Key;
                    char value = alphabet.ElementAt(i + shift).Value;
                    alphabet.Remove(key);
                    alphabet.Add(key, value);
                }
                else{
                    char key = alphabet.ElementAt(i).Key;
                    char value = alphabet.ElementAt(shift + a).Value;
                    a++;
                    alphabet.Remove(key);
                    alphabet.Add(key, value);
                }
            }
        }

        public void printTranslation(string input, int shift){
            char[] inputCharArray = input.ToUpper().ToCharArray();
            string result = "";
            knownShift(shift);
            foreach(char letter in inputCharArray){
                result += alphabet[letter];
            }
            Console.WriteLine(result);
        }
    }
}