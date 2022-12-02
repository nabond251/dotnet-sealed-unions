// <copyright file="IUnion6.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.Common.DotnetSealedUnions;

/// <summary>
/// <see cref="IUnion6{TFirst, TSecond, TThird, TFourth, TFifth, TSixth}"/>
/// represents a union containing an element of 6 possible types.
/// </summary>
/// <typeparam name="TFirst">First possible type.</typeparam>
/// <typeparam name="TSecond">Second possible type.</typeparam>
/// <typeparam name="TThird">Third possible type.</typeparam>
/// <typeparam name="TFourth">Fourth possible type.</typeparam>
/// <typeparam name="TFifth">Fifth possible type.</typeparam>
/// <typeparam name="TSixth">Sixth possible type.</typeparam>
public interface IUnion6<
    TFirst,
    TSecond,
    TThird,
    TFourth,
    TFifth,
    TSixth>
{
    /// <summary>
    /// Creator class for
    /// <see cref="IUnion6{TFirst, TSecond, TThird, TFourth, TFifth, TSixth}"/>.
    /// </summary>
    public interface IFactory
    {
        /// <summary>
        /// Creates a Union6 wrapping a value of the first
        /// <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A
        /// <see cref="IUnion6{TFirst, TSecond, TThird, TFourth, TFifth, TSixth}"/>
        /// object wrapping the value.
        /// </returns>
        IUnion6<
            TFirst,
            TSecond,
            TThird,
            TFourth,
            TFifth,
            TSixth>
            First(TFirst value);

        /// <summary>
        /// Creates a Union6 wrapping a value of the second
        /// <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A
        /// <see cref="IUnion6{TFirst, TSecond, TThird, TFourth, TFifth, TSixth}"/>
        /// object wrapping the value.
        /// </returns>
        IUnion6<
            TFirst,
            TSecond,
            TThird,
            TFourth,
            TFifth,
            TSixth>
            Second(TSecond value);

        /// <summary>
        /// Creates a Union6 wrapping a value of the third
        /// <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A
        /// <see cref="IUnion6{TFirst, TSecond, TThird, TFourth, TFifth, TSixth}"/>
        /// object wrapping the value.
        /// </returns>
        IUnion6<
            TFirst,
            TSecond,
            TThird,
            TFourth,
            TFifth,
            TSixth>
            Third(TThird value);

        /// <summary>
        /// Creates a Union6 wrapping a value of the fourth
        /// <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A
        /// <see cref="IUnion6{TFirst, TSecond, TThird, TFourth, TFifth, TSixth}"/>
        /// object wrapping the value.
        /// </returns>
        IUnion6<
            TFirst,
            TSecond,
            TThird,
            TFourth,
            TFifth,
            TSixth>
            Fourth(TFourth value);

        /// <summary>
        /// Creates a Union6 wrapping a value of the fifth
        /// <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A
        /// <see cref="IUnion6{TFirst, TSecond, TThird, TFourth, TFifth, TSixth}"/>
        /// object wrapping the value.
        /// </returns>
        IUnion6<
            TFirst,
            TSecond,
            TThird,
            TFourth,
            TFifth,
            TSixth>
            Fifth(TFifth value);

        /// <summary>
        /// Creates a Union6 wrapping a value of the sixth
        /// <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A
        /// <see cref="IUnion6{TFirst, TSecond, TThird, TFourth, TFifth, TSixth}"/>
        /// object wrapping the value.
        /// </returns>
        IUnion6<
            TFirst,
            TSecond,
            TThird,
            TFourth,
            TFifth,
            TSixth>
            Sixth(TSixth value);
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
    /// <param name="continuationFifth">
    /// Continuation to execute if fifth possible type.
    /// </param>
    /// <param name="continuationSixth">
    /// Continuation to execute if sixth possible type.
    /// </param>
    void Continued(
        Action<TFirst> continuationFirst,
        Action<TSecond> continuationSecond,
        Action<TThird> continuationThird,
        Action<TFourth> continuationFourth,
        Action<TFifth> continuationFifth,
        Action<TSixth> continuationSixth);

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
    /// <param name="mapFifth">
    /// Transformation to evaluate if fifth possible type.
    /// </param>
    /// <param name="mapSixth">
    /// Transformation to evaluate if sixth possible type.
    /// </param>
    /// <returns>
    /// An object of the result type.
    /// </returns>
    TR Join<TR>(
        Func<TFirst, TR> mapFirst,
        Func<TSecond, TR> mapSecond,
        Func<TThird, TR> mapThird,
        Func<TFourth, TR> mapFourth,
        Func<TFifth, TR> mapFifth,
        Func<TSixth, TR> mapSixth);
}
