// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;

namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS1"]/*'/>
public partial struct D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS1
{
    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS1.InputStream"]/*'/>

    [NativeTypeName("D3D12_VIDEO_PROCESS_INPUT_STREAM[2]")]
    public _InputStream_e__FixedBuffer InputStream;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS1.Transform"]/*'/>

    public D3D12_VIDEO_PROCESS_TRANSFORM Transform;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS1.Flags"]/*'/>

    public D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAGS Flags;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS1.RateInfo"]/*'/>

    public D3D12_VIDEO_PROCESS_INPUT_STREAM_RATE RateInfo;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS1.FilterLevels"]/*'/>

    [NativeTypeName("INT[32]")]
    public _FilterLevels_e__FixedBuffer FilterLevels;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS1.AlphaBlending"]/*'/>

    public D3D12_VIDEO_PROCESS_ALPHA_BLENDING AlphaBlending;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS1.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS1.FieldType"]/*'/>

    public D3D12_VIDEO_FIELD_TYPE FieldType;

    /// <include file='_InputStream_e__FixedBuffer.xml' path='doc/member[@name="_InputStream_e__FixedBuffer"]/*'/>

    [InlineArray(2)]
    public partial struct _InputStream_e__FixedBuffer
    {
        public D3D12_VIDEO_PROCESS_INPUT_STREAM e0;
    }

    /// <include file='_FilterLevels_e__FixedBuffer.xml' path='doc/member[@name="_FilterLevels_e__FixedBuffer"]/*'/>

    [InlineArray(32)]
    public partial struct _FilterLevels_e__FixedBuffer
    {
        public int e0;
    }
}
