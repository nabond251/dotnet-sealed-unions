// <copyright file="TennisGame.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.Common.DotnetSealedUnions.Tests;

using System;
using System.Collections.Generic;
using SdgApps.Common.DotnetSealedUnions.Generic;

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
        IUnion4<Points, IAdvantage, Deuce, IGame> Score { get; }

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
            return new PointsScore(playerOnePoints, playerTwoPoints);
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
            return new AdvantageScore(advantage);
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
            return new DeuceScore();
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
            return new GameScore(game);
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
            return score.Score.Join(
                points => points.ToString(),
                advantage => advantage.Player.Join(
                    one => "Adv P1",
                    two => "Adv P2"),
                deuce => "Deuce",
                game => game.Player.Join(one => "Win P1", two => "Win P2"));
        }

        /// <summary>
        /// <see cref="IScore"/> implementation with given player points values.
        /// </summary>
        private class PointsScore : IScore
        {
            private readonly IPlayerPoints playerOnePoints;
            private readonly IPlayerPoints playerTwoPoints;

            public PointsScore(IPlayerPoints playerOnePoints, IPlayerPoints playerTwoPoints)
            {
                this.playerOnePoints = playerOnePoints;
                this.playerTwoPoints = playerTwoPoints;
            }

            public IUnion4<Points, IAdvantage, Deuce, IGame> Score =>
                GenericUnions.QuartetFactory<Points, IAdvantage, Deuce, IGame>()
                .First(new Points(this.playerOnePoints, this.playerTwoPoints));
        }

        /// <summary>
        /// <see cref="IScore"/> implementation for advantage.
        /// </summary>
        private class AdvantageScore : IScore
        {
            private readonly IAdvantage advantage;

            public AdvantageScore(IAdvantage advantage)
            {
                this.advantage = advantage;
            }

            public IUnion4<Points, IAdvantage, Deuce, IGame> Score =>
                GenericUnions.QuartetFactory<Points, IAdvantage, Deuce, IGame>()
                .Second(this.advantage);
        }

        /// <summary>
        /// <see cref="IScore"/> implementation for deuce.
        /// </summary>
        private class DeuceScore : IScore
        {
            public IUnion4<Points, IAdvantage, Deuce, IGame> Score =>
                GenericUnions.QuartetFactory<Points, IAdvantage, Deuce, IGame>()
                .Third(new Deuce());
        }

        /// <summary>
        /// <see cref="IScore"/> implementation for game.
        /// </summary>
        private class GameScore : IScore
        {
            private readonly IGame game;

            public GameScore(IGame game)
            {
                this.game = game;
            }

            public IUnion4<Points, IAdvantage, Deuce, IGame> Score =>
                GenericUnions.QuartetFactory<Points, IAdvantage, Deuce, IGame>()
                .Fourth(this.game);
        }
    }

    /// <summary>
    /// Tennis player points.
    /// </summary>
    public interface IPlayerPoints
    {
        /// <summary>
        /// Gets player points union.
        /// </summary>
        IUnion4<Zero, Fifteen, Thirty, Forty> PlayerPoints { get; }

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
            return new ZeroPlayerPoints();
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
            return new FifteenPlayerPoints();
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
            return new ThirtyPlayerPoints();
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
            return new FortyPlayerPoints();
        }

        /// <summary>
        /// Gets string representation of <see cref="IPlayerPoints"/>.
        /// </summary>
        /// <param name="playerPoints">
        /// <see cref="IPlayerPoints"/> whose string representation to get.
        /// </param>
        /// <returns>
        /// String representation of <paramref name="playerPoints"/>.
        /// </returns>
        static string GetString(IPlayerPoints playerPoints)
        {
            return playerPoints.PlayerPoints.Join(
                zero => "0",
                fifteen => "15",
                thirty => "30",
                forty => "40");
        }

        /// <summary>
        /// <see cref="IPlayerPoints"/> implementation with zero points.
        /// </summary>
        private class ZeroPlayerPoints : IPlayerPoints
        {
            public IUnion4<Zero, Fifteen, Thirty, Forty> PlayerPoints =>
                GenericUnions.QuartetFactory<Zero, Fifteen, Thirty, Forty>()
                .First(new Zero());
        }

        /// <summary>
        /// <see cref="IPlayerPoints"/> implementation with fifteen points.
        /// </summary>
        private class FifteenPlayerPoints : IPlayerPoints
        {
            public IUnion4<Zero, Fifteen, Thirty, Forty> PlayerPoints =>
                GenericUnions.QuartetFactory<Zero, Fifteen, Thirty, Forty>()
                .Second(new Fifteen());
        }

        /// <summary>
        /// <see cref="IPlayerPoints"/> implementation with thirty points.
        /// </summary>
        private class ThirtyPlayerPoints : IPlayerPoints
        {
            public IUnion4<Zero, Fifteen, Thirty, Forty> PlayerPoints =>
                GenericUnions.QuartetFactory<Zero, Fifteen, Thirty, Forty>()
                .Third(new Thirty());
        }

        /// <summary>
        /// <see cref="IPlayerPoints"/> implementation with forty points.
        /// </summary>
        private class FortyPlayerPoints : IPlayerPoints
        {
            public IUnion4<Zero, Fifteen, Thirty, Forty> PlayerPoints =>
                GenericUnions.QuartetFactory<Zero, Fifteen, Thirty, Forty>()
                .Fourth(new Forty());
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
            return new OnePlayer();
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
            return new TwoPlayer();
        }

        /// <summary>
        /// <see cref="IAdvantage"/> implementation for player one.
        /// </summary>
        private class OnePlayer : IAdvantage
        {
            public IUnion2<PlayerOne, PlayerTwo> Player =>
                GenericUnions.DoubletFactory<PlayerOne, PlayerTwo>()
                .First(new PlayerOne());

            public override bool Equals(object? obj)
            {
                return obj == this || obj is OnePlayer;
            }

            public override int GetHashCode()
            {
                return 0;
            }
        }

        /// <summary>
        /// <see cref="IAdvantage"/> implementation for player two.
        /// </summary>
        private class TwoPlayer : IAdvantage
        {
            public IUnion2<PlayerOne, PlayerTwo> Player =>
                GenericUnions.DoubletFactory<PlayerOne, PlayerTwo>()
                .Second(new PlayerTwo());

            public override bool Equals(object? obj)
            {
                return obj == this || obj is TwoPlayer;
            }

            public override int GetHashCode()
            {
                return 0;
            }
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
            return new OnePlayer();
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
            return new TwoPlayer();
        }

        /// <summary>
        /// <see cref="IGame"/> implementation for player one.
        /// </summary>
        private class OnePlayer : IGame
        {
            public IUnion2<PlayerOne, PlayerTwo> Player =>
                GenericUnions.DoubletFactory<PlayerOne, PlayerTwo>()
                .First(new PlayerOne());

            public override bool Equals(object? obj)
            {
                return obj == this || obj is OnePlayer;
            }

            public override int GetHashCode()
            {
                return 0;
            }
        }

        /// <summary>
        /// <see cref="IGame"/> implementation for player two.
        /// </summary>
        private class TwoPlayer : IGame
        {
            public IUnion2<PlayerOne, PlayerTwo> Player =>
                GenericUnions.DoubletFactory<PlayerOne, PlayerTwo>()
                .Second(new PlayerTwo());

            public override bool Equals(object? obj)
            {
                return obj == this || obj is TwoPlayer;
            }

            public override int GetHashCode()
            {
                return 0;
            }
        }
    }

    /// <summary>
    /// Tennis player.
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        /// Gets the player union.
        /// </summary>
        IUnion2<PlayerOne, PlayerTwo> Player { get; }

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
            return new OnePlayer();
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
            return new TwoPlayer();
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
            return player.Player.Join(playerOne => "Player 1", playerTwo => "Player 2");
        }

        /// <summary>
        /// <see cref="IPlayer"/> implementation for player one.
        /// </summary>
        private class OnePlayer : IPlayer
        {
            public IUnion2<PlayerOne, PlayerTwo> Player =>
                GenericUnions.DoubletFactory<PlayerOne, PlayerTwo>()
                .First(new PlayerOne());
        }

        /// <summary>
        /// <see cref="IPlayer"/> implementation for player two.
        /// </summary>
        private class TwoPlayer : IPlayer
        {
            public IUnion2<PlayerOne, PlayerTwo> Player =>
                GenericUnions.DoubletFactory<PlayerOne, PlayerTwo>()
                .Second(new PlayerTwo());
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
        return score.Score.Join(
            ScorePoints(player),
            ScoreAdvantage(player),
            ScoreDeuce(player),
            ScoreGame(player));
    }

    private static Func<Points, IScore> ScorePoints(IPlayer player)
    {
        return points =>
        {
            if (IsPlayerForty(points.PlayerOnePoints))
            {
                return player.Player.Join(
                    one => IScore.Game(IGame.One()),
                    two => IsPlayerThirty(points.PlayerTwoPoints) ?
                        IScore.Deuce() :
                        ScorePlayer(points.PlayerOnePoints, Score(points.PlayerTwoPoints)));
            }
            else if (IsPlayerForty(points.PlayerTwoPoints))
            {
                return player.Player.Join(
                    one => IsPlayerThirty(points.PlayerOnePoints) ?
                        IScore.Deuce() :
                        ScorePlayer(Score(points.PlayerOnePoints), points.PlayerTwoPoints),
                    two => IScore.Game(IGame.Two()));
            }
            else
            {
                return player.Player.Join(
                    one => ScorePlayer(Score(points.PlayerOnePoints), points.PlayerTwoPoints),
                    two => ScorePlayer(points.PlayerOnePoints, Score(points.PlayerTwoPoints)));
            }
        };
    }

    private static IScore ScorePlayer(IPlayerPoints playerOnePoints, IPlayerPoints playerTwoPoints)
    {
        return IScore.Points(playerOnePoints, playerTwoPoints);
    }

    private static bool IsPlayerThirty(IPlayerPoints playerPoints)
    {
        return playerPoints.PlayerPoints.Join(
            zero => false,
            fifteen => false,
            thirty => true,
            forty => false);
    }

    private static bool IsPlayerForty(IPlayerPoints playerPoints)
    {
        return playerPoints.PlayerPoints.Join(
            zero => false,
            fifteen => false,
            thirty => false,
            forty => true);
    }

    private static IPlayerPoints Score(IPlayerPoints playerPoints)
    {
        return playerPoints.PlayerPoints.Join(
            zero => IPlayerPoints.Fifteen(),
            fifteen => IPlayerPoints.Thirty(),
            thirty => IPlayerPoints.Forty(),
            forty =>
            {
                throw new InvalidOperationException();
            });
    }

    private static Func<IAdvantage, IScore> ScoreAdvantage(IPlayer player)
    {
        return advantage => advantage.Player.Join(
            playerOne => player.Player.Join(
                one => IScore.Game(IGame.One()),
                two => IScore.Deuce()),
            playerTwo => player.Player.Join(
                one => IScore.Deuce(),
                two => IScore.Game(IGame.Two())));
    }

    private static Func<Deuce, IScore> ScoreDeuce(IPlayer player)
    {
        return deuce => player.Player.Join(
            first => IScore.Advantage(IAdvantage.One()),
            second => IScore.Advantage(IAdvantage.Two()));
    }

    private static Func<IGame, IScore> ScoreGame(IPlayer player)
    {
        return game => player.Player.Join(
            one => ScorePlayer(IPlayerPoints.Fifteen(), IPlayerPoints.Zero()),
            second => ScorePlayer(IPlayerPoints.Zero(), IPlayerPoints.Fifteen()));
    }

    /// <summary>
    /// Points score data.
    /// </summary>
    public class Points
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Points"/> class.
        /// </summary>
        /// <param name="playerOnePoints">Player one points value.</param>
        /// <param name="playerTwoPoints">Player two points value.</param>
        public Points(
            IPlayerPoints playerOnePoints,
            IPlayerPoints playerTwoPoints)
        {
            this.PlayerOnePoints = playerOnePoints;
            this.PlayerTwoPoints = playerTwoPoints;
        }

        /// <summary>
        /// Gets player one points value.
        /// </summary>
        public IPlayerPoints PlayerOnePoints { get; }

        /// <summary>
        /// Gets player two points value.
        /// </summary>
        public IPlayerPoints PlayerTwoPoints { get; }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return obj is Points points &&
                EqualityComparer<IUnion4<Zero, Fifteen, Thirty, Forty>>.Default.Equals(
                    this.PlayerOnePoints.PlayerPoints, points.PlayerOnePoints.PlayerPoints) &&
                EqualityComparer<IUnion4<Zero, Fifteen, Thirty, Forty>>.Default.Equals(
                    this.PlayerTwoPoints.PlayerPoints, points.PlayerTwoPoints.PlayerPoints);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return HashCode.Combine(this.PlayerOnePoints, this.PlayerTwoPoints);
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"[{this.PlayerOnePoints}, {this.PlayerTwoPoints}]";
        }
    }

    /// <summary>
    /// Zero score data.
    /// </summary>
    public class Zero
    {
        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return obj == this || obj is Zero;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return 0;
        }
    }

    /// <summary>
    /// Fifteen score data.
    /// </summary>
    public class Fifteen
    {
        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return obj == this || obj is Fifteen;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return 0;
        }
    }

    /// <summary>
    /// Thirty score data.
    /// </summary>
    public class Thirty
    {
        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return obj == this || obj is Thirty;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return 0;
        }
    }

    /// <summary>
    /// Forty score data.
    /// </summary>
    public class Forty
    {
        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return obj == this || obj is Forty;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return 0;
        }
    }

    /// <summary>
    /// Deuce score data.
    /// </summary>
    public class Deuce
    {
        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return obj == this || obj is Deuce;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return 0;
        }
    }

    /// <summary>
    /// Player one data.
    /// </summary>
    public class PlayerOne
    {
        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return obj == this || obj is PlayerOne;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return 0;
        }
    }

    /// <summary>
    /// Player two data.
    /// </summary>
    public class PlayerTwo
    {
        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return obj == this || obj is PlayerTwo;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return 0;
        }
    }
}
