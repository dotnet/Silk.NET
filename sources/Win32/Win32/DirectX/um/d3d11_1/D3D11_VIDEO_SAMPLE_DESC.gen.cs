// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[SupportedOSPlatform("windows10.0")]
public partial struct D3D11_VIDEO_SAMPLE_DESC
{
    public uint Width;
    public uint Height;
    public DXGI_FORMAT Format;
    public DXGI_COLOR_SPACE_TYPE ColorSpace;
}
