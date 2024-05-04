// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvStoreCacheControl_")]
    public enum StoreCacheControl : int
    {
        [NativeName("Name", "SpvStoreCacheControlUncachedINTEL")]
        UncachedIntel = 0x0,
        [NativeName("Name", "SpvStoreCacheControlWriteThroughINTEL")]
        WriteThroughIntel = 0x1,
        [NativeName("Name", "SpvStoreCacheControlWriteBackINTEL")]
        WriteBackIntel = 0x2,
        [NativeName("Name", "SpvStoreCacheControlStreamingINTEL")]
        StreamingIntel = 0x3,
        [NativeName("Name", "SpvStoreCacheControlMax")]
        Max = 0x7FFFFFFF,
    }
}
