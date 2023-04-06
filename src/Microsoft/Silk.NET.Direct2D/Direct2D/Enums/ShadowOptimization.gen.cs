// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_SHADOW_OPTIMIZATION")]
    public enum ShadowOptimization : int
    {
        [NativeName("Name", "D2D1_SHADOW_OPTIMIZATION_SPEED")]
        Speed = 0x0,
        [NativeName("Name", "D2D1_SHADOW_OPTIMIZATION_BALANCED")]
        Balanced = 0x1,
        [NativeName("Name", "D2D1_SHADOW_OPTIMIZATION_QUALITY")]
        Quality = 0x2,
        [NativeName("Name", "D2D1_SHADOW_OPTIMIZATION_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
