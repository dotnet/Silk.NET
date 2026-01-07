// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_APPLICATION_SPECIFIC_DRIVER_BLOB_STATUS")]
    public enum ApplicationSpecificDriverBlobStatus : int
    {
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "D3D12_APPLICATION_SPECIFIC_DRIVER_BLOB_UNKNOWN")]
        ApplicationSpecificDriverBlobUnknown = 0x1,
        [Obsolete("Deprecated in favour of \"Used\"")]
        [NativeName("Name", "D3D12_APPLICATION_SPECIFIC_DRIVER_BLOB_USED")]
        ApplicationSpecificDriverBlobUsed = 0x2,
        [Obsolete("Deprecated in favour of \"Ignored\"")]
        [NativeName("Name", "D3D12_APPLICATION_SPECIFIC_DRIVER_BLOB_IGNORED")]
        ApplicationSpecificDriverBlobIgnored = 0x3,
        [Obsolete("Deprecated in favour of \"NotSpecified\"")]
        [NativeName("Name", "D3D12_APPLICATION_SPECIFIC_DRIVER_BLOB_NOT_SPECIFIED")]
        ApplicationSpecificDriverBlobNotSpecified = 0x4,
        [NativeName("Name", "D3D12_APPLICATION_SPECIFIC_DRIVER_BLOB_UNKNOWN")]
        Unknown = 0x1,
        [NativeName("Name", "D3D12_APPLICATION_SPECIFIC_DRIVER_BLOB_USED")]
        Used = 0x2,
        [NativeName("Name", "D3D12_APPLICATION_SPECIFIC_DRIVER_BLOB_IGNORED")]
        Ignored = 0x3,
        [NativeName("Name", "D3D12_APPLICATION_SPECIFIC_DRIVER_BLOB_NOT_SPECIFIED")]
        NotSpecified = 0x4,
    }
}
