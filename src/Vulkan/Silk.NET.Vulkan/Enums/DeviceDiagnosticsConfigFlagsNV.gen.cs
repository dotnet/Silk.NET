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
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ShaderDebugInfoBitNV\"")]
        [NativeName("Name", "VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_SHADER_DEBUG_INFO_BIT_NV")]
        DeviceDiagnosticsConfigEnableShaderDebugInfoBitNV = 1,
        [Obsolete("Deprecated in favour of \"ResourceTrackingBitNV\"")]
        [NativeName("Name", "VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_RESOURCE_TRACKING_BIT_NV")]
        DeviceDiagnosticsConfigEnableResourceTrackingBitNV = 2,
        [Obsolete("Deprecated in favour of \"AutomaticCheckpointsBitNV\"")]
        [NativeName("Name", "VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_AUTOMATIC_CHECKPOINTS_BIT_NV")]
        DeviceDiagnosticsConfigEnableAutomaticCheckpointsBitNV = 4,
        [Obsolete("Deprecated in favour of \"ShaderErrorReportingBitNV\"")]
        [NativeName("Name", "VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_SHADER_ERROR_REPORTING_BIT_NV")]
        DeviceDiagnosticsConfigEnableShaderErrorReportingBitNV = 8,
        [NativeName("Name", "VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_SHADER_DEBUG_INFO_BIT_NV")]
        ShaderDebugInfoBitNV = 1,
        [NativeName("Name", "VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_RESOURCE_TRACKING_BIT_NV")]
        ResourceTrackingBitNV = 2,
        [NativeName("Name", "VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_AUTOMATIC_CHECKPOINTS_BIT_NV")]
        AutomaticCheckpointsBitNV = 4,
        [NativeName("Name", "VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_SHADER_ERROR_REPORTING_BIT_NV")]
        ShaderErrorReportingBitNV = 8,
    }
}
