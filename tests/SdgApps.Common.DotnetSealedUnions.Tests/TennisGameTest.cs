// <copyright file="TennisGameTest.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.Common.DotnetSealedUnions.Tests;

using static SdgApps.Common.DotnetSealedUnions.Tests.TennisGame;

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
        IScore start = IScore.Points(IPlayerPoints.Zero(), IPlayerPoints.Zero());
        IScore fifteenZero = UpdateAndPrintScore(start, IPlayer.One());
        IScore thirtyZero = UpdateAndPrintScore(fifteenZero, IPlayer.One());
        IScore fortyZero = UpdateAndPrintScore(thirtyZero, IPlayer.One());
        Assert.Equal(
            IScore.Points(IPlayerPoints.Forty(), IPlayerPoints.Zero()).Score,
            fortyZero.Score);
        IScore fortyThirty = UpdateAndPrintScore(ScorePoint(fortyZero, IPlayer.Two()), IPlayer.Two());
        Assert.Equal(
            IScore.Points(IPlayerPoints.Forty(), IPlayerPoints.Thirty()).Score,
            fortyThirty.Score);
        IScore deuce1 = UpdateAndPrintScore(fortyThirty, IPlayer.Two());
        Assert.Equal(IScore.Deuce().Score, deuce1.Score);
        IScore advantageP1 = UpdateAndPrintScore(deuce1, IPlayer.One());
        Assert.Equal(IScore.Advantage(IAdvantage.One()).Score, advantageP1.Score);
        IScore gameP1 = UpdateAndPrintScore(advantageP1, IPlayer.One());
        Assert.Equal(IScore.Game(IGame.One()).Score, gameP1.Score);
        IScore zeroFifteen = UpdateAndPrintScore(gameP1, IPlayer.Two());
        Assert.Equal(
            IScore.Points(IPlayerPoints.Zero(), IPlayerPoints.Fifteen()).Score,
            zeroFifteen.Score);
        IScore deuce2 = UpdateAndPrintScore(advantageP1, IPlayer.Two());
        Assert.Equal(IScore.Deuce().Score, deuce2.Score);
    }

    private static IScore UpdateAndPrintScore(IScore oldScore, IPlayer player)
    {
        IScore newScore = ScorePoint(oldScore, player);
        Console.WriteLine(IScore.GetString(oldScore) + " + " + IPlayer.GetString(player) + " -> "
            + IScore.GetString(newScore));
        return newScore;
    }
}
