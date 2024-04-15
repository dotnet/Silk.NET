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
    [NativeName("Name", "WGPUCreateComputePipelineAsyncCallbackInfo")]
    public unsafe partial struct CreateComputePipelineAsyncCallbackInfo
    {
        public CreateComputePipelineAsyncCallbackInfo
        (
            ChainedStruct* nextInChain = null,
            CallbackMode? mode = null,
            PfnCreateComputePipelineAsyncCallback? callback = null,
            void* userdata = null
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

            if (userdata is not null)
            {
                Userdata = userdata;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "WGPUCallbackMode")]
        [NativeName("Type.Name", "WGPUCallbackMode")]
        [NativeName("Name", "mode")]
        public CallbackMode Mode;

        [NativeName("Type", "WGPUCreateComputePipelineAsyncCallback")]
        [NativeName("Type.Name", "WGPUCreateComputePipelineAsyncCallback")]
        [NativeName("Name", "callback")]
        public PfnCreateComputePipelineAsyncCallback Callback;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "userdata")]
        public void* Userdata;
    }
}
