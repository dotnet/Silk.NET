// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICRawRenderMode")]
    public enum WICRawRenderMode : int
    {
        [Obsolete("Deprecated in favour of \"RawRenderModeDraft\"")]
        [NativeName("Name", "WICRawRenderModeDraft")]
        WicrawRenderModeDraft = 0x1,
        [Obsolete("Deprecated in favour of \"RawRenderModeNormal\"")]
        [NativeName("Name", "WICRawRenderModeNormal")]
        WicrawRenderModeNormal = 0x2,
        [Obsolete("Deprecated in favour of \"RawRenderModeBestQuality\"")]
        [NativeName("Name", "WICRawRenderModeBestQuality")]
        WicrawRenderModeBestQuality = 0x3,
        [Obsolete("Deprecated in favour of \"AwrendermodeForceDword\"")]
        [NativeName("Name", "WICRAWRENDERMODE_FORCE_DWORD")]
        WicrawrendermodeForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICRawRenderModeDraft")]
        RawRenderModeDraft = 0x1,
        [NativeName("Name", "WICRawRenderModeNormal")]
        RawRenderModeNormal = 0x2,
        [NativeName("Name", "WICRawRenderModeBestQuality")]
        RawRenderModeBestQuality = 0x3,
        [NativeName("Name", "WICRAWRENDERMODE_FORCE_DWORD")]
        AwrendermodeForceDword = 0x7FFFFFFF,
    }
}
