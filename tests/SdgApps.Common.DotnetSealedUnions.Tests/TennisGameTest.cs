// <copyright file="TennisGameTest.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.Common.DotnetSealedUnions.Tests
{
    /// <summary>
    /// Tests sealed unions using tennis kata.
    /// </summary>
    public class TennisGameTest
    {
        /// <summary>
        /// Runs a tennis kata.
        /// </summary>
        [Fact]
        public void TestTennis()
        {
            Score start = Score.Points(PlayerPoints.Zero(), PlayerPoints.Zero());
            Score fifteenZero = UpdateAndPrintScore(start, Player.One());
            Score thirtyZero = UpdateAndPrintScore(fifteenZero, Player.One());
            Score fortyZero = UpdateAndPrintScore(thirtyZero, Player.One());
            Assert.Equal(
                Score.Points(PlayerPoints.Forty(), PlayerPoints.Zero()).Score,
                fortyZero.Score);
            Score fortyThirty = UpdateAndPrintScore(ScorePoint(fortyZero, Player.Two()), Player.Two());
            Assert.Equal(
                Score.Points(PlayerPoints.Forty(), PlayerPoints.Thirty()).Score,
                fortyThirty.Score);
            Score deuce1 = UpdateAndPrintScore(fortyThirty, Player.Two());
            Assert.Equal(Score.Deuce().Score, deuce1.Score);
            Score advantageP1 = UpdateAndPrintScore(deuce1, Player.One());
            Assert.Equal(Score.Advantage(Advantage.One()).Score, advantageP1.Score);
            Score gameP1 = UpdateAndPrintScore(advantageP1, Player.One());
            Assert.Equal(Score.Game(Game.One()).Score, gameP1.Score);
            Score zeroFifteen = UpdateAndPrintScore(gameP1, Player.Two());
            Assert.Equal(
                Score.Points(PlayerPoints.Zero(), PlayerPoints.Fifteen()).Score,
                zeroFifteen.Score);
            Score deuce2 = UpdateAndPrintScore(advantageP1, Player.Two());
            Assert.Equal(Score.Deuce().Score, deuce2.Score);
        }

        private Score UpdateAndPrintScore(Score oldScore, Player player)
        {
            Score newScore = ScorePoint(oldScore, player);
            Console.WriteLine(Score.GetString(oldScore) + " + " + Player.GetString(player) + " -> "
                + Score.GetString(newScore));
            return newScore;
        }
    }
}
