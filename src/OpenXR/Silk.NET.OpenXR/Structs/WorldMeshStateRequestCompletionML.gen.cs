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
    [NativeName("Name", "XrWorldMeshStateRequestCompletionML")]
    public unsafe partial struct WorldMeshStateRequestCompletionML
    {
        public WorldMeshStateRequestCompletionML
        (
            StructureType? type = StructureType.TypeWorldMeshStateRequestCompletionML,
            void* next = null,
            Result? futureResult = null,
            long? timestamp = null,
            uint? meshBlockStateCapacityInput = null,
            uint? meshBlockStateCountOutput = null,
            WorldMeshBlockStateML* meshBlockStates = null
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

            if (timestamp is not null)
            {
                Timestamp = timestamp.Value;
            }

            if (meshBlockStateCapacityInput is not null)
            {
                MeshBlockStateCapacityInput = meshBlockStateCapacityInput.Value;
            }

            if (meshBlockStateCountOutput is not null)
            {
                MeshBlockStateCountOutput = meshBlockStateCountOutput.Value;
            }

            if (meshBlockStates is not null)
            {
                MeshBlockStates = meshBlockStates;
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
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "timestamp")]
        public long Timestamp;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "meshBlockStateCapacityInput")]
        public uint MeshBlockStateCapacityInput;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "meshBlockStateCountOutput")]
        public uint MeshBlockStateCountOutput;
/// <summary></summary>
        [NativeName("Type", "XrWorldMeshBlockStateML*")]
        [NativeName("Type.Name", "XrWorldMeshBlockStateML")]
        [NativeName("Name", "meshBlockStates")]
        public WorldMeshBlockStateML* MeshBlockStates;
    }
}
