// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [Flags]
    [NativeName("Name", "MF_MEDIA_ENGINE_FRAME_PROTECTION_FLAGS")]
    public enum MediaEngineFrameProtectionFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "MF_MEDIA_ENGINE_FRAME_PROTECTION_FLAG_PROTECTED")]
        Protected = 0x1,
        [NativeName("Name", "MF_MEDIA_ENGINE_FRAME_PROTECTION_FLAG_REQUIRES_SURFACE_PROTECTION")]
        RequiresSurfaceProtection = 0x2,
        [NativeName("Name", "MF_MEDIA_ENGINE_FRAME_PROTECTION_FLAG_REQUIRES_ANTI_SCREEN_SCRAPE_PROTECTION")]
        RequiresAntiScreenScrapeProtection = 0x4,
    }
}
