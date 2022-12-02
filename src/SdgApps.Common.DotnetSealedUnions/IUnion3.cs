// <copyright file="IUnion3.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.Common.DotnetSealedUnions;

/// <summary>
/// <see cref="IUnion3{TFirst, TSecond, TThird}"/>
/// represents a union containing an element of 3 possible types.
/// </summary>
/// <typeparam name="TFirst">First possible type.</typeparam>
/// <typeparam name="TSecond">Second possible type.</typeparam>
/// <typeparam name="TThird">Third possible type.</typeparam>
public interface IUnion3<
    TFirst,
    TSecond,
    TThird>
{
    /// <summary>
    /// Creator class for
    /// <see cref="IUnion3{TFirst, TSecond, TThird}"/>.
    /// </summary>
    public interface IFactory
    {
        /// <summary>
        /// Creates a Union3 wrapping a value of the first
        /// <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A
        /// <see cref="IUnion3{TFirst, TSecond, TThird}"/>
        /// object wrapping the value.
        /// </returns>
        IUnion3<
            TFirst,
            TSecond,
            TThird>
            First(TFirst value);

        /// <summary>
        /// Creates a Union3 wrapping a value of the second
        /// <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A
        /// <see cref="IUnion3{TFirst, TSecond, TThird}"/>
        /// object wrapping the value.
        /// </returns>
        IUnion3<
            TFirst,
            TSecond,
            TThird>
            Second(TSecond value);

        /// <summary>
        /// Creates a Union3 wrapping a value of the third
        /// <paramref name="value"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A
        /// <see cref="IUnion3{TFirst, TSecond, TThird}"/>
        /// object wrapping the value.
        /// </returns>
        IUnion3<
            TFirst,
            TSecond,
            TThird>
            Third(TThird value);
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
    void Continued(
        Action<TFirst> continuationFirst,
        Action<TSecond> continuationSecond,
        Action<TThird> continuationThird);

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
    /// <returns>
    /// An object of the result type.
    /// </returns>
    TR Join<TR>(
        Func<TFirst, TR> mapFirst,
        Func<TSecond, TR> mapSecond,
        Func<TThird, TR> mapThird);
}
