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
    [NativeName("Name", "WGPUExternalTextureBindingEntry")]
    public unsafe partial struct ExternalTextureBindingEntry
    {
        public ExternalTextureBindingEntry
        (
            ChainedStruct? chain = null,
            ExternalTextureImpl* externalTexture = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (externalTexture is not null)
            {
                ExternalTexture = externalTexture;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "WGPUExternalTexture")]
        [NativeName("Type.Name", "WGPUExternalTexture")]
        [NativeName("Name", "externalTexture")]
        public ExternalTextureImpl* ExternalTexture;
    }
}
