﻿// <copyright file="GenericUnionsTest.cs" company="Soli Deo Gloria Apps">
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
        IUnion0<int>.IFactory nulletFactory = GenericUnions.nulletFactory<int>();
        IUnion1.IFactory<int> singletFactory = GenericUnions.singletFactory();
        IUnion2.IFactory<int, int> doubletFactory = GenericUnions.doubletFactory();
        IUnion3.IFactory<int, int, int> tripletFactory = GenericUnions.tripletFactory();
        IUnion4.IFactory<int, int, int, int> quartetFactory = GenericUnions
                .quartetFactory();
        IUnion5.IFactory<int, int, int, int, int> quintetFactory = GenericUnions
                .quintetFactory();
        IUnion6.IFactory<int, int, int, int, int, int> sextetFactory = GenericUnions
                .sextetFactory();
        IUnion7.IFactory<int, int, int, int, int, int, int> septetFactory = GenericUnions
                .septetFactory();
        IUnion8.IFactory<int, int, int, int, int, int, int, int> octetFactory = GenericUnions
                .octetFactory();
        IUnion9.IFactory<int, int, int, int, int, int, int, int, int> nonetFactory = GenericUnions
                .nonetFactory();
        String join0 = nulletFactory.first(0).join(VALUE);
        String join1 = singletFactory.first(0).join(VALUE, () -> INVALID);
        String join2 = doubletFactory.first(0).join(VALUE, EMPTY);
        String join3 = tripletFactory.first(0).join(VALUE, EMPTY, EMPTY);
        String join4 = quartetFactory.first(0).join(VALUE, EMPTY, EMPTY, EMPTY);
        String join5 = quintetFactory.first(0).join(VALUE, EMPTY, EMPTY, EMPTY, EMPTY);
        String join6 = sextetFactory.first(0).join(VALUE, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY);
        String join7 = septetFactory.first(0).join(VALUE, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY);
        String join8 = octetFactory.first(0).join(VALUE, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY,
                EMPTY);
        String join9 = nonetFactory.first(0).join(VALUE, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY,
                EMPTY, EMPTY);
        Assert.assertEquals(VALID_ARRAY,
                Arrays.asList(join0, join1, join2, join3, join4, join5, join6, join7, join8, join9));
        join1 = singletFactory.none().join(EMPTY, () -> VALID);
        join2 = doubletFactory.second(0).join(EMPTY, VALUE);
        join3 = tripletFactory.second(0).join(EMPTY, VALUE, EMPTY);
        join4 = quartetFactory.second(0).join(EMPTY, VALUE, EMPTY, EMPTY);
        join5 = quintetFactory.second(0).join(EMPTY, VALUE, EMPTY, EMPTY, EMPTY);
        join6 = sextetFactory.second(0).join(EMPTY, VALUE, EMPTY, EMPTY, EMPTY, EMPTY);
        join7 = septetFactory.second(0).join(EMPTY, VALUE, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY);
        join8 = octetFactory.second(0).join(EMPTY, VALUE, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY);
        join9 = nonetFactory.second(0).join(EMPTY, VALUE, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY,
                EMPTY);
        Assert.assertEquals(VALID_ARRAY,
                Arrays.asList(join0, join1, join2, join3, join4, join5, join6, join7, join8, join9));
        join3 = tripletFactory.third(0).join(EMPTY, EMPTY, VALUE);
        join4 = quartetFactory.third(0).join(EMPTY, EMPTY, VALUE, EMPTY);
        join5 = quintetFactory.third(0).join(EMPTY, EMPTY, VALUE, EMPTY, EMPTY);
        join6 = sextetFactory.third(0).join(EMPTY, EMPTY, VALUE, EMPTY, EMPTY, EMPTY);
        join7 = septetFactory.third(0).join(EMPTY, EMPTY, VALUE, EMPTY, EMPTY, EMPTY, EMPTY);
        join8 = octetFactory.third(0).join(EMPTY, EMPTY, VALUE, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY);
        join9 = nonetFactory.third(0).join(EMPTY, EMPTY, VALUE, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY,
                EMPTY);
        Assert.assertEquals(VALID_ARRAY,
                Arrays.asList(join0, join1, join2, join3, join4, join5, join6, join7, join8, join9));
        join4 = quartetFactory.fourth(0).join(EMPTY, EMPTY, EMPTY, VALUE);
        join5 = quintetFactory.fourth(0).join(EMPTY, EMPTY, EMPTY, VALUE, EMPTY);
        join6 = sextetFactory.fourth(0).join(EMPTY, EMPTY, EMPTY, VALUE, EMPTY, EMPTY);
        join7 = septetFactory.fourth(0).join(EMPTY, EMPTY, EMPTY, VALUE, EMPTY, EMPTY, EMPTY);
        join8 = octetFactory.fourth(0).join(EMPTY, EMPTY, EMPTY, VALUE, EMPTY, EMPTY, EMPTY, EMPTY);
        join9 = nonetFactory.fourth(0).join(EMPTY, EMPTY, EMPTY, VALUE, EMPTY, EMPTY, EMPTY, EMPTY,
                EMPTY);
        Assert.assertEquals(VALID_ARRAY,
                Arrays.asList(join0, join1, join2, join3, join4, join5, join6, join7, join8, join9));
        join5 = quintetFactory.fifth(0).join(EMPTY, EMPTY, EMPTY, EMPTY, VALUE);
        join6 = sextetFactory.fifth(0).join(EMPTY, EMPTY, EMPTY, EMPTY, VALUE, EMPTY);
        join7 = septetFactory.fifth(0).join(EMPTY, EMPTY, EMPTY, EMPTY, VALUE, EMPTY, EMPTY);
        join8 = octetFactory.fifth(0).join(EMPTY, EMPTY, EMPTY, EMPTY, VALUE, EMPTY, EMPTY, EMPTY);
        join9 = nonetFactory.fifth(0).join(EMPTY, EMPTY, EMPTY, EMPTY, VALUE, EMPTY, EMPTY, EMPTY,
                EMPTY);
        Assert.assertEquals(VALID_ARRAY,
                Arrays.asList(join0, join1, join2, join3, join4, join5, join6, join7, join8, join9));
        join6 = sextetFactory.sixth(0).join(EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, VALUE);
        join7 = septetFactory.sixth(0).join(EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, VALUE, EMPTY);
        join8 = octetFactory.sixth(0).join(EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, VALUE, EMPTY, EMPTY);
        join9 = nonetFactory.sixth(0).join(EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, VALUE, EMPTY, EMPTY,
                EMPTY);
        Assert.assertEquals(VALID_ARRAY,
                Arrays.asList(join0, join1, join2, join3, join4, join5, join6, join7, join8, join9));
        join7 = septetFactory.seventh(0).join(EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, VALUE);
        join8 = octetFactory.seventh(0).join(EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, VALUE,
                EMPTY);
        join9 = nonetFactory.seventh(0).join(EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, VALUE, EMPTY,
                EMPTY);
        Assert.assertEquals(VALID_ARRAY,
                Arrays.asList(join0, join1, join2, join3, join4, join5, join6, join7, join8, join9));
        join8 = octetFactory.eighth(0).join(EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, VALUE);
        join9 = nonetFactory.eighth(0).join(EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, VALUE,
                EMPTY);
        Assert.assertEquals(VALID_ARRAY,
                Arrays.asList(join0, join1, join2, join3, join4, join5, join6, join7, join8, join9));
        join9 = nonetFactory.ninth(0).join(EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY, EMPTY,
                VALUE);
        Assert.assertEquals(VALID_ARRAY,
                Arrays.asList(join0, join1, join2, join3, join4, join5, join6, join7, join8, join9));
    }

    @Test
    public void testContinued() throws Exception {
        IUnion0.IFactory<int> nulletFactory = GenericUnions.nulletFactory();
        IUnion1.IFactory<int> singletFactory = GenericUnions.singletFactory();
        IUnion2.IFactory<int, int> doubletFactory = GenericUnions.doubletFactory();
        IUnion3.IFactory<int, int, int> tripletFactory = GenericUnions.tripletFactory();
        IUnion4.IFactory<int, int, int, int> quartetFactory = GenericUnions
                .quartetFactory();
        IUnion5.IFactory<int, int, int, int, int> quintetFactory = GenericUnions
                .quintetFactory();
        IUnion6.IFactory<int, int, int, int, int, int> sextetFactory = GenericUnions
                .sextetFactory();
        IUnion7.IFactory<int, int, int, int, int, int, int> septetFactory = GenericUnions
                .septetFactory();
        IUnion8.IFactory<int, int, int, int, int, int, int, int> octetFactory = GenericUnions
                .octetFactory();
        IUnion9.IFactory<int, int, int, int, int, int, int, int, int> nonetFactory = GenericUnions
                .nonetFactory();
        nulletFactory.first(0).continued(SUCCESS);
        singletFactory.first(0).continued(SUCCESS, () -> {
            throw new IllegalStateException();
        });
        doubletFactory.first(0).continued(SUCCESS, ERROR);
        tripletFactory.first(0).continued(SUCCESS, ERROR, ERROR);
        quartetFactory.first(0).continued(SUCCESS, ERROR, ERROR, ERROR);
        quintetFactory.first(0).continued(SUCCESS, ERROR, ERROR, ERROR, ERROR);
        sextetFactory.first(0).continued(SUCCESS, ERROR, ERROR, ERROR, ERROR, ERROR);
        septetFactory.first(0).continued(SUCCESS, ERROR, ERROR, ERROR, ERROR, ERROR, ERROR);
        octetFactory.first(0).continued(SUCCESS, ERROR, ERROR, ERROR, ERROR, ERROR, ERROR, ERROR);
        nonetFactory.first(0).continued(SUCCESS, ERROR, ERROR, ERROR, ERROR, ERROR, ERROR, ERROR,
                ERROR);
        /* */
        singletFactory.none().continued(ERROR, () -> {
        });
        doubletFactory.second(0).continued(ERROR, SUCCESS);
        tripletFactory.second(0).continued(ERROR, SUCCESS, ERROR);
        quartetFactory.second(0).continued(ERROR, SUCCESS, ERROR, ERROR);
        quintetFactory.second(0).continued(ERROR, SUCCESS, ERROR, ERROR, ERROR);
        sextetFactory.second(0).continued(ERROR, SUCCESS, ERROR, ERROR, ERROR, ERROR);
        septetFactory.second(0).continued(ERROR, SUCCESS, ERROR, ERROR, ERROR, ERROR, ERROR);
        octetFactory.second(0).continued(ERROR, SUCCESS, ERROR, ERROR, ERROR, ERROR, ERROR, ERROR);
        nonetFactory.second(0).continued(ERROR, SUCCESS, ERROR, ERROR, ERROR, ERROR, ERROR, ERROR,
                ERROR);
        /* */
        tripletFactory.third(0).continued(ERROR, ERROR, SUCCESS);
        quartetFactory.third(0).continued(ERROR, ERROR, SUCCESS, ERROR);
        quintetFactory.third(0).continued(ERROR, ERROR, SUCCESS, ERROR, ERROR);
        sextetFactory.third(0).continued(ERROR, ERROR, SUCCESS, ERROR, ERROR, ERROR);
        septetFactory.third(0).continued(ERROR, ERROR, SUCCESS, ERROR, ERROR, ERROR, ERROR);
        octetFactory.third(0).continued(ERROR, ERROR, SUCCESS, ERROR, ERROR, ERROR, ERROR, ERROR);
        nonetFactory.third(0).continued(ERROR, ERROR, SUCCESS, ERROR, ERROR, ERROR, ERROR, ERROR,
                ERROR);
        /* */
        quartetFactory.fourth(0).continued(ERROR, ERROR, ERROR, SUCCESS);
        quintetFactory.fourth(0).continued(ERROR, ERROR, ERROR, SUCCESS, ERROR);
        sextetFactory.fourth(0).continued(ERROR, ERROR, ERROR, SUCCESS, ERROR, ERROR);
        septetFactory.fourth(0).continued(ERROR, ERROR, ERROR, SUCCESS, ERROR, ERROR, ERROR);
        octetFactory.fourth(0).continued(ERROR, ERROR, ERROR, SUCCESS, ERROR, ERROR, ERROR, ERROR);
        nonetFactory.fourth(0).continued(ERROR, ERROR, ERROR, SUCCESS, ERROR, ERROR, ERROR, ERROR,
                ERROR);
        /* */
        quintetFactory.fifth(0).continued(ERROR, ERROR, ERROR, ERROR, SUCCESS);
        sextetFactory.fifth(0).continued(ERROR, ERROR, ERROR, ERROR, SUCCESS, ERROR);
        septetFactory.fifth(0).continued(ERROR, ERROR, ERROR, ERROR, SUCCESS, ERROR, ERROR);
        octetFactory.fifth(0).continued(ERROR, ERROR, ERROR, ERROR, SUCCESS, ERROR, ERROR, ERROR);
        nonetFactory.fifth(0).continued(ERROR, ERROR, ERROR, ERROR, SUCCESS, ERROR, ERROR, ERROR,
                ERROR);
        /* */
        sextetFactory.sixth(0).continued(ERROR, ERROR, ERROR, ERROR, ERROR, SUCCESS);
        septetFactory.sixth(0).continued(ERROR, ERROR, ERROR, ERROR, ERROR, SUCCESS, ERROR);
        octetFactory.sixth(0).continued(ERROR, ERROR, ERROR, ERROR, ERROR, SUCCESS, ERROR, ERROR);
        nonetFactory.sixth(0).continued(ERROR, ERROR, ERROR, ERROR, ERROR, SUCCESS, ERROR, ERROR,
                ERROR);
        /* */
        septetFactory.seventh(0).continued(ERROR, ERROR, ERROR, ERROR, ERROR, ERROR, SUCCESS);
        octetFactory.seventh(0).continued(ERROR, ERROR, ERROR, ERROR, ERROR, ERROR, SUCCESS, ERROR);
        nonetFactory.seventh(0).continued(ERROR, ERROR, ERROR, ERROR, ERROR, ERROR, SUCCESS, ERROR,
                ERROR);
        /* */
        octetFactory.eighth(0).continued(ERROR, ERROR, ERROR, ERROR, ERROR, ERROR, ERROR, SUCCESS);
        nonetFactory.eighth(0).continued(ERROR, ERROR, ERROR, ERROR, ERROR, ERROR, ERROR, SUCCESS,
                ERROR);
        /* */
        nonetFactory.ninth(0).continued(ERROR, ERROR, ERROR, ERROR, ERROR, ERROR, ERROR, ERROR,
                SUCCESS);
    }
}