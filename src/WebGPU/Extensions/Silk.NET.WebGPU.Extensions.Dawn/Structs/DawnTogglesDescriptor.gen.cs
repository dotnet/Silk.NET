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
            nuint? enabledToggleCount = null,
            byte** enabledToggles = null,
            nuint? disabledToggleCount = null,
            byte** disabledToggles = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (enabledToggleCount is not null)
            {
                EnabledToggleCount = enabledToggleCount.Value;
            }

            if (enabledToggles is not null)
            {
                EnabledToggles = enabledToggles;
            }

            if (disabledToggleCount is not null)
            {
                DisabledToggleCount = disabledToggleCount.Value;
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

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "enabledToggleCount")]
        public nuint EnabledToggleCount;

        [NativeName("Type", "const char *const *")]
        [NativeName("Type.Name", "const char *const *")]
        [NativeName("Name", "enabledToggles")]
        public byte** EnabledToggles;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "disabledToggleCount")]
        public nuint DisabledToggleCount;

        [NativeName("Type", "const char *const *")]
        [NativeName("Type.Name", "const char *const *")]
        [NativeName("Name", "disabledToggles")]
        public byte** DisabledToggles;
    }
}
