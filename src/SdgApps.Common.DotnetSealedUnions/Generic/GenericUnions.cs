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

    private sealed class Union2Factory<TA, TB> : IUnion2<TA, TB>.IFactory
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

    private sealed class Union4Factory<TA, TB, TC, TD> : IUnion4<TA, TB, TC, TD>.IFactory
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
