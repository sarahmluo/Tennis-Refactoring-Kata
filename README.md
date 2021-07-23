# Tennis Refactoring Kata

## Purpose and guidelines

- We use this kata as a basis for evaluating your technical skills, decision making and further discussion.  
- Only care about the C# version of the kata.  We haven't prepared the TypeScript or JavaScript versions.
- We'll talk about why you made the changes you did, how you did them, and just generally talk about other development principles using this code-base as our common ground.  
- We're primarily looking for code refactoring. The overall behavior of the code should not change - it should always pass the existing tests. However, you are permitted to change the public interface if you deem it necessary.
- Fork this repo and make your changes there.  We want to be able to see the resulting commits and code (ideally during your on-site interview).
- While we want you to be proud of what you do, **please** - Target spending about an hour, up to 3 hours on this, and don't stress out. 😊

## Goal
The aim of this Kata is to refactor the code into a state that you would be happy leaving for your peers (or your future self!) to work on.  
As it stands, this scoring code was developed as a 'temporary' solution, that quickly became permanent.  Now that the organization has realized this, you have been tasked with refactoring the code!

## Considerations

* The resulting code should reflect something you think is nearly production-ready, and something you're happy to attach your name to.
* We're looking for incremental improvements, so commit as often as you can. 
* Use the tests to provide feedback on your changes.
* Ask yourself:
  * Is the code readable?
  * Does the code express intent well?
  * Is there any obscure logic that could be simplified?

<hr>

### Tennis Rules

Tennis has a rather quirky scoring system, and to newcomers it can be a little difficult to keep track of. The tennis society has contracted you to build a scoreboard to display the current score during tennis games. 

You can read more about Tennis scores [here](http://en.wikipedia.org/wiki/Tennis#Scoring) which is summarized below:

1. A game is won by the first player to have won at least four points in total and at least two points more than the opponent.
2. The running score of each game is described in a manner peculiar to tennis: scores from zero to three points are described as "Love", "Fifteen", "Thirty", and "Forty" respectively.
3. If at least three points have been scored by each player, and the scores are equal, the score is "Deuce".
4. If at least three points have been scored by each side and a player has one more point than his opponent, the score of the game is "Advantage" for the player in the lead.

##### Thanks to the original [developer(s)](https://github.com/emilybache/Tennis-Refactoring-Kata), and [7digital](https://github.com/7digital/Tennis-Refactoring-Kata)
