// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WIC8BIMIptcDigestProperties")]
    public enum WIC8BIMIptcDigestProperties : int
    {
        [NativeName("Name", "WIC8BIMIptcDigestPString")]
        PString = 0x1,
        [NativeName("Name", "WIC8BIMIptcDigestIptcDigest")]
        IptcDigest = 0x2,
        [NativeName("Name", "WIC8BIMIptcDigestProperties_FORCE_DWORD")]
        PropertiesForceDword = 0x7FFFFFFF,
    }
}
