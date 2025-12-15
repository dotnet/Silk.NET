// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_COMPARISON_FUNC")]
    public enum ComparisonFunc : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_COMPARISON_FUNC_NONE")]
        ComparisonFuncNone = 0x0,
        [Obsolete("Deprecated in favour of \"Never\"")]
        [NativeName("Name", "D3D12_COMPARISON_FUNC_NEVER")]
        ComparisonFuncNever = 0x1,
        [Obsolete("Deprecated in favour of \"Less\"")]
        [NativeName("Name", "D3D12_COMPARISON_FUNC_LESS")]
        ComparisonFuncLess = 0x2,
        [Obsolete("Deprecated in favour of \"Equal\"")]
        [NativeName("Name", "D3D12_COMPARISON_FUNC_EQUAL")]
        ComparisonFuncEqual = 0x3,
        [Obsolete("Deprecated in favour of \"LessEqual\"")]
        [NativeName("Name", "D3D12_COMPARISON_FUNC_LESS_EQUAL")]
        ComparisonFuncLessEqual = 0x4,
        [Obsolete("Deprecated in favour of \"Greater\"")]
        [NativeName("Name", "D3D12_COMPARISON_FUNC_GREATER")]
        ComparisonFuncGreater = 0x5,
        [Obsolete("Deprecated in favour of \"NotEqual\"")]
        [NativeName("Name", "D3D12_COMPARISON_FUNC_NOT_EQUAL")]
        ComparisonFuncNotEqual = 0x6,
        [Obsolete("Deprecated in favour of \"GreaterEqual\"")]
        [NativeName("Name", "D3D12_COMPARISON_FUNC_GREATER_EQUAL")]
        ComparisonFuncGreaterEqual = 0x7,
        [Obsolete("Deprecated in favour of \"Always\"")]
        [NativeName("Name", "D3D12_COMPARISON_FUNC_ALWAYS")]
        ComparisonFuncAlways = 0x8,
        [NativeName("Name", "D3D12_COMPARISON_FUNC_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_COMPARISON_FUNC_NEVER")]
        Never = 0x1,
        [NativeName("Name", "D3D12_COMPARISON_FUNC_LESS")]
        Less = 0x2,
        [NativeName("Name", "D3D12_COMPARISON_FUNC_EQUAL")]
        Equal = 0x3,
        [NativeName("Name", "D3D12_COMPARISON_FUNC_LESS_EQUAL")]
        LessEqual = 0x4,
        [NativeName("Name", "D3D12_COMPARISON_FUNC_GREATER")]
        Greater = 0x5,
        [NativeName("Name", "D3D12_COMPARISON_FUNC_NOT_EQUAL")]
        NotEqual = 0x6,
        [NativeName("Name", "D3D12_COMPARISON_FUNC_GREATER_EQUAL")]
        GreaterEqual = 0x7,
        [NativeName("Name", "D3D12_COMPARISON_FUNC_ALWAYS")]
        Always = 0x8,
    }
}
