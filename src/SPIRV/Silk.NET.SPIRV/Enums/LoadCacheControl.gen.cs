// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvLoadCacheControl_")]
    public enum LoadCacheControl : int
    {
        [NativeName("Name", "SpvLoadCacheControlUncachedINTEL")]
        UncachedIntel = 0x0,
        [NativeName("Name", "SpvLoadCacheControlCachedINTEL")]
        CachedIntel = 0x1,
        [NativeName("Name", "SpvLoadCacheControlStreamingINTEL")]
        StreamingIntel = 0x2,
        [NativeName("Name", "SpvLoadCacheControlInvalidateAfterReadINTEL")]
        InvalidateAfterReadIntel = 0x3,
        [NativeName("Name", "SpvLoadCacheControlConstCachedINTEL")]
        ConstCachedIntel = 0x4,
        [NativeName("Name", "SpvLoadCacheControlMax")]
        Max = 0x7FFFFFFF,
    }
}
