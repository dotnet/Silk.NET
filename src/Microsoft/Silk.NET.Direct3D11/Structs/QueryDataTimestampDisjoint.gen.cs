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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_QUERY_DATA_TIMESTAMP_DISJOINT")]
    public unsafe partial struct QueryDataTimestampDisjoint
    {
        public QueryDataTimestampDisjoint
        (
            ulong? frequency = null,
            Silk.NET.Core.Bool32? disjoint = null
        ) : this()
        {
            if (frequency is not null)
            {
                Frequency = frequency.Value;
            }

            if (disjoint is not null)
            {
                Disjoint = disjoint.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "Frequency")]
        public ulong Frequency;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Disjoint")]
        public Silk.NET.Core.Bool32 Disjoint;
    }
}
