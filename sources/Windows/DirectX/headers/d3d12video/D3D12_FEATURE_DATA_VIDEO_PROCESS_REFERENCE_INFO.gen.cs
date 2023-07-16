// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;

namespace Silk.NET.DirectX;
/// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO"]/*'/>
public partial struct D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.NodeIndex"]/*'/>
    public uint NodeIndex;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.DeinterlaceMode"]/*'/>
    public D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS DeinterlaceMode;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.Filters"]/*'/>
    public D3D12_VIDEO_PROCESS_FILTER_FLAGS Filters;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.FeatureSupport"]/*'/>
    public D3D12_VIDEO_PROCESS_FEATURE_FLAGS FeatureSupport;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.InputFrameRate"]/*'/>
    public DXGI_RATIONAL InputFrameRate;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.OutputFrameRate"]/*'/>
    public DXGI_RATIONAL OutputFrameRate;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.EnableAutoProcessing"]/*'/>
    public BOOL EnableAutoProcessing;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.PastFrames"]/*'/>
    public uint PastFrames;
    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO.FutureFrames"]/*'/>
    public uint FutureFrames;
}