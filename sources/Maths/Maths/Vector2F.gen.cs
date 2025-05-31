namespace Silk.NET.Maths
{
    using System.Collections;
    using System.Diagnostics.CodeAnalysis;
    using System.Numerics;

    partial struct Vector2F<T> :
        IEquatable<Vector2F<T>>,
        IReadOnlyList<T>
        where T : IFloatingPointIeee754<T>
    {
        /// <summary>The X component of the vector.</summary>
        public T X;

        /// <summary>The Y component of the vector.</summary>
        public T Y;

        /// <summary>Initializes all components of the vector to the same value.</summary>
        public Vector2F(T value) => (X, Y) = (value, value);

        /// <summary>Initializes the vector with individual component values.</summary>
        public Vector2F(T x, T y) => (X, Y) = (x, y);

        /// <inheritdoc/>
        T IReadOnlyList<T>.this[int index] => this[index];

        ///<summary>Gets the component at the specified index: 0 = X, 1 = Y. </summary>
        [UnscopedRef]
        public ref T this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return ref X;
                    case 1:
                        return ref Y;
                }

                throw new ArgumentOutOfRangeException(nameof(index));
            }
        }

        /// <summary>The number of elements in the vector.</summary>
        public int Count => 2;

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <summary> Returns an enumerator that iterates through the vector components.</summary>
        public IEnumerator<T> GetEnumerator()
        {
            yield return X;
            yield return Y;
        }

        /// <summary>Returns a boolean indicating whether the given two vectors are equal.</summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns><c>true</c> if the given vectors are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(Vector2F<T> left, Vector2F<T> right) =>
            left.X == right.X &&
            left.Y == right.Y;

        /// <summary>Returns a boolean indicating whether the given two vectors are not equal.</summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns><c>true</c> if the given vectors are not equal; <c>false</c> otherwise.</returns>
        public static bool operator !=(Vector2F<T> left, Vector2F<T> right) => !(left == right);

        /// <inheridoc/>
        public override bool Equals(object? obj) => obj is Vector2F<T> other && Equals(other);

        /// <inheridoc/>
        public bool Equals(Vector2F<T> other) => this == other;

        /// <inheridoc/>
        public override int GetHashCode() => HashCode.Combine(X, Y);
    }

    static partial class Vector2F
    {
        public static Vector2F<TSelf> Log<TSelf>(this Vector2F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log(x.X), TSelf.Log(x.Y));

        public static Vector2F<TSelf> Log<TSelf>(this Vector2F<TSelf> x, Vector2F<TSelf> newBase)
            where TSelf : IFloatingPointIeee754<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log(x.X, newBase.X), TSelf.Log(x.Y, newBase.Y));

        public static Vector2F<TSelf> LogP1<TSelf>(this Vector2F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.LogP1(x.X), TSelf.LogP1(x.Y));

        public static Vector2F<TSelf> Log2<TSelf>(this Vector2F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log2(x.X), TSelf.Log2(x.Y));

        public static Vector2F<TSelf> Log2P1<TSelf>(this Vector2F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log2P1(x.X), TSelf.Log2P1(x.Y));

        public static Vector2F<TSelf> Log10<TSelf>(this Vector2F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log10(x.X), TSelf.Log10(x.Y));

        public static Vector2F<TSelf> Log10P1<TSelf>(this Vector2F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log10P1(x.X), TSelf.Log10P1(x.Y));

        public static Vector2F<TSelf> Exp<TSelf>(this Vector2F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.Exp(x.X), TSelf.Exp(x.Y));

        public static Vector2F<TSelf> ExpM1<TSelf>(this Vector2F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.ExpM1(x.X), TSelf.ExpM1(x.Y));

        public static Vector2F<TSelf> Exp2<TSelf>(this Vector2F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.Exp2(x.X), TSelf.Exp2(x.Y));

        public static Vector2F<TSelf> Exp2M1<TSelf>(this Vector2F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.Exp2M1(x.X), TSelf.Exp2M1(x.Y));

        public static Vector2F<TSelf> Exp10<TSelf>(this Vector2F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.Exp10(x.X), TSelf.Exp10(x.Y));

        public static Vector2F<TSelf> Exp10M1<TSelf>(this Vector2F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.Exp10M1(x.X), TSelf.Exp10M1(x.Y));
    }
}
