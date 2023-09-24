// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WIC8BIMIptcProperties")]
    public enum WIC8BIMIptcProperties : int
    {
        [NativeName("Name", "WIC8BIMIptcPString")]
        PString = 0x0,
        [NativeName("Name", "WIC8BIMIptcEmbeddedIPTC")]
        EmbeddedIptc = 0x1,
        [NativeName("Name", "WIC8BIMIptcProperties_FORCE_DWORD")]
        PropertiesForceDword = 0x7FFFFFFF,
    }
}
