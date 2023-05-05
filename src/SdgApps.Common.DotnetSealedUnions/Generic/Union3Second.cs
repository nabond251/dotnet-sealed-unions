// <copyright file="Union3Second.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.Common.DotnetSealedUnions.Generic;

/// <summary>
/// <see cref="IUnion3{TFirst, TSecond, TThird}"/>
/// element with second of 3 possible types.
/// </summary>
/// <typeparam name="TA">First possible type.</typeparam>
/// <typeparam name="TB">Second possible type.</typeparam>
/// <typeparam name="TC">Third possible type.</typeparam>
internal sealed class Union3Second<TA, TB, TC>
    : IUnion3<TA, TB, TC>
{
    private readonly TB value;

    /// <summary>
    /// Initializes a new instance of the
    /// <see cref="Union3Second{TA, TB, TC}"/> class.
    /// </summary>
    /// <param name="value">Element value.</param>
    public Union3Second(TB value)
    {
        this.value = value;
    }

    /// <inheritdoc/>
    public void Continued(
        Action<TA> continuationFirst,
        Action<TB> continuationSecond,
        Action<TC> continuationThird)
    {
        continuationSecond(this.value);
    }

    /// <inheritdoc/>
    public TR Join<TR>(
        Func<TA, TR> mapFirst,
        Func<TB, TR> mapSecond,
        Func<TC, TR> mapThird)
    {
        return mapSecond(this.value);
    }

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        return obj is Union3Second<TA, TB, TC> second &&
            EqualityComparer<TB>.Default.Equals(this.value, second.value);
    }

    /// <inheritdoc/>
    public override int GetHashCode()
    {
#if NETSTANDARD2_0
        return -1584136870 + EqualityComparer<TB>.Default.GetHashCode(this.value);
#else
        return HashCode.Combine(this.value);
#endif
    }

    /// <inheritdoc/>
    public override string ToString()
    {
        return this.value?.ToString() ?? string.Empty;
    }
}
