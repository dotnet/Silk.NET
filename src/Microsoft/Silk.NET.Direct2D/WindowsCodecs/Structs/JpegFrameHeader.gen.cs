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

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICJpegFrameHeader")]
    public unsafe partial struct JpegFrameHeader
    {
        public JpegFrameHeader
        (
            uint? width = null,
            uint? height = null,
            JpegTransferMatrix? transferMatrix = null,
            JpegScanType? scanType = null,
            uint? cComponents = null,
            uint? componentIdentifiers = null,
            uint? sampleFactors = null,
            uint? quantizationTableIndices = null
        ) : this()
        {
            if (width is not null)
            {
                Width = width.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (transferMatrix is not null)
            {
                TransferMatrix = transferMatrix.Value;
            }

            if (scanType is not null)
            {
                ScanType = scanType.Value;
            }

            if (cComponents is not null)
            {
                CComponents = cComponents.Value;
            }

            if (componentIdentifiers is not null)
            {
                ComponentIdentifiers = componentIdentifiers.Value;
            }

            if (sampleFactors is not null)
            {
                SampleFactors = sampleFactors.Value;
            }

            if (quantizationTableIndices is not null)
            {
                QuantizationTableIndices = quantizationTableIndices.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Width")]
        public uint Width;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Height")]
        public uint Height;

        [NativeName("Type", "WICJpegTransferMatrix")]
        [NativeName("Type.Name", "WICJpegTransferMatrix")]
        [NativeName("Name", "TransferMatrix")]
        public JpegTransferMatrix TransferMatrix;

        [NativeName("Type", "WICJpegScanType")]
        [NativeName("Type.Name", "WICJpegScanType")]
        [NativeName("Name", "ScanType")]
        public JpegScanType ScanType;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "cComponents")]
        public uint CComponents;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "ComponentIdentifiers")]
        public uint ComponentIdentifiers;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "SampleFactors")]
        public uint SampleFactors;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "QuantizationTableIndices")]
        public uint QuantizationTableIndices;
    }
}
