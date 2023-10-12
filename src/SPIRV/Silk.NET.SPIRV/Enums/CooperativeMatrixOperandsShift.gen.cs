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
        [NativeName("Name", "SpvCooperativeMatrixOperandsMatrixASignedComponentsKHRShift")]
        MatrixASignedComponentsKhrShift = 0x0,
        [NativeName("Name", "SpvCooperativeMatrixOperandsMatrixBSignedComponentsKHRShift")]
        MatrixBSignedComponentsKhrShift = 0x1,
        [NativeName("Name", "SpvCooperativeMatrixOperandsMatrixCSignedComponentsKHRShift")]
        MatrixCSignedComponentsKhrShift = 0x2,
        [NativeName("Name", "SpvCooperativeMatrixOperandsMatrixResultSignedComponentsKHRShift")]
        MatrixResultSignedComponentsKhrShift = 0x3,
        [NativeName("Name", "SpvCooperativeMatrixOperandsSaturatingAccumulationKHRShift")]
        SaturatingAccumulationKhrShift = 0x4,
        [NativeName("Name", "SpvCooperativeMatrixOperandsMax")]
        Max = 0x7FFFFFFF,
    }
}
