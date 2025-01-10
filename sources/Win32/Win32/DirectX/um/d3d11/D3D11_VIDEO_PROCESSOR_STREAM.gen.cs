// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[SupportedOSPlatform("windows6.2")]
public unsafe partial struct D3D11_VIDEO_PROCESSOR_STREAM
{
    public BOOL Enable;
    public uint OutputIndex;
    public uint InputFrameOrField;
    public uint PastFrames;
    public uint FutureFrames;
    public ID3D11VideoProcessorInputView* ppPastSurfaces;
    public ID3D11VideoProcessorInputView pInputSurface;
    public ID3D11VideoProcessorInputView* ppFutureSurfaces;
    public ID3D11VideoProcessorInputView* ppPastSurfacesRight;
    public ID3D11VideoProcessorInputView pInputSurfaceRight;
    public ID3D11VideoProcessorInputView* ppFutureSurfacesRight;
}
