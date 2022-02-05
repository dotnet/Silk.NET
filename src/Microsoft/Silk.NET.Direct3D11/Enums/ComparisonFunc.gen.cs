// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_COMPARISON_FUNC")]
    public enum ComparisonFunc : int
    {
        [NativeName("Name", "D3D11_COMPARISON_NEVER")]
        ComparisonNever = 0x1,
        [NativeName("Name", "D3D11_COMPARISON_LESS")]
        ComparisonLess = 0x2,
        [NativeName("Name", "D3D11_COMPARISON_EQUAL")]
        ComparisonEqual = 0x3,
        [NativeName("Name", "D3D11_COMPARISON_LESS_EQUAL")]
        ComparisonLessEqual = 0x4,
        [NativeName("Name", "D3D11_COMPARISON_GREATER")]
        ComparisonGreater = 0x5,
        [NativeName("Name", "D3D11_COMPARISON_NOT_EQUAL")]
        ComparisonNotEqual = 0x6,
        [NativeName("Name", "D3D11_COMPARISON_GREATER_EQUAL")]
        ComparisonGreaterEqual = 0x7,
        [NativeName("Name", "D3D11_COMPARISON_ALWAYS")]
        ComparisonAlways = 0x8,
    }
}
