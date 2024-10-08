/* file:Windturbine.cs
author Hamza Awad
This program asks users for name platecapacity and
passes them to diffrent functions to calculate
how much power the windturbine generated in watts,kilowatts,or megawatts using the formula w=g(〖s/25)〗^3.
The program will give error messages if the numbers entered do not meet requirments.
*/


class Program{
    /*
function name:getNameplateCapacity
this function gets the users input for nameplate and
if it is a valid input it returns it as true otherwise it returns falls.

*/
static bool getNameplateCapacity(ref double nameplate){
  Console.WriteLine("Please enter the generator’s nameplate capacity in"); 
  Console.WriteLine("watts (0 to end):");
  nameplate = Convert.ToDouble(Console.ReadLine());
    if (nameplate == 0){
    return false;
    }
    else{
    return true;
  }
}
/*
function checkNameplateCapacity gets the nameplate and checks if it falls under the right conditions and if it is in the correct number range
if it does not it returns it false
*/

static bool checkNameplateCapacity (double nameplate)
{

       if (nameplate > 300 && nameplate < 8000000){
        return true;
       }
    else if (nameplate < 0){
         Console.WriteLine("Nameplate capacity must be greater than"); 
         Console.WriteLine("zero");
        }
	else if ( nameplate < 300 ){
           Console.WriteLine("Nameplate capacity must be between 300 and"); 
		   Console.WriteLine("8000000 watts");
        }
	else if ( nameplate > 8000000){
           Console.WriteLine("Nameplate capacity must be less than");
           Console.WriteLine("8000000 watts");

        }
       return false;


}
/*
funcion  getAndCheckWindSpeed gets and checks if the wind speed entered by the user is in between the correct range
and passes it to calcWattsGenerated
*/
static bool getAndCheckWindSpeed( ref double speed){

        Console.WriteLine("Please enter today’s average wind speed in"); 
        Console.WriteLine("miles per hour: ");
        speed = Convert.ToDouble(Console.ReadLine());
         if (speed >6 && speed <= 55){
         return true;
         }
	else if (speed < 0 ){
            Console.WriteLine(" Wind speed must be greater than"); 
			Console.WriteLine("zero.");
        }
         else if (0 <= speed && speed < 6 ){
         Console.WriteLine("Wind speed is not sufficient to power the");
		 Console.WriteLine("generator.");
        }
	else if (speed > 55){
        Console.WriteLine("Wind speed too high.");
        Console.WriteLine("turbine is not operating.");
        }
       return false;
}
/*
function calcWattsGenerated gets nameplate and speed and uses a formula to calculate watts
and returns watts
*/

static double calcWattsGenerated(double nameplate, double speed){
  double watts = Math.Pow((speed / 25.0), 3) * nameplate;
return (watts);

}

/* function printWattsGenerated prints out watts calculated to the user
in watts kilowatts or megawatts depending on the amount
*/
static void printWattsGenerated( double watts ){
        if (watts >= 1000000) {
            Console.WriteLine("The wind turbine generated " +Math.Round(watts / 1000000,2) + " Megawatts today.");
        } else if (watts >= 1000) {
            Console.WriteLine("The wind turbine generated " + Math.Round(watts / 1000,2) + " Kilowatts today.");
        } else {
            Console.WriteLine("The wind turbine generated " +Math.Round(watts, 2)+" Watts today.");
        }
}

   static void Main(string[] args) {
    
        double nameplateCapacity=0;;// maxwatts can be generated per          
        //day by windmill
        double windSpeed=0; // average wind speed in mph per day
        bool goodInput; // maxWatts or average windspeed error
        double watts; // watts generated in one particular day
        // say hello and get maxWatts for the first time
        Console.WriteLine("Welcome to the Wind Turbine Calculator. ");
         while (getNameplateCapacity(ref nameplateCapacity)) {
            if (checkNameplateCapacity(nameplateCapacity)) {
                goodInput = getAndCheckWindSpeed(ref windSpeed);
                if (goodInput) {
                    watts = calcWattsGenerated(nameplateCapacity, windSpeed);
                    printWattsGenerated(watts);
                }
            }
        }
        // end while maxWatts < 0

            Console.WriteLine("Thank you for using the Wind Turbine"); 
            Console.WriteLine("Calculator.");
        }
}