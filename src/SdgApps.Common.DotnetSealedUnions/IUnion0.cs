// <copyright file="IUnion0.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.Common.DotnetSealedUnions;

/// <summary>
/// <see cref="IUnion0{TFirst}"/>
/// represents a union containing an element of 1 possible type.
/// </summary>
/// <typeparam name="TFirst">First possible type.</typeparam>
public interface IUnion0<
    TFirst>
{
    /// <summary>
    /// Creator class for
    /// <see cref="IUnion0{TFirst}"/>.
    /// </summary>
    public interface IFactory
    {
        /// <summary>
        /// Creates a Union0 wrapping a <paramref name="value"/> of the first
        /// type.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A
        /// <see cref="IUnion0{TFirst}"/>
        /// object wrapping the value.
        /// </returns>
        IUnion0<
            TFirst>
            First(TFirst value);
    }

    /// <summary>
    /// Executes one of the continuations depending on the element type.
    /// </summary>
    /// <param name="continuationFirst">
    /// Continuation to execute if first possible type.
    /// </param>
    void Continued(
        Action<TFirst> continuationFirst);

    /// <summary>
    /// Transforms the element in the union to a new type.
    /// </summary>
    /// <typeparam name="TR">Result type.</typeparam>
    /// <param name="mapFirst">
    /// Transformation to evaluate if first possible type.
    /// </param>
    /// <returns>
    /// An object of the result type.
    /// </returns>
    TR Join<TR>(
        Func<TFirst, TR> mapFirst);
}
