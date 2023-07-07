// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvCooperativeMatrixOperandsShift_")]
    public enum CooperativeMatrixOperandsShift : int
    {
        [NativeName("Name", "SpvCooperativeMatrixOperandsMatrixASignedComponentsShift")]
        MatrixASignedComponentsShift = 0x0,
        [NativeName("Name", "SpvCooperativeMatrixOperandsMatrixBSignedComponentsShift")]
        MatrixBSignedComponentsShift = 0x1,
        [NativeName("Name", "SpvCooperativeMatrixOperandsMatrixCSignedComponentsShift")]
        MatrixCSignedComponentsShift = 0x2,
        [NativeName("Name", "SpvCooperativeMatrixOperandsMatrixResultSignedComponentsShift")]
        MatrixResultSignedComponentsShift = 0x3,
        [NativeName("Name", "SpvCooperativeMatrixOperandsSaturatingAccumulationShift")]
        SaturatingAccumulationShift = 0x4,
        [NativeName("Name", "SpvCooperativeMatrixOperandsMax")]
        Max = 0x7FFFFFFF,
    }
}
