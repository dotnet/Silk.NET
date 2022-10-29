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
    [NativeName("Name", "WGPUChainedStruct")]
    public unsafe partial struct ChainedStruct
    {
        public ChainedStruct
        (
            ChainedStruct* next = null,
            SType? sType = null
        ) : this()
        {
            if (next is not null)
            {
                Next = next;
            }

            if (sType is not null)
            {
                SType = sType.Value;
            }
        }


        [NativeName("Type", "const struct WGPUChainedStruct *")]
        [NativeName("Type.Name", "const struct WGPUChainedStruct *")]
        [NativeName("Name", "next")]
        public ChainedStruct* Next;

        [NativeName("Type", "WGPUSType")]
        [NativeName("Type.Name", "WGPUSType")]
        [NativeName("Name", "sType")]
        public SType SType;
    }
}
