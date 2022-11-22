// <copyright file="Union4Fourth.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.Common.DotnetSealedUnions.Generic
{
    /// <summary>
    /// <see cref="IUnion4{TFirst, TSecond, TThird, TFourth}"/> element with
    /// fourth of 4 possible types.
    /// </summary>
    /// <typeparam name="TA">First possible type.</typeparam>
    /// <typeparam name="TB">Second possible type.</typeparam>
    /// <typeparam name="TC">Third possible type.</typeparam>
    /// <typeparam name="TD">Fourth possible type.</typeparam>
    internal sealed class Union4Fourth<TA, TB, TC, TD> : IUnion4<TA, TB, TC, TD>
    {
        private readonly TD value;

        /// <summary>
        /// Initializes a new instance of the <see cref="Union4Fourth{TA, TB, TC, TD}"/> class.
        /// </summary>
        /// <param name="value">Element value.</param>
        public Union4Fourth(TD value)
        {
            this.value = value;
        }

        /// <inheritdoc/>
        public void Continued(Action<TA> continuationFirst, Action<TB> continuationSecond, Action<TC> continuationThird, Action<TD> continuationFourth)
        {
            continuationFourth(this.value);
        }

        /// <inheritdoc/>
        public TR Join<TR>(Func<TA, TR> mapFirst, Func<TB, TR> mapSecond, Func<TC, TR> mapThird, Func<TD, TR> mapFourth)
        {
            return mapFourth(this.value);
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return obj is Union4Fourth<TA, TB, TC, TD> fourth &&
                EqualityComparer<TD>.Default.Equals(this.value, fourth.value);
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
}
