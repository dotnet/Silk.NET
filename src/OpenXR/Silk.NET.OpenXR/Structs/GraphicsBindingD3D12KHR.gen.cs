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
    [NativeName("Name", "XrGraphicsBindingD3D12KHR")]
    public unsafe partial struct GraphicsBindingD3D12KHR
    {
        public GraphicsBindingD3D12KHR
        (
            StructureType type = StructureType.TypeGraphicsBindingD3D12Khr,
            void* next = default,
            IntPtr device = default,
            IntPtr queue = default
        )
        {
            Type = type;
            Next = next;
            Device = device;
            Queue = queue;
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
        [NativeName("Type", "ID3D12Device*")]
        [NativeName("Type.Name", "ID3D12Device")]
        [NativeName("Name", "device")]
        public IntPtr Device;
/// <summary></summary>
        [NativeName("Type", "ID3D12CommandQueue*")]
        [NativeName("Type.Name", "ID3D12CommandQueue")]
        [NativeName("Name", "queue")]
        public IntPtr Queue;
    }
}
