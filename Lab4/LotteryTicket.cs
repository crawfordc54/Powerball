using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Lab4
{
    class LotteryTicket
    {
        public Collection<int> whiteBalls = new Collection<int>();
        public int redBall;
        public LotteryTicket()
        {
            Random rand = new Random();
            whiteBalls.Add(rand.Next(1, 69));
            whiteBalls.Add(rand.Next(1, 69));
            whiteBalls.Add(rand.Next(1, 69));
            whiteBalls.Add(rand.Next(1, 69));
            whiteBalls.Add(rand.Next(1, 69));

            redBall = (rand.Next(1, 26));
        }
        public Collection<int> Draw()
        {
            Random rand = new Random();
            Collection<int> winningNumbers = new Collection<int>();
            winningNumbers.Add(rand.Next(1, 69));
            winningNumbers.Add(rand.Next(1, 69));
            winningNumbers.Add(rand.Next(1, 69));
            winningNumbers.Add(rand.Next(1, 69));
            winningNumbers.Add(rand.Next(1, 69));
            winningNumbers.Add(rand.Next(1, 26));
            return winningNumbers;
        }
    }
}
