// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_VIDEO_EXTENSION_COMMAND_DESC.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_DESC"]/*'/>
[SupportedOSPlatform("windows10.0.19041.0")]
public partial struct D3D12_VIDEO_EXTENSION_COMMAND_DESC
{
    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_DESC.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_DESC.NodeMask"]/*'/>
    public uint NodeMask;
    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_DESC.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_DESC.CommandId"]/*'/>
    public Guid CommandId;
}