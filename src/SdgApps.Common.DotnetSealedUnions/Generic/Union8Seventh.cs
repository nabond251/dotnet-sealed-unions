// <copyright file="Union8Seventh.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.Common.DotnetSealedUnions.Generic;

/// <summary>
/// <see cref="IUnion8{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TEighth}"/>
/// element with seventh of 8 possible types.
/// </summary>
/// <typeparam name="TA">First possible type.</typeparam>
/// <typeparam name="TB">Second possible type.</typeparam>
/// <typeparam name="TC">Third possible type.</typeparam>
/// <typeparam name="TD">Fourth possible type.</typeparam>
/// <typeparam name="TE">Fifth possible type.</typeparam>
/// <typeparam name="TF">Sixth possible type.</typeparam>
/// <typeparam name="TG">Seventh possible type.</typeparam>
/// <typeparam name="TH">Eighth possible type.</typeparam>
internal sealed class Union8Seventh<TA, TB, TC, TD, TE, TF, TG, TH>
    : IUnion8<TA, TB, TC, TD, TE, TF, TG, TH>
{
    private readonly TG value;

    /// <summary>
    /// Initializes a new instance of the
    /// <see cref="Union8Seventh{TA, TB, TC, TD, TE, TF, TG, TH}"/> class.
    /// </summary>
    /// <param name="value">Element value.</param>
    public Union8Seventh(TG value)
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
        Action<TF> continuationSixth,
        Action<TG> continuationSeventh,
        Action<TH> continuationEighth)
    {
        continuationSeventh(this.value);
    }

    /// <inheritdoc/>
    public TR Join<TR>(
        Func<TA, TR> mapFirst,
        Func<TB, TR> mapSecond,
        Func<TC, TR> mapThird,
        Func<TD, TR> mapFourth,
        Func<TE, TR> mapFifth,
        Func<TF, TR> mapSixth,
        Func<TG, TR> mapSeventh,
        Func<TH, TR> mapEighth)
    {
        return mapSeventh(this.value);
    }

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        return obj is Union8Seventh<TA, TB, TC, TD, TE, TF, TG, TH> seventh &&
            EqualityComparer<TG>.Default.Equals(this.value, seventh.value);
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
