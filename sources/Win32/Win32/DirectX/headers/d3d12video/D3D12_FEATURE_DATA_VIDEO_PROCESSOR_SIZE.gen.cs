// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE"]/*'/>
public unsafe partial struct D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE.NodeMask"]/*'/>

    public uint NodeMask;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE.pOutputStreamDesc"]/*'/>

    [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")]
    public D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC* pOutputStreamDesc;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE.NumInputStreamDescs"]/*'/>

    public uint NumInputStreamDescs;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE.pInputStreamDescs"]/*'/>

    [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")]
    public D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC* pInputStreamDescs;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE.MemoryPoolL0Size"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong MemoryPoolL0Size;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE.MemoryPoolL1Size"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong MemoryPoolL1Size;
}
