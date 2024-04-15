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
    [NativeName("Name", "WGPUAdapterPropertiesVk")]
    public unsafe partial struct AdapterPropertiesVk
    {
        public AdapterPropertiesVk
        (
            ChainedStructOut? chain = null,
            uint? driverVersion = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (driverVersion is not null)
            {
                DriverVersion = driverVersion.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStructOut")]
        [NativeName("Type.Name", "WGPUChainedStructOut")]
        [NativeName("Name", "chain")]
        public ChainedStructOut Chain;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "driverVersion")]
        public uint DriverVersion;
    }
}
