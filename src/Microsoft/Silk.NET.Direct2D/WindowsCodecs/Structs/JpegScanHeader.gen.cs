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
    [NativeName("Name", "WICJpegScanHeader")]
    public unsafe partial struct JpegScanHeader
    {
        public JpegScanHeader
        (
            uint? cComponents = null,
            uint? restartInterval = null,
            uint? componentSelectors = null,
            uint? huffmanTableIndices = null,
            byte? startSpectralSelection = null,
            byte? endSpectralSelection = null,
            byte? successiveApproximationHigh = null,
            byte? successiveApproximationLow = null
        ) : this()
        {
            if (cComponents is not null)
            {
                CComponents = cComponents.Value;
            }

            if (restartInterval is not null)
            {
                RestartInterval = restartInterval.Value;
            }

            if (componentSelectors is not null)
            {
                ComponentSelectors = componentSelectors.Value;
            }

            if (huffmanTableIndices is not null)
            {
                HuffmanTableIndices = huffmanTableIndices.Value;
            }

            if (startSpectralSelection is not null)
            {
                StartSpectralSelection = startSpectralSelection.Value;
            }

            if (endSpectralSelection is not null)
            {
                EndSpectralSelection = endSpectralSelection.Value;
            }

            if (successiveApproximationHigh is not null)
            {
                SuccessiveApproximationHigh = successiveApproximationHigh.Value;
            }

            if (successiveApproximationLow is not null)
            {
                SuccessiveApproximationLow = successiveApproximationLow.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "cComponents")]
        public uint CComponents;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "RestartInterval")]
        public uint RestartInterval;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "ComponentSelectors")]
        public uint ComponentSelectors;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "HuffmanTableIndices")]
        public uint HuffmanTableIndices;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "StartSpectralSelection")]
        public byte StartSpectralSelection;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "EndSpectralSelection")]
        public byte EndSpectralSelection;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "SuccessiveApproximationHigh")]
        public byte SuccessiveApproximationHigh;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "SuccessiveApproximationLow")]
        public byte SuccessiveApproximationLow;
    }
}
