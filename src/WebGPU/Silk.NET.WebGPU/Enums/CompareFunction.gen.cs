// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUCompareFunction")]
    public enum CompareFunction : int
    {
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
