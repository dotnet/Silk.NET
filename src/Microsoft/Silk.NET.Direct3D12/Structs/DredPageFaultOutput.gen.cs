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
    [NativeName("Name", "D3D12_DRED_PAGE_FAULT_OUTPUT")]
    public unsafe partial struct DredPageFaultOutput
    {
        public DredPageFaultOutput
        (
            ulong? pageFaultVA = null,
            DredAllocationNode* pHeadExistingAllocationNode = null,
            DredAllocationNode* pHeadRecentFreedAllocationNode = null
        ) : this()
        {
            if (pageFaultVA is not null)
            {
                PageFaultVA = pageFaultVA.Value;
            }

            if (pHeadExistingAllocationNode is not null)
            {
                PHeadExistingAllocationNode = pHeadExistingAllocationNode;
            }

            if (pHeadRecentFreedAllocationNode is not null)
            {
                PHeadRecentFreedAllocationNode = pHeadRecentFreedAllocationNode;
            }
        }


        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Name", "PageFaultVA")]
        public ulong PageFaultVA;

        [NativeName("Type", "const D3D12_DRED_ALLOCATION_NODE *")]
        [NativeName("Type.Name", "const D3D12_DRED_ALLOCATION_NODE *")]
        [NativeName("Name", "pHeadExistingAllocationNode")]
        public DredAllocationNode* PHeadExistingAllocationNode;

        [NativeName("Type", "const D3D12_DRED_ALLOCATION_NODE *")]
        [NativeName("Type.Name", "const D3D12_DRED_ALLOCATION_NODE *")]
        [NativeName("Name", "pHeadRecentFreedAllocationNode")]
        public DredAllocationNode* PHeadRecentFreedAllocationNode;
    }
}
