// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrCompareOpFB")]
    public enum CompareOpFB : int
    {
        [Obsolete("Deprecated in favour of \"NeverFB\"")]
        [NativeName("Name", "XR_COMPARE_OP_NEVER_FB")]
        CompareOpNeverFB = 0,
        [Obsolete("Deprecated in favour of \"LessFB\"")]
        [NativeName("Name", "XR_COMPARE_OP_LESS_FB")]
        CompareOpLessFB = 1,
        [Obsolete("Deprecated in favour of \"EqualFB\"")]
        [NativeName("Name", "XR_COMPARE_OP_EQUAL_FB")]
        CompareOpEqualFB = 2,
        [Obsolete("Deprecated in favour of \"LessOrEqualFB\"")]
        [NativeName("Name", "XR_COMPARE_OP_LESS_OR_EQUAL_FB")]
        CompareOpLessOrEqualFB = 3,
        [Obsolete("Deprecated in favour of \"GreaterFB\"")]
        [NativeName("Name", "XR_COMPARE_OP_GREATER_FB")]
        CompareOpGreaterFB = 4,
        [Obsolete("Deprecated in favour of \"NotEqualFB\"")]
        [NativeName("Name", "XR_COMPARE_OP_NOT_EQUAL_FB")]
        CompareOpNotEqualFB = 5,
        [Obsolete("Deprecated in favour of \"GreaterOrEqualFB\"")]
        [NativeName("Name", "XR_COMPARE_OP_GREATER_OR_EQUAL_FB")]
        CompareOpGreaterOrEqualFB = 6,
        [Obsolete("Deprecated in favour of \"AlwaysFB\"")]
        [NativeName("Name", "XR_COMPARE_OP_ALWAYS_FB")]
        CompareOpAlwaysFB = 7,
        [NativeName("Name", "XR_COMPARE_OP_NEVER_FB")]
        NeverFB = 0,
        [NativeName("Name", "XR_COMPARE_OP_LESS_FB")]
        LessFB = 1,
        [NativeName("Name", "XR_COMPARE_OP_EQUAL_FB")]
        EqualFB = 2,
        [NativeName("Name", "XR_COMPARE_OP_LESS_OR_EQUAL_FB")]
        LessOrEqualFB = 3,
        [NativeName("Name", "XR_COMPARE_OP_GREATER_FB")]
        GreaterFB = 4,
        [NativeName("Name", "XR_COMPARE_OP_NOT_EQUAL_FB")]
        NotEqualFB = 5,
        [NativeName("Name", "XR_COMPARE_OP_GREATER_OR_EQUAL_FB")]
        GreaterOrEqualFB = 6,
        [NativeName("Name", "XR_COMPARE_OP_ALWAYS_FB")]
        AlwaysFB = 7,
    }
}
