// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_4.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT
{
    D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_Y = 0,
    D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_U = 1,
    D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_V = 2,
    D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_R = 0,
    D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_G = 1,
    D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_B = 2,
    D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_A = 3,
}
