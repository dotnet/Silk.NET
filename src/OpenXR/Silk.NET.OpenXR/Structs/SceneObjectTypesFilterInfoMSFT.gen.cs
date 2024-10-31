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
    [NativeName("Name", "XrSceneObjectTypesFilterInfoMSFT")]
    public unsafe partial struct SceneObjectTypesFilterInfoMSFT
    {
        public SceneObjectTypesFilterInfoMSFT
        (
            StructureType? type = StructureType.TypeSceneObjectTypesFilterInfoMsft,
            void* next = null,
            uint? objectTypeCount = null,
            SceneObjectTypeMSFT* objectTypes = null
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

            if (objectTypeCount is not null)
            {
                ObjectTypeCount = objectTypeCount.Value;
            }

            if (objectTypes is not null)
            {
                ObjectTypes = objectTypes;
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
        [NativeName("Name", "objectTypeCount")]
        public uint ObjectTypeCount;
/// <summary></summary>
        [NativeName("Type", "XrSceneObjectTypeMSFT*")]
        [NativeName("Type.Name", "XrSceneObjectTypeMSFT")]
        [NativeName("Name", "objectTypes")]
        public SceneObjectTypeMSFT* ObjectTypes;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
