// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_CHANNEL_DEPTH")]
    public enum ChannelDepth : int
    {
        [NativeName("Name", "D2D1_CHANNEL_DEPTH_DEFAULT")]
        DepthDefault = 0x0,
        [NativeName("Name", "D2D1_CHANNEL_DEPTH_1")]
        Depth1 = 0x1,
        [NativeName("Name", "D2D1_CHANNEL_DEPTH_4")]
        Depth4 = 0x4,
        [NativeName("Name", "D2D1_CHANNEL_DEPTH_FORCE_DWORD")]
        DepthForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
