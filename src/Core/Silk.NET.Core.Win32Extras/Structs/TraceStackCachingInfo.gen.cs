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

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "_TRACE_STACK_CACHING_INFO")]
    public unsafe partial struct TraceStackCachingInfo
    {
        public TraceStackCachingInfo
        (
            byte? enabled = null,
            uint? cacheSize = null,
            uint? bucketCount = null
        ) : this()
        {
            if (enabled is not null)
            {
                Enabled = enabled.Value;
            }

            if (cacheSize is not null)
            {
                CacheSize = cacheSize.Value;
            }

            if (bucketCount is not null)
            {
                BucketCount = bucketCount.Value;
            }
        }


        [NativeName("Type", "BOOLEAN")]
        [NativeName("Type.Name", "BOOLEAN")]
        [NativeName("Name", "Enabled")]
        public byte Enabled;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "CacheSize")]
        public uint CacheSize;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "BucketCount")]
        public uint BucketCount;
    }
}
