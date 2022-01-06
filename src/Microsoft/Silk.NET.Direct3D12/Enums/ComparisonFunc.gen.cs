// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_COMPARISON_FUNC")]
    public enum ComparisonFunc : int
    {
        [NativeName("Name", "D3D12_COMPARISON_FUNC_NEVER")]
        ComparisonFuncNever = 0x1,
        [NativeName("Name", "D3D12_COMPARISON_FUNC_LESS")]
        ComparisonFuncLess = 0x2,
        [NativeName("Name", "D3D12_COMPARISON_FUNC_EQUAL")]
        ComparisonFuncEqual = 0x3,
        [NativeName("Name", "D3D12_COMPARISON_FUNC_LESS_EQUAL")]
        ComparisonFuncLessEqual = 0x4,
        [NativeName("Name", "D3D12_COMPARISON_FUNC_GREATER")]
        ComparisonFuncGreater = 0x5,
        [NativeName("Name", "D3D12_COMPARISON_FUNC_NOT_EQUAL")]
        ComparisonFuncNotEqual = 0x6,
        [NativeName("Name", "D3D12_COMPARISON_FUNC_GREATER_EQUAL")]
        ComparisonFuncGreaterEqual = 0x7,
        [NativeName("Name", "D3D12_COMPARISON_FUNC_ALWAYS")]
        ComparisonFuncAlways = 0x8,
    }
}
