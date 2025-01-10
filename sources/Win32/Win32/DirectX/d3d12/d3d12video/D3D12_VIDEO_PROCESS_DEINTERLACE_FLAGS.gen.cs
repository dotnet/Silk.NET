// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Flags]
public enum D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS
{
    D3D12_VIDEO_PROCESS_DEINTERLACE_FLAG_NONE = 0,
    D3D12_VIDEO_PROCESS_DEINTERLACE_FLAG_BOB = 0x1,
    D3D12_VIDEO_PROCESS_DEINTERLACE_FLAG_CUSTOM = unchecked((int)(0x80000000)),
}
