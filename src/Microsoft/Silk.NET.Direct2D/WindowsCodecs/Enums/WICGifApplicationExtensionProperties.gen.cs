// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICGifApplicationExtensionProperties")]
    public enum WICGifApplicationExtensionProperties : int
    {
        [Obsolete("Deprecated in favour of \"Application\"")]
        [NativeName("Name", "WICGifApplicationExtensionApplication")]
        WicgifApplicationExtensionApplication = 0x1,
        [Obsolete("Deprecated in favour of \"Data\"")]
        [NativeName("Name", "WICGifApplicationExtensionData")]
        WicgifApplicationExtensionData = 0x2,
        [Obsolete("Deprecated in favour of \"PropertiesForceDword\"")]
        [NativeName("Name", "WICGifApplicationExtensionProperties_FORCE_DWORD")]
        WicgifApplicationExtensionPropertiesForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICGifApplicationExtensionApplication")]
        Application = 0x1,
        [NativeName("Name", "WICGifApplicationExtensionData")]
        Data = 0x2,
        [NativeName("Name", "WICGifApplicationExtensionProperties_FORCE_DWORD")]
        PropertiesForceDword = 0x7FFFFFFF,
    }
}
