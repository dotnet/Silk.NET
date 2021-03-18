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
