// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Flags]
public enum D3D11_VIDEO_PROCESSOR_FILTER_CAPS
{
    D3D11_VIDEO_PROCESSOR_FILTER_CAPS_BRIGHTNESS = 0x1,
    D3D11_VIDEO_PROCESSOR_FILTER_CAPS_CONTRAST = 0x2,
    D3D11_VIDEO_PROCESSOR_FILTER_CAPS_HUE = 0x4,
    D3D11_VIDEO_PROCESSOR_FILTER_CAPS_SATURATION = 0x8,
    D3D11_VIDEO_PROCESSOR_FILTER_CAPS_NOISE_REDUCTION = 0x10,
    D3D11_VIDEO_PROCESSOR_FILTER_CAPS_EDGE_ENHANCEMENT = 0x20,
    D3D11_VIDEO_PROCESSOR_FILTER_CAPS_ANAMORPHIC_SCALING = 0x40,
    D3D11_VIDEO_PROCESSOR_FILTER_CAPS_STEREO_ADJUSTMENT = 0x80,
}
