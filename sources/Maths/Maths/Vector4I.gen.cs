namespace Silk.NET.Maths
{
    using System.Diagnostics.CodeAnalysis;
    using System.Numerics;

    partial struct Vector4I<T> : IEquatable<Vector4I<T>> where T : IBinaryInteger<T>
    {
        /// <summary>The X component of the vector.</summary>
        public T X;

        /// <summary>The Y component of the vector.</summary>
        public T Y;

        /// <summary>The Z component of the vector.</summary>
        public T Z;

        /// <summary>The W component of the vector.</summary>
        public T W;

        /// <summary>Initializes the vector with individual component values.</summary>
        public Vector4I(T x, T y, T z, T w) => (X, Y, Z, W) = (x, y, z, w);

        /// <inheritdoc/>
        T IReadOnlyList<T>.this[int index] => this[index];

        ///<summary>Gets the component at the specified index: 0 = X, 1 = Y, 2 = Z, 3 = W. </summary>
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
                    case 2:
                        return ref Z;
                    case 3:
                        return ref W;
                }

                throw new ArgumentOutOfRangeException(nameof(index));
            }
        }

        /// <summary>Returns a boolean indicating whether the given two vectors are equal.</summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns><c>true</c> if the given vectors are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(Vector4I<T> left, Vector4I<T> right) =>
            left.X == right.X &&
            left.Y == right.Y &&
            left.Z == right.Z &&
            left.W == right.W;

        /// <summary>Returns a boolean indicating whether the given two vectors are not equal.</summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns><c>true</c> if the given vectors are not equal; <c>false</c> otherwise.</returns>
        public static bool operator !=(Vector4I<T> left, Vector4I<T> right) => !(left == right);

        /// <inheridoc/>
        public override bool Equals(object? obj) => obj is Vector4I<T> other && Equals(other);

        /// <inheridoc/>
        public bool Equals(Vector4I<T> other) => this == other;

        /// <inheridoc/>
        public override int GetHashCode() => HashCode.Combine(X, Y, Z, W);
    }

    static partial class Vector4I
    {
        public static Vector4I<TSelf> Log<TSelf>(this Vector4I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log(x.X), TSelf.Log(x.Y), TSelf.Log(x.Z), TSelf.Log(x.W));

        public static Vector4I<TSelf> Log<TSelf>(this Vector4I<TSelf> x, Vector4I<TSelf> newBase)
            where TSelf : IBinaryInteger<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log(x.X, newBase.X), TSelf.Log(x.Y, newBase.Y), TSelf.Log(x.Z, newBase.Z), TSelf.Log(x.W, newBase.W));

        public static Vector4I<TSelf> LogP1<TSelf>(this Vector4I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.LogP1(x.X), TSelf.LogP1(x.Y), TSelf.LogP1(x.Z), TSelf.LogP1(x.W));

        public static Vector4I<TSelf> Log2<TSelf>(this Vector4I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log2(x.X), TSelf.Log2(x.Y), TSelf.Log2(x.Z), TSelf.Log2(x.W));

        public static Vector4I<TSelf> Log2P1<TSelf>(this Vector4I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log2P1(x.X), TSelf.Log2P1(x.Y), TSelf.Log2P1(x.Z), TSelf.Log2P1(x.W));

        public static Vector4I<TSelf> Log10<TSelf>(this Vector4I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log10(x.X), TSelf.Log10(x.Y), TSelf.Log10(x.Z), TSelf.Log10(x.W));

        public static Vector4I<TSelf> Log10P1<TSelf>(this Vector4I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log10P1(x.X), TSelf.Log10P1(x.Y), TSelf.Log10P1(x.Z), TSelf.Log10P1(x.W));

        public static Vector4I<TSelf> Exp<TSelf>(this Vector4I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.Exp(x.X), TSelf.Exp(x.Y), TSelf.Exp(x.Z), TSelf.Exp(x.W));

        public static Vector4I<TSelf> ExpM1<TSelf>(this Vector4I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.ExpM1(x.X), TSelf.ExpM1(x.Y), TSelf.ExpM1(x.Z), TSelf.ExpM1(x.W));

        public static Vector4I<TSelf> Exp2<TSelf>(this Vector4I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.Exp2(x.X), TSelf.Exp2(x.Y), TSelf.Exp2(x.Z), TSelf.Exp2(x.W));

        public static Vector4I<TSelf> Exp2M1<TSelf>(this Vector4I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.Exp2M1(x.X), TSelf.Exp2M1(x.Y), TSelf.Exp2M1(x.Z), TSelf.Exp2M1(x.W));

        public static Vector4I<TSelf> Exp10<TSelf>(this Vector4I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.Exp10(x.X), TSelf.Exp10(x.Y), TSelf.Exp10(x.Z), TSelf.Exp10(x.W));

        public static Vector4I<TSelf> Exp10M1<TSelf>(this Vector4I<TSelf> x)
            where TSelf : IBinaryInteger<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.Exp10M1(x.X), TSelf.Exp10M1(x.Y), TSelf.Exp10M1(x.Z), TSelf.Exp10M1(x.W));
    }
}
