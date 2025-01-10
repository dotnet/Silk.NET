// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT
{
    public uint NodeIndex;
    public D3D12_VIDEO_SAMPLE InputSample;
    public D3D12_VIDEO_FIELD_TYPE InputFieldType;
    public D3D12_VIDEO_FRAME_STEREO_FORMAT InputStereoFormat;
    public DXGI_RATIONAL InputFrameRate;
    public D3D12_VIDEO_FORMAT OutputFormat;
    public D3D12_VIDEO_FRAME_STEREO_FORMAT OutputStereoFormat;
    public DXGI_RATIONAL OutputFrameRate;
    public D3D12_VIDEO_PROCESS_SUPPORT_FLAGS SupportFlags;
    public D3D12_VIDEO_SCALE_SUPPORT ScaleSupport;
    public D3D12_VIDEO_PROCESS_FEATURE_FLAGS FeatureSupport;
    public D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS DeinterlaceSupport;
    public D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS AutoProcessingSupport;
    public D3D12_VIDEO_PROCESS_FILTER_FLAGS FilterSupport;

    [NativeTypeName("D3D12_VIDEO_PROCESS_FILTER_RANGE[32]")]
    public _FilterRangeSupport_e__FixedBuffer FilterRangeSupport;

    [InlineArray(32)]
    public partial struct _FilterRangeSupport_e__FixedBuffer
    {
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e0;
    }
}
