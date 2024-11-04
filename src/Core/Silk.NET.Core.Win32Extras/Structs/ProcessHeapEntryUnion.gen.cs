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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_minwinbase_L252_C5")]
    public unsafe partial struct ProcessHeapEntryUnion
    {
        public ProcessHeapEntryUnion
        (
            ProcessHeapEntryUnionBlock? block = null,
            ProcessHeapEntryUnionRegion? region = null
        ) : this()
        {
            if (block is not null)
            {
                Block = block.Value;
            }

            if (region is not null)
            {
                Region = region.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "struct (unnamed struct at C:\\Program Files (x86)\\Windows Kits\\10\\Include\\10.0.26100.0\\um\\minwinbase.h:253:9)")]
        [NativeName("Type.Name", "struct (unnamed struct at C:\\Program Files (x86)\\Windows Kits\\10\\Include\\10.0.26100.0\\um\\minwinbase.h:253:9)")]
        [NativeName("Name", "Block")]
        public ProcessHeapEntryUnionBlock Block;

        [FieldOffset(0)]
        [NativeName("Type", "struct (unnamed struct at C:\\Program Files (x86)\\Windows Kits\\10\\Include\\10.0.26100.0\\um\\minwinbase.h:257:9)")]
        [NativeName("Type.Name", "struct (unnamed struct at C:\\Program Files (x86)\\Windows Kits\\10\\Include\\10.0.26100.0\\um\\minwinbase.h:257:9)")]
        [NativeName("Name", "Region")]
        public ProcessHeapEntryUnionRegion Region;
    }
}
