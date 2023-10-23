// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvCooperativeMatrixUse_")]
    public enum CooperativeMatrixUse : int
    {
        [NativeName("Name", "SpvCooperativeMatrixUseMatrixAKHR")]
        MatrixAkhr = 0x0,
        [NativeName("Name", "SpvCooperativeMatrixUseMatrixBKHR")]
        MatrixBkhr = 0x1,
        [NativeName("Name", "SpvCooperativeMatrixUseMatrixAccumulatorKHR")]
        MatrixAccumulatorKhr = 0x2,
        [NativeName("Name", "SpvCooperativeMatrixUseMax")]
        Max = 0x7FFFFFFF,
    }
}
