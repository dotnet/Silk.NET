// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvCooperativeMatrixLayout_")]
    public enum CooperativeMatrixLayout : int
    {
        [NativeName("Name", "SpvCooperativeMatrixLayoutRowMajorKHR")]
        RowMajorKhr = 0x0,
        [NativeName("Name", "SpvCooperativeMatrixLayoutColumnMajorKHR")]
        ColumnMajorKhr = 0x1,
        [NativeName("Name", "SpvCooperativeMatrixLayoutRowBlockedInterleavedARM")]
        RowBlockedInterleavedArm = 0x106A,
        [NativeName("Name", "SpvCooperativeMatrixLayoutColumnBlockedInterleavedARM")]
        ColumnBlockedInterleavedArm = 0x106B,
        [NativeName("Name", "SpvCooperativeMatrixLayoutMax")]
        Max = 0x7FFFFFFF,
    }
}
