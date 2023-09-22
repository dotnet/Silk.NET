// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICPngHistProperties")]
    public enum WICPngHistProperties : int
    {
        [Obsolete("Deprecated in favour of \"Frequencies\"")]
        [NativeName("Name", "WICPngHistFrequencies")]
        WicpngHistFrequencies = 0x1,
        [Obsolete("Deprecated in favour of \"PropertiesForceDword\"")]
        [NativeName("Name", "WICPngHistProperties_FORCE_DWORD")]
        WicpngHistPropertiesForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICPngHistFrequencies")]
        Frequencies = 0x1,
        [NativeName("Name", "WICPngHistProperties_FORCE_DWORD")]
        PropertiesForceDword = 0x7FFFFFFF,
    }
}
