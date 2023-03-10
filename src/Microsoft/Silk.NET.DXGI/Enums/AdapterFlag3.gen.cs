// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_ADAPTER_FLAG3")]
    public enum AdapterFlag3 : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "DXGI_ADAPTER_FLAG3_NONE")]
        AdapterFlag3None = 0x0,
        [Obsolete("Deprecated in favour of \"Remote\"")]
        [NativeName("Name", "DXGI_ADAPTER_FLAG3_REMOTE")]
        AdapterFlag3Remote = 0x1,
        [Obsolete("Deprecated in favour of \"Software\"")]
        [NativeName("Name", "DXGI_ADAPTER_FLAG3_SOFTWARE")]
        AdapterFlag3Software = 0x2,
        [Obsolete("Deprecated in favour of \"AcgCompatible\"")]
        [NativeName("Name", "DXGI_ADAPTER_FLAG3_ACG_COMPATIBLE")]
        AdapterFlag3AcgCompatible = 0x4,
        [Obsolete("Deprecated in favour of \"SupportMonitoredFences\"")]
        [NativeName("Name", "DXGI_ADAPTER_FLAG3_SUPPORT_MONITORED_FENCES")]
        AdapterFlag3SupportMonitoredFences = 0x8,
        [Obsolete("Deprecated in favour of \"SupportNonMonitoredFences\"")]
        [NativeName("Name", "DXGI_ADAPTER_FLAG3_SUPPORT_NON_MONITORED_FENCES")]
        AdapterFlag3SupportNonMonitoredFences = 0x10,
        [Obsolete("Deprecated in favour of \"KeyedMutexConformance\"")]
        [NativeName("Name", "DXGI_ADAPTER_FLAG3_KEYED_MUTEX_CONFORMANCE")]
        AdapterFlag3KeyedMutexConformance = 0x20,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "DXGI_ADAPTER_FLAG3_FORCE_DWORD")]
        AdapterFlag3ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "DXGI_ADAPTER_FLAG3_NONE")]
        None = 0x0,
        [NativeName("Name", "DXGI_ADAPTER_FLAG3_REMOTE")]
        Remote = 0x1,
        [NativeName("Name", "DXGI_ADAPTER_FLAG3_SOFTWARE")]
        Software = 0x2,
        [NativeName("Name", "DXGI_ADAPTER_FLAG3_ACG_COMPATIBLE")]
        AcgCompatible = 0x4,
        [NativeName("Name", "DXGI_ADAPTER_FLAG3_SUPPORT_MONITORED_FENCES")]
        SupportMonitoredFences = 0x8,
        [NativeName("Name", "DXGI_ADAPTER_FLAG3_SUPPORT_NON_MONITORED_FENCES")]
        SupportNonMonitoredFences = 0x10,
        [NativeName("Name", "DXGI_ADAPTER_FLAG3_KEYED_MUTEX_CONFORMANCE")]
        KeyedMutexConformance = 0x20,
        [NativeName("Name", "DXGI_ADAPTER_FLAG3_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
