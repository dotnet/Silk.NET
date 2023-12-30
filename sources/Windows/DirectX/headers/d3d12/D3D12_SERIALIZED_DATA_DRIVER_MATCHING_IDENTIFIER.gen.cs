// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;

namespace Silk.NET.DirectX;

/// <include file='D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER.xml' path='doc/member[@name="D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER"]/*'/>
public partial struct D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER
{
    /// <include file='D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER.xml' path='doc/member[@name="D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER.DriverOpaqueGUID"]/*'/>

    public Guid DriverOpaqueGUID;

    /// <include file='D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER.xml' path='doc/member[@name="D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER.DriverOpaqueVersioningData"]/*'/>

    [NativeTypeName("BYTE[16]")]
    public _DriverOpaqueVersioningData_e__FixedBuffer DriverOpaqueVersioningData;

    /// <include file='_DriverOpaqueVersioningData_e__FixedBuffer.xml' path='doc/member[@name="_DriverOpaqueVersioningData_e__FixedBuffer"]/*'/>

    [InlineArray(16)]
    public partial struct _DriverOpaqueVersioningData_e__FixedBuffer
    {
        public byte e0;
    }
}
