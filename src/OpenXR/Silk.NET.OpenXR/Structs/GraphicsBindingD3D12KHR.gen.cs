// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrGraphicsBindingD3D12KHR")]
    public unsafe partial struct GraphicsBindingD3D12KHR
    {
        public GraphicsBindingD3D12KHR
        (
            StructureType? type = StructureType.TypeGraphicsBindingD3D12Khr,
            void* next = null,
            void* device = null,
            void* queue = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (device is not null)
            {
                Device = device;
            }

            if (queue is not null)
            {
                Queue = queue;
            }
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
        public void* Device;
/// <summary></summary>
        [NativeName("Type", "ID3D12CommandQueue*")]
        [NativeName("Type.Name", "ID3D12CommandQueue")]
        [NativeName("Name", "queue")]
        public void* Queue;
    }
}
