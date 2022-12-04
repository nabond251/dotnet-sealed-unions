// <copyright file="Union7Seventh.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.Common.DotnetSealedUnions.Generic;

/// <summary>
/// <see cref="IUnion7{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh}"/>
/// element with seventh of 7 possible types.
/// </summary>
/// <typeparam name="TA">First possible type.</typeparam>
/// <typeparam name="TB">Second possible type.</typeparam>
/// <typeparam name="TC">Third possible type.</typeparam>
/// <typeparam name="TD">Fourth possible type.</typeparam>
/// <typeparam name="TE">Fifth possible type.</typeparam>
/// <typeparam name="TF">Sixth possible type.</typeparam>
/// <typeparam name="TG">Seventh possible type.</typeparam>
internal sealed class Union7Seventh<TA, TB, TC, TD, TE, TF, TG>
    : IUnion7<TA, TB, TC, TD, TE, TF, TG>
{
    private readonly TG value;

    /// <summary>
    /// Initializes a new instance of the
    /// <see cref="Union7Seventh{TA, TB, TC, TD, TE, TF, TG}"/> class.
    /// </summary>
    /// <param name="value">Element value.</param>
    public Union7Seventh(TG value)
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
        Func<TG, TR> mapSeventh)
    {
        return mapSeventh(this.value);
    }

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        return obj is Union7Seventh<TA, TB, TC, TD, TE, TF, TG> seventh &&
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
