// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_FONT_SOURCE_TYPE")]
    public enum FontSourceType : int
    {
        [NativeName("Name", "DWRITE_FONT_SOURCE_TYPE_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "DWRITE_FONT_SOURCE_TYPE_PER_MACHINE")]
        PerMachine = 0x1,
        [NativeName("Name", "DWRITE_FONT_SOURCE_TYPE_PER_USER")]
        PerUser = 0x2,
        [NativeName("Name", "DWRITE_FONT_SOURCE_TYPE_APPX_PACKAGE")]
        AppxPackage = 0x3,
        [NativeName("Name", "DWRITE_FONT_SOURCE_TYPE_REMOTE_FONT_PROVIDER")]
        RemoteFontProvider = 0x4,
    }
}
