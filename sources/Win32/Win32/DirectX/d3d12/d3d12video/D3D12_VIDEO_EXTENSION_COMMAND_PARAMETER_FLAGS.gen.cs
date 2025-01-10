// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Flags]
[SupportedOSPlatform("windows10.0.19041.0")]
public enum D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAGS
{
    D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAG_NONE = 0,
    D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAG_READ = 0x1,
    D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAG_WRITE = 0x2,
}
