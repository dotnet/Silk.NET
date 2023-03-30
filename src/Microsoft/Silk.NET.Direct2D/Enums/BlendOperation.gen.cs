// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_BLEND_OPERATION")]
    public enum BlendOperation : int
    {
        [NativeName("Name", "D2D1_BLEND_OPERATION_ADD")]
        Add = 0x1,
        [NativeName("Name", "D2D1_BLEND_OPERATION_SUBTRACT")]
        Subtract = 0x2,
        [NativeName("Name", "D2D1_BLEND_OPERATION_REV_SUBTRACT")]
        RevSubtract = 0x3,
        [NativeName("Name", "D2D1_BLEND_OPERATION_MIN")]
        Min = 0x4,
        [NativeName("Name", "D2D1_BLEND_OPERATION_MAX")]
        Max = 0x5,
        [NativeName("Name", "D2D1_BLEND_OPERATION_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
