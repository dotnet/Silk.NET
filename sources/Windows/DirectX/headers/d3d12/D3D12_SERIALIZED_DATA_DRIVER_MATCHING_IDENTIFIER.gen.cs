// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;

namespace Silk.NET.DirectX;
/// <include file='D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER.xml' path='doc/member[@name="D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER"]/*'/>
public unsafe partial struct D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER
{
    /// <include file='D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER.xml' path='doc/member[@name="D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER.DriverOpaqueGUID"]/*'/>
    public Guid DriverOpaqueGUID;
    /// <include file='D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER.xml' path='doc/member[@name="D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER.DriverOpaqueVersioningData"]/*'/>
    [NativeTypeName("BYTE[16]")]
    public fixed byte DriverOpaqueVersioningData[16];
}