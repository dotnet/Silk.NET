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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DRED_PAGE_FAULT_OUTPUT")]
    public unsafe partial struct DredPageFaultOutput
    {
        public DredPageFaultOutput
        (
            ulong pageFaultVA = default,
            DredAllocationNode* pHeadExistingAllocationNode = default,
            DredAllocationNode* pHeadRecentFreedAllocationNode = default
        )
        {
            PageFaultVA = pageFaultVA;
            PHeadExistingAllocationNode = pHeadExistingAllocationNode;
            PHeadRecentFreedAllocationNode = pHeadRecentFreedAllocationNode;
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
