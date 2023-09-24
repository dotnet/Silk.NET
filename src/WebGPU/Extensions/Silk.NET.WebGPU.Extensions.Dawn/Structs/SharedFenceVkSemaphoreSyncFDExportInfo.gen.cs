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
    [NativeName("Name", "WGPUSharedFenceVkSemaphoreSyncFDExportInfo")]
    public unsafe partial struct SharedFenceVkSemaphoreSyncFDExportInfo
    {
        public SharedFenceVkSemaphoreSyncFDExportInfo
        (
            ChainedStructOut? chain = null,
            int? handle = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (handle is not null)
            {
                Handle = handle.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStructOut")]
        [NativeName("Type.Name", "WGPUChainedStructOut")]
        [NativeName("Name", "chain")]
        public ChainedStructOut Chain;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "handle")]
        public int Handle;
    }
}
