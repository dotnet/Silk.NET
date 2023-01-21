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

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUAdapterExtras")]
    public unsafe partial struct AdapterExtras
    {
        public AdapterExtras
        (
            ChainedStruct? chain = null,
            BackendType? backend = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (backend is not null)
            {
                Backend = backend.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "WGPUBackendType")]
        [NativeName("Type.Name", "WGPUBackendType")]
        [NativeName("Name", "backend")]
        public BackendType Backend;
    }
}
