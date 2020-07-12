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
    [NativeName("Name", "XrGraphicsRequirementsD3D11KHR")]
    public unsafe partial struct GraphicsRequirementsD3D11KHR
    {
        public GraphicsRequirementsD3D11KHR
        (
            StructureType type = StructureType.TypeGraphicsRequirementsD3D11Khr,
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
