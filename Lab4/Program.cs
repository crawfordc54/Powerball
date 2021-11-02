using System;
using System.Collections.ObjectModel;

namespace Lab4
{
	class Program
	{
		static void Main(string[] args)
		{
			LotteryTicket ticket = new LotteryTicket();
			int numOfChecks = 0;
			Boolean matched = false;
			Collection <int> winningNumbers;
			while(!matched)
            {
				winningNumbers = ticket.Draw();
				numOfChecks++;
				if (ticket.whiteBalls[0] == winningNumbers[0] &&
				   ticket.whiteBalls[1] == winningNumbers[1] &&
				   ticket.whiteBalls[2] == winningNumbers[2] &&
				   ticket.whiteBalls[3] == winningNumbers[3] &&
				   ticket.whiteBalls[4] == winningNumbers[4] &&
				   ticket.redBall == winningNumbers[5])
                {
					matched = true;
                }
			}
			Console.WriteLine("White Ball Numbers: " + ticket.whiteBalls[0] + " " + ticket.whiteBalls[1] + " " + ticket.whiteBalls[2] + " " + ticket.whiteBalls[3] + " " + ticket.whiteBalls[4]);
			Console.WriteLine("Red Ball Number: " + ticket.redBall);
			Console.WriteLine("Number of Tries to Win: " + numOfChecks);
		}
	}
}

