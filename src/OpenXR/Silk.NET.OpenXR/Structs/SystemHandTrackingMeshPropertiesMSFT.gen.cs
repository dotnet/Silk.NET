// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    public unsafe struct SystemHandTrackingMeshPropertiesMSFT
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
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public uint SupportsHandTrackingMesh;
/// <summary></summary>
        public uint MaxHandMeshIndexCount;
/// <summary></summary>
        public uint MaxHandMeshVertexCount;
    }
}
