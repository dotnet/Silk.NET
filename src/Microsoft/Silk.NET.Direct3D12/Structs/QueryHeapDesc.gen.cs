// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "D3D12_QUERY_HEAP_DESC")]
    public unsafe partial struct QueryHeapDesc
    {
        public QueryHeapDesc
        (
            QueryHeapType? type = null,
            uint? count = null,
            uint? nodeMask = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (count is not null)
            {
                Count = count.Value;
            }

            if (nodeMask is not null)
            {
                NodeMask = nodeMask.Value;
            }
        }


        [NativeName("Type", "D3D12_QUERY_HEAP_TYPE")]
        [NativeName("Type.Name", "D3D12_QUERY_HEAP_TYPE")]
        [NativeName("Name", "Type")]
        public QueryHeapType Type;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Count")]
        public uint Count;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeMask")]
        public uint NodeMask;
    }
}
