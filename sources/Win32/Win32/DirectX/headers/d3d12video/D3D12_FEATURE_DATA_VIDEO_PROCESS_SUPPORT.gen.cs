// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;

namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT"]/*'/>
public partial struct D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.NodeIndex"]/*'/>

    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.InputSample"]/*'/>

    public D3D12_VIDEO_SAMPLE InputSample;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.InputFieldType"]/*'/>

    public D3D12_VIDEO_FIELD_TYPE InputFieldType;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.InputStereoFormat"]/*'/>

    public D3D12_VIDEO_FRAME_STEREO_FORMAT InputStereoFormat;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.InputFrameRate"]/*'/>

    public DXGI_RATIONAL InputFrameRate;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.OutputFormat"]/*'/>

    public D3D12_VIDEO_FORMAT OutputFormat;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.OutputStereoFormat"]/*'/>

    public D3D12_VIDEO_FRAME_STEREO_FORMAT OutputStereoFormat;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.OutputFrameRate"]/*'/>

    public DXGI_RATIONAL OutputFrameRate;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.SupportFlags"]/*'/>

    public D3D12_VIDEO_PROCESS_SUPPORT_FLAGS SupportFlags;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.ScaleSupport"]/*'/>

    public D3D12_VIDEO_SCALE_SUPPORT ScaleSupport;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.FeatureSupport"]/*'/>

    public D3D12_VIDEO_PROCESS_FEATURE_FLAGS FeatureSupport;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.DeinterlaceSupport"]/*'/>

    public D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS DeinterlaceSupport;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.AutoProcessingSupport"]/*'/>

    public D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS AutoProcessingSupport;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.FilterSupport"]/*'/>

    public D3D12_VIDEO_PROCESS_FILTER_FLAGS FilterSupport;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.FilterRangeSupport"]/*'/>

    [NativeTypeName("D3D12_VIDEO_PROCESS_FILTER_RANGE[32]")]
    public _FilterRangeSupport_e__FixedBuffer FilterRangeSupport;

    /// <include file='_FilterRangeSupport_e__FixedBuffer.xml' path='doc/member[@name="_FilterRangeSupport_e__FixedBuffer"]/*'/>

    [InlineArray(32)]
    public partial struct _FilterRangeSupport_e__FixedBuffer
    {
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e0;
    }
}
