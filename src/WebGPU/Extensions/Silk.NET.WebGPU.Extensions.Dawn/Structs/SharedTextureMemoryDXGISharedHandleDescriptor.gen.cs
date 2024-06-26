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
    [NativeName("Name", "WGPUSharedTextureMemoryDXGISharedHandleDescriptor")]
    public unsafe partial struct SharedTextureMemoryDXGISharedHandleDescriptor
    {
        public SharedTextureMemoryDXGISharedHandleDescriptor
        (
            ChainedStruct? chain = null,
            void* handle = null,
            Silk.NET.Core.Bool32? useKeyedMutex = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (handle is not null)
            {
                Handle = handle;
            }

            if (useKeyedMutex is not null)
            {
                UseKeyedMutex = useKeyedMutex.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "handle")]
        public void* Handle;

        [NativeName("Type", "WGPUBool")]
        [NativeName("Type.Name", "WGPUBool")]
        [NativeName("Name", "useKeyedMutex")]
        public Silk.NET.Core.Bool32 UseKeyedMutex;
    }
}
