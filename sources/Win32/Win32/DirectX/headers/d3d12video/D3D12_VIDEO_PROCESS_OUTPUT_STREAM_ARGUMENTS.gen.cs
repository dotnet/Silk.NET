// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
using System.Runtime.CompilerServices;

namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS"]/*'/>
public partial struct D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS
{
    /// <include file='D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS.OutputStream"]/*'/>

    [NativeTypeName("D3D12_VIDEO_PROCESS_OUTPUT_STREAM[2]")]
    public _OutputStream_e__FixedBuffer OutputStream;

    /// <include file='D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS.TargetRectangle"]/*'/>

    [NativeTypeName("D3D12_RECT")]
    public RECT TargetRectangle;

    /// <include file='_OutputStream_e__FixedBuffer.xml' path='doc/member[@name="_OutputStream_e__FixedBuffer"]/*'/>

    [InlineArray(2)]
    public partial struct _OutputStream_e__FixedBuffer
    {
        public D3D12_VIDEO_PROCESS_OUTPUT_STREAM e0;
    }
}
