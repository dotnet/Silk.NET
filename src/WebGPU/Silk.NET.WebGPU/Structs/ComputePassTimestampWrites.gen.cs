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

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUComputePassTimestampWrites")]
    public unsafe partial struct ComputePassTimestampWrites
    {
        public ComputePassTimestampWrites
        (
            QuerySet* querySet = null,
            uint? beginningOfPassWriteIndex = null,
            uint? endOfPassWriteIndex = null
        ) : this()
        {
            if (querySet is not null)
            {
                QuerySet = querySet;
            }

            if (beginningOfPassWriteIndex is not null)
            {
                BeginningOfPassWriteIndex = beginningOfPassWriteIndex.Value;
            }

            if (endOfPassWriteIndex is not null)
            {
                EndOfPassWriteIndex = endOfPassWriteIndex.Value;
            }
        }


        [NativeName("Type", "WGPUQuerySet")]
        [NativeName("Type.Name", "WGPUQuerySet")]
        [NativeName("Name", "querySet")]
        public QuerySet* QuerySet;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "beginningOfPassWriteIndex")]
        public uint BeginningOfPassWriteIndex;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "endOfPassWriteIndex")]
        public uint EndOfPassWriteIndex;
    }
}
