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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkLayerProperties")]
    public unsafe partial struct LayerProperties
    {
        public LayerProperties
        (
            uint? specVersion = null,
            uint? implementationVersion = null
        ) : this()
        {
            if (specVersion is not null)
            {
                SpecVersion = specVersion.Value;
            }

            if (implementationVersion is not null)
            {
                ImplementationVersion = implementationVersion.Value;
            }
        }

        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "layerName")]
        public fixed byte LayerName[256];
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "specVersion")]
        public uint SpecVersion;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "implementationVersion")]
        public uint ImplementationVersion;
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "description")]
        public fixed byte Description[256];
    }
}
