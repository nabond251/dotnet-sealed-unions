// <copyright file="Union6Second.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.Common.DotnetSealedUnions.Generic;

/// <summary>
/// <see cref="IUnion6{TFirst, TSecond, TThird, TFourth, TFifth, TSixth}"/>
/// element with second of 6 possible types.
/// </summary>
/// <typeparam name="TA">First possible type.</typeparam>
/// <typeparam name="TB">Second possible type.</typeparam>
/// <typeparam name="TC">Third possible type.</typeparam>
/// <typeparam name="TD">Fourth possible type.</typeparam>
/// <typeparam name="TE">Fifth possible type.</typeparam>
/// <typeparam name="TF">Sixth possible type.</typeparam>
internal sealed class Union6Second<TA, TB, TC, TD, TE, TF>
    : IUnion6<TA, TB, TC, TD, TE, TF>
{
    private readonly TB value;

    /// <summary>
    /// Initializes a new instance of the
    /// <see cref="Union6Second{TA, TB, TC, TD, TE, TF}"/> class.
    /// </summary>
    /// <param name="value">Element value.</param>
    public Union6Second(TB value)
    {
        this.value = value;
    }

    /// <inheritdoc/>
    public void Continued(
        Action<TA> continuationFirst,
        Action<TB> continuationSecond,
        Action<TC> continuationThird,
        Action<TD> continuationFourth,
        Action<TE> continuationFifth,
        Action<TF> continuationSixth)
    {
        continuationSecond(this.value);
    }

    /// <inheritdoc/>
    public TR Join<TR>(
        Func<TA, TR> mapFirst,
        Func<TB, TR> mapSecond,
        Func<TC, TR> mapThird,
        Func<TD, TR> mapFourth,
        Func<TE, TR> mapFifth,
        Func<TF, TR> mapSixth)
    {
        return mapSecond(this.value);
    }

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        return obj is Union6Second<TA, TB, TC, TD, TE, TF> second &&
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
