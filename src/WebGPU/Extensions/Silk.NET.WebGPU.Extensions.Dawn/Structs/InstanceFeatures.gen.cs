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
    [NativeName("Name", "WGPUInstanceFeatures")]
    public unsafe partial struct InstanceFeatures
    {
        public InstanceFeatures
        (
            ChainedStruct* nextInChain = null,
            Silk.NET.Core.Bool32? timedWaitAnyEnable = null,
            nuint? timedWaitAnyMaxCount = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (timedWaitAnyEnable is not null)
            {
                TimedWaitAnyEnable = timedWaitAnyEnable.Value;
            }

            if (timedWaitAnyMaxCount is not null)
            {
                TimedWaitAnyMaxCount = timedWaitAnyMaxCount.Value;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "WGPUBool")]
        [NativeName("Type.Name", "WGPUBool")]
        [NativeName("Name", "timedWaitAnyEnable")]
        public Silk.NET.Core.Bool32 TimedWaitAnyEnable;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "timedWaitAnyMaxCount")]
        public nuint TimedWaitAnyMaxCount;
    }
}
