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
    [NativeName("Name", "WGPUSurfaceDescriptorFromWindowsHWND")]
    public unsafe partial struct SurfaceDescriptorFromWindowsHWND
    {
        public SurfaceDescriptorFromWindowsHWND
        (
            ChainedStruct? chain = null,
            void* hinstance = null,
            void* hwnd = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (hinstance is not null)
            {
                Hinstance = hinstance;
            }

            if (hwnd is not null)
            {
                Hwnd = hwnd;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "hinstance")]
        public void* Hinstance;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "hwnd")]
        public void* Hwnd;
    }
}
