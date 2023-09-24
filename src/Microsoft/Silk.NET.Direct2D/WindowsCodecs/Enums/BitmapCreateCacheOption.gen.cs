// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICBitmapCreateCacheOption")]
    public enum BitmapCreateCacheOption : int
    {
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
