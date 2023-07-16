// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE
{
    /// <include file='D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE.D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_OPAQUE"]/*'/>
    D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_OPAQUE = 0,
    /// <include file='D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE.D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_BACKGROUND"]/*'/>
    D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_BACKGROUND = 1,
    /// <include file='D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE.D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_DESTINATION"]/*'/>
    D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_DESTINATION = 2,
    /// <include file='D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE.D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_SOURCE_STREAM"]/*'/>
    D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE_SOURCE_STREAM = 3,
}