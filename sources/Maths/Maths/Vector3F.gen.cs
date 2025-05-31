namespace Silk.NET.Maths
{
    using System.Diagnostics.CodeAnalysis;
    using System.Numerics;

    partial struct Vector3F<T> :
        IEquatable<Vector3F<T>>,
        IReadOnlyList<T>
        where T : IFloatingPointIeee754<T>
    {
        /// <summary>The X component of the vector.</summary>
        public T X;

        /// <summary>The Y component of the vector.</summary>
        public T Y;

        /// <summary>The Z component of the vector.</summary>
        public T Z;

        /// <summary>Initializes all components of the vector to the same value.</summary>
        public Vector3F(T value) => (X, Y, Z) = (value, value, value);

        /// <summary>Initializes the vector with individual component values.</summary>
        public Vector3F(T x, T y, T z) => (X, Y, Z) = (x, y, z);

        /// <inheritdoc/>
        T IReadOnlyList<T>.this[int index] => this[index];

        ///<summary>Gets the component at the specified index: 0 = X, 1 = Y, 2 = Z. </summary>
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
                }

                throw new ArgumentOutOfRangeException(nameof(index));
            }
        }

        /// <summary>Returns a boolean indicating whether the given two vectors are equal.</summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns><c>true</c> if the given vectors are equal; <c>false</c> otherwise.</returns>
        public static bool operator ==(Vector3F<T> left, Vector3F<T> right) =>
            left.X == right.X &&
            left.Y == right.Y &&
            left.Z == right.Z;

        /// <summary>Returns a boolean indicating whether the given two vectors are not equal.</summary>
        /// <param name="left">The first vector to compare.</param>
        /// <param name="right">The second vector to compare.</param>
        /// <returns><c>true</c> if the given vectors are not equal; <c>false</c> otherwise.</returns>
        public static bool operator !=(Vector3F<T> left, Vector3F<T> right) => !(left == right);

        /// <inheridoc/>
        public override bool Equals(object? obj) => obj is Vector3F<T> other && Equals(other);

        /// <inheridoc/>
        public bool Equals(Vector3F<T> other) => this == other;

        /// <inheridoc/>
        public override int GetHashCode() => HashCode.Combine(X, Y, Z);
    }

    static partial class Vector3F
    {
        public static Vector3F<TSelf> Log<TSelf>(this Vector3F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log(x.X), TSelf.Log(x.Y), TSelf.Log(x.Z));

        public static Vector3F<TSelf> Log<TSelf>(this Vector3F<TSelf> x, Vector3F<TSelf> newBase)
            where TSelf : IFloatingPointIeee754<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log(x.X, newBase.X), TSelf.Log(x.Y, newBase.Y), TSelf.Log(x.Z, newBase.Z));

        public static Vector3F<TSelf> LogP1<TSelf>(this Vector3F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.LogP1(x.X), TSelf.LogP1(x.Y), TSelf.LogP1(x.Z));

        public static Vector3F<TSelf> Log2<TSelf>(this Vector3F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log2(x.X), TSelf.Log2(x.Y), TSelf.Log2(x.Z));

        public static Vector3F<TSelf> Log2P1<TSelf>(this Vector3F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log2P1(x.X), TSelf.Log2P1(x.Y), TSelf.Log2P1(x.Z));

        public static Vector3F<TSelf> Log10<TSelf>(this Vector3F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log10(x.X), TSelf.Log10(x.Y), TSelf.Log10(x.Z));

        public static Vector3F<TSelf> Log10P1<TSelf>(this Vector3F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, ILogarithmicFunctions<TSelf> =>
            new(TSelf.Log10P1(x.X), TSelf.Log10P1(x.Y), TSelf.Log10P1(x.Z));

        public static Vector3F<TSelf> Exp<TSelf>(this Vector3F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.Exp(x.X), TSelf.Exp(x.Y), TSelf.Exp(x.Z));

        public static Vector3F<TSelf> ExpM1<TSelf>(this Vector3F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.ExpM1(x.X), TSelf.ExpM1(x.Y), TSelf.ExpM1(x.Z));

        public static Vector3F<TSelf> Exp2<TSelf>(this Vector3F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.Exp2(x.X), TSelf.Exp2(x.Y), TSelf.Exp2(x.Z));

        public static Vector3F<TSelf> Exp2M1<TSelf>(this Vector3F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.Exp2M1(x.X), TSelf.Exp2M1(x.Y), TSelf.Exp2M1(x.Z));

        public static Vector3F<TSelf> Exp10<TSelf>(this Vector3F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.Exp10(x.X), TSelf.Exp10(x.Y), TSelf.Exp10(x.Z));

        public static Vector3F<TSelf> Exp10M1<TSelf>(this Vector3F<TSelf> x)
            where TSelf : IFloatingPointIeee754<TSelf>, IExponentialFunctions<TSelf> =>
            new(TSelf.Exp10M1(x.X), TSelf.Exp10M1(x.Y), TSelf.Exp10M1(x.Z));
    }
}
