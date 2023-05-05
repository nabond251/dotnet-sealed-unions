// <copyright file="Union1First.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.Common.DotnetSealedUnions.Generic;

/// <summary>
/// <see cref="IUnion1{TFirst}"/>
/// element with first of 1 possible types.
/// </summary>
/// <typeparam name="TA">First possible type.</typeparam>
internal sealed class Union1First<TA>
    : IUnion1<TA>
{
    private readonly TA value;

    /// <summary>
    /// Initializes a new instance of the
    /// <see cref="Union1First{TA}"/> class.
    /// </summary>
    /// <param name="value">Element value.</param>
    public Union1First(TA value)
    {
        this.value = value;
    }

    /// <inheritdoc/>
    public void Continued(
        Action<TA> continuationFirst,
        Action continuationNone)
    {
        continuationFirst(this.value);
    }

    /// <inheritdoc/>
    public TR Join<TR>(
        Func<TA, TR> mapFirst,
        Func<TR> mapNone)
    {
        return mapFirst(this.value);
    }

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        return obj is Union1First<TA> first &&
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
