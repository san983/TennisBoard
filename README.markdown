#TDD Coding Dojo

Hi there,

Up to now, this is the result of our first Coding Dojo session about TDD done in BA Accenture offices on July 6th 2011

Facilitated by 
[Fernando](http://www.twitter.com/fdibartolo), 
[Gaston](http://www.twitter.com/gastonalgaze), 
[Santos](http://www.twitter.com/san983)

##Tennis Board
Two Players with their name

Player points can be 0-15-30-40

Board should display:
<points player 1> - <points player 2>
Tied in <points>

If Player makes a point while he has 40, he wins the game, and should display: "<playername> wins game"
If both Players have 40 points, show "Deuce"

The next consecutive Player point, show: "Advantage <playername>"
If same Player scores, show: "<playername> wins game"
But if the other Player scores, instead show again: "Advantage <playername>"

6 games makes a set
If Players are 5 games each, should go to 7 games
If Players are 6 games each, should go to Tie Break

3 sets makes the match