// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_LINE_JOIN")]
    public enum LineJoin : int
    {
        [NativeName("Name", "D2D1_LINE_JOIN_MITER")]
        Miter = 0x0,
        [NativeName("Name", "D2D1_LINE_JOIN_BEVEL")]
        Bevel = 0x1,
        [NativeName("Name", "D2D1_LINE_JOIN_ROUND")]
        Round = 0x2,
        [NativeName("Name", "D2D1_LINE_JOIN_MITER_OR_BEVEL")]
        MiterOrBevel = 0x3,
        [NativeName("Name", "D2D1_LINE_JOIN_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
