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
    [NativeName("Name", "XrRenderModelPropertiesFB")]
    public unsafe partial struct RenderModelPropertiesFB
    {
        public RenderModelPropertiesFB
        (
            StructureType? type = StructureType.TypeRenderModelPropertiesFB,
            void* next = null,
            uint? vendorId = null,
            ulong? modelKey = null,
            uint? modelVersion = null,
            RenderModelFlagsFB? flags = null
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

            if (vendorId is not null)
            {
                VendorId = vendorId.Value;
            }

            if (modelKey is not null)
            {
                ModelKey = modelKey.Value;
            }

            if (modelVersion is not null)
            {
                ModelVersion = modelVersion.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
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
        [NativeName("Name", "vendorId")]
        public uint VendorId;
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "modelName")]
        public fixed byte ModelName[64];
/// <summary></summary>
        [NativeName("Type", "XrRenderModelKeyFB")]
        [NativeName("Type.Name", "XrRenderModelKeyFB")]
        [NativeName("Name", "modelKey")]
        public ulong ModelKey;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "modelVersion")]
        public uint ModelVersion;
/// <summary></summary>
        [NativeName("Type", "XrRenderModelFlagsFB")]
        [NativeName("Type.Name", "XrRenderModelFlagsFB")]
        [NativeName("Name", "flags")]
        public RenderModelFlagsFB Flags;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
