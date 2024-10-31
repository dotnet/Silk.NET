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
    [NativeName("Name", "XrCompositionLayerPassthroughFB")]
    public unsafe partial struct CompositionLayerPassthroughFB
    {
        public CompositionLayerPassthroughFB
        (
            StructureType? type = StructureType.TypeCompositionLayerPassthroughFB,
            void* next = null,
            CompositionLayerFlags? flags = null,
            Space? space = null,
            PassthroughLayerFB? layerHandle = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (space is not null)
            {
                Space = space.Value;
            }

            if (layerHandle is not null)
            {
                LayerHandle = layerHandle.Value;
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
        [NativeName("Type", "XrCompositionLayerFlags")]
        [NativeName("Type.Name", "XrCompositionLayerFlags")]
        [NativeName("Name", "flags")]
        public CompositionLayerFlags Flags;
/// <summary></summary>
        [NativeName("Type", "XrSpace")]
        [NativeName("Type.Name", "XrSpace")]
        [NativeName("Name", "space")]
        public Space Space;
/// <summary></summary>
        [NativeName("Type", "XrPassthroughLayerFB")]
        [NativeName("Type.Name", "XrPassthroughLayerFB")]
        [NativeName("Name", "layerHandle")]
        public PassthroughLayerFB LayerHandle;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
