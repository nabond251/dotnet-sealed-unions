// <copyright file="TennisGame.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.Common.DotnetSealedUnions.Tests;

/// <summary>
/// Tennis kata tennis game.
/// </summary>
public class TennisGame
{
    /// <summary>
    /// Tennis score.
    /// </summary>
    public interface IScore
    {
        /// <summary>
        /// Gets score.
        /// </summary>
        object Score { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="IScore"/> interface
        /// with given player points values.
        /// </summary>
        /// <param name="playerOnePoints">Player one points value.</param>
        /// <param name="playerTwoPoints">Player two points value.</param>
        /// <returns>
        /// A new instance of the <see cref="IScore"/> interface with given
        /// player points values.
        /// </returns>
        static IScore Points(IPlayerPoints playerOnePoints, IPlayerPoints playerTwoPoints)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IScore"/> interface
        /// with advantage score.
        /// </summary>
        /// <param name="advantage">Advantage score.</param>
        /// <returns>
        /// A new instance of the <see cref="IScore"/> interface with advantage
        /// score.
        /// </returns>
        static IScore Advantage(IAdvantage advantage)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IScore"/> interface
        /// with deuce score.
        /// </summary>
        /// <returns>
        /// A new instance of the <see cref="IScore"/> interface with deuce
        /// score.
        /// </returns>
        static IScore Deuce()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IScore"/> interface
        /// with game score.
        /// </summary>
        /// <param name="game">Game score.</param>
        /// <returns>
        /// A new instance of the <see cref="IScore"/> interface with game
        /// score.
        /// </returns>
        static IScore Game(IGame game)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets string representation of <see cref="IScore"/>.
        /// </summary>
        /// <param name="score">
        /// <see cref="IScore"/> whose string representation to get.
        /// </param>
        /// <returns>
        /// String representation of <paramref name="score"/>.
        /// </returns>
        static string GetString(IScore score)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Tennis player points.
    /// </summary>
    public interface IPlayerPoints
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IPlayerPoints"/>
        /// interface with zero points.
        /// </summary>
        /// <returns>
        /// A new instance of the <see cref="IPlayerPoints"/> interface with
        /// zero points.
        /// </returns>
        static IPlayerPoints Zero()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IPlayerPoints"/>
        /// interface with fifteen points.
        /// </summary>
        /// <returns>
        /// A new instance of the <see cref="IPlayerPoints"/> interface with
        /// fifteen points.
        /// </returns>
        static IPlayerPoints Fifteen()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IPlayerPoints"/>
        /// interface with thirty points.
        /// </summary>
        /// <returns>
        /// A new instance of the <see cref="IPlayerPoints"/> interface with
        /// thirty points.
        /// </returns>
        static IPlayerPoints Thirty()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IPlayerPoints"/>
        /// interface with forty points.
        /// </summary>
        /// <returns>
        /// A new instance of the <see cref="IPlayerPoints"/> interface with
        /// forty points.
        /// </returns>
        static IPlayerPoints Forty()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Advantage score.
    /// </summary>
    public interface IAdvantage : IPlayer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IAdvantage"/> interface
        /// for player one.
        /// </summary>
        /// <returns>
        /// A new instance of the <see cref="IAdvantage"/> interface for player
        /// one.
        /// </returns>
        static new IAdvantage One()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IAdvantage"/> interface
        /// for player two.
        /// </summary>
        /// <returns>
        /// A new instance of the <see cref="IAdvantage"/> interface for player
        /// two.
        /// </returns>
        static new IAdvantage Two()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Game score.
    /// </summary>
    public interface IGame : IPlayer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IGame"/> interface for
        /// player one.
        /// </summary>
        /// <returns>
        /// A new instance of the <see cref="IGame"/> interface for player one.
        /// </returns>
        static new IGame One()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IGame"/> interface for
        /// player two.
        /// </summary>
        /// <returns>
        /// A new instance of the <see cref="IGame"/> interface for player two.
        /// </returns>
        static new IGame Two()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Tennis player.
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IPlayer"/> interface
        /// for player one.
        /// </summary>
        /// <returns>
        /// A new instance of the <see cref="IPlayer"/> interface for player
        /// one.
        /// </returns>
        static IPlayer One()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IPlayer"/> interface
        /// for player two.
        /// </summary>
        /// <returns>
        /// A new instance of the <see cref="IPlayer"/> interface for player
        /// two.
        /// </returns>
        static IPlayer Two()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets string representation of <see cref="IPlayer"/>.
        /// </summary>
        /// <param name="player">
        /// <see cref="IPlayer"/> whose string representation to get.
        /// </param>
        /// <returns>
        /// String representation of <paramref name="player"/>.
        /// </returns>
        static string GetString(IPlayer player)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Scores a point for given player.
    /// </summary>
    /// <param name="score">Current score.</param>
    /// <param name="player">Player for whom the point is scored.</param>
    /// <returns>New score.</returns>
    public static IScore ScorePoint(IScore score, IPlayer player)
    {
        throw new NotImplementedException();
    }
}
