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
    [NativeName("Name", "WGPUPopErrorScopeCallbackInfo")]
    public unsafe partial struct PopErrorScopeCallbackInfo
    {
        public PopErrorScopeCallbackInfo
        (
            ChainedStruct* nextInChain = null,
            CallbackMode? mode = null,
            PfnPopErrorScopeCallback? callback = null,
            PfnErrorCallback? oldCallback = null,
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

            if (oldCallback is not null)
            {
                OldCallback = oldCallback.Value;
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

        [NativeName("Type", "WGPUPopErrorScopeCallback")]
        [NativeName("Type.Name", "WGPUPopErrorScopeCallback")]
        [NativeName("Name", "callback")]
        public PfnPopErrorScopeCallback Callback;

        [NativeName("Type", "WGPUErrorCallback")]
        [NativeName("Type.Name", "WGPUErrorCallback")]
        [NativeName("Name", "oldCallback")]
        public PfnErrorCallback OldCallback;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "userdata")]
        public void* Userdata;
    }
}
