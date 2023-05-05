﻿// <copyright file="Union9Eighth.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.Common.DotnetSealedUnions.Generic;

/// <summary>
/// <see cref="IUnion9{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TEighth, TNinth}"/>
/// element with eighth of 9 possible types.
/// </summary>
/// <typeparam name="TA">First possible type.</typeparam>
/// <typeparam name="TB">Second possible type.</typeparam>
/// <typeparam name="TC">Third possible type.</typeparam>
/// <typeparam name="TD">Fourth possible type.</typeparam>
/// <typeparam name="TE">Fifth possible type.</typeparam>
/// <typeparam name="TF">Sixth possible type.</typeparam>
/// <typeparam name="TG">Seventh possible type.</typeparam>
/// <typeparam name="TH">Eighth possible type.</typeparam>
/// <typeparam name="TI">Ninth possible type.</typeparam>
internal sealed class Union9Eighth<TA, TB, TC, TD, TE, TF, TG, TH, TI>
    : IUnion9<TA, TB, TC, TD, TE, TF, TG, TH, TI>
{
    private readonly TH value;

    /// <summary>
    /// Initializes a new instance of the
    /// <see cref="Union9Eighth{TA, TB, TC, TD, TE, TF, TG, TH, TI}"/> class.
    /// </summary>
    /// <param name="value">Element value.</param>
    public Union9Eighth(TH value)
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
        Action<TH> continuationEighth,
        Action<TI> continuationNinth)
    {
        continuationEighth(this.value);
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
        Func<TH, TR> mapEighth,
        Func<TI, TR> mapNinth)
    {
        return mapEighth(this.value);
    }

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        return obj is Union9Eighth<TA, TB, TC, TD, TE, TF, TG, TH, TI> eighth &&
            EqualityComparer<TH>.Default.Equals(this.value, eighth.value);
    }

    /// <inheritdoc/>
    public override int GetHashCode()
    {
#if NETSTANDARD2_0
        return -1584136870 + EqualityComparer<TH>.Default.GetHashCode(this.value);
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
