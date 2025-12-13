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
    [NativeName("Name", "XrRenderModelCreateInfoEXT")]
    public unsafe partial struct RenderModelCreateInfoEXT
    {
        public RenderModelCreateInfoEXT
        (
            StructureType? type = StructureType.TypeRenderModelCreateInfoExt,
            void* next = null,
            ulong? renderModelId = null,
            uint? gltfExtensionCount = null,
            byte** gltfExtensions = null
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

            if (renderModelId is not null)
            {
                RenderModelId = renderModelId.Value;
            }

            if (gltfExtensionCount is not null)
            {
                GltfExtensionCount = gltfExtensionCount.Value;
            }

            if (gltfExtensions is not null)
            {
                GltfExtensions = gltfExtensions;
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
        [NativeName("Type", "XrRenderModelIdEXT")]
        [NativeName("Type.Name", "XrRenderModelIdEXT")]
        [NativeName("Name", "renderModelId")]
        public ulong RenderModelId;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "gltfExtensionCount")]
        public uint GltfExtensionCount;
/// <summary></summary>
        [NativeName("Type", "char**")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "gltfExtensions")]
        public byte** GltfExtensions;
    }
}
