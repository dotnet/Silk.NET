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
    [NativeName("Name", "XrWorldMeshRequestCompletionML")]
    public unsafe partial struct WorldMeshRequestCompletionML
    {
        public WorldMeshRequestCompletionML
        (
            StructureType? type = StructureType.TypeWorldMeshRequestCompletionML,
            void* next = null,
            Result? futureResult = null,
            uint? blockCount = null,
            WorldMeshBlockML* blocks = null
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

            if (futureResult is not null)
            {
                FutureResult = futureResult.Value;
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
        [NativeName("Type", "XrResult")]
        [NativeName("Type.Name", "XrResult")]
        [NativeName("Name", "futureResult")]
        public Result FutureResult;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "blockCount")]
        public uint BlockCount;
/// <summary></summary>
        [NativeName("Type", "XrWorldMeshBlockML*")]
        [NativeName("Type.Name", "XrWorldMeshBlockML")]
        [NativeName("Name", "blocks")]
        public WorldMeshBlockML* Blocks;
    }
}
