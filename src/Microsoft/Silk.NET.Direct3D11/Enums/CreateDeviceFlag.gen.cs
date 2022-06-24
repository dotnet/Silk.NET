// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_CREATE_DEVICE_FLAG")]
    public enum CreateDeviceFlag : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Singlethreaded\"")]
        [NativeName("Name", "D3D11_CREATE_DEVICE_SINGLETHREADED")]
        CreateDeviceSinglethreaded = 0x1,
        [Obsolete("Deprecated in favour of \"Debug\"")]
        [NativeName("Name", "D3D11_CREATE_DEVICE_DEBUG")]
        CreateDeviceDebug = 0x2,
        [Obsolete("Deprecated in favour of \"SwitchToRef\"")]
        [NativeName("Name", "D3D11_CREATE_DEVICE_SWITCH_TO_REF")]
        CreateDeviceSwitchToRef = 0x4,
        [Obsolete("Deprecated in favour of \"PreventInternalThreadingOptimizations\"")]
        [NativeName("Name", "D3D11_CREATE_DEVICE_PREVENT_INTERNAL_THREADING_OPTIMIZATIONS")]
        CreateDevicePreventInternalThreadingOptimizations = 0x8,
        [Obsolete("Deprecated in favour of \"BgraSupport\"")]
        [NativeName("Name", "D3D11_CREATE_DEVICE_BGRA_SUPPORT")]
        CreateDeviceBgraSupport = 0x20,
        [Obsolete("Deprecated in favour of \"Debuggable\"")]
        [NativeName("Name", "D3D11_CREATE_DEVICE_DEBUGGABLE")]
        CreateDeviceDebuggable = 0x40,
        [Obsolete("Deprecated in favour of \"PreventAlteringLayerSettingsFromRegistry\"")]
        [NativeName("Name", "D3D11_CREATE_DEVICE_PREVENT_ALTERING_LAYER_SETTINGS_FROM_REGISTRY")]
        CreateDevicePreventAlteringLayerSettingsFromRegistry = 0x80,
        [Obsolete("Deprecated in favour of \"DisableGpuTimeout\"")]
        [NativeName("Name", "D3D11_CREATE_DEVICE_DISABLE_GPU_TIMEOUT")]
        CreateDeviceDisableGpuTimeout = 0x100,
        [Obsolete("Deprecated in favour of \"VideoSupport\"")]
        [NativeName("Name", "D3D11_CREATE_DEVICE_VIDEO_SUPPORT")]
        CreateDeviceVideoSupport = 0x800,
        [NativeName("Name", "D3D11_CREATE_DEVICE_SINGLETHREADED")]
        Singlethreaded = 0x1,
        [NativeName("Name", "D3D11_CREATE_DEVICE_DEBUG")]
        Debug = 0x2,
        [NativeName("Name", "D3D11_CREATE_DEVICE_SWITCH_TO_REF")]
        SwitchToRef = 0x4,
        [NativeName("Name", "D3D11_CREATE_DEVICE_PREVENT_INTERNAL_THREADING_OPTIMIZATIONS")]
        PreventInternalThreadingOptimizations = 0x8,
        [NativeName("Name", "D3D11_CREATE_DEVICE_BGRA_SUPPORT")]
        BgraSupport = 0x20,
        [NativeName("Name", "D3D11_CREATE_DEVICE_DEBUGGABLE")]
        Debuggable = 0x40,
        [NativeName("Name", "D3D11_CREATE_DEVICE_PREVENT_ALTERING_LAYER_SETTINGS_FROM_REGISTRY")]
        PreventAlteringLayerSettingsFromRegistry = 0x80,
        [NativeName("Name", "D3D11_CREATE_DEVICE_DISABLE_GPU_TIMEOUT")]
        DisableGpuTimeout = 0x100,
        [NativeName("Name", "D3D11_CREATE_DEVICE_VIDEO_SUPPORT")]
        VideoSupport = 0x800,
    }
}
