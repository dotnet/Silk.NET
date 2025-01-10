// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Flags]
[SupportedOSPlatform("windows6.2")]
public enum D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS
{
    D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_BLEND = 0x1,
    D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_BOB = 0x2,
    D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_ADAPTIVE = 0x4,
    D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_MOTION_COMPENSATION = 0x8,
    D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_INVERSE_TELECINE = 0x10,
    D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_FRAME_RATE_CONVERSION = 0x20,
}
