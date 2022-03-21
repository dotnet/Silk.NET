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

namespace Silk.NET.DirectStorage
{
    [NativeName("Name", "DSTORAGE_SOURCE_MEMORY")]
    public unsafe partial struct SourceMemory
    {
        public SourceMemory
        (
            void* source = null,
            uint? size = null
        ) : this()
        {
            if (source is not null)
            {
                Source = source;
            }

            if (size is not null)
            {
                Size = size.Value;
            }
        }


        [NativeName("Type", "const void *")]
        [NativeName("Type.Name", "const void *")]
        [NativeName("Name", "Source")]
        public void* Source;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "Size")]
        public uint Size;
    }
}
