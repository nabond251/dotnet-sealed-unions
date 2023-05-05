// <copyright file="Union2First.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.Common.DotnetSealedUnions.Generic;

/// <summary>
/// <see cref="IUnion2{TFirst, TSecond}"/>
/// element with first of 2 possible types.
/// </summary>
/// <typeparam name="TA">First possible type.</typeparam>
/// <typeparam name="TB">Second possible type.</typeparam>
internal sealed class Union2First<TA, TB>
    : IUnion2<TA, TB>
{
    private readonly TA value;

    /// <summary>
    /// Initializes a new instance of the
    /// <see cref="Union2First{TA, TB}"/> class.
    /// </summary>
    /// <param name="value">Element value.</param>
    public Union2First(TA value)
    {
        this.value = value;
    }

    /// <inheritdoc/>
    public void Continued(
        Action<TA> continuationFirst,
        Action<TB> continuationSecond)
    {
        continuationFirst(this.value);
    }

    /// <inheritdoc/>
    public TR Join<TR>(
        Func<TA, TR> mapFirst,
        Func<TB, TR> mapSecond)
    {
        return mapFirst(this.value);
    }

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        return obj is Union2First<TA, TB> first &&
            EqualityComparer<TA>.Default.Equals(this.value, first.value);
    }

    /// <inheritdoc/>
    public override int GetHashCode()
    {
#if NETSTANDARD2_0
        return -1584136870 + EqualityComparer<TA>.Default.GetHashCode(this.value);
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
