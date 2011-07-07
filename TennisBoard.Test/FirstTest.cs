using NUnit.Framework;

namespace TennisBoard.Test
{
    [TestFixture]
    public class FirstTest
    {
        [Test]
        public void CanCreateNewBoard()
        {
            TennisBoard newBoard = new TennisBoard();
            Assert.IsNotNull(newBoard);
        }

        [Test]
        public void WontDisplayBoardResultWithoutPlayerNames()
        {
            TennisBoard newBoard = new TennisBoard();
            Assert.AreNotEqual("Igor: 0 - Olaf: 0", newBoard.GetResult());
        }

        [Test]
        public void WillDisplayBoardResultWithGivenPlayerNamesAndScores()
        {
            TennisBoard newBoard = new TennisBoard("Damian", "Mati");
            Assert.AreEqual("Damian: 0 - Mati: 0", newBoard.GetResult());
        }

        [Test]
        public void WillTestThatPlayerOneScoresFirstPoint()
        {
            TennisBoard newBoard = new TennisBoard("Damian", "Mati");
            newBoard.PlayerAScores();
            Assert.AreEqual("Damian: 15 - Mati: 0", newBoard.GetResult());
        }

        [Test]
        public void WillTestThatPlayerTwoScoresFirstPoint()
        {
            TennisBoard newBoard = new TennisBoard("Damian", "Mati");
            newBoard.PlayerBScores();
            Assert.AreEqual("Damian: 0 - Mati: 15", newBoard.GetResult());
        }

        [Test]
        public void WillTestBothPlayersScore()
        {
            TennisBoard newBoard = new TennisBoard("Damian", "Mati");
            newBoard.PlayerAScores();
            newBoard.PlayerBScores();
            Assert.AreEqual("Damian: 15 - Mati: 15", newBoard.GetResult());
        }


        [Test]
        public void WillTestScore30_15()
        {
            TennisBoard newBoard = new TennisBoard("Damian", "Mati");
            newBoard.PlayerAScores();
            newBoard.PlayerAScores();
            newBoard.PlayerBScores();
            Assert.AreEqual("Damian: 30 - Mati: 15", newBoard.GetResult());
        }

        [Test]
        public void WillTestScore15_30()
        {
            TennisBoard newBoard = new TennisBoard("Damian", "Mati");
            newBoard.PlayerAScores();
            newBoard.PlayerBScores();
            newBoard.PlayerBScores();
            Assert.AreEqual("Damian: 15 - Mati: 30", newBoard.GetResult());
        }

        [Test]
        public void WillTestScore40_0()
        {
            TennisBoard newBoard = new TennisBoard("Damian", "Mati");
            newBoard.PlayerAScores();
            newBoard.PlayerAScores();
            newBoard.PlayerAScores();
            Assert.AreEqual("Damian: 40 - Mati: 0", newBoard.GetResult());
        }

        [Test]
        public void WillTestPlayerAWinsGame()
        {
            TennisBoard newBoard = new TennisBoard("Damian", "Mati");
            newBoard.PlayerAScores();
            newBoard.PlayerAScores();
            newBoard.PlayerAScores();
            newBoard.PlayerAScores();
            Assert.AreEqual("Damian Wins Game", newBoard.GetResult());
        }

        [Test]
        public void WillTestPlayerBWinsGame()
        {
            TennisBoard newBoard = new TennisBoard("Damian", "River");
            newBoard.PlayerBScores();
            newBoard.PlayerBScores();
            newBoard.PlayerBScores();
            newBoard.PlayerBScores();
            Assert.AreEqual("River Wins Game", newBoard.GetResult());
        }

        [Test]
        public void WillTestPlayersGetToDeuce()
        {
            TennisBoard newBoard = new TennisBoard("Damian", "River");
            newBoard.PlayerAScores();
            newBoard.PlayerAScores();
            newBoard.PlayerAScores();
            newBoard.PlayerBScores();
            newBoard.PlayerBScores();
            newBoard.PlayerBScores();
            Assert.AreEqual("Deuce 40 - 40", newBoard.GetResult());
        }
        [Test]
        public void WillTestPlayerBAdvantage()
        {
            TennisBoard newBoard = new TennisBoard("Damian", "River");
            newBoard.PlayerAScores();
            newBoard.PlayerAScores();
            newBoard.PlayerAScores();
            newBoard.PlayerBScores();
            newBoard.PlayerBScores();
            newBoard.PlayerBScores();
            newBoard.PlayerBScores();
            Assert.AreEqual("Advantage River", newBoard.GetResult());
        }
    }
}