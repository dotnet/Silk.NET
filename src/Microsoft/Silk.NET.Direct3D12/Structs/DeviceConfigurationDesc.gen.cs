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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DEVICE_CONFIGURATION_DESC")]
    public unsafe partial struct DeviceConfigurationDesc
    {
        public DeviceConfigurationDesc
        (
            DeviceFlags? flags = null,
            uint? gpuBasedValidationFlags = null,
            uint? sDKVersion = null,
            uint? numEnabledExperimentalFeatures = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (gpuBasedValidationFlags is not null)
            {
                GpuBasedValidationFlags = gpuBasedValidationFlags.Value;
            }

            if (sDKVersion is not null)
            {
                SDKVersion = sDKVersion.Value;
            }

            if (numEnabledExperimentalFeatures is not null)
            {
                NumEnabledExperimentalFeatures = numEnabledExperimentalFeatures.Value;
            }
        }


        [NativeName("Type", "D3D12_DEVICE_FLAGS")]
        [NativeName("Type.Name", "D3D12_DEVICE_FLAGS")]
        [NativeName("Name", "Flags")]
        public DeviceFlags Flags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "GpuBasedValidationFlags")]
        public uint GpuBasedValidationFlags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SDKVersion")]
        public uint SDKVersion;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumEnabledExperimentalFeatures")]
        public uint NumEnabledExperimentalFeatures;
    }
}
