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
    [NativeName("Name", "WGPUDawnTogglesDescriptor")]
    public unsafe partial struct DawnTogglesDescriptor
    {
        public DawnTogglesDescriptor
        (
            ChainedStruct? chain = null,
            uint? enabledTogglesCount = null,
            byte** enabledToggles = null,
            uint? disabledTogglesCount = null,
            byte** disabledToggles = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (enabledTogglesCount is not null)
            {
                EnabledTogglesCount = enabledTogglesCount.Value;
            }

            if (enabledToggles is not null)
            {
                EnabledToggles = enabledToggles;
            }

            if (disabledTogglesCount is not null)
            {
                DisabledTogglesCount = disabledTogglesCount.Value;
            }

            if (disabledToggles is not null)
            {
                DisabledToggles = disabledToggles;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "enabledTogglesCount")]
        public uint EnabledTogglesCount;

        [NativeName("Type", "const char *const *")]
        [NativeName("Type.Name", "const char *const *")]
        [NativeName("Name", "enabledToggles")]
        public byte** EnabledToggles;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "disabledTogglesCount")]
        public uint DisabledTogglesCount;

        [NativeName("Type", "const char *const *")]
        [NativeName("Type.Name", "const char *const *")]
        [NativeName("Name", "disabledToggles")]
        public byte** DisabledToggles;
    }
}
