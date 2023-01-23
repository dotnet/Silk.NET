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
    [NativeName("Name", "_DXVA_PictureParameters")]
    public unsafe partial struct PictureParameters
    {
        public PictureParameters
        (
            ushort? wDecodedPictureIndex = null,
            ushort? wDeblockedPictureIndex = null,
            ushort? wForwardRefPictureIndex = null,
            ushort? wBackwardRefPictureIndex = null,
            ushort? wPicWidthInMBminus1 = null,
            ushort? wPicHeightInMBminus1 = null,
            byte? bMacroblockWidthMinus1 = null,
            byte? bMacroblockHeightMinus1 = null,
            byte? bBlockWidthMinus1 = null,
            byte? bBlockHeightMinus1 = null,
            byte? bBPPminus1 = null,
            byte? bPicStructure = null,
            byte? bSecondField = null,
            byte? bPicIntra = null,
            byte? bPicBackwardPrediction = null,
            byte? bBidirectionalAveragingMode = null,
            byte? bMVprecisionAndChromaRelation = null,
            byte? bChromaFormat = null,
            byte? bPicScanFixed = null,
            byte? bPicScanMethod = null,
            byte? bPicReadbackRequests = null,
            byte? bRcontrol = null,
            byte? bPicSpatialResid8 = null,
            byte? bPicOverflowBlocks = null,
            byte? bPicExtrapolation = null,
            byte? bPicDeblocked = null,
            byte? bPicDeblockConfined = null,
            byte? bPic4MVallowed = null,
            byte? bPicOBMC = null,
            byte? bPicBinPB = null,
            byte? bMVRPS = null,
            byte? bReservedBits = null,
            ushort? wBitstreamFcodes = null,
            ushort? wBitstreamPCEelements = null,
            byte? bBitstreamConcealmentNeed = null,
            byte? bBitstreamConcealmentMethod = null
        ) : this()
        {
            if (wDecodedPictureIndex is not null)
            {
                WDecodedPictureIndex = wDecodedPictureIndex.Value;
            }

            if (wDeblockedPictureIndex is not null)
            {
                WDeblockedPictureIndex = wDeblockedPictureIndex.Value;
            }

            if (wForwardRefPictureIndex is not null)
            {
                WForwardRefPictureIndex = wForwardRefPictureIndex.Value;
            }

            if (wBackwardRefPictureIndex is not null)
            {
                WBackwardRefPictureIndex = wBackwardRefPictureIndex.Value;
            }

            if (wPicWidthInMBminus1 is not null)
            {
                WPicWidthInMBminus1 = wPicWidthInMBminus1.Value;
            }

            if (wPicHeightInMBminus1 is not null)
            {
                WPicHeightInMBminus1 = wPicHeightInMBminus1.Value;
            }

            if (bMacroblockWidthMinus1 is not null)
            {
                BMacroblockWidthMinus1 = bMacroblockWidthMinus1.Value;
            }

            if (bMacroblockHeightMinus1 is not null)
            {
                BMacroblockHeightMinus1 = bMacroblockHeightMinus1.Value;
            }

            if (bBlockWidthMinus1 is not null)
            {
                BBlockWidthMinus1 = bBlockWidthMinus1.Value;
            }

            if (bBlockHeightMinus1 is not null)
            {
                BBlockHeightMinus1 = bBlockHeightMinus1.Value;
            }

            if (bBPPminus1 is not null)
            {
                BBPPminus1 = bBPPminus1.Value;
            }

            if (bPicStructure is not null)
            {
                BPicStructure = bPicStructure.Value;
            }

            if (bSecondField is not null)
            {
                BSecondField = bSecondField.Value;
            }

            if (bPicIntra is not null)
            {
                BPicIntra = bPicIntra.Value;
            }

            if (bPicBackwardPrediction is not null)
            {
                BPicBackwardPrediction = bPicBackwardPrediction.Value;
            }

            if (bBidirectionalAveragingMode is not null)
            {
                BBidirectionalAveragingMode = bBidirectionalAveragingMode.Value;
            }

            if (bMVprecisionAndChromaRelation is not null)
            {
                BMVprecisionAndChromaRelation = bMVprecisionAndChromaRelation.Value;
            }

            if (bChromaFormat is not null)
            {
                BChromaFormat = bChromaFormat.Value;
            }

            if (bPicScanFixed is not null)
            {
                BPicScanFixed = bPicScanFixed.Value;
            }

            if (bPicScanMethod is not null)
            {
                BPicScanMethod = bPicScanMethod.Value;
            }

            if (bPicReadbackRequests is not null)
            {
                BPicReadbackRequests = bPicReadbackRequests.Value;
            }

            if (bRcontrol is not null)
            {
                BRcontrol = bRcontrol.Value;
            }

            if (bPicSpatialResid8 is not null)
            {
                BPicSpatialResid8 = bPicSpatialResid8.Value;
            }

            if (bPicOverflowBlocks is not null)
            {
                BPicOverflowBlocks = bPicOverflowBlocks.Value;
            }

            if (bPicExtrapolation is not null)
            {
                BPicExtrapolation = bPicExtrapolation.Value;
            }

            if (bPicDeblocked is not null)
            {
                BPicDeblocked = bPicDeblocked.Value;
            }

            if (bPicDeblockConfined is not null)
            {
                BPicDeblockConfined = bPicDeblockConfined.Value;
            }

            if (bPic4MVallowed is not null)
            {
                BPic4MVallowed = bPic4MVallowed.Value;
            }

            if (bPicOBMC is not null)
            {
                BPicOBMC = bPicOBMC.Value;
            }

            if (bPicBinPB is not null)
            {
                BPicBinPB = bPicBinPB.Value;
            }

            if (bMVRPS is not null)
            {
                BMVRPS = bMVRPS.Value;
            }

            if (bReservedBits is not null)
            {
                BReservedBits = bReservedBits.Value;
            }

            if (wBitstreamFcodes is not null)
            {
                WBitstreamFcodes = wBitstreamFcodes.Value;
            }

            if (wBitstreamPCEelements is not null)
            {
                WBitstreamPCEelements = wBitstreamPCEelements.Value;
            }

            if (bBitstreamConcealmentNeed is not null)
            {
                BBitstreamConcealmentNeed = bBitstreamConcealmentNeed.Value;
            }

            if (bBitstreamConcealmentMethod is not null)
            {
                BBitstreamConcealmentMethod = bBitstreamConcealmentMethod.Value;
            }
        }


        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wDecodedPictureIndex")]
        public ushort WDecodedPictureIndex;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wDeblockedPictureIndex")]
        public ushort WDeblockedPictureIndex;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wForwardRefPictureIndex")]
        public ushort WForwardRefPictureIndex;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wBackwardRefPictureIndex")]
        public ushort WBackwardRefPictureIndex;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wPicWidthInMBminus1")]
        public ushort WPicWidthInMBminus1;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wPicHeightInMBminus1")]
        public ushort WPicHeightInMBminus1;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bMacroblockWidthMinus1")]
        public byte BMacroblockWidthMinus1;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bMacroblockHeightMinus1")]
        public byte BMacroblockHeightMinus1;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bBlockWidthMinus1")]
        public byte BBlockWidthMinus1;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bBlockHeightMinus1")]
        public byte BBlockHeightMinus1;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bBPPminus1")]
        public byte BBPPminus1;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bPicStructure")]
        public byte BPicStructure;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bSecondField")]
        public byte BSecondField;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bPicIntra")]
        public byte BPicIntra;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bPicBackwardPrediction")]
        public byte BPicBackwardPrediction;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bBidirectionalAveragingMode")]
        public byte BBidirectionalAveragingMode;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bMVprecisionAndChromaRelation")]
        public byte BMVprecisionAndChromaRelation;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bChromaFormat")]
        public byte BChromaFormat;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bPicScanFixed")]
        public byte BPicScanFixed;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bPicScanMethod")]
        public byte BPicScanMethod;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bPicReadbackRequests")]
        public byte BPicReadbackRequests;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bRcontrol")]
        public byte BRcontrol;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bPicSpatialResid8")]
        public byte BPicSpatialResid8;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bPicOverflowBlocks")]
        public byte BPicOverflowBlocks;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bPicExtrapolation")]
        public byte BPicExtrapolation;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bPicDeblocked")]
        public byte BPicDeblocked;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bPicDeblockConfined")]
        public byte BPicDeblockConfined;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bPic4MVallowed")]
        public byte BPic4MVallowed;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bPicOBMC")]
        public byte BPicOBMC;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bPicBinPB")]
        public byte BPicBinPB;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bMV_RPS")]
        public byte BMVRPS;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bReservedBits")]
        public byte BReservedBits;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wBitstreamFcodes")]
        public ushort WBitstreamFcodes;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wBitstreamPCEelements")]
        public ushort WBitstreamPCEelements;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bBitstreamConcealmentNeed")]
        public byte BBitstreamConcealmentNeed;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bBitstreamConcealmentMethod")]
        public byte BBitstreamConcealmentMethod;
    }
}
