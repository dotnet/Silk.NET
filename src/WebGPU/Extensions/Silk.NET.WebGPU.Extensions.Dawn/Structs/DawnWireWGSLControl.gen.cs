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
    [NativeName("Name", "WGPUDawnWireWGSLControl")]
    public unsafe partial struct DawnWireWGSLControl
    {
        public DawnWireWGSLControl
        (
            ChainedStruct? chain = null,
            Silk.NET.Core.Bool32? enableExperimental = null,
            Silk.NET.Core.Bool32? enableUnsafe = null,
            Silk.NET.Core.Bool32? enableTesting = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (enableExperimental is not null)
            {
                EnableExperimental = enableExperimental.Value;
            }

            if (enableUnsafe is not null)
            {
                EnableUnsafe = enableUnsafe.Value;
            }

            if (enableTesting is not null)
            {
                EnableTesting = enableTesting.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "WGPUBool")]
        [NativeName("Type.Name", "WGPUBool")]
        [NativeName("Name", "enableExperimental")]
        public Silk.NET.Core.Bool32 EnableExperimental;

        [NativeName("Type", "WGPUBool")]
        [NativeName("Type.Name", "WGPUBool")]
        [NativeName("Name", "enableUnsafe")]
        public Silk.NET.Core.Bool32 EnableUnsafe;

        [NativeName("Type", "WGPUBool")]
        [NativeName("Type.Name", "WGPUBool")]
        [NativeName("Name", "enableTesting")]
        public Silk.NET.Core.Bool32 EnableTesting;
    }
}
