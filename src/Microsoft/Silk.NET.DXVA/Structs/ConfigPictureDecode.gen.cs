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
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [NativeName("Name", "_DXVA_ConfigPictureDecode")]
    public unsafe partial struct ConfigPictureDecode
    {
        public ConfigPictureDecode
        (
            uint? dwFunction = null,
            Guid? guidConfigBitstreamEncryption = null,
            Guid? guidConfigMBcontrolEncryption = null,
            Guid? guidConfigResidDiffEncryption = null,
            byte? bConfigBitstreamRaw = null,
            byte? bConfigMBcontrolRasterOrder = null,
            byte? bConfigResidDiffHost = null,
            byte? bConfigSpatialResid8 = null,
            byte? bConfigResid8Subtraction = null,
            byte? bConfigSpatialHost8or9Clipping = null,
            byte? bConfigSpatialResidInterleaved = null,
            byte? bConfigIntraResidUnsigned = null,
            byte? bConfigResidDiffAccelerator = null,
            byte? bConfigHostInverseScan = null,
            byte? bConfigSpecificIDCT = null,
            byte? bConfig4GroupedCoefs = null
        ) : this()
        {
            if (dwFunction is not null)
            {
                DwFunction = dwFunction.Value;
            }

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

            if (bConfigBitstreamRaw is not null)
            {
                BConfigBitstreamRaw = bConfigBitstreamRaw.Value;
            }

            if (bConfigMBcontrolRasterOrder is not null)
            {
                BConfigMBcontrolRasterOrder = bConfigMBcontrolRasterOrder.Value;
            }

            if (bConfigResidDiffHost is not null)
            {
                BConfigResidDiffHost = bConfigResidDiffHost.Value;
            }

            if (bConfigSpatialResid8 is not null)
            {
                BConfigSpatialResid8 = bConfigSpatialResid8.Value;
            }

            if (bConfigResid8Subtraction is not null)
            {
                BConfigResid8Subtraction = bConfigResid8Subtraction.Value;
            }

            if (bConfigSpatialHost8or9Clipping is not null)
            {
                BConfigSpatialHost8or9Clipping = bConfigSpatialHost8or9Clipping.Value;
            }

            if (bConfigSpatialResidInterleaved is not null)
            {
                BConfigSpatialResidInterleaved = bConfigSpatialResidInterleaved.Value;
            }

            if (bConfigIntraResidUnsigned is not null)
            {
                BConfigIntraResidUnsigned = bConfigIntraResidUnsigned.Value;
            }

            if (bConfigResidDiffAccelerator is not null)
            {
                BConfigResidDiffAccelerator = bConfigResidDiffAccelerator.Value;
            }

            if (bConfigHostInverseScan is not null)
            {
                BConfigHostInverseScan = bConfigHostInverseScan.Value;
            }

            if (bConfigSpecificIDCT is not null)
            {
                BConfigSpecificIDCT = bConfigSpecificIDCT.Value;
            }

            if (bConfig4GroupedCoefs is not null)
            {
                BConfig4GroupedCoefs = bConfig4GroupedCoefs.Value;
            }
        }


        [NativeName("Type", "DXVA_ConfigQueryOrReplyFunc")]
        [NativeName("Type.Name", "DXVA_ConfigQueryOrReplyFunc")]
        [NativeName("Name", "dwFunction")]
        public uint DwFunction;
        [NativeName("Type", "DWORD[3]")]
        [NativeName("Type.Name", "DWORD[3]")]
        [NativeName("Name", "dwReservedBits")]
        public fixed uint DwReservedBits[3];

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

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bConfigBitstreamRaw")]
        public byte BConfigBitstreamRaw;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bConfigMBcontrolRasterOrder")]
        public byte BConfigMBcontrolRasterOrder;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bConfigResidDiffHost")]
        public byte BConfigResidDiffHost;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bConfigSpatialResid8")]
        public byte BConfigSpatialResid8;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bConfigResid8Subtraction")]
        public byte BConfigResid8Subtraction;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bConfigSpatialHost8or9Clipping")]
        public byte BConfigSpatialHost8or9Clipping;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bConfigSpatialResidInterleaved")]
        public byte BConfigSpatialResidInterleaved;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bConfigIntraResidUnsigned")]
        public byte BConfigIntraResidUnsigned;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bConfigResidDiffAccelerator")]
        public byte BConfigResidDiffAccelerator;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bConfigHostInverseScan")]
        public byte BConfigHostInverseScan;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bConfigSpecificIDCT")]
        public byte BConfigSpecificIDCT;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bConfig4GroupedCoefs")]
        public byte BConfig4GroupedCoefs;
    }
}
