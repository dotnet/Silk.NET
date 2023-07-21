// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='DXGI_ADAPTER_DESC2.xml' path='doc/member[@name="DXGI_ADAPTER_DESC2"]/*' />
public unsafe partial struct DXGI_ADAPTER_DESC2
{
    /// <include file='DXGI_ADAPTER_DESC2.xml' path='doc/member[@name="DXGI_ADAPTER_DESC2.Description"]/*' />
    [NativeTypeName("WCHAR[128]")]
    public fixed ushort Description[128];

    /// <include file='DXGI_ADAPTER_DESC2.xml' path='doc/member[@name="DXGI_ADAPTER_DESC2.VendorId"]/*' />
    public uint VendorId;

    /// <include file='DXGI_ADAPTER_DESC2.xml' path='doc/member[@name="DXGI_ADAPTER_DESC2.DeviceId"]/*' />
    public uint DeviceId;

    /// <include file='DXGI_ADAPTER_DESC2.xml' path='doc/member[@name="DXGI_ADAPTER_DESC2.SubSysId"]/*' />
    public uint SubSysId;

    /// <include file='DXGI_ADAPTER_DESC2.xml' path='doc/member[@name="DXGI_ADAPTER_DESC2.Revision"]/*' />
    public uint Revision;

    /// <include file='DXGI_ADAPTER_DESC2.xml' path='doc/member[@name="DXGI_ADAPTER_DESC2.DedicatedVideoMemory"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint DedicatedVideoMemory;

    /// <include file='DXGI_ADAPTER_DESC2.xml' path='doc/member[@name="DXGI_ADAPTER_DESC2.DedicatedSystemMemory"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint DedicatedSystemMemory;

    /// <include file='DXGI_ADAPTER_DESC2.xml' path='doc/member[@name="DXGI_ADAPTER_DESC2.SharedSystemMemory"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint SharedSystemMemory;

    /// <include file='DXGI_ADAPTER_DESC2.xml' path='doc/member[@name="DXGI_ADAPTER_DESC2.AdapterLuid"]/*' />
    public LUID AdapterLuid;

    /// <include file='DXGI_ADAPTER_DESC2.xml' path='doc/member[@name="DXGI_ADAPTER_DESC2.Flags"]/*' />
    public uint Flags;

    /// <include file='DXGI_ADAPTER_DESC2.xml' path='doc/member[@name="DXGI_ADAPTER_DESC2.GraphicsPreemptionGranularity"]/*' />
    public DXGI_GRAPHICS_PREEMPTION_GRANULARITY GraphicsPreemptionGranularity;

    /// <include file='DXGI_ADAPTER_DESC2.xml' path='doc/member[@name="DXGI_ADAPTER_DESC2.ComputePreemptionGranularity"]/*' />
    public DXGI_COMPUTE_PREEMPTION_GRANULARITY ComputePreemptionGranularity;
}
