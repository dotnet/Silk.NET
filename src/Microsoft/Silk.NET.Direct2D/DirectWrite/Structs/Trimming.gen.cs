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

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_TRIMMING")]
    public unsafe partial struct Trimming
    {
        public Trimming
        (
            TrimmingGranularity? granularity = null,
            uint? delimiter = null,
            uint? delimiterCount = null
        ) : this()
        {
            if (granularity is not null)
            {
                Granularity = granularity.Value;
            }

            if (delimiter is not null)
            {
                Delimiter = delimiter.Value;
            }

            if (delimiterCount is not null)
            {
                DelimiterCount = delimiterCount.Value;
            }
        }


        [NativeName("Type", "DWRITE_TRIMMING_GRANULARITY")]
        [NativeName("Type.Name", "DWRITE_TRIMMING_GRANULARITY")]
        [NativeName("Name", "granularity")]
        public TrimmingGranularity Granularity;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "delimiter")]
        public uint Delimiter;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "delimiterCount")]
        public uint DelimiterCount;
    }
}
