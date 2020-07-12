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
    public unsafe struct SwapchainImageD3D11KHR
    {
        public SwapchainImageD3D11KHR
        (
            StructureType type = StructureType.TypeSwapchainImageD3D11Khr,
            void* next = default,
            IntPtr texture = default
        )
        {
           Type = type;
           Next = next;
           Texture = texture;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public IntPtr Texture;
    }
}
