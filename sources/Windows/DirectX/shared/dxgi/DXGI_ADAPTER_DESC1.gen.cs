// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='DXGI_ADAPTER_DESC1.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1"]/*' />
public unsafe partial struct DXGI_ADAPTER_DESC1
{
    /// <include file='DXGI_ADAPTER_DESC1.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1.Description"]/*' />
    [NativeTypeName("WCHAR[128]")]
    public fixed ushort Description[128];

    /// <include file='DXGI_ADAPTER_DESC1.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1.VendorId"]/*' />
    public uint VendorId;

    /// <include file='DXGI_ADAPTER_DESC1.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1.DeviceId"]/*' />
    public uint DeviceId;

    /// <include file='DXGI_ADAPTER_DESC1.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1.SubSysId"]/*' />
    public uint SubSysId;

    /// <include file='DXGI_ADAPTER_DESC1.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1.Revision"]/*' />
    public uint Revision;

    /// <include file='DXGI_ADAPTER_DESC1.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1.DedicatedVideoMemory"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint DedicatedVideoMemory;

    /// <include file='DXGI_ADAPTER_DESC1.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1.DedicatedSystemMemory"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint DedicatedSystemMemory;

    /// <include file='DXGI_ADAPTER_DESC1.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1.SharedSystemMemory"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint SharedSystemMemory;

    /// <include file='DXGI_ADAPTER_DESC1.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1.AdapterLuid"]/*' />
    public LUID AdapterLuid;

    /// <include file='DXGI_ADAPTER_DESC1.xml' path='doc/member[@name="DXGI_ADAPTER_DESC1.Flags"]/*' />
    public uint Flags;
}
