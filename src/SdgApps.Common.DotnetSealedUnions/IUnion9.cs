// <copyright file="IUnion9.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.Common.DotnetSealedUnions;

/// <summary>
/// <see cref="IUnion9{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TEighth, TNinth}"/>
/// represents a union containing an element of 9 possible types.
/// </summary>
/// <typeparam name="TFirst">First possible type.</typeparam>
/// <typeparam name="TSecond">Second possible type.</typeparam>
/// <typeparam name="TThird">Third possible type.</typeparam>
/// <typeparam name="TFourth">Fourth possible type.</typeparam>
/// <typeparam name="TFifth">Fifth possible type.</typeparam>
/// <typeparam name="TSixth">Sixth possible type.</typeparam>
/// <typeparam name="TSeventh">Seventh possible type.</typeparam>
/// <typeparam name="TEighth">Eighth possible type.</typeparam>
/// <typeparam name="TNinth">Ninth possible type.</typeparam>
public interface IUnion9<
    TFirst,
    TSecond,
    TThird,
    TFourth,
    TFifth,
    TSixth,
    TSeventh,
    TEighth,
    TNinth>
{
    /// <summary>
    /// Creator class for
    /// <see cref="IUnion9{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TEighth, TNinth}"/>.
    /// </summary>
    public interface IFactory
    {
        /// <summary>
        /// Creates a Union9 wrapping a <paramref name="value"/> of the first
        /// type.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A
        /// <see cref="IUnion9{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TEighth, TNinth}"/>
        /// object wrapping the value.
        /// </returns>
        IUnion9<
            TFirst,
            TSecond,
            TThird,
            TFourth,
            TFifth,
            TSixth,
            TSeventh,
            TEighth,
            TNinth>
            First(TFirst value);

        /// <summary>
        /// Creates a Union9 wrapping a <paramref name="value"/> of the second
        /// type.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A
        /// <see cref="IUnion9{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TEighth, TNinth}"/>
        /// object wrapping the value.
        /// </returns>
        IUnion9<
            TFirst,
            TSecond,
            TThird,
            TFourth,
            TFifth,
            TSixth,
            TSeventh,
            TEighth,
            TNinth>
            Second(TSecond value);

        /// <summary>
        /// Creates a Union9 wrapping a <paramref name="value"/> of the third
        /// type.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A
        /// <see cref="IUnion9{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TEighth, TNinth}"/>
        /// object wrapping the value.
        /// </returns>
        IUnion9<
            TFirst,
            TSecond,
            TThird,
            TFourth,
            TFifth,
            TSixth,
            TSeventh,
            TEighth,
            TNinth>
            Third(TThird value);

        /// <summary>
        /// Creates a Union9 wrapping a <paramref name="value"/> of the fourth
        /// type.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A
        /// <see cref="IUnion9{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TEighth, TNinth}"/>
        /// object wrapping the value.
        /// </returns>
        IUnion9<
            TFirst,
            TSecond,
            TThird,
            TFourth,
            TFifth,
            TSixth,
            TSeventh,
            TEighth,
            TNinth>
            Fourth(TFourth value);

        /// <summary>
        /// Creates a Union9 wrapping a <paramref name="value"/> of the fifth
        /// type.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A
        /// <see cref="IUnion9{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TEighth, TNinth}"/>
        /// object wrapping the value.
        /// </returns>
        IUnion9<
            TFirst,
            TSecond,
            TThird,
            TFourth,
            TFifth,
            TSixth,
            TSeventh,
            TEighth,
            TNinth>
            Fifth(TFifth value);

        /// <summary>
        /// Creates a Union9 wrapping a <paramref name="value"/> of the sixth
        /// type.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A
        /// <see cref="IUnion9{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TEighth, TNinth}"/>
        /// object wrapping the value.
        /// </returns>
        IUnion9<
            TFirst,
            TSecond,
            TThird,
            TFourth,
            TFifth,
            TSixth,
            TSeventh,
            TEighth,
            TNinth>
            Sixth(TSixth value);

        /// <summary>
        /// Creates a Union9 wrapping a <paramref name="value"/> of the seventh
        /// type.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A
        /// <see cref="IUnion9{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TEighth, TNinth}"/>
        /// object wrapping the value.
        /// </returns>
        IUnion9<
            TFirst,
            TSecond,
            TThird,
            TFourth,
            TFifth,
            TSixth,
            TSeventh,
            TEighth,
            TNinth>
            Seventh(TSeventh value);

        /// <summary>
        /// Creates a Union9 wrapping a <paramref name="value"/> of the eighth
        /// type.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A
        /// <see cref="IUnion9{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TEighth, TNinth}"/>
        /// object wrapping the value.
        /// </returns>
        IUnion9<
            TFirst,
            TSecond,
            TThird,
            TFourth,
            TFifth,
            TSixth,
            TSeventh,
            TEighth,
            TNinth>
            Eighth(TEighth value);

        /// <summary>
        /// Creates a Union9 wrapping a <paramref name="value"/> of the ninth
        /// type.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A
        /// <see cref="IUnion9{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TEighth, TNinth}"/>
        /// object wrapping the value.
        /// </returns>
        IUnion9<
            TFirst,
            TSecond,
            TThird,
            TFourth,
            TFifth,
            TSixth,
            TSeventh,
            TEighth,
            TNinth>
            Ninth(TNinth value);
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
    /// <param name="continuationNinth">
    /// Continuation to execute if ninth possible type.
    /// </param>
    void Continued(
        Action<TFirst> continuationFirst,
        Action<TSecond> continuationSecond,
        Action<TThird> continuationThird,
        Action<TFourth> continuationFourth,
        Action<TFifth> continuationFifth,
        Action<TSixth> continuationSixth,
        Action<TSeventh> continuationSeventh,
        Action<TEighth> continuationEighth,
        Action<TNinth> continuationNinth);

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
    /// <param name="mapNinth">
    /// Transformation to evaluate if ninth possible type.
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
        Func<TEighth, TR> mapEighth,
        Func<TNinth, TR> mapNinth);
}
