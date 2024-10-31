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
    [NativeName("Name", "XrRoomLayoutFB")]
    public unsafe partial struct RoomLayoutFB
    {
        public RoomLayoutFB
        (
            StructureType? type = StructureType.TypeRoomLayoutFB,
            void* next = null,
            UuidEXT? floorUuid = null,
            UuidEXT? ceilingUuid = null,
            uint? wallUuidCapacityInput = null,
            uint? wallUuidCountOutput = null,
            UuidEXT* wallUuids = null
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

            if (floorUuid is not null)
            {
                FloorUuid = floorUuid.Value;
            }

            if (ceilingUuid is not null)
            {
                CeilingUuid = ceilingUuid.Value;
            }

            if (wallUuidCapacityInput is not null)
            {
                WallUuidCapacityInput = wallUuidCapacityInput.Value;
            }

            if (wallUuidCountOutput is not null)
            {
                WallUuidCountOutput = wallUuidCountOutput.Value;
            }

            if (wallUuids is not null)
            {
                WallUuids = wallUuids;
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
        [NativeName("Type", "XrUuidEXT")]
        [NativeName("Type.Name", "XrUuidEXT")]
        [NativeName("Name", "floorUuid")]
        public UuidEXT FloorUuid;
/// <summary></summary>
        [NativeName("Type", "XrUuidEXT")]
        [NativeName("Type.Name", "XrUuidEXT")]
        [NativeName("Name", "ceilingUuid")]
        public UuidEXT CeilingUuid;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "wallUuidCapacityInput")]
        public uint WallUuidCapacityInput;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "wallUuidCountOutput")]
        public uint WallUuidCountOutput;
/// <summary></summary>
        [NativeName("Type", "XrUuidEXT*")]
        [NativeName("Type.Name", "XrUuidEXT")]
        [NativeName("Name", "wallUuids")]
        public UuidEXT* WallUuids;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
