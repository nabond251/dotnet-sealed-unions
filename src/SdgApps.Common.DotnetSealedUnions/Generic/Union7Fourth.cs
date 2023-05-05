// <copyright file="Union7Fourth.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.Common.DotnetSealedUnions.Generic;

/// <summary>
/// <see cref="IUnion7{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh}"/>
/// element with fourth of 7 possible types.
/// </summary>
/// <typeparam name="TA">First possible type.</typeparam>
/// <typeparam name="TB">Second possible type.</typeparam>
/// <typeparam name="TC">Third possible type.</typeparam>
/// <typeparam name="TD">Fourth possible type.</typeparam>
/// <typeparam name="TE">Fifth possible type.</typeparam>
/// <typeparam name="TF">Sixth possible type.</typeparam>
/// <typeparam name="TG">Seventh possible type.</typeparam>
internal sealed class Union7Fourth<TA, TB, TC, TD, TE, TF, TG>
    : IUnion7<TA, TB, TC, TD, TE, TF, TG>
{
    private readonly TD value;

    /// <summary>
    /// Initializes a new instance of the
    /// <see cref="Union7Fourth{TA, TB, TC, TD, TE, TF, TG}"/> class.
    /// </summary>
    /// <param name="value">Element value.</param>
    public Union7Fourth(TD value)
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
        Action<TG> continuationSeventh)
    {
        continuationFourth(this.value);
    }

    /// <inheritdoc/>
    public TR Join<TR>(
        Func<TA, TR> mapFirst,
        Func<TB, TR> mapSecond,
        Func<TC, TR> mapThird,
        Func<TD, TR> mapFourth,
        Func<TE, TR> mapFifth,
        Func<TF, TR> mapSixth,
        Func<TG, TR> mapSeventh)
    {
        return mapFourth(this.value);
    }

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        return obj is Union7Fourth<TA, TB, TC, TD, TE, TF, TG> fourth &&
            EqualityComparer<TD>.Default.Equals(this.value, fourth.value);
    }

    /// <inheritdoc/>
    public override int GetHashCode()
    {
#if NETSTANDARD2_0
        return -1584136870 + EqualityComparer<TD>.Default.GetHashCode(this.value);
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
