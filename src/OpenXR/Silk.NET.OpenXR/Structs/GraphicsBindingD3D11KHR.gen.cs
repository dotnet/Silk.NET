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
    public unsafe struct GraphicsBindingD3D11KHR
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
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public ID3D11Device* Device;
    }
}
