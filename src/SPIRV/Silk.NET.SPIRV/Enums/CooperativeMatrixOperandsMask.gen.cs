// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [Flags]
    [NativeName("Name", "SpvCooperativeMatrixOperandsMask_")]
    public enum CooperativeMatrixOperandsMask : int
    {
        [NativeName("Name", "SpvCooperativeMatrixOperandsMaskNone")]
        MaskNone = 0x0,
        [NativeName("Name", "SpvCooperativeMatrixOperandsMatrixASignedComponentsMask")]
        MatrixASignedComponentsMask = 0x1,
        [NativeName("Name", "SpvCooperativeMatrixOperandsMatrixBSignedComponentsMask")]
        MatrixBSignedComponentsMask = 0x2,
        [NativeName("Name", "SpvCooperativeMatrixOperandsMatrixCSignedComponentsMask")]
        MatrixCSignedComponentsMask = 0x4,
        [NativeName("Name", "SpvCooperativeMatrixOperandsMatrixResultSignedComponentsMask")]
        MatrixResultSignedComponentsMask = 0x8,
        [NativeName("Name", "SpvCooperativeMatrixOperandsSaturatingAccumulationMask")]
        SaturatingAccumulationMask = 0x10,
    }
}
