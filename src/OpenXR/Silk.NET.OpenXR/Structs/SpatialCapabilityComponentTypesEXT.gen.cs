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
    [NativeName("Name", "XrSpatialCapabilityComponentTypesEXT")]
    public unsafe partial struct SpatialCapabilityComponentTypesEXT
    {
        public SpatialCapabilityComponentTypesEXT
        (
            StructureType? type = StructureType.TypeSpatialCapabilityComponentTypesExt,
            void* next = null,
            uint? componentTypeCapacityInput = null,
            uint? componentTypeCountOutput = null,
            SpatialComponentTypeEXT* componentTypes = null
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

            if (componentTypeCapacityInput is not null)
            {
                ComponentTypeCapacityInput = componentTypeCapacityInput.Value;
            }

            if (componentTypeCountOutput is not null)
            {
                ComponentTypeCountOutput = componentTypeCountOutput.Value;
            }

            if (componentTypes is not null)
            {
                ComponentTypes = componentTypes;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "componentTypeCapacityInput")]
        public uint ComponentTypeCapacityInput;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "componentTypeCountOutput")]
        public uint ComponentTypeCountOutput;
/// <summary></summary>
        [NativeName("Type", "XrSpatialComponentTypeEXT*")]
        [NativeName("Type.Name", "XrSpatialComponentTypeEXT")]
        [NativeName("Name", "componentTypes")]
        public SpatialComponentTypeEXT* ComponentTypes;
    }
}
