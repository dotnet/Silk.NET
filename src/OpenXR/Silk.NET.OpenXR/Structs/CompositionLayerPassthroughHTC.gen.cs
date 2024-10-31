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
    [NativeName("Name", "XrCompositionLayerPassthroughHTC")]
    public unsafe partial struct CompositionLayerPassthroughHTC
    {
        public CompositionLayerPassthroughHTC
        (
            StructureType? type = StructureType.TypeCompositionLayerPassthroughHtc,
            void* next = null,
            CompositionLayerFlags? layerFlags = null,
            Space? space = null,
            PassthroughHTC? passthrough = null,
            PassthroughColorHTC? color = null
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

            if (layerFlags is not null)
            {
                LayerFlags = layerFlags.Value;
            }

            if (space is not null)
            {
                Space = space.Value;
            }

            if (passthrough is not null)
            {
                Passthrough = passthrough.Value;
            }

            if (color is not null)
            {
                Color = color.Value;
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
        [NativeName("Name", "layerFlags")]
        public CompositionLayerFlags LayerFlags;
/// <summary></summary>
        [NativeName("Type", "XrSpace")]
        [NativeName("Type.Name", "XrSpace")]
        [NativeName("Name", "space")]
        public Space Space;
/// <summary></summary>
        [NativeName("Type", "XrPassthroughHTC")]
        [NativeName("Type.Name", "XrPassthroughHTC")]
        [NativeName("Name", "passthrough")]
        public PassthroughHTC Passthrough;
/// <summary></summary>
        [NativeName("Type", "XrPassthroughColorHTC")]
        [NativeName("Type.Name", "XrPassthroughColorHTC")]
        [NativeName("Name", "color")]
        public PassthroughColorHTC Color;
    }
}
