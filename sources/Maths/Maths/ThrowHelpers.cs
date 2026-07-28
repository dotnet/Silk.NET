// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;

namespace Silk.NET.Maths
{
    internal static class ThrowHelpers
    {
        [DoesNotReturn]
        public static void IndexOutOfRangeException() => throw new IndexOutOfRangeException();

        [DoesNotReturn]
        public static void ArgumentOutOfRangeException_index() => throw new ArgumentOutOfRangeException("index", "Index must be greater than or equal to zero and less than the size of the vector.");
        [DoesNotReturn]
        public static void ArgumentOutOfRangeException_startIndex() => throw new ArgumentOutOfRangeException("startIndex", "Start index must be greater than or equal to zero and leave at least the size of the vector in entries to the collection.");
        [DoesNotReturn]
        public static void ArgumentOutOfRangeException_nearPlaneDistance() => throw new ArgumentOutOfRangeException("nearPlaneDistance", "Near plane must be greater than zero.");
        [DoesNotReturn]
        public static void ArgumentOutOfRangeException_farPlaneDistance() => throw new ArgumentOutOfRangeException("farPlaneDistance", "Far plane must be greater than zero.");
        [DoesNotReturn]
        public static void ArgumentOutOfRangeException_fieldOfView() => throw new ArgumentOutOfRangeException("fieldOfView", "Field of view must be greater than zero and less than Pi.");
        [DoesNotReturn]
        public static void ArgumentNullException_array() => throw new ArgumentNullException("array");

        [DoesNotReturn]
        public static void FormatException_InvalidFormatVector2D() => throw new FormatException("Invalid format for Vector2D.");
        [DoesNotReturn]
        public static void FormatException_InvalidFormatVector3D() => throw new FormatException("Invalid format for Vector3D.");
        [DoesNotReturn]
        public static void FormatException_InvalidFormatVector4D() => throw new FormatException("Invalid format for Vector4D.");

        [DoesNotReturn]
        public static void ArgumentException_InputSpanTooSmall_2() => throw new ArgumentException("Input span must contain exactly 2 elements.", "values");
        [DoesNotReturn]
        public static void ArgumentException_InputSpanTooSmall_3() => throw new ArgumentException("Input span must contain exactly 3 elements.", "values");
        [DoesNotReturn]
        public static void ArgumentException_InputSpanTooSmall_4() => throw new ArgumentException("Input span must contain exactly 4 elements.", "values");
    }
}
