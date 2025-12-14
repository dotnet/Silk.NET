// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvTensorClampMode_")]
    public enum TensorClampMode : int
    {
        [NativeName("Name", "SpvTensorClampModeUndefined")]
        Undefined = 0x0,
        [NativeName("Name", "SpvTensorClampModeConstant")]
        Constant = 0x1,
        [NativeName("Name", "SpvTensorClampModeClampToEdge")]
        ClampToEdge = 0x2,
        [NativeName("Name", "SpvTensorClampModeRepeat")]
        Repeat = 0x3,
        [NativeName("Name", "SpvTensorClampModeRepeatMirrored")]
        RepeatMirrored = 0x4,
        [NativeName("Name", "SpvTensorClampModeMax")]
        Max = 0x7FFFFFFF,
    }
}
