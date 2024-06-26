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
    [NativeName("Name", "WGPUDrmFormatCapabilities")]
    public unsafe partial struct DrmFormatCapabilities
    {
        public DrmFormatCapabilities
        (
            ChainedStructOut? chain = null,
            nuint? propertiesCount = null,
            DrmFormatProperties* properties = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (propertiesCount is not null)
            {
                PropertiesCount = propertiesCount.Value;
            }

            if (properties is not null)
            {
                Properties = properties;
            }
        }


        [NativeName("Type", "WGPUChainedStructOut")]
        [NativeName("Type.Name", "WGPUChainedStructOut")]
        [NativeName("Name", "chain")]
        public ChainedStructOut Chain;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "propertiesCount")]
        public nuint PropertiesCount;

        [NativeName("Type", "const WGPUDrmFormatProperties *")]
        [NativeName("Type.Name", "const WGPUDrmFormatProperties *")]
        [NativeName("Name", "properties")]
        public DrmFormatProperties* Properties;
    }
}
