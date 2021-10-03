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
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [NativeName("Name", "D3D12_DRED_ALLOCATION_NODE")]
    public unsafe partial struct DredAllocationNode
    {
        public DredAllocationNode
        (
            byte* objectNameA = null,
            char* objectNameW = null,
            DredAllocationType? allocationType = null,
            DredAllocationNode* pNext = null
        ) : this()
        {
            if (objectNameA is not null)
            {
                ObjectNameA = objectNameA;
            }

            if (objectNameW is not null)
            {
                ObjectNameW = objectNameW;
            }

            if (allocationType is not null)
            {
                AllocationType = allocationType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }
        }


        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "ObjectNameA")]
        public byte* ObjectNameA;

        [NativeName("Type", "const wchar_t *")]
        [NativeName("Type.Name", "const wchar_t *")]
        [NativeName("Name", "ObjectNameW")]
        public char* ObjectNameW;

        [NativeName("Type", "D3D12_DRED_ALLOCATION_TYPE")]
        [NativeName("Type.Name", "D3D12_DRED_ALLOCATION_TYPE")]
        [NativeName("Name", "AllocationType")]
        public DredAllocationType AllocationType;

        [NativeName("Type", "const struct D3D12_DRED_ALLOCATION_NODE *")]
        [NativeName("Type.Name", "const struct D3D12_DRED_ALLOCATION_NODE *")]
        [NativeName("Name", "pNext")]
        public DredAllocationNode* PNext;
    }
}
