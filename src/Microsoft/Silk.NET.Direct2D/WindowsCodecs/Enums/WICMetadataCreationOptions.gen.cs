// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICMetadataCreationOptions")]
    public enum WICMetadataCreationOptions : int
    {
        [Obsolete("Deprecated in favour of \"Default\"")]
        [NativeName("Name", "WICMetadataCreationDefault")]
        WicmetadataCreationDefault = 0x0,
        [Obsolete("Deprecated in favour of \"AllowUnknown\"")]
        [NativeName("Name", "WICMetadataCreationAllowUnknown")]
        WicmetadataCreationAllowUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"FailUnknown\"")]
        [NativeName("Name", "WICMetadataCreationFailUnknown")]
        WicmetadataCreationFailUnknown = 0x10000,
        [Obsolete("Deprecated in favour of \"Mask\"")]
        [NativeName("Name", "WICMetadataCreationMask")]
        WicmetadataCreationMask = unchecked((int) 0xFFFFFFFFFFFF0000),
        [NativeName("Name", "WICMetadataCreationDefault")]
        Default = 0x0,
        [NativeName("Name", "WICMetadataCreationAllowUnknown")]
        AllowUnknown = 0x0,
        [NativeName("Name", "WICMetadataCreationFailUnknown")]
        FailUnknown = 0x10000,
        [NativeName("Name", "WICMetadataCreationMask")]
        Mask = unchecked((int) 0xFFFFFFFFFFFF0000),
    }
}
