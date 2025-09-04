//===================================Note==================================




//class provides blueprint 
// instances posses those blueprint.
// an object is an instance of class.
// an object poosess the properties defined by the class.

// car design -- blueprint - provided by the class . 
// us blueprint s bni hue actual car is our actual car. or an object.

//class - doesn't look memory (its just a blueprint)
//object -- jo ki ek actual instace h (memory m space leta h). kyuki ye khudki kuch value rakhta h . 
// Note - every instance does holds some values.


// Analogy 
// class - blueprint of making a cake.
// this class will have some properties / ingrediants - jaise (floor,vinegar, baking soda) are the properties.
// this class willl have some method -- state --- 1.Baking 2. serving 





using C__day4;
using System;

namespace C__day4
{

    public class cakeBluePrint
    {
        public string floor { get; set; } = string.Empty;


        public void Action()
        {
            Console.WriteLine($"Baking cake..using {floor} and  baking is in progress");
        }
    }
}
internal class Program
    {
        static void Main(string[] args)
        {
        

        cakeBluePrint Actualcake = new cakeBluePrint();
         Actualcake.floor = "Maida";
         Actualcake.Action();

        cakeBluePrint second_cake = new cakeBluePrint();
        second_cake.floor = "Rice";
        second_cake.Action();


        }
    }


