// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsShift_")]
    public enum MatrixMultiplyAccumulateOperandsShift : int
    {
        [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMatrixASignedComponentsINTELShift")]
        MatrixASignedComponentsIntelShift = 0x0,
        [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMatrixBSignedComponentsINTELShift")]
        MatrixBSignedComponentsIntelShift = 0x1,
        [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMatrixCBFloat16INTELShift")]
        MatrixCBFloat16intelShift = 0x2,
        [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMatrixResultBFloat16INTELShift")]
        MatrixResultBFloat16intelShift = 0x3,
        [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMatrixAPackedInt8INTELShift")]
        MatrixAPackedInt8intelShift = 0x4,
        [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMatrixBPackedInt8INTELShift")]
        MatrixBPackedInt8intelShift = 0x5,
        [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMatrixAPackedInt4INTELShift")]
        MatrixAPackedInt4intelShift = 0x6,
        [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMatrixBPackedInt4INTELShift")]
        MatrixBPackedInt4intelShift = 0x7,
        [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMatrixATF32INTELShift")]
        MatrixAtf32intelShift = 0x8,
        [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMatrixBTF32INTELShift")]
        MatrixBtf32intelShift = 0x9,
        [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMatrixAPackedFloat16INTELShift")]
        MatrixAPackedFloat16intelShift = 0xA,
        [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMatrixBPackedFloat16INTELShift")]
        MatrixBPackedFloat16intelShift = 0xB,
        [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMatrixAPackedBFloat16INTELShift")]
        MatrixAPackedBFloat16intelShift = 0xC,
        [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMatrixBPackedBFloat16INTELShift")]
        MatrixBPackedBFloat16intelShift = 0xD,
        [NativeName("Name", "SpvMatrixMultiplyAccumulateOperandsMax")]
        Max = 0x7FFFFFFF,
    }
}
