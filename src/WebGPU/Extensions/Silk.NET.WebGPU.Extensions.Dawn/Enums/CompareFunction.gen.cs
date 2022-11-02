// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [NativeName("Name", "WGPUCompareFunction")]
    public enum CompareFunction : int
    {
        [Obsolete("Deprecated in favour of \"Undefined\"")]
        [NativeName("Name", "WGPUCompareFunction_Undefined")]
        CompareFunctionUndefined = 0x0,
        [Obsolete("Deprecated in favour of \"Never\"")]
        [NativeName("Name", "WGPUCompareFunction_Never")]
        CompareFunctionNever = 0x1,
        [Obsolete("Deprecated in favour of \"Less\"")]
        [NativeName("Name", "WGPUCompareFunction_Less")]
        CompareFunctionLess = 0x2,
        [Obsolete("Deprecated in favour of \"LessEqual\"")]
        [NativeName("Name", "WGPUCompareFunction_LessEqual")]
        CompareFunctionLessEqual = 0x3,
        [Obsolete("Deprecated in favour of \"Greater\"")]
        [NativeName("Name", "WGPUCompareFunction_Greater")]
        CompareFunctionGreater = 0x4,
        [Obsolete("Deprecated in favour of \"GreaterEqual\"")]
        [NativeName("Name", "WGPUCompareFunction_GreaterEqual")]
        CompareFunctionGreaterEqual = 0x5,
        [Obsolete("Deprecated in favour of \"Equal\"")]
        [NativeName("Name", "WGPUCompareFunction_Equal")]
        CompareFunctionEqual = 0x6,
        [Obsolete("Deprecated in favour of \"NotEqual\"")]
        [NativeName("Name", "WGPUCompareFunction_NotEqual")]
        CompareFunctionNotEqual = 0x7,
        [Obsolete("Deprecated in favour of \"Always\"")]
        [NativeName("Name", "WGPUCompareFunction_Always")]
        CompareFunctionAlways = 0x8,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUCompareFunction_Force32")]
        CompareFunctionForce32 = 0x7FFFFFFF,
        [NativeName("Name", "WGPUCompareFunction_Undefined")]
        Undefined = 0x0,
        [NativeName("Name", "WGPUCompareFunction_Never")]
        Never = 0x1,
        [NativeName("Name", "WGPUCompareFunction_Less")]
        Less = 0x2,
        [NativeName("Name", "WGPUCompareFunction_LessEqual")]
        LessEqual = 0x3,
        [NativeName("Name", "WGPUCompareFunction_Greater")]
        Greater = 0x4,
        [NativeName("Name", "WGPUCompareFunction_GreaterEqual")]
        GreaterEqual = 0x5,
        [NativeName("Name", "WGPUCompareFunction_Equal")]
        Equal = 0x6,
        [NativeName("Name", "WGPUCompareFunction_NotEqual")]
        NotEqual = 0x7,
        [NativeName("Name", "WGPUCompareFunction_Always")]
        Always = 0x8,
        [NativeName("Name", "WGPUCompareFunction_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
