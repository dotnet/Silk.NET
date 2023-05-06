// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_FEATURE")]
    public enum Feature : int
    {
        [NativeName("Name", "D2D1_FEATURE_DOUBLES")]
        Doubles = 0x0,
        [NativeName("Name", "D2D1_FEATURE_D3D10_X_HARDWARE_OPTIONS")]
        D3D10XHardwareOptions = 0x1,
        [NativeName("Name", "D2D1_FEATURE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
