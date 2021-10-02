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
    [NativeName("Name", "_DXVAHD_VPDEVCAPS")]
    public unsafe partial struct HDVpdevcaps
    {
        public HDVpdevcaps
        (
            HDDeviceType? deviceType = null,
            uint? deviceCaps = null,
            uint? featureCaps = null,
            uint? filterCaps = null,
            uint? inputFormatCaps = null,
            Silk.NET.Direct3D9.Pool? inputPool = null,
            uint? outputFormatCount = null,
            uint? inputFormatCount = null,
            uint? videoProcessorCount = null,
            uint? maxInputStreams = null,
            uint? maxStreamStates = null
        ) : this()
        {
            if (deviceType is not null)
            {
                DeviceType = deviceType.Value;
            }

            if (deviceCaps is not null)
            {
                DeviceCaps = deviceCaps.Value;
            }

            if (featureCaps is not null)
            {
                FeatureCaps = featureCaps.Value;
            }

            if (filterCaps is not null)
            {
                FilterCaps = filterCaps.Value;
            }

            if (inputFormatCaps is not null)
            {
                InputFormatCaps = inputFormatCaps.Value;
            }

            if (inputPool is not null)
            {
                InputPool = inputPool.Value;
            }

            if (outputFormatCount is not null)
            {
                OutputFormatCount = outputFormatCount.Value;
            }

            if (inputFormatCount is not null)
            {
                InputFormatCount = inputFormatCount.Value;
            }

            if (videoProcessorCount is not null)
            {
                VideoProcessorCount = videoProcessorCount.Value;
            }

            if (maxInputStreams is not null)
            {
                MaxInputStreams = maxInputStreams.Value;
            }

            if (maxStreamStates is not null)
            {
                MaxStreamStates = maxStreamStates.Value;
            }
        }


        [NativeName("Type", "DXVAHD_DEVICE_TYPE")]
        [NativeName("Type.Name", "DXVAHD_DEVICE_TYPE")]
        [NativeName("Name", "DeviceType")]
        public HDDeviceType DeviceType;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DeviceCaps")]
        public uint DeviceCaps;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FeatureCaps")]
        public uint FeatureCaps;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FilterCaps")]
        public uint FilterCaps;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InputFormatCaps")]
        public uint InputFormatCaps;

        [NativeName("Type", "D3DPOOL")]
        [NativeName("Type.Name", "D3DPOOL")]
        [NativeName("Name", "InputPool")]
        public Silk.NET.Direct3D9.Pool InputPool;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "OutputFormatCount")]
        public uint OutputFormatCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InputFormatCount")]
        public uint InputFormatCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "VideoProcessorCount")]
        public uint VideoProcessorCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxInputStreams")]
        public uint MaxInputStreams;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxStreamStates")]
        public uint MaxStreamStates;
    }
}
