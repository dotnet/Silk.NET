// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICJpegChrominanceProperties")]
    public enum WICJpegChrominanceProperties : int
    {
        [Obsolete("Deprecated in favour of \"Table\"")]
        [NativeName("Name", "WICJpegChrominanceTable")]
        WicjpegChrominanceTable = 0x1,
        [Obsolete("Deprecated in favour of \"PropertiesForceDword\"")]
        [NativeName("Name", "WICJpegChrominanceProperties_FORCE_DWORD")]
        WicjpegChrominancePropertiesForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICJpegChrominanceTable")]
        Table = 0x1,
        [NativeName("Name", "WICJpegChrominanceProperties_FORCE_DWORD")]
        PropertiesForceDword = 0x7FFFFFFF,
    }
}
