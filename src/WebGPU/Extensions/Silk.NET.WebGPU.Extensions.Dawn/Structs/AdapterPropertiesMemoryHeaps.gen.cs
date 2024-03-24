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
    [NativeName("Name", "WGPUAdapterPropertiesMemoryHeaps")]
    public unsafe partial struct AdapterPropertiesMemoryHeaps
    {
        public AdapterPropertiesMemoryHeaps
        (
            ChainedStructOut? chain = null,
            nuint? heapCount = null,
            MemoryHeapInfo* heapInfo = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (heapCount is not null)
            {
                HeapCount = heapCount.Value;
            }

            if (heapInfo is not null)
            {
                HeapInfo = heapInfo;
            }
        }


        [NativeName("Type", "WGPUChainedStructOut")]
        [NativeName("Type.Name", "WGPUChainedStructOut")]
        [NativeName("Name", "chain")]
        public ChainedStructOut Chain;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "heapCount")]
        public nuint HeapCount;

        [NativeName("Type", "const WGPUMemoryHeapInfo *")]
        [NativeName("Type.Name", "const WGPUMemoryHeapInfo *")]
        [NativeName("Name", "heapInfo")]
        public MemoryHeapInfo* HeapInfo;
    }
}
