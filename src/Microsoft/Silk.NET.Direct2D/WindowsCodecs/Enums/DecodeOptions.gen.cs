// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICDecodeOptions")]
    public enum DecodeOptions : int
    {
        [NativeName("Name", "WICDecodeMetadataCacheOnDemand")]
        DecodeMetadataCacheOnDemand = 0x0,
        [NativeName("Name", "WICDecodeMetadataCacheOnLoad")]
        DecodeMetadataCacheOnLoad = 0x1,
        [NativeName("Name", "WICMETADATACACHEOPTION_FORCE_DWORD")]
        EtadatacacheoptionForceDword = 0x7FFFFFFF,
    }
}
