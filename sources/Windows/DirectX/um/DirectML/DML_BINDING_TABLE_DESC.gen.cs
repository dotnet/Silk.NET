// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DML_BINDING_TABLE_DESC.xml' path='doc/member[@name="DML_BINDING_TABLE_DESC"]/*' />
public unsafe partial struct DML_BINDING_TABLE_DESC
{
    /// <include file='DML_BINDING_TABLE_DESC.xml' path='doc/member[@name="DML_BINDING_TABLE_DESC.Dispatchable"]/*' />
    public IDMLDispatchable* Dispatchable;

    /// <include file='DML_BINDING_TABLE_DESC.xml' path='doc/member[@name="DML_BINDING_TABLE_DESC.CPUDescriptorHandle"]/*' />
    public D3D12_CPU_DESCRIPTOR_HANDLE CPUDescriptorHandle;

    /// <include file='DML_BINDING_TABLE_DESC.xml' path='doc/member[@name="DML_BINDING_TABLE_DESC.GPUDescriptorHandle"]/*' />
    public D3D12_GPU_DESCRIPTOR_HANDLE GPUDescriptorHandle;

    /// <include file='DML_BINDING_TABLE_DESC.xml' path='doc/member[@name="DML_BINDING_TABLE_DESC.SizeInDescriptors"]/*' />
    public uint SizeInDescriptors;
}
