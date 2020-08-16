// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrGraphicsRequirementsD3D12KHR")]
    public unsafe partial struct GraphicsRequirementsD3D12KHR
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
        [NativeName("Type", "LUID")]
        [NativeName("Type.Name", "LUID")]
        [NativeName("Name", "adapterLuid")]
        public ulong AdapterLuid;
/// <summary></summary>
        [NativeName("Type", "D3D_FEATURE_LEVEL")]
        [NativeName("Type.Name", "D3D_FEATURE_LEVEL")]
        [NativeName("Name", "minFeatureLevel")]
        public uint MinFeatureLevel;
    }
}
