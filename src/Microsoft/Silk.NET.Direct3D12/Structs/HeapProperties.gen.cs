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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_HEAP_PROPERTIES")]
    public unsafe partial struct HeapProperties
    {
        public HeapProperties
        (
            HeapType? type = null,
            CpuPageProperty? cPUPageProperty = null,
            MemoryPool? memoryPoolPreference = null,
            uint? creationNodeMask = null,
            uint? visibleNodeMask = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (cPUPageProperty is not null)
            {
                CPUPageProperty = cPUPageProperty.Value;
            }

            if (memoryPoolPreference is not null)
            {
                MemoryPoolPreference = memoryPoolPreference.Value;
            }

            if (creationNodeMask is not null)
            {
                CreationNodeMask = creationNodeMask.Value;
            }

            if (visibleNodeMask is not null)
            {
                VisibleNodeMask = visibleNodeMask.Value;
            }
        }


        [NativeName("Type", "D3D12_HEAP_TYPE")]
        [NativeName("Type.Name", "D3D12_HEAP_TYPE")]
        [NativeName("Name", "Type")]
        public HeapType Type;

        [NativeName("Type", "D3D12_CPU_PAGE_PROPERTY")]
        [NativeName("Type.Name", "D3D12_CPU_PAGE_PROPERTY")]
        [NativeName("Name", "CPUPageProperty")]
        public CpuPageProperty CPUPageProperty;

        [NativeName("Type", "D3D12_MEMORY_POOL")]
        [NativeName("Type.Name", "D3D12_MEMORY_POOL")]
        [NativeName("Name", "MemoryPoolPreference")]
        public MemoryPool MemoryPoolPreference;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "CreationNodeMask")]
        public uint CreationNodeMask;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "VisibleNodeMask")]
        public uint VisibleNodeMask;
    }
}
