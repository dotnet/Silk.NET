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
    public unsafe struct GraphicsBindingD3D12KHR
    {
        public GraphicsBindingD3D12KHR
        (
            StructureType type = StructureType.TypeGraphicsBindingD3D12Khr,
            void* next = default,
            IntPtr device = default,
            ID3D12CommandQueue* queue = default
        )
        {
           Type = type;
           Next = next;
           Device = device;
           Queue = queue;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public IntPtr Device;
/// <summary></summary>
        public ID3D12CommandQueue* Queue;
    }
}
