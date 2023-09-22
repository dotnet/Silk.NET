// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICPlanarOptions")]
    public enum WICPlanarOptions : int
    {
        [Obsolete("Deprecated in favour of \"PlanarOptionsDefault\"")]
        [NativeName("Name", "WICPlanarOptionsDefault")]
        WicplanarOptionsDefault = 0x0,
        [Obsolete("Deprecated in favour of \"PlanarOptionsPreserveSubsampling\"")]
        [NativeName("Name", "WICPlanarOptionsPreserveSubsampling")]
        WicplanarOptionsPreserveSubsampling = 0x1,
        [Obsolete("Deprecated in favour of \"LanaroptionsForceDword\"")]
        [NativeName("Name", "WICPLANAROPTIONS_FORCE_DWORD")]
        WicplanaroptionsForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICPlanarOptionsDefault")]
        PlanarOptionsDefault = 0x0,
        [NativeName("Name", "WICPlanarOptionsPreserveSubsampling")]
        PlanarOptionsPreserveSubsampling = 0x1,
        [NativeName("Name", "WICPLANAROPTIONS_FORCE_DWORD")]
        LanaroptionsForceDword = 0x7FFFFFFF,
    }
}
