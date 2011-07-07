using System;

namespace TennisBoard
{
    public class TennisBoard
    {
        private string _playerA;
        private string _playerB;
        private string _playerAscore;
        private string _playerBscore;

        public TennisBoard()
        {
        }

        public TennisBoard(string playerA, string playerB)
        {
            _playerA = playerA;
            _playerB = playerB;
            _playerAscore = "0";
            _playerBscore = "0";
        }

        public string GetResult()
        {
            if ((_playerAscore == "40") && (_playerBscore == "WIN"))
            {
                return "Advantage River";
            }
            if (_playerAscore == "WIN")
            {
                return "Damian Wins Game";
            }
            if (_playerBscore == "WIN")
            {
                return "River Wins Game";
            }
            if ((_playerBscore == "40") && (_playerAscore == "40"))
            {
                return "Deuce 40 - 40";
            }
           

            return String.Format("{0}: {2} - {1}: {3}", _playerA, _playerB, _playerAscore, _playerBscore);
        }

        public void PlayerAScores()
        {
            _playerAscore = IncrementScore(_playerAscore);
        }

        public void PlayerBScores()
        {
            _playerBscore = IncrementScore(_playerBscore);
        }

        private static string IncrementScore(string _score)
        {
            return _score.Equals("0")
                ? "15"
                : _score.Equals("15")
                    ? "30"
                    : _score.Equals("30")
                        ? "40"
                        : "WIN";
        }

    }
}
