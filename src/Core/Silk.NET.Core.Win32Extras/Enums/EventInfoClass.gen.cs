// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "_EVENT_INFO_CLASS")]
    public enum EventInfoClass : int
    {
        [NativeName("Name", "EventProviderBinaryTrackInfo")]
        EventProviderBinaryTrackInfo = 0x0,
        [NativeName("Name", "EventProviderSetReserved1")]
        EventProviderSetReserved1 = 0x1,
        [NativeName("Name", "EventProviderSetTraits")]
        EventProviderSetTraits = 0x2,
        [NativeName("Name", "EventProviderUseDescriptorType")]
        EventProviderUseDescriptorType = 0x3,
        [NativeName("Name", "MaxEventInfo")]
        MaxEventInfo = 0x4,
    }
}
