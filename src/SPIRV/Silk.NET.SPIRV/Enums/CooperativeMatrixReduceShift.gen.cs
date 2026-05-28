// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvCooperativeMatrixReduceShift_")]
    public enum CooperativeMatrixReduceShift : int
    {
        [NativeName("Name", "SpvCooperativeMatrixReduceRowShift")]
        RowShift = 0x0,
        [NativeName("Name", "SpvCooperativeMatrixReduceColumnShift")]
        ColumnShift = 0x1,
        [NativeName("Name", "SpvCooperativeMatrixReduce2x2Shift")]
        X2Shift = 0x2,
        [NativeName("Name", "SpvCooperativeMatrixReduceMax")]
        Max = 0x7FFFFFFF,
    }
}
