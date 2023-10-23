// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICRawCapabilities")]
    public enum RawCapabilities : int
    {
        [NativeName("Name", "WICRawCapabilityNotSupported")]
        RawCapabilityNotSupported = 0x0,
        [NativeName("Name", "WICRawCapabilityGetSupported")]
        RawCapabilityGetSupported = 0x1,
        [NativeName("Name", "WICRawCapabilityFullySupported")]
        RawCapabilityFullySupported = 0x2,
        [NativeName("Name", "WICRAWCAPABILITIES_FORCE_DWORD")]
        AwcapabilitiesForceDword = 0x7FFFFFFF,
    }
}
