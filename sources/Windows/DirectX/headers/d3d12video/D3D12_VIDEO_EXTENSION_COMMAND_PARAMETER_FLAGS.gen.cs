// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAGS"]/*' />
[Flags]
[SupportedOSPlatform("windows10.0.19041.0")]
public enum D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAGS
{
    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAGS.D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAG_NONE"]/*' />
    D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAG_NONE = 0,

    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAGS.D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAG_READ"]/*' />
    D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAG_READ = 0x1,

    /// <include file='D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAGS.D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAG_WRITE"]/*' />
    D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAG_WRITE = 0x2,
}
