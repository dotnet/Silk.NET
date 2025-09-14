// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [Flags]
    [NativeName("Name", "SpvCooperativeMatrixReduceMask_")]
    public enum CooperativeMatrixReduceMask : int
    {
        [NativeName("Name", "SpvCooperativeMatrixReduceMaskNone")]
        MaskNone = 0x0,
        [NativeName("Name", "SpvCooperativeMatrixReduceRowMask")]
        RowMask = 0x1,
        [NativeName("Name", "SpvCooperativeMatrixReduceColumnMask")]
        ColumnMask = 0x2,
        [NativeName("Name", "SpvCooperativeMatrixReduce2x2Mask")]
        X2Mask = 0x4,
    }
}
