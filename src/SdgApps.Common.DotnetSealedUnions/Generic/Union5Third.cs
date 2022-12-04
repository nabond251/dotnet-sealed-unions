// <copyright file="Union5Third.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.Common.DotnetSealedUnions.Generic;

/// <summary>
/// <see cref="IUnion5{TFirst, TSecond, TThird, TFourth, TFifth}"/>
/// element with third of 5 possible types.
/// </summary>
/// <typeparam name="TA">First possible type.</typeparam>
/// <typeparam name="TB">Second possible type.</typeparam>
/// <typeparam name="TC">Third possible type.</typeparam>
/// <typeparam name="TD">Fourth possible type.</typeparam>
/// <typeparam name="TE">Fifth possible type.</typeparam>
internal sealed class Union5Third<TA, TB, TC, TD, TE>
    : IUnion5<TA, TB, TC, TD, TE>
{
    private readonly TC value;

    /// <summary>
    /// Initializes a new instance of the
    /// <see cref="Union5Third{TA, TB, TC, TD, TE}"/> class.
    /// </summary>
    /// <param name="value">Element value.</param>
    public Union5Third(TC value)
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
        continuationThird(this.value);
    }

    /// <inheritdoc/>
    public TR Join<TR>(
        Func<TA, TR> mapFirst,
        Func<TB, TR> mapSecond,
        Func<TC, TR> mapThird,
        Func<TD, TR> mapFourth,
        Func<TE, TR> mapFifth)
    {
        return mapThird(this.value);
    }

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        return obj is Union5Third<TA, TB, TC, TD, TE> third &&
            EqualityComparer<TC>.Default.Equals(this.value, third.value);
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
