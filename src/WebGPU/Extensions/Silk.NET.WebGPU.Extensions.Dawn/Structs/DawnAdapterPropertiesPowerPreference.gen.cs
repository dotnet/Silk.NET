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
    [NativeName("Name", "WGPUDawnAdapterPropertiesPowerPreference")]
    public unsafe partial struct DawnAdapterPropertiesPowerPreference
    {
        public DawnAdapterPropertiesPowerPreference
        (
            ChainedStructOut? chain = null,
            PowerPreference? powerPreference = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (powerPreference is not null)
            {
                PowerPreference = powerPreference.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStructOut")]
        [NativeName("Type.Name", "WGPUChainedStructOut")]
        [NativeName("Name", "chain")]
        public ChainedStructOut Chain;

        [NativeName("Type", "WGPUPowerPreference")]
        [NativeName("Type.Name", "WGPUPowerPreference")]
        [NativeName("Name", "powerPreference")]
        public PowerPreference PowerPreference;
    }
}
