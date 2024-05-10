using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes
            var emperiorPenguin = new Bird();
            emperiorPenguin.CallSound = "eeeghhhh";
            emperiorPenguin.Color = "Black and white";
            emperiorPenguin.CurvedOrSraightBeak = "Straight";
            emperiorPenguin.FlyOrFlightless = "Flightless";
            emperiorPenguin.GroupName = "Colony";
            emperiorPenguin.LandOrSea = "Land";
            emperiorPenguin.MovementType = "walk";
            emperiorPenguin.PredatorOrPrey = "prey";

            Console.WriteLine($"On this episode of Animal Planet we are focusing the Emperior Penguin." +
                $"These beutiful animals are {emperiorPenguin.LandOrSea} animals who {emperiorPenguin.MovementType}." +
                $"You can see these {emperiorPenguin.Color} birds as they are together in their {emperiorPenguin.GroupName}." +
                $"These birds are {emperiorPenguin.FlyOrFlightless} and use thei {emperiorPenguin.CurvedOrSraightBeak} beak to catch fish." +
                $"You can hear these birds with their distinct {emperiorPenguin.CallSound} on {emperiorPenguin.LandOrSea}");





            var turtle = new Reptile();

            turtle.Color = "green";
            turtle.EctoOrEndo = "EctoMorph";
            turtle.EggOrNo = "Eggs";
            turtle.GroupName = "Nest";
            turtle.LandOrSea = "Semi-Aquatic";
            turtle.LegsOrNo = "Legs";
            turtle.MovementType = "walk and swim";
            turtle.ShedOrNo = "do not shed";

            Console.WriteLine($"On this very special episode of Animal Planet. We are focusing on the Turtle." +
                $"This marvelous animal is a {turtle.LandOrSea} animal that uses it {turtle.LegsOrNo} to {turtle.MovementType}." +
                $"We see here multiple turtles together called a {turtle.GroupName} while they protect their {turtle.EggOrNo}." +
                $"These beutiful animals {turtle.ShedOrNo} thier {turtle.Color} skin");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
