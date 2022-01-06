// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [Flags]
    [NativeName("Name", "DXGI_HDR_METADATA_TYPE")]
    public enum HdrMetadataType : int
    {
        [NativeName("Name", "DXGI_HDR_METADATA_TYPE_NONE")]
        HdrMetadataTypeNone = 0x0,
        [NativeName("Name", "DXGI_HDR_METADATA_TYPE_HDR10")]
        HdrMetadataTypeHdr10 = 0x1,
        [NativeName("Name", "DXGI_HDR_METADATA_TYPE_HDR10PLUS")]
        HdrMetadataTypeHdr10Plus = 0x2,
    }
}
