// <copyright file="IUnion4.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.Common.DotnetSealedUnions;

/// <summary>
/// <see cref="IUnion4{TFirst, TSecond, TThird, TFourth}"/> represents a
/// union containing an element of 4 possible types.
/// </summary>
/// <typeparam name="TFirst">First possible type.</typeparam>
/// <typeparam name="TSecond">Second possible type.</typeparam>
/// <typeparam name="TThird">Third possible type.</typeparam>
/// <typeparam name="TFourth">Fourth possible type.</typeparam>
public interface IUnion4<TFirst, TSecond, TThird, TFourth>
{
    /// <summary>
    /// Creator class for
    /// <see cref="IUnion4{TFirst, TSecond, TThird, TFourth}"/>.
    /// </summary>
    public interface IFactory
    {
        /// <summary>
        /// Creates a Union4 wrapping a value of the first
        /// <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A <see cref="IUnion4{TFirst, TSecond, TThird, TFourth}"/> object
        /// wrapping the value.
        /// </returns>
        IUnion4<TFirst, TSecond, TThird, TFourth> First(TFirst value);

        /// <summary>
        /// Creates a Union4 wrapping a value of the second
        /// <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A <see cref="IUnion4{TFirst, TSecond, TThird, TFourth}"/> object
        /// wrapping the value.
        /// </returns>
        IUnion4<TFirst, TSecond, TThird, TFourth> Second(TSecond value);

        /// <summary>
        /// Creates a Union4 wrapping a value of the third
        /// <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A <see cref="IUnion4{TFirst, TSecond, TThird, TFourth}"/> object
        /// wrapping the value.
        /// </returns>
        IUnion4<TFirst, TSecond, TThird, TFourth> Third(TThird value);

        /// <summary>
        /// Creates a Union4 wrapping a value of the fourth
        /// <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A <see cref="IUnion4{TFirst, TSecond, TThird, TFourth}"/> object
        /// wrapping the value.
        /// </returns>
        IUnion4<TFirst, TSecond, TThird, TFourth> Fourth(TFourth value);
    }

    /// <summary>
    /// Executes one of the continuations depending on the element type.
    /// </summary>
    /// <param name="continuationFirst">
    /// Continuation to execute if first possible type.
    /// </param>
    /// <param name="continuationSecond">
    /// Continuation to execute if second possible type.
    /// </param>
    /// <param name="continuationThird">
    /// Continuation to execute if third possible type.
    /// </param>
    /// <param name="continuationFourth">
    /// Continuation to execute if fourth possible type.
    /// </param>
    void Continued(
        Action<TFirst> continuationFirst,
        Action<TSecond> continuationSecond,
        Action<TThird> continuationThird,
        Action<TFourth> continuationFourth);

    /// <summary>
    /// Transforms the element in the union to a new type.
    /// </summary>
    /// <typeparam name="TR">Result type.</typeparam>
    /// <param name="mapFirst">
    /// Transformation to evaluate if first possible type.
    /// </param>
    /// <param name="mapSecond">
    /// Transformation to evaluate if second possible type.
    /// </param>
    /// <param name="mapThird">
    /// Transformation to evaluate if third possible type.
    /// </param>
    /// <param name="mapFourth">
    /// Transformation to evaluate if fourth possible type.
    /// </param>
    /// <returns>
    /// An object of the result type.
    /// </returns>
    TR Join<TR>(
        Func<TFirst, TR> mapFirst,
        Func<TSecond, TR> mapSecond,
        Func<TThird, TR> mapThird,
        Func<TFourth, TR> mapFourth);
}
