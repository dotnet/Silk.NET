// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_PATH_SEGMENT")]
    public enum PathSegment : int
    {
        [NativeName("Name", "D2D1_PATH_SEGMENT_NONE")]
        None = 0x0,
        [NativeName("Name", "D2D1_PATH_SEGMENT_FORCE_UNSTROKED")]
        ForceUnstroked = 0x1,
        [NativeName("Name", "D2D1_PATH_SEGMENT_FORCE_ROUND_LINE_JOIN")]
        ForceRoundLineJoin = 0x2,
        [NativeName("Name", "D2D1_PATH_SEGMENT_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
