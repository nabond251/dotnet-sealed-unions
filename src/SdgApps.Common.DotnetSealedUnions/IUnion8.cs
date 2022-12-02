// <copyright file="IUnion8.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.Common.DotnetSealedUnions;

/// <summary>
/// <see cref="IUnion8{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TEighth}"/>
/// represents a union containing an element of 8 possible types.
/// </summary>
/// <typeparam name="TFirst">First possible type.</typeparam>
/// <typeparam name="TSecond">Second possible type.</typeparam>
/// <typeparam name="TThird">Third possible type.</typeparam>
/// <typeparam name="TFourth">Fourth possible type.</typeparam>
/// <typeparam name="TFifth">Fifth possible type.</typeparam>
/// <typeparam name="TSixth">Sixth possible type.</typeparam>
/// <typeparam name="TSeventh">Seventh possible type.</typeparam>
/// <typeparam name="TEighth">Eighth possible type.</typeparam>
public interface IUnion8<
    TFirst,
    TSecond,
    TThird,
    TFourth,
    TFifth,
    TSixth,
    TSeventh,
    TEighth>
{
    /// <summary>
    /// Creator class for
    /// <see cref="IUnion8{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TEighth}"/>.
    /// </summary>
    public interface IFactory
    {
        /// <summary>
        /// Creates a Union8 wrapping a value of the first
        /// <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A
        /// <see cref="IUnion8{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TEighth}"/>
        /// object wrapping the value.
        /// </returns>
        IUnion8<
            TFirst,
            TSecond,
            TThird,
            TFourth,
            TFifth,
            TSixth,
            TSeventh,
            TEighth>
            First(TFirst value);

        /// <summary>
        /// Creates a Union8 wrapping a value of the second
        /// <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A
        /// <see cref="IUnion8{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TEighth}"/>
        /// object wrapping the value.
        /// </returns>
        IUnion8<
            TFirst,
            TSecond,
            TThird,
            TFourth,
            TFifth,
            TSixth,
            TSeventh,
            TEighth>
            Second(TSecond value);

        /// <summary>
        /// Creates a Union8 wrapping a value of the third
        /// <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A
        /// <see cref="IUnion8{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TEighth}"/>
        /// object wrapping the value.
        /// </returns>
        IUnion8<
            TFirst,
            TSecond,
            TThird,
            TFourth,
            TFifth,
            TSixth,
            TSeventh,
            TEighth>
            Third(TThird value);

        /// <summary>
        /// Creates a Union8 wrapping a value of the fourth
        /// <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A
        /// <see cref="IUnion8{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TEighth}"/>
        /// object wrapping the value.
        /// </returns>
        IUnion8<
            TFirst,
            TSecond,
            TThird,
            TFourth,
            TFifth,
            TSixth,
            TSeventh,
            TEighth>
            Fourth(TFourth value);

        /// <summary>
        /// Creates a Union8 wrapping a value of the fifth
        /// <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A
        /// <see cref="IUnion8{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TEighth}"/>
        /// object wrapping the value.
        /// </returns>
        IUnion8<
            TFirst,
            TSecond,
            TThird,
            TFourth,
            TFifth,
            TSixth,
            TSeventh,
            TEighth>
            Fifth(TFifth value);

        /// <summary>
        /// Creates a Union8 wrapping a value of the sixth
        /// <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A
        /// <see cref="IUnion8{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TEighth}"/>
        /// object wrapping the value.
        /// </returns>
        IUnion8<
            TFirst,
            TSecond,
            TThird,
            TFourth,
            TFifth,
            TSixth,
            TSeventh,
            TEighth>
            Sixth(TSixth value);

        /// <summary>
        /// Creates a Union8 wrapping a value of the seventh
        /// <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A
        /// <see cref="IUnion8{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TEighth}"/>
        /// object wrapping the value.
        /// </returns>
        IUnion8<
            TFirst,
            TSecond,
            TThird,
            TFourth,
            TFifth,
            TSixth,
            TSeventh,
            TEighth>
            Seventh(TSeventh value);

        /// <summary>
        /// Creates a Union8 wrapping a value of the eighth
        /// <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A
        /// <see cref="IUnion8{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TEighth}"/>
        /// object wrapping the value.
        /// </returns>
        IUnion8<
            TFirst,
            TSecond,
            TThird,
            TFourth,
            TFifth,
            TSixth,
            TSeventh,
            TEighth>
            Eighth(TEighth value);
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
    /// <param name="continuationSeventh">
    /// Continuation to execute if seventh possible type.
    /// </param>
    /// <param name="continuationEighth">
    /// Continuation to execute if eighth possible type.
    /// </param>
    void Continued(
        Action<TFirst> continuationFirst,
        Action<TSecond> continuationSecond,
        Action<TThird> continuationThird,
        Action<TFourth> continuationFourth,
        Action<TFifth> continuationFifth,
        Action<TSixth> continuationSixth,
        Action<TSeventh> continuationSeventh,
        Action<TEighth> continuationEighth);

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
    /// <param name="mapSeventh">
    /// Transformation to evaluate if seventh possible type.
    /// </param>
    /// <param name="mapEighth">
    /// Transformation to evaluate if eighth possible type.
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
        Func<TSixth, TR> mapSixth,
        Func<TSeventh, TR> mapSeventh,
        Func<TEighth, TR> mapEighth);
}
