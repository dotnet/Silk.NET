using System;
using System.Diagnostics.CodeAnalysis;

namespace Silk.NET.Maths
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static class ShortScalarHelper
    {
        public static T a<T>(T left, T right) where T : unmanaged, IFormattable => Scalar.Add<T>(left, right);
        public static T s<T>(T left, T right) where T : unmanaged, IFormattable => Scalar.Subtract<T>(left, right);
        public static T m<T>(T left, T right) where T : unmanaged, IFormattable => Scalar.Multiply<T>(left, right);
        public static T d<T>(T left, T right) where T : unmanaged, IFormattable => Scalar.Divide<T>(left, right);
    }
}
