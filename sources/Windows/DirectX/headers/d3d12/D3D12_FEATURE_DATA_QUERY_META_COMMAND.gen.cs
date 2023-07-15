// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_FEATURE_DATA_QUERY_META_COMMAND.xml' path='doc/member[@name="D3D12_FEATURE_DATA_QUERY_META_COMMAND"]/*'/>
public unsafe partial struct D3D12_FEATURE_DATA_QUERY_META_COMMAND
{
    /// <include file='D3D12_FEATURE_DATA_QUERY_META_COMMAND.xml' path='doc/member[@name="D3D12_FEATURE_DATA_QUERY_META_COMMAND.CommandId"]/*'/>
    public Guid CommandId;
    /// <include file='D3D12_FEATURE_DATA_QUERY_META_COMMAND.xml' path='doc/member[@name="D3D12_FEATURE_DATA_QUERY_META_COMMAND.NodeMask"]/*'/>
    public uint NodeMask;
    /// <include file='D3D12_FEATURE_DATA_QUERY_META_COMMAND.xml' path='doc/member[@name="D3D12_FEATURE_DATA_QUERY_META_COMMAND.pQueryInputData"]/*'/>
    [NativeTypeName("const void *")]
    public void* pQueryInputData;
    /// <include file='D3D12_FEATURE_DATA_QUERY_META_COMMAND.xml' path='doc/member[@name="D3D12_FEATURE_DATA_QUERY_META_COMMAND.QueryInputDataSizeInBytes"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint QueryInputDataSizeInBytes;
    /// <include file='D3D12_FEATURE_DATA_QUERY_META_COMMAND.xml' path='doc/member[@name="D3D12_FEATURE_DATA_QUERY_META_COMMAND.pQueryOutputData"]/*'/>
    public void* pQueryOutputData;
    /// <include file='D3D12_FEATURE_DATA_QUERY_META_COMMAND.xml' path='doc/member[@name="D3D12_FEATURE_DATA_QUERY_META_COMMAND.QueryOutputDataSizeInBytes"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint QueryOutputDataSizeInBytes;
}