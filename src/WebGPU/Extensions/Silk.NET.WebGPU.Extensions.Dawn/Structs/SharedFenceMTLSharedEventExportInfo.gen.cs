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
    [NativeName("Name", "WGPUSharedFenceMTLSharedEventExportInfo")]
    public unsafe partial struct SharedFenceMTLSharedEventExportInfo
    {
        public SharedFenceMTLSharedEventExportInfo
        (
            ChainedStructOut? chain = null,
            void* sharedEvent = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (sharedEvent is not null)
            {
                SharedEvent = sharedEvent;
            }
        }


        [NativeName("Type", "WGPUChainedStructOut")]
        [NativeName("Type.Name", "WGPUChainedStructOut")]
        [NativeName("Name", "chain")]
        public ChainedStructOut Chain;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "sharedEvent")]
        public void* SharedEvent;
    }
}
