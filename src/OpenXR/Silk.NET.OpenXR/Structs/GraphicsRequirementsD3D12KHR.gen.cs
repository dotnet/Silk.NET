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
    public unsafe struct GraphicsRequirementsD3D12KHR
    {
        public GraphicsRequirementsD3D12KHR
        (
            StructureType type = StructureType.TypeGraphicsRequirementsD3D12Khr,
            void* next = default,
            ulong adapterLuid = default,
            uint minFeatureLevel = default
        )
        {
           Type = type;
           Next = next;
           AdapterLuid = adapterLuid;
           MinFeatureLevel = minFeatureLevel;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public ulong AdapterLuid;
/// <summary></summary>
        public uint MinFeatureLevel;
    }
}
