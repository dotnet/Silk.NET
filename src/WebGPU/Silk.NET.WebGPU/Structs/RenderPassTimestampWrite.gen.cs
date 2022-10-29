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
    [NativeName("Name", "WGPURenderPassTimestampWrite")]
    public unsafe partial struct RenderPassTimestampWrite
    {
        public RenderPassTimestampWrite
        (
            QuerySet* querySet = null,
            uint? queryIndex = null,
            RenderPassTimestampLocation? location = null
        ) : this()
        {
            if (querySet is not null)
            {
                QuerySet = querySet;
            }

            if (queryIndex is not null)
            {
                QueryIndex = queryIndex.Value;
            }

            if (location is not null)
            {
                Location = location.Value;
            }
        }


        [NativeName("Type", "WGPUQuerySet")]
        [NativeName("Type.Name", "WGPUQuerySet")]
        [NativeName("Name", "querySet")]
        public QuerySet* QuerySet;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "queryIndex")]
        public uint QueryIndex;

        [NativeName("Type", "WGPURenderPassTimestampLocation")]
        [NativeName("Type.Name", "WGPURenderPassTimestampLocation")]
        [NativeName("Name", "location")]
        public RenderPassTimestampLocation Location;
    }
}
