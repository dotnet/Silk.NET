// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICBitmapCreateCacheOption")]
    public enum WICBitmapCreateCacheOption : int
    {
        [Obsolete("Deprecated in favour of \"BitmapNoCache\"")]
        [NativeName("Name", "WICBitmapNoCache")]
        WicbitmapNoCache = 0x0,
        [Obsolete("Deprecated in favour of \"BitmapCacheOnDemand\"")]
        [NativeName("Name", "WICBitmapCacheOnDemand")]
        WicbitmapCacheOnDemand = 0x1,
        [Obsolete("Deprecated in favour of \"BitmapCacheOnLoad\"")]
        [NativeName("Name", "WICBitmapCacheOnLoad")]
        WicbitmapCacheOnLoad = 0x2,
        [Obsolete("Deprecated in favour of \"ItmapcreatecacheoptionForceDword\"")]
        [NativeName("Name", "WICBITMAPCREATECACHEOPTION_FORCE_DWORD")]
        WicbitmapcreatecacheoptionForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICBitmapNoCache")]
        BitmapNoCache = 0x0,
        [NativeName("Name", "WICBitmapCacheOnDemand")]
        BitmapCacheOnDemand = 0x1,
        [NativeName("Name", "WICBitmapCacheOnLoad")]
        BitmapCacheOnLoad = 0x2,
        [NativeName("Name", "WICBITMAPCREATECACHEOPTION_FORCE_DWORD")]
        ItmapcreatecacheoptionForceDword = 0x7FFFFFFF,
    }
}
