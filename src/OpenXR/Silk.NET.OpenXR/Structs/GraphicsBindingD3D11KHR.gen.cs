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
    [NativeName("Name", "XrGraphicsBindingD3D11KHR")]
    public unsafe partial struct GraphicsBindingD3D11KHR
    {
        public GraphicsBindingD3D11KHR
        (
            StructureType type = StructureType.TypeGraphicsBindingD3D11Khr,
            void* next = default,
            ID3D11Device* device = default
        )
        {
            Type = type;
            Next = next;
            Device = device;
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
        [NativeName("Type", "ID3D11Device*")]
        [NativeName("Type.Name", "ID3D11Device")]
        [NativeName("Name", "device")]
        public ID3D11Device* Device;
    }
}
