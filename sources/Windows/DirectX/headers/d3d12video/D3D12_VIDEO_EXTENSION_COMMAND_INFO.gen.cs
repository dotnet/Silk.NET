// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_EXTENSION_COMMAND_INFO.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_INFO"]/*' />
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct D3D12_VIDEO_EXTENSION_COMMAND_INFO
{
    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_INFO.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_INFO.CommandId"]/*' />
    public Guid CommandId;

    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_INFO.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_INFO.Name"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* Name;

    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_INFO.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_INFO.CommandListSupportFlags"]/*' />
    public D3D12_COMMAND_LIST_SUPPORT_FLAGS CommandListSupportFlags;
}
