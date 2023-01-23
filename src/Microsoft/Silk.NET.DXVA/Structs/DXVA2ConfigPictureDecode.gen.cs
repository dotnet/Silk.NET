// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVA2_ConfigPictureDecode")]
    public unsafe partial struct DXVA2ConfigPictureDecode
    {
        public DXVA2ConfigPictureDecode
        (
            Guid? guidConfigBitstreamEncryption = null,
            Guid? guidConfigMBcontrolEncryption = null,
            Guid? guidConfigResidDiffEncryption = null,
            uint? configBitstreamRaw = null,
            uint? configMBcontrolRasterOrder = null,
            uint? configResidDiffHost = null,
            uint? configSpatialResid8 = null,
            uint? configResid8Subtraction = null,
            uint? configSpatialHost8or9Clipping = null,
            uint? configSpatialResidInterleaved = null,
            uint? configIntraResidUnsigned = null,
            uint? configResidDiffAccelerator = null,
            uint? configHostInverseScan = null,
            uint? configSpecificIDCT = null,
            uint? config4GroupedCoefs = null,
            ushort? configMinRenderTargetBuffCount = null,
            ushort? configDecoderSpecific = null
        ) : this()
        {
            if (guidConfigBitstreamEncryption is not null)
            {
                GuidConfigBitstreamEncryption = guidConfigBitstreamEncryption.Value;
            }

            if (guidConfigMBcontrolEncryption is not null)
            {
                GuidConfigMBcontrolEncryption = guidConfigMBcontrolEncryption.Value;
            }

            if (guidConfigResidDiffEncryption is not null)
            {
                GuidConfigResidDiffEncryption = guidConfigResidDiffEncryption.Value;
            }

            if (configBitstreamRaw is not null)
            {
                ConfigBitstreamRaw = configBitstreamRaw.Value;
            }

            if (configMBcontrolRasterOrder is not null)
            {
                ConfigMBcontrolRasterOrder = configMBcontrolRasterOrder.Value;
            }

            if (configResidDiffHost is not null)
            {
                ConfigResidDiffHost = configResidDiffHost.Value;
            }

            if (configSpatialResid8 is not null)
            {
                ConfigSpatialResid8 = configSpatialResid8.Value;
            }

            if (configResid8Subtraction is not null)
            {
                ConfigResid8Subtraction = configResid8Subtraction.Value;
            }

            if (configSpatialHost8or9Clipping is not null)
            {
                ConfigSpatialHost8or9Clipping = configSpatialHost8or9Clipping.Value;
            }

            if (configSpatialResidInterleaved is not null)
            {
                ConfigSpatialResidInterleaved = configSpatialResidInterleaved.Value;
            }

            if (configIntraResidUnsigned is not null)
            {
                ConfigIntraResidUnsigned = configIntraResidUnsigned.Value;
            }

            if (configResidDiffAccelerator is not null)
            {
                ConfigResidDiffAccelerator = configResidDiffAccelerator.Value;
            }

            if (configHostInverseScan is not null)
            {
                ConfigHostInverseScan = configHostInverseScan.Value;
            }

            if (configSpecificIDCT is not null)
            {
                ConfigSpecificIDCT = configSpecificIDCT.Value;
            }

            if (config4GroupedCoefs is not null)
            {
                Config4GroupedCoefs = config4GroupedCoefs.Value;
            }

            if (configMinRenderTargetBuffCount is not null)
            {
                ConfigMinRenderTargetBuffCount = configMinRenderTargetBuffCount.Value;
            }

            if (configDecoderSpecific is not null)
            {
                ConfigDecoderSpecific = configDecoderSpecific.Value;
            }
        }


        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "guidConfigBitstreamEncryption")]
        public Guid GuidConfigBitstreamEncryption;

        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "guidConfigMBcontrolEncryption")]
        public Guid GuidConfigMBcontrolEncryption;

        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "guidConfigResidDiffEncryption")]
        public Guid GuidConfigResidDiffEncryption;

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
