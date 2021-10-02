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
    [NativeName("Name", "D3D12_QUERY_DATA_SO_STATISTICS")]
    public unsafe partial struct QueryDataSOStatistics
    {
        public QueryDataSOStatistics
        (
            ulong? numPrimitivesWritten = null,
            ulong? primitivesStorageNeeded = null
        ) : this()
        {
            if (numPrimitivesWritten is not null)
            {
                NumPrimitivesWritten = numPrimitivesWritten.Value;
            }

            if (primitivesStorageNeeded is not null)
            {
                PrimitivesStorageNeeded = primitivesStorageNeeded.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "NumPrimitivesWritten")]
        public ulong NumPrimitivesWritten;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "PrimitivesStorageNeeded")]
        public ulong PrimitivesStorageNeeded;
    }
}
