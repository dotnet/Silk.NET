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
    [NativeName("Name", "D3D12_RANGE_UINT64")]
    public unsafe partial struct RangeUint64
    {
        public RangeUint64
        (
            ulong? begin = null,
            ulong? end = null
        ) : this()
        {
            if (begin is not null)
            {
                Begin = begin.Value;
            }

            if (end is not null)
            {
                End = end.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "Begin")]
        public ulong Begin;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "End")]
        public ulong End;
    }
}
