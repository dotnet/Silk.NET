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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "DSTORAGE_SOURCE")]
    public unsafe partial struct Source
    {
        public Source
        (
            SourceMemory? memory = null,
            SourceFile? file = null
        ) : this()
        {
            if (memory is not null)
            {
                Memory = memory.Value;
            }

            if (file is not null)
            {
                File = file.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "DSTORAGE_SOURCE_MEMORY")]
        [NativeName("Type.Name", "DSTORAGE_SOURCE_MEMORY")]
        [NativeName("Name", "Memory")]
        public SourceMemory Memory;

        [FieldOffset(0)]
        [NativeName("Type", "DSTORAGE_SOURCE_FILE")]
        [NativeName("Type.Name", "DSTORAGE_SOURCE_FILE")]
        [NativeName("Name", "File")]
        public SourceFile File;
    }
}
