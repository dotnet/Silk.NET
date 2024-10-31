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
    [NativeName("Name", "XrSceneMeshIndicesUint16MSFT")]
    public unsafe partial struct SceneMeshIndicesUint16MSFT
    {
        public SceneMeshIndicesUint16MSFT
        (
            StructureType? type = StructureType.TypeSceneMeshIndicesUint16Msft,
            void* next = null,
            uint? indexCapacityInput = null,
            uint? indexCountOutput = null,
            ushort* indices = null
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

            if (indexCapacityInput is not null)
            {
                IndexCapacityInput = indexCapacityInput.Value;
            }

            if (indexCountOutput is not null)
            {
                IndexCountOutput = indexCountOutput.Value;
            }

            if (indices is not null)
            {
                Indices = indices;
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
        [NativeName("Name", "indexCapacityInput")]
        public uint IndexCapacityInput;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "indexCountOutput")]
        public uint IndexCountOutput;
/// <summary></summary>
        [NativeName("Type", "uint16_t*")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "indices")]
        public ushort* Indices;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
