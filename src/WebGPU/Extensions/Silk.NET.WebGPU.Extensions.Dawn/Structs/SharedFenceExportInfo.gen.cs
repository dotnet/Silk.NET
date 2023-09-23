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
    [NativeName("Name", "WGPUSharedFenceExportInfo")]
    public unsafe partial struct SharedFenceExportInfo
    {
        public SharedFenceExportInfo
        (
            ChainedStructOut* nextInChain = null,
            SharedFenceType? type = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (type is not null)
            {
                Type = type.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStructOut *")]
        [NativeName("Type.Name", "WGPUChainedStructOut *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStructOut* NextInChain;

        [NativeName("Type", "WGPUSharedFenceType")]
        [NativeName("Type.Name", "WGPUSharedFenceType")]
        [NativeName("Name", "type")]
        public SharedFenceType Type;
    }
}
