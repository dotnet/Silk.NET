// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICMetadataCreationOptions")]
    public enum MetadataCreationOptions : int
    {
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
