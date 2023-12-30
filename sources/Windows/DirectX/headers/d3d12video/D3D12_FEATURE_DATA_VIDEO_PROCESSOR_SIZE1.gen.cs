// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1"]/*'/>
public unsafe partial struct D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1.NodeMask"]/*'/>

    public uint NodeMask;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1.pOutputStreamDesc"]/*'/>

    [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")]
    public D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC* pOutputStreamDesc;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1.NumInputStreamDescs"]/*'/>

    public uint NumInputStreamDescs;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1.pInputStreamDescs"]/*'/>

    [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")]
    public D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC* pInputStreamDescs;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1.Protected"]/*'/>

    public BOOL Protected;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1.MemoryPoolL0Size"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong MemoryPoolL0Size;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE1.MemoryPoolL1Size"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong MemoryPoolL1Size;
}
