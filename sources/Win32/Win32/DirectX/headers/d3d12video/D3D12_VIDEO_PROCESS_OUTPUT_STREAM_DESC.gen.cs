// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
using System.Runtime.CompilerServices;

namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC"]/*'/>
public partial struct D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC
{
    /// <include file='D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC.Format"]/*'/>

    public DXGI_FORMAT Format;

    /// <include file='D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC.ColorSpace"]/*'/>

    public DXGI_COLOR_SPACE_TYPE ColorSpace;

    /// <include file='D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC.AlphaFillMode"]/*'/>

    public D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE AlphaFillMode;

    /// <include file='D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC.AlphaFillModeSourceStreamIndex"]/*'/>

    public uint AlphaFillModeSourceStreamIndex;

    /// <include file='D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC.BackgroundColor"]/*'/>

    [NativeTypeName("FLOAT[4]")]
    public _BackgroundColor_e__FixedBuffer BackgroundColor;

    /// <include file='D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC.FrameRate"]/*'/>

    public DXGI_RATIONAL FrameRate;

    /// <include file='D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC.EnableStereo"]/*'/>

    public BOOL EnableStereo;

    /// <include file='_BackgroundColor_e__FixedBuffer.xml' path='doc/member[@name="_BackgroundColor_e__FixedBuffer"]/*'/>

    [InlineArray(4)]
    public partial struct _BackgroundColor_e__FixedBuffer
    {
        public float e0;
    }
}
