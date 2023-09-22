// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICWebpAnmfProperties")]
    public enum WICWebpAnmfProperties : int
    {
        [Obsolete("Deprecated in favour of \"FrameDuration\"")]
        [NativeName("Name", "WICWebpAnmfFrameDuration")]
        WicwebpAnmfFrameDuration = 0x1,
        [Obsolete("Deprecated in favour of \"PropertiesForceDword\"")]
        [NativeName("Name", "WICWebpAnmfProperties_FORCE_DWORD")]
        WicwebpAnmfPropertiesForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICWebpAnmfFrameDuration")]
        FrameDuration = 0x1,
        [NativeName("Name", "WICWebpAnmfProperties_FORCE_DWORD")]
        PropertiesForceDword = 0x7FFFFFFF,
    }
}
