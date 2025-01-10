// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DXGI_ADAPTER_DESC2
{
    [NativeTypeName("WCHAR[128]")]
    public _Description_e__FixedBuffer Description;
    public uint VendorId;
    public uint DeviceId;
    public uint SubSysId;
    public uint Revision;

    [NativeTypeName("SIZE_T")]
    public nuint DedicatedVideoMemory;

    [NativeTypeName("SIZE_T")]
    public nuint DedicatedSystemMemory;

    [NativeTypeName("SIZE_T")]
    public nuint SharedSystemMemory;
    public LUID AdapterLuid;
    public uint Flags;
    public DXGI_GRAPHICS_PREEMPTION_GRANULARITY GraphicsPreemptionGranularity;
    public DXGI_COMPUTE_PREEMPTION_GRANULARITY ComputePreemptionGranularity;

    [InlineArray(128)]
    public partial struct _Description_e__FixedBuffer
    {
        public ushort e0;
    }
}
