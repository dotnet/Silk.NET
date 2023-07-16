// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_STREAM_OUTPUT_DESC.xml' path='doc/member[@name="D3D12_STREAM_OUTPUT_DESC"]/*'/>
public unsafe partial struct D3D12_STREAM_OUTPUT_DESC
{
    /// <include file='D3D12_STREAM_OUTPUT_DESC.xml' path='doc/member[@name="D3D12_STREAM_OUTPUT_DESC.pSODeclaration"]/*'/>
    [NativeTypeName("const D3D12_SO_DECLARATION_ENTRY *")]
    public D3D12_SO_DECLARATION_ENTRY* pSODeclaration;
    /// <include file='D3D12_STREAM_OUTPUT_DESC.xml' path='doc/member[@name="D3D12_STREAM_OUTPUT_DESC.NumEntries"]/*'/>
    public uint NumEntries;
    /// <include file='D3D12_STREAM_OUTPUT_DESC.xml' path='doc/member[@name="D3D12_STREAM_OUTPUT_DESC.pBufferStrides"]/*'/>
    [NativeTypeName("const UINT *")]
    public uint* pBufferStrides;
    /// <include file='D3D12_STREAM_OUTPUT_DESC.xml' path='doc/member[@name="D3D12_STREAM_OUTPUT_DESC.NumStrides"]/*'/>
    public uint NumStrides;
    /// <include file='D3D12_STREAM_OUTPUT_DESC.xml' path='doc/member[@name="D3D12_STREAM_OUTPUT_DESC.RasterizedStream"]/*'/>
    public uint RasterizedStream;
}