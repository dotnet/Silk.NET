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
    [NativeName("Name", "XrSpatialComponentDataQueryResultEXT")]
    public unsafe partial struct SpatialComponentDataQueryResultEXT
    {
        public SpatialComponentDataQueryResultEXT
        (
            StructureType? type = StructureType.TypeSpatialComponentDataQueryResultExt,
            void* next = null,
            uint? entityIdCapacityInput = null,
            uint? entityIdCountOutput = null,
            ulong* entityIds = null,
            uint? entityStateCapacityInput = null,
            uint? entityStateCountOutput = null,
            SpatialEntityTrackingStateEXT* entityStates = null
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

            if (entityIdCapacityInput is not null)
            {
                EntityIdCapacityInput = entityIdCapacityInput.Value;
            }

            if (entityIdCountOutput is not null)
            {
                EntityIdCountOutput = entityIdCountOutput.Value;
            }

            if (entityIds is not null)
            {
                EntityIds = entityIds;
            }

            if (entityStateCapacityInput is not null)
            {
                EntityStateCapacityInput = entityStateCapacityInput.Value;
            }

            if (entityStateCountOutput is not null)
            {
                EntityStateCountOutput = entityStateCountOutput.Value;
            }

            if (entityStates is not null)
            {
                EntityStates = entityStates;
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
        [NativeName("Name", "entityIdCapacityInput")]
        public uint EntityIdCapacityInput;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "entityIdCountOutput")]
        public uint EntityIdCountOutput;
/// <summary></summary>
        [NativeName("Type", "XrSpatialEntityIdEXT*")]
        [NativeName("Type.Name", "XrSpatialEntityIdEXT")]
        [NativeName("Name", "entityIds")]
        public ulong* EntityIds;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "entityStateCapacityInput")]
        public uint EntityStateCapacityInput;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "entityStateCountOutput")]
        public uint EntityStateCountOutput;
/// <summary></summary>
        [NativeName("Type", "XrSpatialEntityTrackingStateEXT*")]
        [NativeName("Type.Name", "XrSpatialEntityTrackingStateEXT")]
        [NativeName("Name", "entityStates")]
        public SpatialEntityTrackingStateEXT* EntityStates;
    }
}
