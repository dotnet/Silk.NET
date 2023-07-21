// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_META_COMMAND_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_DESC"]/*' />
public unsafe partial struct D3D12_META_COMMAND_PARAMETER_DESC
{
    /// <include file='D3D12_META_COMMAND_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_DESC.Name"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* Name;

    /// <include file='D3D12_META_COMMAND_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_DESC.Type"]/*' />
    public D3D12_META_COMMAND_PARAMETER_TYPE Type;

    /// <include file='D3D12_META_COMMAND_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_DESC.Flags"]/*' />
    public D3D12_META_COMMAND_PARAMETER_FLAGS Flags;

    /// <include file='D3D12_META_COMMAND_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_DESC.RequiredResourceState"]/*' />
    public D3D12_RESOURCE_STATES RequiredResourceState;

    /// <include file='D3D12_META_COMMAND_PARAMETER_DESC.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_DESC.StructureOffset"]/*' />
    public uint StructureOffset;
}
