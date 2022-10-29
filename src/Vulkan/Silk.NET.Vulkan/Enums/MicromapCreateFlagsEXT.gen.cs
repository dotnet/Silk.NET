// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkMicromapCreateFlagsEXT")]
    public enum MicromapCreateFlagsEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"DeviceAddressCaptureReplayBitExt\"")]
        [NativeName("Name", "VK_MICROMAP_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_EXT")]
        MicromapCreateDeviceAddressCaptureReplayBitExt = 1,
        [NativeName("Name", "VK_MICROMAP_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_EXT")]
        DeviceAddressCaptureReplayBitExt = 1,
    }
}
