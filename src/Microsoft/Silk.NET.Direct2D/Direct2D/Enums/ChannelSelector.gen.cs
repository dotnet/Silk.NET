// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_CHANNEL_SELECTOR")]
    public enum ChannelSelector : int
    {
        [NativeName("Name", "D2D1_CHANNEL_SELECTOR_R")]
        R = 0x0,
        [NativeName("Name", "D2D1_CHANNEL_SELECTOR_G")]
        G = 0x1,
        [NativeName("Name", "D2D1_CHANNEL_SELECTOR_B")]
        B = 0x2,
        [NativeName("Name", "D2D1_CHANNEL_SELECTOR_A")]
        A = 0x3,
        [NativeName("Name", "D2D1_CHANNEL_SELECTOR_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
