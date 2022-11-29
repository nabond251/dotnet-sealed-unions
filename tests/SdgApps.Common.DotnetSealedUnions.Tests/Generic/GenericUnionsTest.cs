// <copyright file="GenericUnionsTest.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.Common.DotnetSealedUnions.Tests.Generic;

using SdgApps.Common.DotnetSealedUnions.Generic;

/// <summary>
/// Tests generic sealed unions.
/// </summary>
public class GenericUnionsTest
{
    /// <summary>
    /// Valid union data.
    /// </summary>
    public static readonly string VALID = "a";

    /// <summary>
    /// Invalid union data.
    /// </summary>
    public static readonly string INVALID = string.Empty;

    /// <summary>
    /// Array of expected union data.
    /// </summary>
    public static readonly IReadOnlyCollection<string> ValidArray = new List<string>()
    { VALID, VALID };

    /// <summary>
    /// Valid join.
    /// </summary>
    public static readonly Func<int, string> VALUE = value => VALID;

    /// <summary>
    /// Invalid join.
    /// </summary>
    public static readonly Func<int, string> EMPTY = value => INVALID;

    private static readonly Action<int> SUCCESS = any =>
    {
    };

    private static readonly Action<int> ERROR = any =>
    {
        throw new InvalidOperationException();
    };

    /// <summary>
    /// Tests Join overloads.
    /// </summary>
    [Fact]
    public void TestJoin()
    {
        IUnion2<int, int>.IFactory doubletFactory = GenericUnions.DoubletFactory<int, int>();
        IUnion4<int, int, int, int>.IFactory quartetFactory = GenericUnions
            .QuartetFactory<int, int, int, int>();
        string join2 = doubletFactory.First(0).Join(VALUE, EMPTY);
        string join4 = quartetFactory.First(0).Join(VALUE, EMPTY, EMPTY, EMPTY);
        Assert.Equal(
            ValidArray,
            new List<string> { join2, join4 });
        join2 = doubletFactory.Second(0).Join(EMPTY, VALUE);
        join4 = quartetFactory.Second(0).Join(EMPTY, VALUE, EMPTY, EMPTY);
        Assert.Equal(
            ValidArray,
            new List<string> { join2, join4 });
        join4 = quartetFactory.Third(0).Join(EMPTY, EMPTY, VALUE, EMPTY);
        Assert.Equal(
            ValidArray,
            new List<string> { join2, join4 });
        join4 = quartetFactory.Fourth(0).Join(EMPTY, EMPTY, EMPTY, VALUE);
        Assert.Equal(
            ValidArray,
            new List<string> { join2, join4 });
    }

    /// <summary>
    /// Tests Continue overloads.
    /// </summary>
    [Fact]
    public void TestContinued()
    {
        IUnion2<int, int>.IFactory doubletFactory = GenericUnions.DoubletFactory<int, int>();
        IUnion4<int, int, int, int>.IFactory quartetFactory = GenericUnions
            .QuartetFactory<int, int, int, int>();
        doubletFactory.First(0).Continued(SUCCESS, ERROR);
        quartetFactory.First(0).Continued(SUCCESS, ERROR, ERROR, ERROR);

        doubletFactory.Second(0).Continued(ERROR, SUCCESS);
        quartetFactory.Second(0).Continued(ERROR, SUCCESS, ERROR, ERROR);

        quartetFactory.Third(0).Continued(ERROR, ERROR, SUCCESS, ERROR);

        quartetFactory.Fourth(0).Continued(ERROR, ERROR, ERROR, SUCCESS);

        Assert.True(true);
    }
}
