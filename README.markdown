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
_points player 1_ - _points player 2_
Tied in _points_

If Player makes a point while he has 40, he wins the game, and should display: "_playername_ wins game"
If both Players have 40 points, show "Deuce"

The next consecutive Player point, show: "Advantage _playername_"
If same Player scores, show: "<playername> wins game"
But if the other Player scores, instead show again: "Advantage _playername_"

6 games makes a set
If Players are 5 games each, should go to 7 games
If Players are 6 games each, should go to Tie Break

3 sets makes the match