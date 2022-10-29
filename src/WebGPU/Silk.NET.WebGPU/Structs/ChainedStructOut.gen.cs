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
    [NativeName("Name", "WGPUChainedStructOut")]
    public unsafe partial struct ChainedStructOut
    {
        public ChainedStructOut
        (
            ChainedStructOut* next = null,
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


        [NativeName("Type", "struct WGPUChainedStructOut *")]
        [NativeName("Type.Name", "struct WGPUChainedStructOut *")]
        [NativeName("Name", "next")]
        public ChainedStructOut* Next;

        [NativeName("Type", "WGPUSType")]
        [NativeName("Type.Name", "WGPUSType")]
        [NativeName("Name", "sType")]
        public SType SType;
    }
}
