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
    public static readonly IReadOnlyCollection<string> ValidArray = new List<string>
    { VALID, VALID, VALID, VALID, VALID, VALID, VALID, VALID, VALID, VALID };

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
        IUnion0<int>.IFactory nulletFactory = GenericUnions.NulletFactory<int>();
        IUnion1<int>.IFactory singletFactory = GenericUnions.SingletFactory<int>();
        IUnion2<int, int>.IFactory doubletFactory = GenericUnions.DoubletFactory<int, int>();
        IUnion3<int, int, int>.IFactory tripletFactory = GenericUnions.TripletFactory<int, int, int>();
        IUnion4<int, int, int, int>.IFactory quartetFactory = GenericUnions
                .QuartetFactory<int, int, int, int>();
        IUnion5<int, int, int, int, int>.IFactory quintetFactory = GenericUnions
                .QuintetFactory<int, int, int, int, int>();
        IUnion6<int, int, int, int, int, int>.IFactory sextetFactory = GenericUnions
                .SextetFactory<int, int, int, int, int, int>();
        IUnion7<int, int, int, int, int, int, int>.IFactory septetFactory = GenericUnions
                .SeptetFactory<int, int, int, int, int, int, int>();
        IUnion8<int, int, int, int, int, int, int, int>.IFactory octetFactory = GenericUnions
                .OctetFactory<int, int, int, int, int, int, int, int>();
        IUnion9<int, int, int, int, int, int, int, int, int>.IFactory nonetFactory = GenericUnions
                .NonetFactory<int, int, int, int, int, int, int, int, int>();
        string join0 = nulletFactory.First(0).Join(VALUE);
        string join1 = singletFactory.First(0).Join(VALUE, () => INVALID);
        string join2 = doubletFactory.First(0).Join(VALUE, EMPTY);
        string join3 = tripletFactory.First(0).Join(VALUE, EMPTY, EMPTY);
        string join4 = quartetFactory.First(0).Join(VALUE, EMPTY, EMPTY, EMPTY);
        string join5 = quintetFactory.First(0).Join(VALUE, EMPTY, EMPTY, EMPTY, EMPTY);
        string join6 = sextetFactory.First(0).Join(VALUE, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY);
        string join7 = septetFactory.First(0).Join(VALUE, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY);
        string join8 = octetFactory.First(0).Join(VALUE, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY);
        string join9 = nonetFactory.First(0).Join(VALUE, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY);
        Assert.Equal(
            ValidArray,
            new List<string> { join0, join1, join2, join3, join4, join5, join6, join7, join8, join9 });
        join1 = singletFactory.None().Join(EMPTY, () => VALID);
        join2 = doubletFactory.Second(0).Join(EMPTY, VALUE);
        join3 = tripletFactory.Second(0).Join(EMPTY, VALUE, EMPTY);
        join4 = quartetFactory.Second(0).Join(EMPTY, VALUE, EMPTY, EMPTY);
        join5 = quintetFactory.Second(0).Join(EMPTY, VALUE, EMPTY, EMPTY, EMPTY);
        join6 = sextetFactory.Second(0).Join(EMPTY, VALUE, EMPTY, EMPTY, EMPTY, EMPTY);
        join7 = septetFactory.Second(0).Join(EMPTY, VALUE, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY);
        join8 = octetFactory.Second(0).Join(EMPTY, VALUE, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY);
        join9 = nonetFactory.Second(0).Join(EMPTY, VALUE, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY);
        Assert.Equal(
            ValidArray,
            new List<string> { join0, join1, join2, join3, join4, join5, join6, join7, join8, join9 });
        join3 = tripletFactory.Third(0).Join(EMPTY, EMPTY, VALUE);
        join4 = quartetFactory.Third(0).Join(EMPTY, EMPTY, VALUE, EMPTY);
        join5 = quintetFactory.Third(0).Join(EMPTY, EMPTY, VALUE, EMPTY, EMPTY);
        join6 = sextetFactory.Third(0).Join(EMPTY, EMPTY, VALUE, EMPTY, EMPTY, EMPTY);
        join7 = septetFactory.Third(0).Join(EMPTY, EMPTY, VALUE, EMPTY, EMPTY, EMPTY, EMPTY);
        join8 = octetFactory.Third(0).Join(EMPTY, EMPTY, VALUE, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY);
        join9 = nonetFactory.Third(0).Join(EMPTY, EMPTY, VALUE, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY);
        Assert.Equal(
            ValidArray,
            new List<string> { join0, join1, join2, join3, join4, join5, join6, join7, join8, join9 });
        join4 = quartetFactory.Fourth(0).Join(EMPTY, EMPTY, EMPTY, VALUE);
        join5 = quintetFactory.Fourth(0).Join(EMPTY, EMPTY, EMPTY, VALUE, EMPTY);
        join6 = sextetFactory.Fourth(0).Join(EMPTY, EMPTY, EMPTY, VALUE, EMPTY, EMPTY);
        join7 = septetFactory.Fourth(0).Join(EMPTY, EMPTY, EMPTY, VALUE, EMPTY, EMPTY, EMPTY);
        join8 = octetFactory.Fourth(0).Join(EMPTY, EMPTY, EMPTY, VALUE, EMPTY, EMPTY, EMPTY, EMPTY);
        join9 = nonetFactory.Fourth(0).Join(EMPTY, EMPTY, EMPTY, VALUE, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY);
        Assert.Equal(
            ValidArray,
            new List<string> { join0, join1, join2, join3, join4, join5, join6, join7, join8, join9 });
        join5 = quintetFactory.Fifth(0).Join(EMPTY, EMPTY, EMPTY, EMPTY, VALUE);
        join6 = sextetFactory.Fifth(0).Join(EMPTY, EMPTY, EMPTY, EMPTY, VALUE, EMPTY);
        join7 = septetFactory.Fifth(0).Join(EMPTY, EMPTY, EMPTY, EMPTY, VALUE, EMPTY, EMPTY);
        join8 = octetFactory.Fifth(0).Join(EMPTY, EMPTY, EMPTY, EMPTY, VALUE, EMPTY, EMPTY, EMPTY);
        join9 = nonetFactory.Fifth(0).Join(EMPTY, EMPTY, EMPTY, EMPTY, VALUE, EMPTY, EMPTY, EMPTY, EMPTY);
        Assert.Equal(
            ValidArray,
            new List<string> { join0, join1, join2, join3, join4, join5, join6, join7, join8, join9 });
        join6 = sextetFactory.Sixth(0).Join(EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, VALUE);
        join7 = septetFactory.Sixth(0).Join(EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, VALUE, EMPTY);
        join8 = octetFactory.Sixth(0).Join(EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, VALUE, EMPTY, EMPTY);
        join9 = nonetFactory.Sixth(0).Join(EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, VALUE, EMPTY, EMPTY, EMPTY);
        Assert.Equal(
            ValidArray,
            new List<string> { join0, join1, join2, join3, join4, join5, join6, join7, join8, join9 });
        join7 = septetFactory.Seventh(0).Join(EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, VALUE);
        join8 = octetFactory.Seventh(0).Join(EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, VALUE, EMPTY);
        join9 = nonetFactory.Seventh(0).Join(EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, VALUE, EMPTY, EMPTY);
        Assert.Equal(
            ValidArray,
            new List<string> { join0, join1, join2, join3, join4, join5, join6, join7, join8, join9 });
        join8 = octetFactory.Eighth(0).Join(EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, VALUE);
        join9 = nonetFactory.Eighth(0).Join(EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, VALUE, EMPTY);
        Assert.Equal(
            ValidArray,
            new List<string> { join0, join1, join2, join3, join4, join5, join6, join7, join8, join9 });
        join9 = nonetFactory.Ninth(0).Join(EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, VALUE);
        Assert.Equal(
            ValidArray,
            new List<string> { join0, join1, join2, join3, join4, join5, join6, join7, join8, join9 });
    }

    /// <summary>
    /// Tests Continue overloads.
    /// </summary>
    [Fact]
    public void TestContinued()
    {
        IUnion0<int>.IFactory nulletFactory = GenericUnions.NulletFactory<int>();
        IUnion1<int>.IFactory singletFactory = GenericUnions.SingletFactory<int>();
        IUnion2<int, int>.IFactory doubletFactory = GenericUnions.DoubletFactory<int, int>();
        IUnion3<int, int, int>.IFactory tripletFactory = GenericUnions.TripletFactory<int, int, int>();
        IUnion4<int, int, int, int>.IFactory quartetFactory = GenericUnions
                .QuartetFactory<int, int, int, int>();
        IUnion5<int, int, int, int, int>.IFactory quintetFactory = GenericUnions
                .QuintetFactory<int, int, int, int, int>();
        IUnion6<int, int, int, int, int, int>.IFactory sextetFactory = GenericUnions
                .SextetFactory<int, int, int, int, int, int>();
        IUnion7<int, int, int, int, int, int, int>.IFactory septetFactory = GenericUnions
                .SeptetFactory<int, int, int, int, int, int, int>();
        IUnion8<int, int, int, int, int, int, int, int>.IFactory octetFactory = GenericUnions
                .OctetFactory<int, int, int, int, int, int, int, int>();
        IUnion9<int, int, int, int, int, int, int, int, int>.IFactory nonetFactory = GenericUnions
                .NonetFactory<int, int, int, int, int, int, int, int, int>();
        nulletFactory.First(0).Continued(SUCCESS);
        singletFactory.First(0).Continued(SUCCESS, () =>
        {
            throw new InvalidOperationException();
        });
        doubletFactory.First(0).Continued(SUCCESS, ERROR);
        tripletFactory.First(0).Continued(SUCCESS, ERROR, ERROR);
        quartetFactory.First(0).Continued(SUCCESS, ERROR, ERROR, ERROR);
        quintetFactory.First(0).Continued(SUCCESS, ERROR, ERROR, ERROR, ERROR);
        sextetFactory.First(0).Continued(SUCCESS, ERROR, ERROR, ERROR, ERROR, ERROR);
        septetFactory.First(0).Continued(SUCCESS, ERROR, ERROR, ERROR, ERROR, ERROR, ERROR);
        octetFactory.First(0).Continued(SUCCESS, ERROR, ERROR, ERROR, ERROR, ERROR, ERROR, ERROR);
        nonetFactory.First(0).Continued(SUCCESS, ERROR, ERROR, ERROR, ERROR, ERROR, ERROR, ERROR, ERROR);

        singletFactory.None().Continued(ERROR, () =>
        {
        });
        doubletFactory.Second(0).Continued(ERROR, SUCCESS);
        tripletFactory.Second(0).Continued(ERROR, SUCCESS, ERROR);
        quartetFactory.Second(0).Continued(ERROR, SUCCESS, ERROR, ERROR);
        quintetFactory.Second(0).Continued(ERROR, SUCCESS, ERROR, ERROR, ERROR);
        sextetFactory.Second(0).Continued(ERROR, SUCCESS, ERROR, ERROR, ERROR, ERROR);
        septetFactory.Second(0).Continued(ERROR, SUCCESS, ERROR, ERROR, ERROR, ERROR, ERROR);
        octetFactory.Second(0).Continued(ERROR, SUCCESS, ERROR, ERROR, ERROR, ERROR, ERROR, ERROR);
        nonetFactory.Second(0).Continued(ERROR, SUCCESS, ERROR, ERROR, ERROR, ERROR, ERROR, ERROR, ERROR);

        tripletFactory.Third(0).Continued(ERROR, ERROR, SUCCESS);
        quartetFactory.Third(0).Continued(ERROR, ERROR, SUCCESS, ERROR);
        quintetFactory.Third(0).Continued(ERROR, ERROR, SUCCESS, ERROR, ERROR);
        sextetFactory.Third(0).Continued(ERROR, ERROR, SUCCESS, ERROR, ERROR, ERROR);
        septetFactory.Third(0).Continued(ERROR, ERROR, SUCCESS, ERROR, ERROR, ERROR, ERROR);
        octetFactory.Third(0).Continued(ERROR, ERROR, SUCCESS, ERROR, ERROR, ERROR, ERROR, ERROR);
        nonetFactory.Third(0).Continued(ERROR, ERROR, SUCCESS, ERROR, ERROR, ERROR, ERROR, ERROR, ERROR);

        quartetFactory.Fourth(0).Continued(ERROR, ERROR, ERROR, SUCCESS);
        quintetFactory.Fourth(0).Continued(ERROR, ERROR, ERROR, SUCCESS, ERROR);
        sextetFactory.Fourth(0).Continued(ERROR, ERROR, ERROR, SUCCESS, ERROR, ERROR);
        septetFactory.Fourth(0).Continued(ERROR, ERROR, ERROR, SUCCESS, ERROR, ERROR, ERROR);
        octetFactory.Fourth(0).Continued(ERROR, ERROR, ERROR, SUCCESS, ERROR, ERROR, ERROR, ERROR);
        nonetFactory.Fourth(0).Continued(ERROR, ERROR, ERROR, SUCCESS, ERROR, ERROR, ERROR, ERROR, ERROR);

        quintetFactory.Fifth(0).Continued(ERROR, ERROR, ERROR, ERROR, SUCCESS);
        sextetFactory.Fifth(0).Continued(ERROR, ERROR, ERROR, ERROR, SUCCESS, ERROR);
        septetFactory.Fifth(0).Continued(ERROR, ERROR, ERROR, ERROR, SUCCESS, ERROR, ERROR);
        octetFactory.Fifth(0).Continued(ERROR, ERROR, ERROR, ERROR, SUCCESS, ERROR, ERROR, ERROR);
        nonetFactory.Fifth(0).Continued(ERROR, ERROR, ERROR, ERROR, SUCCESS, ERROR, ERROR, ERROR, ERROR);

        sextetFactory.Sixth(0).Continued(ERROR, ERROR, ERROR, ERROR, ERROR, SUCCESS);
        septetFactory.Sixth(0).Continued(ERROR, ERROR, ERROR, ERROR, ERROR, SUCCESS, ERROR);
        octetFactory.Sixth(0).Continued(ERROR, ERROR, ERROR, ERROR, ERROR, SUCCESS, ERROR, ERROR);
        nonetFactory.Sixth(0).Continued(ERROR, ERROR, ERROR, ERROR, ERROR, SUCCESS, ERROR, ERROR, ERROR);

        septetFactory.Seventh(0).Continued(ERROR, ERROR, ERROR, ERROR, ERROR, ERROR, SUCCESS);
        octetFactory.Seventh(0).Continued(ERROR, ERROR, ERROR, ERROR, ERROR, ERROR, SUCCESS, ERROR);
        nonetFactory.Seventh(0).Continued(ERROR, ERROR, ERROR, ERROR, ERROR, ERROR, SUCCESS, ERROR, ERROR);

        octetFactory.Eighth(0).Continued(ERROR, ERROR, ERROR, ERROR, ERROR, ERROR, ERROR, SUCCESS);
        nonetFactory.Eighth(0).Continued(ERROR, ERROR, ERROR, ERROR, ERROR, ERROR, ERROR, SUCCESS, ERROR);

        nonetFactory.Ninth(0).Continued(ERROR, ERROR, ERROR, ERROR, ERROR, ERROR, ERROR, ERROR, SUCCESS);

        Assert.True(true);
    }
}
