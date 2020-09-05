// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_DECODER_CONFIG")]
    public unsafe partial struct VideoDecoderConfig
    {
        public VideoDecoderConfig
        (
            _GUID guidConfigBitstreamEncryption = default,
            _GUID guidConfigMBcontrolEncryption = default,
            _GUID guidConfigResidDiffEncryption = default,
            uint configBitstreamRaw = default,
            uint configMBcontrolRasterOrder = default,
            uint configResidDiffHost = default,
            uint configSpatialResid8 = default,
            uint configResid8Subtraction = default,
            uint configSpatialHost8or9Clipping = default,
            uint configSpatialResidInterleaved = default,
            uint configIntraResidUnsigned = default,
            uint configResidDiffAccelerator = default,
            uint configHostInverseScan = default,
            uint configSpecificIDCT = default,
            uint config4GroupedCoefs = default,
            ushort configMinRenderTargetBuffCount = default,
            ushort configDecoderSpecific = default
        )
        {
            GuidConfigBitstreamEncryption = guidConfigBitstreamEncryption;
            GuidConfigMBcontrolEncryption = guidConfigMBcontrolEncryption;
            GuidConfigResidDiffEncryption = guidConfigResidDiffEncryption;
            ConfigBitstreamRaw = configBitstreamRaw;
            ConfigMBcontrolRasterOrder = configMBcontrolRasterOrder;
            ConfigResidDiffHost = configResidDiffHost;
            ConfigSpatialResid8 = configSpatialResid8;
            ConfigResid8Subtraction = configResid8Subtraction;
            ConfigSpatialHost8or9Clipping = configSpatialHost8or9Clipping;
            ConfigSpatialResidInterleaved = configSpatialResidInterleaved;
            ConfigIntraResidUnsigned = configIntraResidUnsigned;
            ConfigResidDiffAccelerator = configResidDiffAccelerator;
            ConfigHostInverseScan = configHostInverseScan;
            ConfigSpecificIDCT = configSpecificIDCT;
            Config4GroupedCoefs = config4GroupedCoefs;
            ConfigMinRenderTargetBuffCount = configMinRenderTargetBuffCount;
            ConfigDecoderSpecific = configDecoderSpecific;
        }


        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "guidConfigBitstreamEncryption")]
        public _GUID GuidConfigBitstreamEncryption;

        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "guidConfigMBcontrolEncryption")]
        public _GUID GuidConfigMBcontrolEncryption;

        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "guidConfigResidDiffEncryption")]
        public _GUID GuidConfigResidDiffEncryption;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ConfigBitstreamRaw")]
        public uint ConfigBitstreamRaw;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ConfigMBcontrolRasterOrder")]
        public uint ConfigMBcontrolRasterOrder;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ConfigResidDiffHost")]
        public uint ConfigResidDiffHost;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ConfigSpatialResid8")]
        public uint ConfigSpatialResid8;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ConfigResid8Subtraction")]
        public uint ConfigResid8Subtraction;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ConfigSpatialHost8or9Clipping")]
        public uint ConfigSpatialHost8or9Clipping;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ConfigSpatialResidInterleaved")]
        public uint ConfigSpatialResidInterleaved;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ConfigIntraResidUnsigned")]
        public uint ConfigIntraResidUnsigned;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ConfigResidDiffAccelerator")]
        public uint ConfigResidDiffAccelerator;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ConfigHostInverseScan")]
        public uint ConfigHostInverseScan;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ConfigSpecificIDCT")]
        public uint ConfigSpecificIDCT;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Config4GroupedCoefs")]
        public uint Config4GroupedCoefs;

        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "ConfigMinRenderTargetBuffCount")]
        public ushort ConfigMinRenderTargetBuffCount;

        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "ConfigDecoderSpecific")]
        public ushort ConfigDecoderSpecific;
    }
}
