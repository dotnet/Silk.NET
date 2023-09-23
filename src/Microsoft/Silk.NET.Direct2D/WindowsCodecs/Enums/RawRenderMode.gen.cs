// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICRawRenderMode")]
    public enum RawRenderMode : int
    {
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
