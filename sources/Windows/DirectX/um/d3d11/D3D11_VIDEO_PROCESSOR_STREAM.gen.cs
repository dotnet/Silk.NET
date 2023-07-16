// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='D3D11_VIDEO_PROCESSOR_STREAM.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STREAM"]/*'/>
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct D3D11_VIDEO_PROCESSOR_STREAM
{
    /// <include file='D3D11_VIDEO_PROCESSOR_STREAM.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STREAM.Enable"]/*'/>
    public BOOL Enable;
    /// <include file='D3D11_VIDEO_PROCESSOR_STREAM.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STREAM.OutputIndex"]/*'/>
    public uint OutputIndex;
    /// <include file='D3D11_VIDEO_PROCESSOR_STREAM.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STREAM.InputFrameOrField"]/*'/>
    public uint InputFrameOrField;
    /// <include file='D3D11_VIDEO_PROCESSOR_STREAM.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STREAM.PastFrames"]/*'/>
    public uint PastFrames;
    /// <include file='D3D11_VIDEO_PROCESSOR_STREAM.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STREAM.FutureFrames"]/*'/>
    public uint FutureFrames;
    /// <include file='D3D11_VIDEO_PROCESSOR_STREAM.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STREAM.ppPastSurfaces"]/*'/>
    public ID3D11VideoProcessorInputView** ppPastSurfaces;
    /// <include file='D3D11_VIDEO_PROCESSOR_STREAM.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STREAM.pInputSurface"]/*'/>
    public ID3D11VideoProcessorInputView* pInputSurface;
    /// <include file='D3D11_VIDEO_PROCESSOR_STREAM.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STREAM.ppFutureSurfaces"]/*'/>
    public ID3D11VideoProcessorInputView** ppFutureSurfaces;
    /// <include file='D3D11_VIDEO_PROCESSOR_STREAM.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STREAM.ppPastSurfacesRight"]/*'/>
    public ID3D11VideoProcessorInputView** ppPastSurfacesRight;
    /// <include file='D3D11_VIDEO_PROCESSOR_STREAM.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STREAM.pInputSurfaceRight"]/*'/>
    public ID3D11VideoProcessorInputView* pInputSurfaceRight;
    /// <include file='D3D11_VIDEO_PROCESSOR_STREAM.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STREAM.ppFutureSurfacesRight"]/*'/>
    public ID3D11VideoProcessorInputView** ppFutureSurfacesRight;
}