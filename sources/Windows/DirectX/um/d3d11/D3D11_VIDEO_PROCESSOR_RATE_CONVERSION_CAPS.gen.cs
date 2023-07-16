// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS
{
    /// <include file='D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS.PastFrames"]/*'/>
    public uint PastFrames;
    /// <include file='D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS.FutureFrames"]/*'/>
    public uint FutureFrames;
    /// <include file='D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS.ProcessorCaps"]/*'/>
    public uint ProcessorCaps;
    /// <include file='D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS.ITelecineCaps"]/*'/>
    public uint ITelecineCaps;
    /// <include file='D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS.CustomRateCount"]/*'/>
    public uint CustomRateCount;
}