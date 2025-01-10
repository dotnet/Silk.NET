// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
using Silk.NET.DirectX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.3")]
public partial struct WICDdsParameters
{
    public uint Width;
    public uint Height;
    public uint Depth;
    public uint MipLevels;
    public uint ArraySize;
    public DXGI_FORMAT DxgiFormat;
    public WICDdsDimension Dimension;
    public WICDdsAlphaMode AlphaMode;
}
