#region

using System;
using System.Diagnostics.CodeAnalysis;

#endregion

namespace Silk.NET.Maths
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    internal static class ShortScalarHelper
    {
        public static T a<T>(T left, T right) where T : unmanaged, IFormattable => Scalar.Add(left, right);
        public static T s<T>(T left, T right) where T : unmanaged, IFormattable => Scalar.Subtract(left, right);
        public static T m<T>(T left, T right) where T : unmanaged, IFormattable => Scalar.Multiply(left, right);
        public static T d<T>(T left, T right) where T : unmanaged, IFormattable => Scalar.Divide(left, right);
    }
}