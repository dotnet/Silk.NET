// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvSamplerAddressingMode_")]
    public enum SamplerAddressingMode : int
    {
        [NativeName("Name", "SpvSamplerAddressingModeNone")]
        None = 0x0,
        [NativeName("Name", "SpvSamplerAddressingModeClampToEdge")]
        ClampToEdge = 0x1,
        [NativeName("Name", "SpvSamplerAddressingModeClamp")]
        Clamp = 0x2,
        [NativeName("Name", "SpvSamplerAddressingModeRepeat")]
        Repeat = 0x3,
        [NativeName("Name", "SpvSamplerAddressingModeRepeatMirrored")]
        RepeatMirrored = 0x4,
        [NativeName("Name", "SpvSamplerAddressingModeMax")]
        Max = 0x7FFFFFFF,
    }
}
