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
    [NativeName("Name", "D3D12_WORK_GRAPH_MEMORY_REQUIREMENTS")]
    public unsafe partial struct WorkGraphMemoryRequirements
    {
        public WorkGraphMemoryRequirements
        (
            ulong? minSizeInBytes = null,
            ulong? maxSizeInBytes = null,
            uint? sizeGranularityInBytes = null
        ) : this()
        {
            if (minSizeInBytes is not null)
            {
                MinSizeInBytes = minSizeInBytes.Value;
            }

            if (maxSizeInBytes is not null)
            {
                MaxSizeInBytes = maxSizeInBytes.Value;
            }

            if (sizeGranularityInBytes is not null)
            {
                SizeGranularityInBytes = sizeGranularityInBytes.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "MinSizeInBytes")]
        public ulong MinSizeInBytes;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "MaxSizeInBytes")]
        public ulong MaxSizeInBytes;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SizeGranularityInBytes")]
        public uint SizeGranularityInBytes;
    }
}
