// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_DEVICE_FLAGS")]
    public enum DeviceFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_DEVICE_FLAG_NONE")]
        DeviceFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"DebugLayerEnabled\"")]
        [NativeName("Name", "D3D12_DEVICE_FLAG_DEBUG_LAYER_ENABLED")]
        DeviceFlagDebugLayerEnabled = 0x1,
        [Obsolete("Deprecated in favour of \"GpuBasedValidationEnabled\"")]
        [NativeName("Name", "D3D12_DEVICE_FLAG_GPU_BASED_VALIDATION_ENABLED")]
        DeviceFlagGpuBasedValidationEnabled = 0x2,
        [Obsolete("Deprecated in favour of \"SynchronizedCommandQueueValidationDisabled\"")]
        [NativeName("Name", "D3D12_DEVICE_FLAG_SYNCHRONIZED_COMMAND_QUEUE_VALIDATION_DISABLED")]
        DeviceFlagSynchronizedCommandQueueValidationDisabled = 0x4,
        [Obsolete("Deprecated in favour of \"DredAutoBreadcrumbsEnabled\"")]
        [NativeName("Name", "D3D12_DEVICE_FLAG_DRED_AUTO_BREADCRUMBS_ENABLED")]
        DeviceFlagDredAutoBreadcrumbsEnabled = 0x8,
        [Obsolete("Deprecated in favour of \"DredPageFaultReportingEnabled\"")]
        [NativeName("Name", "D3D12_DEVICE_FLAG_DRED_PAGE_FAULT_REPORTING_ENABLED")]
        DeviceFlagDredPageFaultReportingEnabled = 0x10,
        [Obsolete("Deprecated in favour of \"DredWatsonReportingEnabled\"")]
        [NativeName("Name", "D3D12_DEVICE_FLAG_DRED_WATSON_REPORTING_ENABLED")]
        DeviceFlagDredWatsonReportingEnabled = 0x20,
        [Obsolete("Deprecated in favour of \"DredBreadcrumbContextEnabled\"")]
        [NativeName("Name", "D3D12_DEVICE_FLAG_DRED_BREADCRUMB_CONTEXT_ENABLED")]
        DeviceFlagDredBreadcrumbContextEnabled = 0x40,
        [Obsolete("Deprecated in favour of \"DredUseMarkersOnlyBreadcrumbs\"")]
        [NativeName("Name", "D3D12_DEVICE_FLAG_DRED_USE_MARKERS_ONLY_BREADCRUMBS")]
        DeviceFlagDredUseMarkersOnlyBreadcrumbs = 0x80,
        [Obsolete("Deprecated in favour of \"ShaderInstrumentationEnabled\"")]
        [NativeName("Name", "D3D12_DEVICE_FLAG_SHADER_INSTRUMENTATION_ENABLED")]
        DeviceFlagShaderInstrumentationEnabled = 0x100,
        [Obsolete("Deprecated in favour of \"AutoDebugNameEnabled\"")]
        [NativeName("Name", "D3D12_DEVICE_FLAG_AUTO_DEBUG_NAME_ENABLED")]
        DeviceFlagAutoDebugNameEnabled = 0x200,
        [Obsolete("Deprecated in favour of \"ForceLegacyStateValidation\"")]
        [NativeName("Name", "D3D12_DEVICE_FLAG_FORCE_LEGACY_STATE_VALIDATION")]
        DeviceFlagForceLegacyStateValidation = 0x400,
        [NativeName("Name", "D3D12_DEVICE_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_DEVICE_FLAG_DEBUG_LAYER_ENABLED")]
        DebugLayerEnabled = 0x1,
        [NativeName("Name", "D3D12_DEVICE_FLAG_GPU_BASED_VALIDATION_ENABLED")]
        GpuBasedValidationEnabled = 0x2,
        [NativeName("Name", "D3D12_DEVICE_FLAG_SYNCHRONIZED_COMMAND_QUEUE_VALIDATION_DISABLED")]
        SynchronizedCommandQueueValidationDisabled = 0x4,
        [NativeName("Name", "D3D12_DEVICE_FLAG_DRED_AUTO_BREADCRUMBS_ENABLED")]
        DredAutoBreadcrumbsEnabled = 0x8,
        [NativeName("Name", "D3D12_DEVICE_FLAG_DRED_PAGE_FAULT_REPORTING_ENABLED")]
        DredPageFaultReportingEnabled = 0x10,
        [NativeName("Name", "D3D12_DEVICE_FLAG_DRED_WATSON_REPORTING_ENABLED")]
        DredWatsonReportingEnabled = 0x20,
        [NativeName("Name", "D3D12_DEVICE_FLAG_DRED_BREADCRUMB_CONTEXT_ENABLED")]
        DredBreadcrumbContextEnabled = 0x40,
        [NativeName("Name", "D3D12_DEVICE_FLAG_DRED_USE_MARKERS_ONLY_BREADCRUMBS")]
        DredUseMarkersOnlyBreadcrumbs = 0x80,
        [NativeName("Name", "D3D12_DEVICE_FLAG_SHADER_INSTRUMENTATION_ENABLED")]
        ShaderInstrumentationEnabled = 0x100,
        [NativeName("Name", "D3D12_DEVICE_FLAG_AUTO_DEBUG_NAME_ENABLED")]
        AutoDebugNameEnabled = 0x200,
        [NativeName("Name", "D3D12_DEVICE_FLAG_FORCE_LEGACY_STATE_VALIDATION")]
        ForceLegacyStateValidation = 0x400,
    }
}
