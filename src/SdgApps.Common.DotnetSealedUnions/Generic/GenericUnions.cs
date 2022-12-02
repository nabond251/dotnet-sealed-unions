﻿// <copyright file="GenericUnions.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.Common.DotnetSealedUnions.Generic;

/// <summary>
/// Generic unions container class.
/// </summary>
public static class GenericUnions
{
    public static IUnion0<TResult>.IFactory NulletFactory<TResult>()
    {
        return new Union0Factory<TResult>();
    }

    public static IUnion1<TResult>.IFactory SingletFactory<TResult>()
    {
        return new Union1Factory<TResult>();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="IUnion2{TFirst, TSecond}"/>
    /// class.
    /// </summary>
    /// <typeparam name="TA">First possible type.</typeparam>
    /// <typeparam name="TB">Second possible type.</typeparam>
    /// <returns>
    /// A new instance of the
    /// <see cref="IUnion2{TFirst, TSecond}"/> class.
    /// </returns>
    public static IUnion2<TA, TB>.IFactory DoubletFactory<TA, TB>()
    {
        return new Union2Factory<TA, TB>();
    }

    /// <summary>
    /// Initializes a new instance of the
    /// <see cref="IUnion4{TFirst, TSecond, TThird, TFourth}"/> class.
    /// </summary>
    /// <typeparam name="TA">First possible type.</typeparam>
    /// <typeparam name="TB">Second possible type.</typeparam>
    /// <typeparam name="TC">Third possible type.</typeparam>
    /// <typeparam name="TD">Fourth possible type.</typeparam>
    /// <returns>
    /// A new instance of the
    /// <see cref="IUnion4{TFirst, TSecond, TThird, TFourth}"/> class.
    /// </returns>
    public static IUnion4<TA, TB, TC, TD>.IFactory QuartetFactory<TA, TB, TC, TD>()
    {
        return new Union4Factory<TA, TB, TC, TD>();
    }

    /// <summary>
    /// Initializes a new instance of the
    /// <see cref="IUnion9{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TEighth, TNinth}"/>
    /// class.
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
    /// <returns>
    /// A new instance of the
    /// <see cref="IUnion9{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TEighth, TNinth}"/>
    /// class.
    /// </returns>
    public static IUnion9<TA, TB, TC, TD, TE, TF, TG, TH, TI>.IFactory
        NonetFactory<TA, TB, TC, TD, TE, TF, TG, TH, TI>()
    {
        return new Union9Factory<TA, TB, TC, TD, TE, TF, TG, TH, TI>();
    }

    private sealed class Union0Factory<TA>
        : IUnion0<TA>.IFactory
    {
        public IUnion0<TA> First(TA value)
        {
            return new Union0First<TA>(value);
        }
    }

    private sealed class Union1Factory<TA>
        : IUnion1<TA>.IFactory
    {
        public IUnion1<TA> First(TA value)
        {
            return new Union1First<TA>(value);
        }

        public IUnion1<TA> None()
        {
            return new Union1None<TA>();
        }
    }

    private sealed class Union2Factory<TA, TB>
        : IUnion2<TA, TB>.IFactory
    {
        public IUnion2<TA, TB> First(TA value)
        {
            return new Union2First<TA, TB>(value);
        }

        public IUnion2<TA, TB> Second(TB value)
        {
            return new Union2Second<TA, TB>(value);
        }
    }

    private sealed class Union3Factory<TA, TB, TC>
        : IUnion3<TA, TB, TC>.IFactory
    {
        public IUnion3<TA, TB, TC> First(TA value)
        {
            return new Union3First<TA, TB, TC>(value);
        }

        public IUnion3<TA, TB, TC> Second(TB value)
        {
            return new Union3Second<TA, TB, TC>(value);
        }

        public IUnion3<TA, TB, TC> Third(TC value)
        {
            return new Union3Third<TA, TB, TC>(value);
        }
    }

    private sealed class Union4Factory<TA, TB, TC, TD>
        : IUnion4<TA, TB, TC, TD>.IFactory
    {
        public IUnion4<TA, TB, TC, TD> First(TA value)
        {
            return new Union4First<TA, TB, TC, TD>(value);
        }

        public IUnion4<TA, TB, TC, TD> Second(TB value)
        {
            return new Union4Second<TA, TB, TC, TD>(value);
        }

        public IUnion4<TA, TB, TC, TD> Third(TC value)
        {
            return new Union4Third<TA, TB, TC, TD>(value);
        }

        public IUnion4<TA, TB, TC, TD> Fourth(TD value)
        {
            return new Union4Fourth<TA, TB, TC, TD>(value);
        }
    }

    private sealed class Union5Factory<TA, TB, TC, TD, TE>
        : IUnion5<TA, TB, TC, TD, TE>.IFactory
    {
        public IUnion5<TA, TB, TC, TD, TE> First(TA value)
        {
            return new Union5First<TA, TB, TC, TD, TE>(value);
        }

        public IUnion5<TA, TB, TC, TD, TE> Second(TB value)
        {
            return new Union5Second<TA, TB, TC, TD, TE>(value);
        }

        public IUnion5<TA, TB, TC, TD, TE> Third(TC value)
        {
            return new Union5Third<TA, TB, TC, TD, TE>(value);
        }

        public IUnion5<TA, TB, TC, TD, TE> Fourth(TD value)
        {
            return new Union5Fourth<TA, TB, TC, TD, TE>(value);
        }

        public IUnion5<TA, TB, TC, TD, TE> Fifth(TE value)
        {
            return new Union5Fifth<TA, TB, TC, TD, TE>(value);
        }
    }

    private sealed class Union6Factory<TA, TB, TC, TD, TE, TF>
        : IUnion6<TA, TB, TC, TD, TE, TF>.IFactory
    {
        public IUnion6<TA, TB, TC, TD, TE, TF> First(TA value)
        {
            return new Union6First<TA, TB, TC, TD, TE, TF>(value);
        }

        public IUnion6<TA, TB, TC, TD, TE, TF> Second(TB value)
        {
            return new Union6Second<TA, TB, TC, TD, TE, TF>(value);
        }

        public IUnion6<TA, TB, TC, TD, TE, TF> Third(TC value)
        {
            return new Union6Third<TA, TB, TC, TD, TE, TF>(value);
        }

        public IUnion6<TA, TB, TC, TD, TE, TF> Fourth(TD value)
        {
            return new Union6Fourth<TA, TB, TC, TD, TE, TF>(value);
        }

        public IUnion6<TA, TB, TC, TD, TE, TF> Fifth(TE value)
        {
            return new Union6Fifth<TA, TB, TC, TD, TE, TF>(value);
        }

        public IUnion6<TA, TB, TC, TD, TE, TF> Sixth(TF value)
        {
            return new Union6Sixth<TA, TB, TC, TD, TE, TF>(value);
        }
    }

    private sealed class Union7Factory<TA, TB, TC, TD, TE, TF, TG>
        : IUnion7<TA, TB, TC, TD, TE, TF, TG>.IFactory
    {
        public IUnion7<TA, TB, TC, TD, TE, TF, TG> First(TA value)
        {
            return new Union7First<TA, TB, TC, TD, TE, TF, TG>(value);
        }

        public IUnion7<TA, TB, TC, TD, TE, TF, TG> Second(TB value)
        {
            return new Union7Second<TA, TB, TC, TD, TE, TF, TG>(value);
        }

        public IUnion7<TA, TB, TC, TD, TE, TF, TG> Third(TC value)
        {
            return new Union7Third<TA, TB, TC, TD, TE, TF, TG>(value);
        }

        public IUnion7<TA, TB, TC, TD, TE, TF, TG> Fourth(TD value)
        {
            return new Union7Fourth<TA, TB, TC, TD, TE, TF, TG>(value);
        }

        public IUnion7<TA, TB, TC, TD, TE, TF, TG> Fifth(TE value)
        {
            return new Union7Fifth<TA, TB, TC, TD, TE, TF, TG>(value);
        }

        public IUnion7<TA, TB, TC, TD, TE, TF, TG> Sixth(TF value)
        {
            return new Union7Sixth<TA, TB, TC, TD, TE, TF, TG>(value);
        }

        public IUnion7<TA, TB, TC, TD, TE, TF, TG> Seventh(TG value)
        {
            return new Union7Seventh<TA, TB, TC, TD, TE, TF, TG>(value);
        }
    }

    private sealed class Union8Factory<TA, TB, TC, TD, TE, TF, TG, TH>
        : IUnion8<TA, TB, TC, TD, TE, TF, TG, TH>.IFactory
    {
        public IUnion8<TA, TB, TC, TD, TE, TF, TG, TH> First(TA value)
        {
            return new Union8First<TA, TB, TC, TD, TE, TF, TG, TH>(value);
        }

        public IUnion8<TA, TB, TC, TD, TE, TF, TG, TH> Second(TB value)
        {
            return new Union8Second<TA, TB, TC, TD, TE, TF, TG, TH>(value);
        }

        public IUnion8<TA, TB, TC, TD, TE, TF, TG, TH> Third(TC value)
        {
            return new Union8Third<TA, TB, TC, TD, TE, TF, TG, TH>(value);
        }

        public IUnion8<TA, TB, TC, TD, TE, TF, TG, TH> Fourth(TD value)
        {
            return new Union8Fourth<TA, TB, TC, TD, TE, TF, TG, TH>(value);
        }

        public IUnion8<TA, TB, TC, TD, TE, TF, TG, TH> Fifth(TE value)
        {
            return new Union8Fifth<TA, TB, TC, TD, TE, TF, TG, TH>(value);
        }

        public IUnion8<TA, TB, TC, TD, TE, TF, TG, TH> Sixth(TF value)
        {
            return new Union8Sixth<TA, TB, TC, TD, TE, TF, TG, TH>(value);
        }

        public IUnion8<TA, TB, TC, TD, TE, TF, TG, TH> Seventh(TG value)
        {
            return new Union8Seventh<TA, TB, TC, TD, TE, TF, TG, TH>(value);
        }

        public IUnion8<TA, TB, TC, TD, TE, TF, TG, TH> Eighth(TH value)
        {
            return new Union8Eighth<TA, TB, TC, TD, TE, TF, TG, TH>(value);
        }
    }

    private sealed class Union9Factory<TA, TB, TC, TD, TE, TF, TG, TH, TI>
        : IUnion9<TA, TB, TC, TD, TE, TF, TG, TH, TI>.IFactory
    {
        public IUnion9<TA, TB, TC, TD, TE, TF, TG, TH, TI> First(TA value)
        {
            return new Union9First<TA, TB, TC, TD, TE, TF, TG, TH, TI>(value);
        }

        public IUnion9<TA, TB, TC, TD, TE, TF, TG, TH, TI> Second(TB value)
        {
            return new Union9Second<TA, TB, TC, TD, TE, TF, TG, TH, TI>(value);
        }

        public IUnion9<TA, TB, TC, TD, TE, TF, TG, TH, TI> Third(TC value)
        {
            return new Union9Third<TA, TB, TC, TD, TE, TF, TG, TH, TI>(value);
        }

        public IUnion9<TA, TB, TC, TD, TE, TF, TG, TH, TI> Fourth(TD value)
        {
            return new Union9Fourth<TA, TB, TC, TD, TE, TF, TG, TH, TI>(value);
        }

        public IUnion9<TA, TB, TC, TD, TE, TF, TG, TH, TI> Fifth(TE value)
        {
            return new Union9Fifth<TA, TB, TC, TD, TE, TF, TG, TH, TI>(value);
        }

        public IUnion9<TA, TB, TC, TD, TE, TF, TG, TH, TI> Sixth(TF value)
        {
            return new Union9Sixth<TA, TB, TC, TD, TE, TF, TG, TH, TI>(value);
        }

        public IUnion9<TA, TB, TC, TD, TE, TF, TG, TH, TI> Seventh(TG value)
        {
            return new Union9Seventh<TA, TB, TC, TD, TE, TF, TG, TH, TI>(value);
        }

        public IUnion9<TA, TB, TC, TD, TE, TF, TG, TH, TI> Eighth(TH value)
        {
            return new Union9Eighth<TA, TB, TC, TD, TE, TF, TG, TH, TI>(value);
        }

        public IUnion9<TA, TB, TC, TD, TE, TF, TG, TH, TI> Ninth(TI value)
        {
            return new Union9Ninth<TA, TB, TC, TD, TE, TF, TG, TH, TI>(value);
        }
    }
}
