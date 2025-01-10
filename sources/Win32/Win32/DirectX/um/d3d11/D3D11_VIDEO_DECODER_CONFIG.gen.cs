// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_VIDEO_DECODER_CONFIG
{
    public Guid guidConfigBitstreamEncryption;
    public Guid guidConfigMBcontrolEncryption;
    public Guid guidConfigResidDiffEncryption;
    public uint ConfigBitstreamRaw;
    public uint ConfigMBcontrolRasterOrder;
    public uint ConfigResidDiffHost;
    public uint ConfigSpatialResid8;
    public uint ConfigResid8Subtraction;
    public uint ConfigSpatialHost8or9Clipping;
    public uint ConfigSpatialResidInterleaved;
    public uint ConfigIntraResidUnsigned;
    public uint ConfigResidDiffAccelerator;
    public uint ConfigHostInverseScan;
    public uint ConfigSpecificIDCT;
    public uint Config4GroupedCoefs;
    public ushort ConfigMinRenderTargetBuffCount;
    public ushort ConfigDecoderSpecific;
}
