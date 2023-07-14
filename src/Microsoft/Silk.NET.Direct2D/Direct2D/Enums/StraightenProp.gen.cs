// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_STRAIGHTEN_PROP")]
    public enum StraightenProp : int
    {
        [NativeName("Name", "D2D1_STRAIGHTEN_PROP_ANGLE")]
        Angle = 0x0,
        [NativeName("Name", "D2D1_STRAIGHTEN_PROP_MAINTAIN_SIZE")]
        MaintainSize = 0x1,
        [NativeName("Name", "D2D1_STRAIGHTEN_PROP_SCALE_MODE")]
        ScaleMode = 0x2,
        [NativeName("Name", "D2D1_STRAIGHTEN_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
