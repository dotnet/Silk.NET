// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICDecodeOptions")]
    public enum WICDecodeOptions : int
    {
        [Obsolete("Deprecated in favour of \"DecodeMetadataCacheOnDemand\"")]
        [NativeName("Name", "WICDecodeMetadataCacheOnDemand")]
        WicdecodeMetadataCacheOnDemand = 0x0,
        [Obsolete("Deprecated in favour of \"DecodeMetadataCacheOnLoad\"")]
        [NativeName("Name", "WICDecodeMetadataCacheOnLoad")]
        WicdecodeMetadataCacheOnLoad = 0x1,
        [Obsolete("Deprecated in favour of \"EtadatacacheoptionForceDword\"")]
        [NativeName("Name", "WICMETADATACACHEOPTION_FORCE_DWORD")]
        WicmetadatacacheoptionForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICDecodeMetadataCacheOnDemand")]
        DecodeMetadataCacheOnDemand = 0x0,
        [NativeName("Name", "WICDecodeMetadataCacheOnLoad")]
        DecodeMetadataCacheOnLoad = 0x1,
        [NativeName("Name", "WICMETADATACACHEOPTION_FORCE_DWORD")]
        EtadatacacheoptionForceDword = 0x7FFFFFFF,
    }
}
