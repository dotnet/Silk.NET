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

namespace Silk.NET.SPIRV.Cross
{
    [NativeName("Name", "spvc_buffer_range")]
    public unsafe partial struct BufferRange
    {
        public BufferRange
        (
            uint? index = null,
            nuint? offset = null,
            nuint? range = null
        ) : this()
        {
            if (index is not null)
            {
                Index = index.Value;
            }

            if (offset is not null)
            {
                Offset = offset.Value;
            }

            if (range is not null)
            {
                Range = range.Value;
            }
        }


        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "index")]
        public uint Index;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "offset")]
        public nuint Offset;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "range")]
        public nuint Range;
    }
}
