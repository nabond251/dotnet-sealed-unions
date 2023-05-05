// <copyright file="Union5Fifth.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.Common.DotnetSealedUnions.Generic;

/// <summary>
/// <see cref="IUnion5{TFirst, TSecond, TThird, TFourth, TFifth}"/>
/// element with fifth of 5 possible types.
/// </summary>
/// <typeparam name="TA">First possible type.</typeparam>
/// <typeparam name="TB">Second possible type.</typeparam>
/// <typeparam name="TC">Third possible type.</typeparam>
/// <typeparam name="TD">Fourth possible type.</typeparam>
/// <typeparam name="TE">Fifth possible type.</typeparam>
internal sealed class Union5Fifth<TA, TB, TC, TD, TE>
    : IUnion5<TA, TB, TC, TD, TE>
{
    private readonly TE value;

    /// <summary>
    /// Initializes a new instance of the
    /// <see cref="Union5Fifth{TA, TB, TC, TD, TE}"/> class.
    /// </summary>
    /// <param name="value">Element value.</param>
    public Union5Fifth(TE value)
    {
        this.value = value;
    }

    /// <inheritdoc/>
    public void Continued(
        Action<TA> continuationFirst,
        Action<TB> continuationSecond,
        Action<TC> continuationThird,
        Action<TD> continuationFourth,
        Action<TE> continuationFifth)
    {
        continuationFifth(this.value);
    }

    /// <inheritdoc/>
    public TR Join<TR>(
        Func<TA, TR> mapFirst,
        Func<TB, TR> mapSecond,
        Func<TC, TR> mapThird,
        Func<TD, TR> mapFourth,
        Func<TE, TR> mapFifth)
    {
        return mapFifth(this.value);
    }

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        return obj is Union5Fifth<TA, TB, TC, TD, TE> fifth &&
            EqualityComparer<TE>.Default.Equals(this.value, fifth.value);
    }

    /// <inheritdoc/>
    public override int GetHashCode()
    {
#if NETSTANDARD2_0
        return -1584136870 + EqualityComparer<TE>.Default.GetHashCode(this.value);
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
