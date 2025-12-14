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
    [NativeName("Name", "WGPUCompilationInfoCallbackInfo")]
    public unsafe partial struct CompilationInfoCallbackInfo
    {
        public CompilationInfoCallbackInfo
        (
            ChainedStruct* nextInChain = null,
            CallbackMode? mode = null,
            PfnCompilationInfoCallback? callback = null,
            void* userdata1 = null,
            void* userdata2 = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (mode is not null)
            {
                Mode = mode.Value;
            }

            if (callback is not null)
            {
                Callback = callback.Value;
            }

            if (userdata1 is not null)
            {
                Userdata1 = userdata1;
            }

            if (userdata2 is not null)
            {
                Userdata2 = userdata2;
            }
        }


        [NativeName("Type", "WGPUChainedStruct *")]
        [NativeName("Type.Name", "WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "WGPUCallbackMode")]
        [NativeName("Type.Name", "WGPUCallbackMode")]
        [NativeName("Name", "mode")]
        public CallbackMode Mode;

        [NativeName("Type", "WGPUCompilationInfoCallback")]
        [NativeName("Type.Name", "WGPUCompilationInfoCallback")]
        [NativeName("Name", "callback")]
        public PfnCompilationInfoCallback Callback;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "userdata1")]
        public void* Userdata1;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "userdata2")]
        public void* Userdata2;
    }
}
