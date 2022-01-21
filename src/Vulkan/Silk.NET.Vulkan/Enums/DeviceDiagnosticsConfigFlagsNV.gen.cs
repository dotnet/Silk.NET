// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkDeviceDiagnosticsConfigFlagsNV")]
    public enum DeviceDiagnosticsConfigFlagsNV : int
    {
        [NativeName("Name", "VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_SHADER_DEBUG_INFO_BIT_NV")]
        DeviceDiagnosticsConfigEnableShaderDebugInfoBitNV = 1,
        [NativeName("Name", "VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_RESOURCE_TRACKING_BIT_NV")]
        DeviceDiagnosticsConfigEnableResourceTrackingBitNV = 2,
        [NativeName("Name", "VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_AUTOMATIC_CHECKPOINTS_BIT_NV")]
        DeviceDiagnosticsConfigEnableAutomaticCheckpointsBitNV = 4,
    }
}
