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
    [NativeName("Name", "XrSwapchainImageD3D12KHR")]
    public unsafe partial struct SwapchainImageD3D12KHR
    {
        public SwapchainImageD3D12KHR
        (
            StructureType type = StructureType.TypeSwapchainImageD3D12Khr,
            void* next = default,
            IntPtr texture = default
        )
        {
            Type = type;
            Next = next;
            Texture = texture;
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
        [NativeName("Type", "ID3D12Resource*")]
        [NativeName("Type.Name", "ID3D12Resource")]
        [NativeName("Name", "texture")]
        public IntPtr Texture;
    }
}
