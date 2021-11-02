# Powerball
## Purpose
The purpose of this lab is to better familiarise yourself with C# collections and how they can be used.

## Objective
The [Powerball](https://en.wikipedia.org/wiki/Powerball) is a multi-state lottery game that involves drawing random numbers with players that have purchased tickets that also contain random numbers. The lottery draw consists of using physical individually numbered ping-pong style balls in a machine that outputs them at random. These balls are divided into two sets, white balls and red balls, which are drawn indepndently. There are 69 sequentially numbered white balls, and 26 sequentially numbered red balls. The drawing occurs on live TV/Internet streaming twice weekly, after which players check their tickets. The tickets themselves that are purchased by players are either randonly generated via computer, or specifically selected by the player, also separated into white ball numbers and a red ball number. While there are payouts for partial matches, the overall advertised jackpot is won by the person whose ticket contains all of the matched white ball numbers and the red ball number. Because the odds of winning are extremely low, the lottery process will repeat several times until a winner is declared, sometimes over a period of months.

In this lab, we will create a simulation of a Powerball lottery system. This system will differ from the actual Powerball process because we will be using the same randonly generated ticket numbers over and over again, until there is a match.

 * Create a object that represents a lottery ticket. It must store a single pick of five white balls and one red ball.
   - Store the white ball selection portion of your Powerball ticket by creating an integer collection of five elements and populate them randomly with any number between 1 and 69
   - Store the red ball selection portion of your Powerball ticket by creating an integer and populating it randomly with any number between 1 and 26
 * Implement a Draw method that will select the winning numbers 
 * Keep drawing for as many times as it takes to hit the winning combination (meanining all white and red numbers drawn match your ticket numbers).
 * When you draw the winning combination, display back to the user:
   - Your ticket's white ball numbers
   - Your ticket's red ball number
   - The number of tries it took to get the winning combination (keep in mind that while computers don't produce fully random numbers, the number of tries it will take will likely be close to the actual Powerball odds, which are 1 in 292,201,338)
