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

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUSurfaceDescriptorFromXlibWindow")]
    public unsafe partial struct SurfaceDescriptorFromXlibWindow
    {
        public SurfaceDescriptorFromXlibWindow
        (
            ChainedStruct? chain = null,
            void* display = null,
            ulong? window = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (display is not null)
            {
                Display = display;
            }

            if (window is not null)
            {
                Window = window.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "display")]
        public void* Display;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "window")]
        public ulong Window;
    }
}
