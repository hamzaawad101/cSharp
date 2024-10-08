
using Test;
using Test2;


class Program
{
   static void Main(string[] args) {
        Helper helper = new Helper("Alex");
        Helper helper2 = new Helper("Hamza");


        Helper.Printv2();



        helper.Print();
        helper2.Print();


        Console.WriteLine("im here2");
        return;
            const double TICKET_PRICE=9.95;
            const double TAX_RATE=0.095;
            int seatingLeft=300;
            string movieName = "The Best Movie Ever";
            string rating = "PG-13";
            int startHour = 4;
            int startMinute = 30;
            char ampm = 'P';
            int tickets;
            string response;
            double subtotal, tax, total;
            Console.WriteLine("Welcome to My Theater’s Ticketing Program.");
            Console.WriteLine("would you like to buy a ticket (y/n)");
            response=Console.ReadLine();
            while(response!="n" ){ 
                    Console.WriteLine("Today we are showing: The Best Movie Ever rated PG-13 at 4:30 PM");
                    Console.WriteLine("How many tickets (0 to end ) ? ");
                    tickets=Convert.ToInt32(Console.ReadLine());
                    if(tickets==0){     
                    break;
                    }else if(seatingLeft==0){
                    Console.WriteLine("I'm sorry. We're SOLD OUT.");
                    }else if(tickets<0){
                    Console.WriteLine("invalid number of tickets: ");

                    } else if (tickets <= seatingLeft) {
                    subtotal=tickets*TICKET_PRICE;
                    tax=TAX_RATE*subtotal;
                    total=subtotal+tax;
                    Console.WriteLine("your subtotal is "+subtotal);
                    Console.WriteLine("your tax is "+Math.Round(tax, 2));
                    Console.WriteLine("your total is "+Math.Round(total, 2));
                    seatingLeft=seatingLeft-tickets;
                    }else if(tickets > seatingLeft){
                    Console.WriteLine("sorry we can not proccess your request");
                    }

            }
      Console.WriteLine("hank you for using My Theatre’s Ticketing Program.");
    }

}
