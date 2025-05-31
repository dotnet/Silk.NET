namespace Silk.NET.Maths
{
    using System.Numerics;

    partial struct Vector3F<T> : IEquatable<Vector3F<T>> where T : IFloatingPointIeee754<T>
    {
        public T X;

        public T Y;

        public T Z;

        public Vector3F(T x, T y, T z) => (X, Y, Z) = (x, y, z);

        public static bool operator ==(Vector3F<T> left, Vector3F<T> right) => left.X == right.X && left.Y == right.Y && left.Z == right.Z;

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
