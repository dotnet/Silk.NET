// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_FONT_LINE_GAP_USAGE")]
    public enum FontLineGapUsage : int
    {
        [NativeName("Name", "DWRITE_FONT_LINE_GAP_USAGE_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "DWRITE_FONT_LINE_GAP_USAGE_DISABLED")]
        Disabled = 0x1,
        [NativeName("Name", "DWRITE_FONT_LINE_GAP_USAGE_ENABLED")]
        Enabled = 0x2,
    }
}
