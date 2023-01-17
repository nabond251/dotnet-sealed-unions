// <copyright file="GenericUnions.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.Common.DotnetSealedUnions.Generic;

/// <summary>
/// Generic unions container class.
/// </summary>
public static class GenericUnions
{
    /// <summary>
    /// Initializes a new instance of the
    /// <see cref="IUnion0{TFirst}.IFactory"/>
    /// class.
    /// </summary>
    /// <typeparam name="TA">First possible type.</typeparam>
    /// <returns>
    /// A new instance of the
    /// <see cref="IUnion0{TFirst}.IFactory"/>
    /// class.
    /// </returns>
    public static IUnion0<TA>.IFactory
        NulletFactory<TA>()
    {
        return new Union0Factory<TA>();
    }

    /// <summary>
    /// Initializes a new instance of the
    /// <see cref="IUnion1{TFirst}.IFactory"/>
    /// class.
    /// </summary>
    /// <typeparam name="TA">First possible type.</typeparam>
    /// <returns>
    /// A new instance of the
    /// <see cref="IUnion1{TFirst}.IFactory"/>
    /// class.
    /// </returns>
    public static IUnion1<TA>.IFactory
        SingletFactory<TA>()
    {
        return new Union1Factory<TA>();
    }

    /// <summary>
    /// Initializes a new instance of the
    /// <see cref="IUnion2{TFirst, TSecond}.IFactory"/>
    /// class.
    /// </summary>
    /// <typeparam name="TA">First possible type.</typeparam>
    /// <typeparam name="TB">Second possible type.</typeparam>
    /// <returns>
    /// A new instance of the
    /// <see cref="IUnion2{TFirst, TSecond}.IFactory"/>
    /// class.
    /// </returns>
    public static IUnion2<TA, TB>.IFactory
        DoubletFactory<TA, TB>()
    {
        return new Union2Factory<TA, TB>();
    }

    /// <summary>
    /// Initializes a new instance of the
    /// <see cref="IUnion3{TFirst, TSecond, TThird}.IFactory"/>
    /// class.
    /// </summary>
    /// <typeparam name="TA">First possible type.</typeparam>
    /// <typeparam name="TB">Second possible type.</typeparam>
    /// <typeparam name="TC">Third possible type.</typeparam>
    /// <returns>
    /// A new instance of the
    /// <see cref="IUnion3{TFirst, TSecond, TThird}.IFactory"/>
    /// class.
    /// </returns>
    public static IUnion3<TA, TB, TC>.IFactory
        TripletFactory<TA, TB, TC>()
    {
        return new Union3Factory<TA, TB, TC>();
    }

    /// <summary>
    /// Initializes a new instance of the
    /// <see cref="IUnion4{TFirst, TSecond, TThird, TFourth}.IFactory"/>
    /// class.
    /// </summary>
    /// <typeparam name="TA">First possible type.</typeparam>
    /// <typeparam name="TB">Second possible type.</typeparam>
    /// <typeparam name="TC">Third possible type.</typeparam>
    /// <typeparam name="TD">Fourth possible type.</typeparam>
    /// <returns>
    /// A new instance of the
    /// <see cref="IUnion4{TFirst, TSecond, TThird, TFourth}.IFactory"/>
    /// class.
    /// </returns>
    public static IUnion4<TA, TB, TC, TD>.IFactory
        QuartetFactory<TA, TB, TC, TD>()
    {
        return new Union4Factory<TA, TB, TC, TD>();
    }

    /// <summary>
    /// Initializes a new instance of the
    /// <see cref="IUnion5{TFirst, TSecond, TThird, TFourth, TFifth}.IFactory"/>
    /// class.
    /// </summary>
    /// <typeparam name="TA">First possible type.</typeparam>
    /// <typeparam name="TB">Second possible type.</typeparam>
    /// <typeparam name="TC">Third possible type.</typeparam>
    /// <typeparam name="TD">Fourth possible type.</typeparam>
    /// <typeparam name="TE">Fifth possible type.</typeparam>
    /// <returns>
    /// A new instance of the
    /// <see cref="IUnion5{TFirst, TSecond, TThird, TFourth, TFifth}.IFactory"/>
    /// class.
    /// </returns>
    public static IUnion5<TA, TB, TC, TD, TE>.IFactory
        QuintetFactory<TA, TB, TC, TD, TE>()
    {
        return new Union5Factory<TA, TB, TC, TD, TE>();
    }

    /// <summary>
    /// Initializes a new instance of the
    /// <see cref="IUnion6{TFirst, TSecond, TThird, TFourth, TFifth, TSixth}.IFactory"/>
    /// class.
    /// </summary>
    /// <typeparam name="TA">First possible type.</typeparam>
    /// <typeparam name="TB">Second possible type.</typeparam>
    /// <typeparam name="TC">Third possible type.</typeparam>
    /// <typeparam name="TD">Fourth possible type.</typeparam>
    /// <typeparam name="TE">Fifth possible type.</typeparam>
    /// <typeparam name="TF">Sixth possible type.</typeparam>
    /// <returns>
    /// A new instance of the
    /// <see cref="IUnion6{TFirst, TSecond, TThird, TFourth, TFifth, TSixth}.IFactory"/>
    /// class.
    /// </returns>
    public static IUnion6<TA, TB, TC, TD, TE, TF>.IFactory
        SextetFactory<TA, TB, TC, TD, TE, TF>()
    {
        return new Union6Factory<TA, TB, TC, TD, TE, TF>();
    }

    /// <summary>
    /// Initializes a new instance of the
    /// <see cref="IUnion7{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh}.IFactory"/>
    /// class.
    /// </summary>
    /// <typeparam name="TA">First possible type.</typeparam>
    /// <typeparam name="TB">Second possible type.</typeparam>
    /// <typeparam name="TC">Third possible type.</typeparam>
    /// <typeparam name="TD">Fourth possible type.</typeparam>
    /// <typeparam name="TE">Fifth possible type.</typeparam>
    /// <typeparam name="TF">Sixth possible type.</typeparam>
    /// <typeparam name="TG">Seventh possible type.</typeparam>
    /// <returns>
    /// A new instance of the
    /// <see cref="IUnion7{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh}.IFactory"/>
    /// class.
    /// </returns>
    public static IUnion7<TA, TB, TC, TD, TE, TF, TG>.IFactory
        SeptetFactory<TA, TB, TC, TD, TE, TF, TG>()
    {
        return new Union7Factory<TA, TB, TC, TD, TE, TF, TG>();
    }

    /// <summary>
    /// Initializes a new instance of the
    /// <see cref="IUnion8{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TEighth}.IFactory"/>
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
    /// <returns>
    /// A new instance of the
    /// <see cref="IUnion8{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TEighth}.IFactory"/>
    /// class.
    /// </returns>
    public static IUnion8<TA, TB, TC, TD, TE, TF, TG, TH>.IFactory
        OctetFactory<TA, TB, TC, TD, TE, TF, TG, TH>()
    {
        return new Union8Factory<TA, TB, TC, TD, TE, TF, TG, TH>();
    }

    /// <summary>
    /// Initializes a new instance of the
    /// <see cref="IUnion9{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TEighth, TNinth}.IFactory"/>
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
    /// <see cref="IUnion9{TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TEighth, TNinth}.IFactory"/>
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
