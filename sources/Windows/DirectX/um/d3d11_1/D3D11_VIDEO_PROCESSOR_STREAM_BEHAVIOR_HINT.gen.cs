// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT"]/*'/>
[SupportedOSPlatform("windows10.0")]
public partial struct D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT
{
    /// <include file='D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT.Enable"]/*'/>
    public BOOL Enable;
    /// <include file='D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT.Width"]/*'/>
    public uint Width;
    /// <include file='D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT.Height"]/*'/>
    public uint Height;
    /// <include file='D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT.Format"]/*'/>
    public DXGI_FORMAT Format;
}