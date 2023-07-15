// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_VIDEO_DECODER_CONFIG
{
    /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.guidConfigBitstreamEncryption"]/*'/>
    public Guid guidConfigBitstreamEncryption;
    /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.guidConfigMBcontrolEncryption"]/*'/>
    public Guid guidConfigMBcontrolEncryption;
    /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.guidConfigResidDiffEncryption"]/*'/>
    public Guid guidConfigResidDiffEncryption;
    /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.ConfigBitstreamRaw"]/*'/>
    public uint ConfigBitstreamRaw;
    /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.ConfigMBcontrolRasterOrder"]/*'/>
    public uint ConfigMBcontrolRasterOrder;
    /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.ConfigResidDiffHost"]/*'/>
    public uint ConfigResidDiffHost;
    /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.ConfigSpatialResid8"]/*'/>
    public uint ConfigSpatialResid8;
    /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.ConfigResid8Subtraction"]/*'/>
    public uint ConfigResid8Subtraction;
    /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.ConfigSpatialHost8or9Clipping"]/*'/>
    public uint ConfigSpatialHost8or9Clipping;
    /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.ConfigSpatialResidInterleaved"]/*'/>
    public uint ConfigSpatialResidInterleaved;
    /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.ConfigIntraResidUnsigned"]/*'/>
    public uint ConfigIntraResidUnsigned;
    /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.ConfigResidDiffAccelerator"]/*'/>
    public uint ConfigResidDiffAccelerator;
    /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.ConfigHostInverseScan"]/*'/>
    public uint ConfigHostInverseScan;
    /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.ConfigSpecificIDCT"]/*'/>
    public uint ConfigSpecificIDCT;
    /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.Config4GroupedCoefs"]/*'/>
    public uint Config4GroupedCoefs;
    /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.ConfigMinRenderTargetBuffCount"]/*'/>
    public ushort ConfigMinRenderTargetBuffCount;
    /// <include file='D3D11_VIDEO_DECODER_CONFIG.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_CONFIG.ConfigDecoderSpecific"]/*'/>
    public ushort ConfigDecoderSpecific;
}