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

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [NativeName("Name", "WGPUDawnTogglesDeviceDescriptor")]
    public unsafe partial struct DawnTogglesDeviceDescriptor
    {
        public DawnTogglesDeviceDescriptor
        (
            ChainedStruct? chain = null,
            uint? forceEnabledTogglesCount = null,
            byte** forceEnabledToggles = null,
            uint? forceDisabledTogglesCount = null,
            byte** forceDisabledToggles = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (forceEnabledTogglesCount is not null)
            {
                ForceEnabledTogglesCount = forceEnabledTogglesCount.Value;
            }

            if (forceEnabledToggles is not null)
            {
                ForceEnabledToggles = forceEnabledToggles;
            }

            if (forceDisabledTogglesCount is not null)
            {
                ForceDisabledTogglesCount = forceDisabledTogglesCount.Value;
            }

            if (forceDisabledToggles is not null)
            {
                ForceDisabledToggles = forceDisabledToggles;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "forceEnabledTogglesCount")]
        public uint ForceEnabledTogglesCount;

        [NativeName("Type", "const char *const *")]
        [NativeName("Type.Name", "const char *const *")]
        [NativeName("Name", "forceEnabledToggles")]
        public byte** ForceEnabledToggles;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "forceDisabledTogglesCount")]
        public uint ForceDisabledTogglesCount;

        [NativeName("Type", "const char *const *")]
        [NativeName("Type.Name", "const char *const *")]
        [NativeName("Name", "forceDisabledToggles")]
        public byte** ForceDisabledToggles;
    }
}
