// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [Flags]
    [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMask_")]
    public enum MatrixMultiplyAccumulateOperandsMask : int
    {
        [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMaskNone")]
        MaskNone = 0x0,
        [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMatrixASignedComponentsINTELMask")]
        MatrixASignedComponentsIntelMask = 0x1,
        [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMatrixBSignedComponentsINTELMask")]
        MatrixBSignedComponentsIntelMask = 0x2,
        [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMatrixCBFloat16INTELMask")]
        MatrixCBFloat16intelMask = 0x4,
        [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMatrixResultBFloat16INTELMask")]
        MatrixResultBFloat16intelMask = 0x8,
        [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMatrixAPackedInt8INTELMask")]
        MatrixAPackedInt8intelMask = 0x10,
        [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMatrixBPackedInt8INTELMask")]
        MatrixBPackedInt8intelMask = 0x20,
        [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMatrixAPackedInt4INTELMask")]
        MatrixAPackedInt4intelMask = 0x40,
        [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMatrixBPackedInt4INTELMask")]
        MatrixBPackedInt4intelMask = 0x80,
        [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMatrixATF32INTELMask")]
        MatrixAtf32intelMask = 0x100,
        [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMatrixBTF32INTELMask")]
        MatrixBtf32intelMask = 0x200,
        [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMatrixAPackedFloat16INTELMask")]
        MatrixAPackedFloat16intelMask = 0x400,
        [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMatrixBPackedFloat16INTELMask")]
        MatrixBPackedFloat16intelMask = 0x800,
        [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMatrixAPackedBFloat16INTELMask")]
        MatrixAPackedBFloat16intelMask = 0x1000,
        [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMatrixBPackedBFloat16INTELMask")]
        MatrixBPackedBFloat16intelMask = 0x2000,
    }
}
