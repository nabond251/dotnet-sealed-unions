// <copyright file="Union1None.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.Common.DotnetSealedUnions.Generic;

/// <summary>
/// <see cref="IUnion1{TFirst}"/>
/// element with no value.
/// </summary>
/// <typeparam name="TA">First possible type.</typeparam>
internal sealed class Union1None<TA>
    : IUnion1<TA>
{
    /// <inheritdoc/>
    public void Continued(
        Action<TA> continuationFirst,
        Action continuationNone)
    {
        continuationNone();
    }

    /// <inheritdoc/>
    public TR Join<TR>(
        Func<TA, TR> mapFirst,
        Func<TR> mapNone)
    {
        return mapNone();
    }

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        return obj is Union1None<TA>;
    }

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        return 1;
    }

    /// <inheritdoc/>
    public override string ToString()
    {
        return "None()";
    }
}
