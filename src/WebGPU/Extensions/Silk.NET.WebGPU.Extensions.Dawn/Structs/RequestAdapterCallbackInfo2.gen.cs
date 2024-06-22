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
    [NativeName("Name", "WGPURequestAdapterCallbackInfo2")]
    public unsafe partial struct RequestAdapterCallbackInfo2
    {
        public RequestAdapterCallbackInfo2
        (
            ChainedStruct* nextInChain = null,
            CallbackMode? mode = null,
            PfnRequestAdapterCallback2? callback = null,
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


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "WGPUCallbackMode")]
        [NativeName("Type.Name", "WGPUCallbackMode")]
        [NativeName("Name", "mode")]
        public CallbackMode Mode;

        [NativeName("Type", "WGPURequestAdapterCallback2")]
        [NativeName("Type.Name", "WGPURequestAdapterCallback2")]
        [NativeName("Name", "callback")]
        public PfnRequestAdapterCallback2 Callback;

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
