using System;

namespace AnimalSound
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            string animal = "", sound;

            //Asking the user what animal sound they would like to hear and outputting the sound of the animal. 
            Console.WriteLine("What animal sound would you like to here?");
            animal = Console.ReadLine();
            sound = Speak(animal);
            if (sound == "")
            {
                Console.WriteLine($"The {animal} sound could not be found.");
            }
            else
            {
                Console.WriteLine($"The {animal} makes a sound like {sound}.");
            }
        }

        /// <summary>
        /// The method takes a string from the main class of the animal and find the right animal sound
        /// </summary>
        /// <param name="animal"></param>
        /// <returns>
        /// The method returns the animal sound
        /// </returns>
        static string Speak(string animal)
        {
            switch (animal.ToLower())
            {
                case "dog":
                    return "woof";
                case "monkey":
                    return "oooohhhaaaaa";
                case "goat":
                    return "bbblleeeaaattt";
                case "cat":
                    return "mmmmeeeeeeooowww";
                case "bird":
                    return "ccccccaaaaaawwwww";
                case "snake":
                    return "ssssssssssss";
                case "donkey":
                    return "hheeeeehaaaaaw";
                case "sheep":
                    return "bbbaaaaaaaa";
                case "pig":
                    return "oooooooiiiinnkkk";
                case "cow":
                    return "mmmmmmoooooo";
                case "chicken":
                    return "cccclllluuccckk"; 
                default:
                    return "";
            }
        }
    }
}
