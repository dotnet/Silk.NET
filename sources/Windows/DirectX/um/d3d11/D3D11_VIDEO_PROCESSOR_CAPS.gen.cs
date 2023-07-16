// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='D3D11_VIDEO_PROCESSOR_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_CAPS"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_VIDEO_PROCESSOR_CAPS
{
    /// <include file='D3D11_VIDEO_PROCESSOR_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_CAPS.DeviceCaps"]/*'/>
    public uint DeviceCaps;
    /// <include file='D3D11_VIDEO_PROCESSOR_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_CAPS.FeatureCaps"]/*'/>
    public uint FeatureCaps;
    /// <include file='D3D11_VIDEO_PROCESSOR_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_CAPS.FilterCaps"]/*'/>
    public uint FilterCaps;
    /// <include file='D3D11_VIDEO_PROCESSOR_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_CAPS.InputFormatCaps"]/*'/>
    public uint InputFormatCaps;
    /// <include file='D3D11_VIDEO_PROCESSOR_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_CAPS.AutoStreamCaps"]/*'/>
    public uint AutoStreamCaps;
    /// <include file='D3D11_VIDEO_PROCESSOR_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_CAPS.StereoCaps"]/*'/>
    public uint StereoCaps;
    /// <include file='D3D11_VIDEO_PROCESSOR_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_CAPS.RateConversionCapsCount"]/*'/>
    public uint RateConversionCapsCount;
    /// <include file='D3D11_VIDEO_PROCESSOR_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_CAPS.MaxInputStreams"]/*'/>
    public uint MaxInputStreams;
    /// <include file='D3D11_VIDEO_PROCESSOR_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_CAPS.MaxStreamStates"]/*'/>
    public uint MaxStreamStates;
}