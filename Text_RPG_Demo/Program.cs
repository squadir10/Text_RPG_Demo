// See https://aka.ms/new-console-template for more information
// Author: Sabrina Quadir
// Purpose: Seeing if I can make a text adventure game in preparation for the final project
//which will be a combination of C# and Unity 


namespace RPG_Game {
    internal class program {
        public static void print(string text, int text_speed = 40) {

            foreach (char c in text) {
                Console.Write(c);
                System.Threading.Thread.Sleep(text_speed);
            }
            Console.WriteLine();
        }
        
        public static void Main(string[] args) {
            
            Console.Title = "Window";
            print("Hello... there", 100);
            print("This is a test to see if the animation works");
            print("bruh idk I hope this works", 75);


        }
        
    }
   
}
