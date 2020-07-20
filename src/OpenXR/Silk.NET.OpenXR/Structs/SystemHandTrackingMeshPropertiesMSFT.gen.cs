// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSystemHandTrackingMeshPropertiesMSFT")]
    public unsafe partial struct SystemHandTrackingMeshPropertiesMSFT
    {
        public SystemHandTrackingMeshPropertiesMSFT
        (
            StructureType type = StructureType.TypeSystemHandTrackingMeshPropertiesMsft,
            void* next = default,
            uint supportsHandTrackingMesh = default,
            uint maxHandMeshIndexCount = default,
            uint maxHandMeshVertexCount = default
        )
        {
            Type = type;
            Next = next;
            SupportsHandTrackingMesh = supportsHandTrackingMesh;
            MaxHandMeshIndexCount = maxHandMeshIndexCount;
            MaxHandMeshVertexCount = maxHandMeshVertexCount;
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
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "supportsHandTrackingMesh")]
        public uint SupportsHandTrackingMesh;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxHandMeshIndexCount")]
        public uint MaxHandMeshIndexCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxHandMeshVertexCount")]
        public uint MaxHandMeshVertexCount;
    }
}
