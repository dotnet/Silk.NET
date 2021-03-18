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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrApiLayerProperties")]
    public unsafe partial struct ApiLayerProperties
    {
        public ApiLayerProperties
        (
            StructureType? type = StructureType.TypeApiLayerProperties,
            void* next = null,
            ulong? specVersion = null,
            uint? layerVersion = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (specVersion is not null)
            {
                SpecVersion = specVersion.Value;
            }

            if (layerVersion is not null)
            {
                LayerVersion = layerVersion.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "layerName")]
        public fixed byte LayerName[256];
/// <summary></summary>
        [NativeName("Type", "XrVersion")]
        [NativeName("Type.Name", "XrVersion")]
        [NativeName("Name", "specVersion")]
        public ulong SpecVersion;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "layerVersion")]
        public uint LayerVersion;
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "description")]
        public fixed byte Description[256];
    }
}
