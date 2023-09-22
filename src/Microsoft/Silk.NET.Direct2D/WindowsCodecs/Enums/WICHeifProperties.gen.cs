// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICHeifProperties")]
    public enum WICHeifProperties : int
    {
        [Obsolete("Deprecated in favour of \"Orientation\"")]
        [NativeName("Name", "WICHeifOrientation")]
        WicheifOrientation = 0x1,
        [Obsolete("Deprecated in favour of \"PropertiesForceDword\"")]
        [NativeName("Name", "WICHeifProperties_FORCE_DWORD")]
        WicheifPropertiesForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICHeifOrientation")]
        Orientation = 0x1,
        [NativeName("Name", "WICHeifProperties_FORCE_DWORD")]
        PropertiesForceDword = 0x7FFFFFFF,
    }
}
