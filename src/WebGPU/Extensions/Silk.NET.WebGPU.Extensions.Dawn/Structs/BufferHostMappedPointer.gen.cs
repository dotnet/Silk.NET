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
    [NativeName("Name", "WGPUBufferHostMappedPointer")]
    public unsafe partial struct BufferHostMappedPointer
    {
        public BufferHostMappedPointer
        (
            ChainedStruct? chain = null,
            void* pointer = null,
            PfnCallback? disposeCallback = null,
            void* userdata = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (pointer is not null)
            {
                Pointer = pointer;
            }

            if (disposeCallback is not null)
            {
                DisposeCallback = disposeCallback.Value;
            }

            if (userdata is not null)
            {
                Userdata = userdata;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "pointer")]
        public void* Pointer;

        [NativeName("Type", "WGPUCallback")]
        [NativeName("Type.Name", "WGPUCallback")]
        [NativeName("Name", "disposeCallback")]
        public PfnCallback DisposeCallback;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "userdata")]
        public void* Userdata;
    }
}
