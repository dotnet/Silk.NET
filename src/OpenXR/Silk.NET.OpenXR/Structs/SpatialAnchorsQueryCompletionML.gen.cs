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
    [NativeName("Name", "XrSpatialAnchorsQueryCompletionML")]
    public unsafe partial struct SpatialAnchorsQueryCompletionML
    {
        public SpatialAnchorsQueryCompletionML
        (
            StructureType? type = StructureType.TypeSpatialAnchorsQueryCompletionML,
            void* next = null,
            Result? futureResult = null,
            uint? uuidCapacityInput = null,
            uint? uuidCountOutput = null,
            UuidEXT* uuids = null
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

            if (uuidCapacityInput is not null)
            {
                UuidCapacityInput = uuidCapacityInput.Value;
            }

            if (uuidCountOutput is not null)
            {
                UuidCountOutput = uuidCountOutput.Value;
            }

            if (uuids is not null)
            {
                Uuids = uuids;
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
        [NativeName("Name", "uuidCapacityInput")]
        public uint UuidCapacityInput;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "uuidCountOutput")]
        public uint UuidCountOutput;
/// <summary></summary>
        [NativeName("Type", "XrUuidEXT*")]
        [NativeName("Type.Name", "XrUuidEXT")]
        [NativeName("Name", "uuids")]
        public UuidEXT* Uuids;
    }
}
