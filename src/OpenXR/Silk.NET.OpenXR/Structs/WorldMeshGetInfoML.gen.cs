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
    [NativeName("Name", "XrWorldMeshGetInfoML")]
    public unsafe partial struct WorldMeshGetInfoML
    {
        public WorldMeshGetInfoML
        (
            StructureType? type = StructureType.TypeWorldMeshGetInfoML,
            void* next = null,
            WorldMeshDetectorFlagsML? flags = null,
            float? fillHoleLength = null,
            float? disconnectedComponentArea = null,
            uint? blockCount = null,
            WorldMeshBlockRequestML* blocks = null
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

            if (fillHoleLength is not null)
            {
                FillHoleLength = fillHoleLength.Value;
            }

            if (disconnectedComponentArea is not null)
            {
                DisconnectedComponentArea = disconnectedComponentArea.Value;
            }

            if (blockCount is not null)
            {
                BlockCount = blockCount.Value;
            }

            if (blocks is not null)
            {
                Blocks = blocks;
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
        [NativeName("Type", "XrWorldMeshDetectorFlagsML")]
        [NativeName("Type.Name", "XrWorldMeshDetectorFlagsML")]
        [NativeName("Name", "flags")]
        public WorldMeshDetectorFlagsML Flags;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "fillHoleLength")]
        public float FillHoleLength;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "disconnectedComponentArea")]
        public float DisconnectedComponentArea;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "blockCount")]
        public uint BlockCount;
/// <summary></summary>
        [NativeName("Type", "XrWorldMeshBlockRequestML*")]
        [NativeName("Type.Name", "XrWorldMeshBlockRequestML")]
        [NativeName("Name", "blocks")]
        public WorldMeshBlockRequestML* Blocks;
    }
}
