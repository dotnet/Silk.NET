// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICBitmapEncoderCacheOption")]
    public enum BitmapEncoderCacheOption : int
    {
        [NativeName("Name", "WICBitmapEncoderCacheInMemory")]
        BitmapEncoderCacheInMemory = 0x0,
        [NativeName("Name", "WICBitmapEncoderCacheTempFile")]
        BitmapEncoderCacheTempFile = 0x1,
        [NativeName("Name", "WICBitmapEncoderNoCache")]
        BitmapEncoderNoCache = 0x2,
        [NativeName("Name", "WICBITMAPENCODERCACHEOPTION_FORCE_DWORD")]
        ItmapencodercacheoptionForceDword = 0x7FFFFFFF,
    }
}
