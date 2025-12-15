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
    [NativeName("Name", "WGPUPrimitiveDepthClipControl")]
    public unsafe partial struct PrimitiveDepthClipControl
    {
        public PrimitiveDepthClipControl
        (
            ChainedStruct? chain = null,
            Silk.NET.Core.Bool32? unclippedDepth = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (unclippedDepth is not null)
            {
                UnclippedDepth = unclippedDepth.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "WGPUBool")]
        [NativeName("Type.Name", "WGPUBool")]
        [NativeName("Name", "unclippedDepth")]
        public Silk.NET.Core.Bool32 UnclippedDepth;
    }
}
