using System;

namespace cs_rps
{
    class Program
  {
        static void Main(string[] args)
        {
            bool  _playing = true;
            string _randoPlay = ""; 
            int _wins = 0;
            int _losses = 0;
            int _ties = 0;
            Console.WriteLine("  Lets Play Rock Paper Scissors ...");
            while(_playing){
                Console.WriteLine($@"
    Please Select rock (r)  paper(p) scissors(s)  quit(q)
    Wins: {_wins}   Losses: {_losses}   Ties: {_ties} 
    ");
            string inputLine = Console.ReadLine();
            int r =  new Random().Next(120);
            if(r <= 40)
            {
                _randoPlay  = "rock";
                } else if(r <= 80 )
                {
                    _randoPlay = "paper";
                    } else 
                    {
                        _randoPlay = "scissors";
                        }
                            Console.WriteLine($"  I choose .... {_randoPlay}");     
            if(inputLine == _randoPlay ){
                Console.WriteLine("Tie Game ......");
                _ties++;
            } else if (inputLine.ToLower() == "rock" || inputLine.ToLower() == "r" ){
                if(_randoPlay == "paper"){
                Console.WriteLine("You Loose Game ...... Paper beats Rock....");
                _losses++;
                } else 
                {
                   Console.WriteLine("You Win .... Rock beats Scissors");
                   _wins++;
                }
            } else if(inputLine.ToLower() == "paper" || inputLine.ToLower() == "p"){
                if(_randoPlay == "scissors"){
                Console.WriteLine("You Loose Game ...... Scissors beat Paper....");
                _losses++;
                }else 
                {
                   Console.WriteLine("You Win .... Paper beats Rock");
                   _wins++;
                }
            } else if (inputLine.ToLower() == "scissors" || inputLine.ToLower() == "s") {
                if(_randoPlay == "rock"){
                Console.WriteLine("You Loose Game ...... Rock beats Scissors....");
                _losses++; 
                } else 
                {
                   Console.WriteLine("You Win .... Scissors beats Paper");
                   _wins++;
                }
            } else if (inputLine.ToLower() == "quit" || inputLine == "q" ) 
            {
                Console.WriteLine("Quitter ..");
                _playing = false;
            } else {
                Console.WriteLine( "Bad Input");
            }
            Console.Clear();
        }
    }
  }
}
