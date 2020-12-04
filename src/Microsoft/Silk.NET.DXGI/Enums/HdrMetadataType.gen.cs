// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_HDR_METADATA_TYPE")]
    public enum HdrMetadataType
    {
        [NativeName("Name", "DXGI_HDR_METADATA_TYPE_NONE")]
        HdrMetadataTypeNone = 0x0,
        [NativeName("Name", "DXGI_HDR_METADATA_TYPE_HDR10")]
        HdrMetadataTypeHdr10 = 0x1,
        [NativeName("Name", "DXGI_HDR_METADATA_TYPE_HDR10PLUS")]
        HdrMetadataTypeHdr10Plus = 0x2,
    }
}
