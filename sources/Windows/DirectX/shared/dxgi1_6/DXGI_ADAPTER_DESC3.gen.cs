// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='DXGI_ADAPTER_DESC3.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3"]/*'/>
public unsafe partial struct DXGI_ADAPTER_DESC3
{
    /// <include file='DXGI_ADAPTER_DESC3.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3.Description"]/*'/>
    [NativeTypeName("WCHAR[128]")]
    public fixed ushort Description[128];
    /// <include file='DXGI_ADAPTER_DESC3.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3.VendorId"]/*'/>
    public uint VendorId;
    /// <include file='DXGI_ADAPTER_DESC3.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3.DeviceId"]/*'/>
    public uint DeviceId;
    /// <include file='DXGI_ADAPTER_DESC3.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3.SubSysId"]/*'/>
    public uint SubSysId;
    /// <include file='DXGI_ADAPTER_DESC3.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3.Revision"]/*'/>
    public uint Revision;
    /// <include file='DXGI_ADAPTER_DESC3.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3.DedicatedVideoMemory"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint DedicatedVideoMemory;
    /// <include file='DXGI_ADAPTER_DESC3.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3.DedicatedSystemMemory"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint DedicatedSystemMemory;
    /// <include file='DXGI_ADAPTER_DESC3.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3.SharedSystemMemory"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint SharedSystemMemory;
    /// <include file='DXGI_ADAPTER_DESC3.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3.AdapterLuid"]/*'/>
    public LUID AdapterLuid;
    /// <include file='DXGI_ADAPTER_DESC3.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3.Flags"]/*'/>
    public DXGI_ADAPTER_FLAG3 Flags;
    /// <include file='DXGI_ADAPTER_DESC3.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3.GraphicsPreemptionGranularity"]/*'/>
    public DXGI_GRAPHICS_PREEMPTION_GRANULARITY GraphicsPreemptionGranularity;
    /// <include file='DXGI_ADAPTER_DESC3.xml' path='doc/member[@name="DXGI_ADAPTER_DESC3.ComputePreemptionGranularity"]/*'/>
    public DXGI_COMPUTE_PREEMPTION_GRANULARITY ComputePreemptionGranularity;
}