// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkDeviceDiagnosticsConfigFlagsNV")]
    public enum DeviceDiagnosticsConfigFlagsNV
    {
        [NativeName("Name", "VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_SHADER_DEBUG_INFO_BIT_NV")]
        DeviceDiagnosticsConfigEnableShaderDebugInfoBitNV = 1,
        [NativeName("Name", "VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_RESOURCE_TRACKING_BIT_NV")]
        DeviceDiagnosticsConfigEnableResourceTrackingBitNV = 2,
        [NativeName("Name", "VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_AUTOMATIC_CHECKPOINTS_BIT_NV")]
        DeviceDiagnosticsConfigEnableAutomaticCheckpointsBitNV = 4,
    }
}
