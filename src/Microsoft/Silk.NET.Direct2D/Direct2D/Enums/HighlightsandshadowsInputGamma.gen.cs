// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_HIGHLIGHTSANDSHADOWS_INPUT_GAMMA")]
    public enum HighlightsandshadowsInputGamma : int
    {
        [NativeName("Name", "D2D1_HIGHLIGHTSANDSHADOWS_INPUT_GAMMA_LINEAR")]
        Linear = 0x0,
        [NativeName("Name", "D2D1_HIGHLIGHTSANDSHADOWS_INPUT_GAMMA_SRGB")]
        Srgb = 0x1,
        [NativeName("Name", "D2D1_HIGHLIGHTSANDSHADOWS_INPUT_GAMMA_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
