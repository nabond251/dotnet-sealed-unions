// <copyright file="Union4Second.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.Common.DotnetSealedUnions.Generic;

/// <summary>
/// <see cref="IUnion4{TFirst, TSecond, TThird, TFourth}"/>
/// element with second of 4 possible types.
/// </summary>
/// <typeparam name="TA">First possible type.</typeparam>
/// <typeparam name="TB">Second possible type.</typeparam>
/// <typeparam name="TC">Third possible type.</typeparam>
/// <typeparam name="TD">Fourth possible type.</typeparam>
internal sealed class Union4Second<TA, TB, TC, TD>
    : IUnion4<TA, TB, TC, TD>
{
    private readonly TB value;

    /// <summary>
    /// Initializes a new instance of the
    /// <see cref="Union4Second{TA, TB, TC, TD}"/> class.
    /// </summary>
    /// <param name="value">Element value.</param>
    public Union4Second(TB value)
    {
        this.value = value;
    }

    /// <inheritdoc/>
    public void Continued(
        Action<TA> continuationFirst,
        Action<TB> continuationSecond,
        Action<TC> continuationThird,
        Action<TD> continuationFourth)
    {
        continuationSecond(this.value);
    }

    /// <inheritdoc/>
    public TR Join<TR>(
        Func<TA, TR> mapFirst,
        Func<TB, TR> mapSecond,
        Func<TC, TR> mapThird,
        Func<TD, TR> mapFourth)
    {
        return mapSecond(this.value);
    }

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        return obj is Union4Second<TA, TB, TC, TD> second &&
            EqualityComparer<TB>.Default.Equals(this.value, second.value);
    }

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        return HashCode.Combine(this.value);
    }

    /// <inheritdoc/>
    public override string ToString()
    {
        return this.value?.ToString() ?? string.Empty;
    }
}
